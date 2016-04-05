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

            var iAudioStore = new Interface()
            {
                Name = "AudioStoreInterface"
            };
            mediaStoreL1.Interfaces.Add(iAudioStore);

            var iEncoder = new Interface()
            {
                Name = "EncoderInterface"
            };
            mediaStoreL1.Interfaces.Add(iEncoder);

            var iAudioDB = new Interface()
            {
                Name = "AudioDBInterface"
            };
            mediaStoreL1.Interfaces.Add(iAudioDB);

            var iUserManagement = new Interface()
            {
                Name = "UserManagementInterface"
            };
            mediaStoreL1.Interfaces.Add(iUserManagement);

            var iUserDB = new Interface()
            {
                Name = "UserDBInterface"
            };
            mediaStoreL1.Interfaces.Add(iUserDB);

            var iCommand = new Interface()
            {
                Name = "CommandInterface"
            };
            mediaStoreL1.Interfaces.Add(iCommand);

            var iConnection = new Interface()
            {
                Name = "ConnectionInterface"
            };
            mediaStoreL1.Interfaces.Add(iConnection);

            var iDataReaderInterface = new Interface()
            {
                Name = "DataReaderInterface"
            };
            mediaStoreL1.Interfaces.Add(iDataReaderInterface);

            var http = new Interface()
            {
                Name = "HTTP"
            };
            mediaStoreL1.Interfaces.Add(http);

            var webBrowser = new ComponentType()
            {
                Name = "WebBrowser"
            };
            webBrowser.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "backend",
                Interface = http
            });
            mediaStoreL1.ComponentTypes.Add(webBrowser);

            var webForm = new ComponentType()
            {
                Name = "WebForm"
            };
            webForm.ProvidedInterfaces.Add(http);
            webForm.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "application",
                Interface = iAudioStore
            });
            mediaStoreL1.ComponentTypes.Add(webForm);

            var audioStore = new ComponentType()
            {
                Name = "AudioStore"
            };
            audioStore.ProvidedInterfaces.Add(iAudioStore);
            audioStore.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "audioDB",
                Interface = iAudioDB
            });
            audioStore.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "userManagement",
                Interface = iUserManagement
            });
            mediaStoreL1.ComponentTypes.Add(audioStore);

            var encodingAdapter = new ComponentType()
            {
                Name = "EncodingAdapter"
            };
            encodingAdapter.ProvidedInterfaces.Add(iAudioDB);
            encodingAdapter.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "encoder",
                Interface = iEncoder
            });
            encodingAdapter.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "database",
                Interface = iAudioDB
            });
            mediaStoreL1.ComponentTypes.Add(encodingAdapter);

            var oggEncoder = new ComponentType()
            {
                Name = "OggEncoder"
            };
            oggEncoder.ProvidedInterfaces.Add(iEncoder);
            mediaStoreL1.ComponentTypes.Add(oggEncoder);

            var userMgmt = new ComponentType()
            {
                Name = "UserManagement"
            };
            userMgmt.ProvidedInterfaces.Add(iUserManagement);
            userMgmt.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "database",
                Interface = iUserDB
            });
            mediaStoreL1.ComponentTypes.Add(userMgmt);

            var dbadapter = new ComponentType()
            {
                Name = "DBAdapter"
            };
            dbadapter.ProvidedInterfaces.Add(iUserDB);
            dbadapter.ProvidedInterfaces.Add(iAudioDB);
            dbadapter.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "command",
                Interface = iCommand
            });
            dbadapter.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "connection",
                Interface = iConnection
            });
            dbadapter.RequiredInterfaces.Add(new RequiredInterface()
            {
                Name = "dataReader",
                Interface = iDataReaderInterface
            });
            mediaStoreL1.ComponentTypes.Add(dbadapter);

            var database = new ComponentType()
            {
                Name = "MySqlClient"
            };
            database.ProvidedInterfaces.Add(iCommand);
            database.ProvidedInterfaces.Add(iConnection);
            database.ProvidedInterfaces.Add(iDataReaderInterface);
            mediaStoreL1.ComponentTypes.Add(database);

            var encrypt = new Signature() { Name = "Encrypt" };
            var decrypt = new Signature() { Name = "Decrypt" };
            iEncoder.Signatures.Add(encrypt);
            iEncoder.Signatures.Add(decrypt);

            var upload = new Signature() { Name = "Upload" };
            var download = new Signature() { Name = "Download" };
            iAudioStore.Signatures.Add(upload);
            iAudioStore.Signatures.Add(download);

            oggEncoder.Services.Add(new Service()
            {
                Name = "Encrypt",
                Implements = encrypt
            });
            oggEncoder.Services.Add(new Service()
            {
                Name = "Decrypt",
                Implements = decrypt
            });

            audioStore.Services.Add(new Service()
            {
                Name = "Upload",
                Implements = upload
            });
            audioStore.Services.Add(new Service()
            {
                Name = "Download",
                Implements = download
            });

            var mediaStoreSystem = new SystemSpecification()
            {
                Name = "MediaStoreSystem"
            };
            mediaStoreSystem.PublicInterfaces.Add(new RequiredInterface()
            {
                Name = "Frontend",
                Interface = http
            });
            mediaStoreL1.SystemSpecifications.Add(mediaStoreSystem);

            return mediaStoreL1;
        }
    }
}
