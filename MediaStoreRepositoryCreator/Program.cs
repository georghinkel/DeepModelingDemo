using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FZI.SoftwareEngineering.DeepModeling.DeepADL;
using NMF.Models;
using NMF.Models.Meta;
using NMF.Models.Repository;

namespace MediaStoreRepositoryCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("http://github.com/georghinkel/mediaStore/Repository");
            var mediaStoreL1 = CreateMediaStoreRepository(uri);
            var model = new Model()
            {
                ModelUri = uri
            };
            model.RootElements.Add(mediaStoreL1);
            var unit = MetaFacade.CreateCode(mediaStoreL1, "FZI.SoftwareEngineering.DeepModeling");
            MetaFacade.GenerateCode(unit, new Microsoft.CSharp.CSharpCodeProvider(), @"..\..\..\MediaStoreRepository\MediaStoreRepository", true);
            using (var fs = File.Create(@"..\..\..\MediaStoreRepository.nmf"))
            {
                MetaRepository.Instance.Serializer.Serialize(mediaStoreL1, fs);
            }
        }

        public static INamespace CreateMediaStoreRepository(Uri uri)
        {
            var mediaStoreL1 = new Repository() { Name = "Repository", Uri = uri, Prefix = "repo" };

            var iMediaStore = new Interface()
            {
                Name = "MediaStoreInterface"
            };
            mediaStoreL1.Interfaces.Add(iMediaStore);

            var iWatermark = new Interface()
            {
                Name = "WatermarkInterface"
            };
            mediaStoreL1.Interfaces.Add(iWatermark);

            var mediaStore = new ComponentType()
            {
                Name = "MediaStore"
            };
            mediaStoreL1.ComponentTypes.Add(mediaStore);

            var mediaStoreEncryption = new RequiredInterface()
            {
                Interface = iWatermark,
                Name = "Watermarking"
            };

            var watermark = new ComponentType()
            {
                Name = "Watermark"
            };
            mediaStoreL1.ComponentTypes.Add(watermark);

            mediaStore.ProvidedInterfaces.Add(iMediaStore);
            mediaStore.RequiredInterfaces.Add(mediaStoreEncryption);

            watermark.ProvidedInterfaces.Add(iWatermark);

            var watermarkEncrypt = new Signature() { Name = "Encrypt" };
            var watermarkDecrypt = new Signature() { Name = "Decrypt" };
            iWatermark.Signatures.Add(watermarkEncrypt);
            iWatermark.Signatures.Add(watermarkDecrypt);

            var mediaStoreUpload = new Signature() { Name = "Upload" };
            var mediaStoreDownload = new Signature() { Name = "Download" };
            iMediaStore.Signatures.Add(mediaStoreUpload);
            iMediaStore.Signatures.Add(mediaStoreDownload);

            watermark.Services.Add(new Service()
            {
                Name = "Encrypt",
                Implements = watermarkEncrypt
            });
            watermark.Services.Add(new Service()
            {
                Name = "Decrypt",
                Implements = watermarkDecrypt
            });

            mediaStore.Services.Add(new Service()
            {
                Name = "Upload",
                Implements = mediaStoreUpload
            });
            mediaStore.Services.Add(new Service()
            {
                Name = "Download",
                Implements = mediaStoreDownload
            });

            var mediaStoreSystem = new SystemSpecification()
            {
                Name = "MediaStoreSystem"
            };
            mediaStoreSystem.PublicInterfaces.Add(new RequiredInterface()
            {
                Name = "Frontend",
                Interface = iMediaStore
            });
            mediaStoreL1.SystemSpecifications.Add(mediaStoreSystem);

            return mediaStoreL1;
        }
    }
}
