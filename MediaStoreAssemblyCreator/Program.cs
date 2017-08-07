using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FZI.SoftwareEngineering.DeepModeling.DeepADL;
using FZI.SoftwareEngineering.DeepModeling.Repository;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;

namespace MediaStoreAssemblyCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMediaStoreAssembly(null, @"..\..\..\MediaStoreAssembly\MediaStoreAssembly", @"..\..\..\MediaStoreAssembly.nmf");
            for (int i = 1; i <= 64; i*=2)
            {
                GenerateMediaStoreAssembly(i, $@"..\..\..\MediaStoreAssemblyX{i}\MediaStoreAssembly", $@"..\..\..\MediaStoreAssemblyX{i}\MediaStoreAssemblyX{i}.nmf");
            }
        }

        private static void GenerateMediaStoreAssembly(int? factor, string codeLocation, string metamodelLocation)
        {
            var uri = new Uri("http://github.com/georghinkel/mediaStore/Assembly" + (factor.HasValue ? "X" + factor.Value.ToString() : ""));

            var system = new MediaStoreSystem()
            {
                Name = "MediaStore" + (factor.HasValue ? "X" + factor.Value.ToString() : "")
            };
            var mediaStoreL2 = new Namespace()
            {
                Name = "Assembly" + (factor.HasValue ? "X" + factor.Value.ToString() : ""),
                Uri = uri,
                Prefix = "mediaStore" + (factor.HasValue ? "X" + factor.Value.ToString() : "")
            };

            mediaStoreL2.Types.Add(system);
            if (!factor.HasValue)
            {
                CreateMediaStoreAssembly(system, string.Empty);
            }
            else
            {
                for (int i = 1; i <= factor.Value; i++)
                {
                    CreateMediaStoreAssembly(system, i.ToString());
                }
            }
            var model = new Model()
            {
                ModelUri = uri
            };
            model.RootElements.Add(mediaStoreL2);
            var unit = MetaFacade.CreateCode(mediaStoreL2, "FZI.SoftwareEngineering.DeepModeling");
            MetaFacade.GenerateCode(unit, new Microsoft.CSharp.CSharpCodeProvider(), codeLocation , true);
            using (var fs = File.OpenWrite(metamodelLocation))
            {
                MetaRepository.Instance.Serializer.Serialize(mediaStoreL2, fs);
            }
        }

        public static void CreateMediaStoreAssembly(MediaStoreSystem system, string suffix)
        {
            var webForm = new WebForm()
            {
                Name = "WebForm" + suffix
            };
            var audioStore = new AudioStore()
            {
                Name = "AudioStore" + suffix
            };
            var encodingadapter = new EncodingAdapter()
            {
                Name = "EncodingAdapter" + suffix
            };
            var encoder = new OggEncoder()
            {
                Name = "OggEncoder" + suffix
            };
            var userMgmt = new UserManagement()
            {
                Name = "UserManagement" + suffix
            };
            var dbAdapter = new DBAdapter()
            {
                Name = "DBAdapter" + suffix
            };
            var mySqlClient = new MySqlClient()
            {
                Name = "MySqlClient" + suffix
            };
            system.AssemblyContexts.Add(webForm);
            system.AssemblyContexts.Add(audioStore);
            system.AssemblyContexts.Add(userMgmt);
            system.AssemblyContexts.Add(encodingadapter);
            system.AssemblyContexts.Add(encoder);
            system.AssemblyContexts.Add(dbAdapter);
            system.AssemblyContexts.Add(mySqlClient);

            webForm.Application = audioStore;

            audioStore.UserManagement = userMgmt;
            audioStore.AudioDB = encodingadapter;

            userMgmt.Database = dbAdapter;

            encodingadapter.Encoder = encoder;
            encodingadapter.Database = dbAdapter;

            dbAdapter.Command = mySqlClient;
            dbAdapter.Connection = mySqlClient;
            dbAdapter.DataReader = mySqlClient;

            system.Frontend = webForm;
        }
    }
}
