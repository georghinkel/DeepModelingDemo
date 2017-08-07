using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL;
using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Assembly;
using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Deployment;
using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.SystemIndependent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZI.SoftwareEngineering.DeepModeling
{
    public class MediaStoreGenerator
    {
        public static Root CreateMediaStore(int factor, out System.Action[] manipulations)
        {
            var repository = new Repository();
            manipulations = new System.Action[3 * factor];

            var iAudioStore = new Interface()
            {
                Name = "AudioStoreInterface"
            };
            repository.Interfaces.Add(iAudioStore);

            var iEncoder = new Interface()
            {
                Name = "EncoderInterface"
            };
            repository.Interfaces.Add(iEncoder);

            var iAudioDB = new Interface()
            {
                Name = "AudioDBInterface"
            };
            repository.Interfaces.Add(iAudioDB);

            var iUserManagement = new Interface()
            {
                Name = "UserManagementInterface"
            };
            repository.Interfaces.Add(iUserManagement);

            var iUserDB = new Interface()
            {
                Name = "UserDBInterface"
            };
            repository.Interfaces.Add(iUserDB);

            var iCommand = new Interface()
            {
                Name = "CommandInterface"
            };
            repository.Interfaces.Add(iCommand);

            var iConnection = new Interface()
            {
                Name = "ConnectionInterface"
            };
            repository.Interfaces.Add(iConnection);

            var iDataReaderInterface = new Interface()
            {
                Name = "DataReaderInterface"
            };
            repository.Interfaces.Add(iDataReaderInterface);

            var http = new Interface()
            {
                Name = "HTTP"
            };
            repository.Interfaces.Add(http);

            var webBrowser = new Component()
            {
                Name = "WebBrowser"
            };
            webBrowser.RequiredInterfaces.Add(http);
            repository.Components.Add(webBrowser);

            var webForm = new Component()
            {
                Name = "WebForm"
            };
            webForm.ProvidedInterfaces.Add(http);
            webForm.RequiredInterfaces.Add(iAudioStore);
            repository.Components.Add(webForm);

            var audioStore = new Component()
            {
                Name = "AudioStore"
            };
            audioStore.ProvidedInterfaces.Add(iAudioStore);
            audioStore.RequiredInterfaces.Add(iAudioDB);
            audioStore.RequiredInterfaces.Add(iUserManagement);
            repository.Components.Add(audioStore);

            var encodingAdapter = new Component()
            {
                Name = "EncodingAdapter"
            };
            encodingAdapter.ProvidedInterfaces.Add(iAudioDB);
            encodingAdapter.RequiredInterfaces.Add(iEncoder);

            encodingAdapter.RequiredInterfaces.Add(iAudioDB);
            repository.Components.Add(encodingAdapter);

            var oggEncoder = new Component()
            {
                Name = "OggEncoder"
            };
            oggEncoder.ProvidedInterfaces.Add(iEncoder);
            repository.Components.Add(oggEncoder);

            var userMgmt = new Component()
            {
                Name = "UserManagement"
            };
            userMgmt.ProvidedInterfaces.Add(iUserManagement);
            userMgmt.RequiredInterfaces.Add(iUserDB);
            repository.Components.Add(userMgmt);

            var dbadapter = new Component()
            {
                Name = "DBAdapter"
            };
            dbadapter.ProvidedInterfaces.Add(iUserDB);
            dbadapter.ProvidedInterfaces.Add(iAudioDB);
            dbadapter.RequiredInterfaces.Add(iCommand);
            dbadapter.RequiredInterfaces.Add(iConnection);
            dbadapter.RequiredInterfaces.Add(iDataReaderInterface);
            repository.Components.Add(dbadapter);

            var database = new Component()
            {
                Name = "MySqlClient"
            };
            database.ProvidedInterfaces.Add(iCommand);
            database.ProvidedInterfaces.Add(iConnection);
            database.ProvidedInterfaces.Add(iDataReaderInterface);
            repository.Components.Add(database);

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
                Signature = encrypt
            });
            oggEncoder.Services.Add(new Service()
            {
                Signature = decrypt
            });

            audioStore.Services.Add(new Service()
            {
                Signature = upload
            });
            audioStore.Services.Add(new Service()
            {
                Signature = download
            });
            var environment = new Environment();
            var system = new System0 { Name = "MediaStore" };
            var allocation = new Allocation
            {
                AllocatedSystem = system,
                Environment = environment
            };
            var isolatedContainer = new Container { Name = "IsolatedContainer" };
            environment.Containers.Add(isolatedContainer);
            for (int i = 0; i < factor; i++)
            {
                var suffix = i.ToString();
                var appServer = new Container { Name = "AppServer" + suffix };
                var databaseServer = new Container { Name = "Database" + suffix };
                environment.Containers.Add(appServer);
                environment.Containers.Add(databaseServer);
                var network = new Link { Name = "Network" + suffix };
                network.ConnectedContainers.Add(appServer);
                network.ConnectedContainers.Add(databaseServer);
                environment.Links.Add(network);

                var webFormAssembly = new AssemblyContext
                {
                    Name = "WebForm" + suffix,
                    Implements = webForm
                };
                var audioStoreAssembly = new AssemblyContext
                {
                    Name = "AudioStore" + suffix,
                    Implements = audioStore
                };
                var encodingAdapterAssembly = new AssemblyContext
                {
                    Name = "EncodingAdapter" + suffix,
                    Implements = encodingAdapter
                };
                var encoderAssembly = new AssemblyContext
                {
                    Name = "EncodingAdapter" + suffix,
                    Implements = encodingAdapter
                };
                var oggEncoderAssembly = new AssemblyContext
                {
                    Name = "OggEncoder" + suffix,
                    Implements = oggEncoder
                };
                var userMgmtAssembly = new AssemblyContext
                {
                    Name = "UserMgmt" + suffix,
                    Implements = userMgmt
                };
                var dbAdapterAssembly = new AssemblyContext
                {
                    Name = "DBAdapter" + suffix,
                    Implements = dbadapter
                };
                var mysqlAssembly = new AssemblyContext
                {
                    Name = "MySql" + suffix,
                    Implements = database
                };

                system.EncapsulatedContexts.Add(webFormAssembly);
                system.EncapsulatedContexts.Add(audioStoreAssembly);
                system.EncapsulatedContexts.Add(encoderAssembly);
                system.EncapsulatedContexts.Add(oggEncoderAssembly);
                system.EncapsulatedContexts.Add(userMgmtAssembly);
                system.EncapsulatedContexts.Add(dbAdapterAssembly);
                system.EncapsulatedContexts.Add(mysqlAssembly);

                allocation.AllocationContexts.Add(new AllocationContext { Assembly = webFormAssembly, Container = appServer });
                allocation.AllocationContexts.Add(new AllocationContext { Assembly = audioStoreAssembly, Container = appServer });
                allocation.AllocationContexts.Add(new AllocationContext { Assembly = encoderAssembly, Container = appServer });
                allocation.AllocationContexts.Add(new AllocationContext { Assembly = oggEncoderAssembly, Container = appServer });
                allocation.AllocationContexts.Add(new AllocationContext { Assembly = userMgmtAssembly, Container = appServer });
                allocation.AllocationContexts.Add(new AllocationContext { Assembly = dbAdapterAssembly, Container = appServer });
                var databaseDeployment = new AllocationContext { Assembly = mysqlAssembly, Container = databaseServer };
                allocation.AllocationContexts.Add(databaseDeployment);

                manipulations[i] = () => databaseDeployment.Container = isolatedContainer;
                manipulations[factor + i] = () => databaseDeployment.Container = databaseServer;
                manipulations[2 * factor + i] = () => network.ConnectedContainers.Remove(databaseServer);

                system.Connectors.Add(new AssemblyConnector { Interface = iAudioStore, ProvidingComponent = audioStoreAssembly, UsingComponent = webFormAssembly });
                system.Connectors.Add(new AssemblyConnector { Interface = iUserManagement, ProvidingComponent = userMgmtAssembly, UsingComponent = audioStoreAssembly });
                system.Connectors.Add(new AssemblyConnector { Interface = iEncoder, ProvidingComponent = encoderAssembly, UsingComponent = audioStoreAssembly });
                system.Connectors.Add(new AssemblyConnector { Interface = iUserDB, ProvidingComponent = dbAdapterAssembly, UsingComponent = userMgmtAssembly });
                system.Connectors.Add(new AssemblyConnector { Interface = iEncoder, ProvidingComponent = oggEncoderAssembly, UsingComponent = encoderAssembly });
                system.Connectors.Add(new AssemblyConnector { Interface = iAudioDB, ProvidingComponent = dbAdapterAssembly, UsingComponent = encoderAssembly });
                system.Connectors.Add(new AssemblyConnector { Interface = iCommand, ProvidingComponent = mysqlAssembly, UsingComponent = dbAdapterAssembly });
                system.Connectors.Add(new AssemblyConnector { Interface = iConnection, ProvidingComponent = mysqlAssembly, UsingComponent = dbAdapterAssembly });
                system.Connectors.Add(new AssemblyConnector { Interface = iDataReaderInterface, ProvidingComponent = mysqlAssembly, UsingComponent = dbAdapterAssembly });
            }

            system.ProvidedInterfaces.Add(http);

            return new Root
            {
                Environment = environment,
                System = system,
                Repository = repository,
                Allocation = allocation
            };
        }
    }
}
