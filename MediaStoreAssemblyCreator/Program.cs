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
            var uri = new Uri("http://github.com/georghinkel/mediaStore/Assembly");
            var mediaStoreL2 = CreateMediaStoreAssembly(uri);
            var model = new Model()
            {
                ModelUri = uri
            };
            model.RootElements.Add(mediaStoreL2);
            var unit = MetaFacade.CreateCode(mediaStoreL2, "FZI.SoftwareEngineering.DeepModeling");
            MetaFacade.GenerateCode(unit, new Microsoft.CSharp.CSharpCodeProvider(), @"..\..\..\MediaStoreAssembly\MediaStoreAssembly", true);
            using (var fs = File.OpenWrite(@"..\..\..\MediaStoreAssembly.nmf"))
            {
                MetaRepository.Instance.Serializer.Serialize(mediaStoreL2, fs);
            }
        }

        public static INamespace CreateMediaStoreAssembly(Uri uri)
        {
            var system = new MediaStoreSystem()
            {
                Name = "MediaStore"
            };
            var webForm = new WebForm()
            {
                Name = "WebForm"
            };
            var audioStore = new AudioStore()
            {
                Name = "AudioStore"
            };
            var encodingadapter = new EncodingAdapter()
            {
                Name = "EncodingAdapter"
            };
            var encoder = new OggEncoder()
            {
                Name = "OggEncoder"
            };
            var userMgmt = new UserManagement()
            {
                Name = "UserManagement"
            };
            var dbAdapter = new DBAdapter()
            {
                Name = "DBAdapter"
            };
            var mySqlClient = new MySqlClient()
            {
                Name = "MySqlClient"
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

            var mediaStoreL2 = new Namespace()
            {
                Name = "Assembly",
                Uri = uri,
                Prefix = "mediaStore"
            };

            mediaStoreL2.Types.Add(system);
            return mediaStoreL2;
        }
    }
}
