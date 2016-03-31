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
            var mediaStore = new MediaStore()
            {
                Name = "MediaStore1"
            };
            var watermark = new Watermark()
            {
                Name = "Watermark1"
            };
            mediaStore.Watermarking = watermark;
            system.AssemblyContexts.Add(mediaStore);
            system.AssemblyContexts.Add(watermark);

            var mediaStoreL2 = new Namespace()
            {
                Name = "Assembly",
                Uri = uri,
                Prefix = "mediaStore"
            };

            system.Frontend = mediaStore;

            mediaStoreL2.Types.Add(system);
            return mediaStoreL2;
        }
    }
}
