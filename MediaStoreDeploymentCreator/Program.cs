using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FZI.SoftwareEngineering.DeepModeling.Assembly;
using FZI.SoftwareEngineering.DeepModeling.DeepADL;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;

namespace MediaStoreAssemblyCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("http://github.com/georghinkel/mediaStore/Deployment");
            var mediaStoreL2 = CreateMediaStoreDeployment(uri);
            var model = new Model()
            {
                ModelUri = uri
            };
            model.RootElements.Add(mediaStoreL2);
            using (var fs = File.OpenWrite(@"..\..\..\MediaStoreDeployment.nmf"))
            {
                MetaRepository.Instance.Serializer.Serialize(mediaStoreL2, fs);
            }
        }

        public static IModelElement CreateMediaStoreDeployment(Uri uri)
        {
            var appServer = new ResourceContainer() { Name = "Application Server" };
            var computeEnvironment = new ResourceEnvironment();
            computeEnvironment.Container.Add(appServer);
            var deployment = new MediaStore()
            {
                Environment = computeEnvironment,
                WebForm = appServer,
                AudioStore = appServer,
                UserManagement = appServer,
                OggEncoder = appServer,
                EncodingAdapter = appServer,
                DBAdapter = appServer,
                MySqlClient = appServer
            };
            return deployment;
        }
    }
}
