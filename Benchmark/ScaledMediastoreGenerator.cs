using FZI.SoftwareEngineering.DeepModeling.DeepADL;
using System;

namespace FZI.SoftwareEngineering.DeepModeling.Benchmark
{
    public class DeepMediaStoreGenerator
    {
        public static ISystemAllocation CreateMediaStoreX1Allocation(out Action[] manipulations)
        {
            var environment = new ResourceEnvironment();
            var isolatedContainer = new ResourceContainer() { Name = "IsolatedContainer" };
            environment.Container.Add(isolatedContainer);
            var appServer1 = new ResourceContainer() { Name = "AppServer1" };
            var databaseServer1 = new ResourceContainer() { Name = "DatabaseServer1" };
            environment.Container.Add(appServer1);
			environment.Container.Add(databaseServer1);
            var network1 = new ResourceLink();
            environment.Links.Add(network1);
            network1.Connects.Add(appServer1);
            network1.Connects.Add(databaseServer1);
            var mediaStore = new FZI.SoftwareEngineering.DeepModeling.AssemblyX1.MediaStoreX1()
            {
                AudioStore1 = appServer1,
                DBAdapter1 = appServer1,
                EncodingAdapter1 = appServer1,
                MySqlClient1 = databaseServer1,
                OggEncoder1 = appServer1,
                UserManagement1 = appServer1,
                WebForm1 = appServer1,
                Environment = environment
            };
			manipulations = new Action[3];
			manipulations[0] = () => mediaStore.MySqlClient1 = isolatedContainer;
			manipulations[1] = () => mediaStore.MySqlClient1 = databaseServer1;
			manipulations[2] = () => network1.Connects.Remove(databaseServer1);
			return mediaStore;
        }
        public static ISystemAllocation CreateMediaStoreX2Allocation(out Action[] manipulations)
        {
            var environment = new ResourceEnvironment();
            var isolatedContainer = new ResourceContainer() { Name = "IsolatedContainer" };
            environment.Container.Add(isolatedContainer);
            var appServer1 = new ResourceContainer() { Name = "AppServer1" };
            var databaseServer1 = new ResourceContainer() { Name = "DatabaseServer1" };
            environment.Container.Add(appServer1);
			environment.Container.Add(databaseServer1);
            var network1 = new ResourceLink();
            environment.Links.Add(network1);
            network1.Connects.Add(appServer1);
            network1.Connects.Add(databaseServer1);
            var appServer2 = new ResourceContainer() { Name = "AppServer2" };
            var databaseServer2 = new ResourceContainer() { Name = "DatabaseServer2" };
            environment.Container.Add(appServer2);
			environment.Container.Add(databaseServer2);
            var network2 = new ResourceLink();
            environment.Links.Add(network2);
            network2.Connects.Add(appServer2);
            network2.Connects.Add(databaseServer2);
            var mediaStore = new FZI.SoftwareEngineering.DeepModeling.AssemblyX2.MediaStoreX2()
            {
                AudioStore1 = appServer1,
                DBAdapter1 = appServer1,
                EncodingAdapter1 = appServer1,
                MySqlClient1 = databaseServer1,
                OggEncoder1 = appServer1,
                UserManagement1 = appServer1,
                WebForm1 = appServer1,
                AudioStore2 = appServer2,
                DBAdapter2 = appServer2,
                EncodingAdapter2 = appServer2,
                MySqlClient2 = databaseServer2,
                OggEncoder2 = appServer2,
                UserManagement2 = appServer2,
                WebForm2 = appServer2,
                Environment = environment
            };
			manipulations = new Action[6];
			manipulations[0] = () => mediaStore.MySqlClient1 = isolatedContainer;
			manipulations[1] = () => mediaStore.MySqlClient2 = isolatedContainer;
			manipulations[2] = () => mediaStore.MySqlClient1 = databaseServer1;
			manipulations[3] = () => mediaStore.MySqlClient2 = databaseServer2;
			manipulations[4] = () => network1.Connects.Remove(databaseServer1);
			manipulations[5] = () => network2.Connects.Remove(databaseServer2);
			return mediaStore;
        }
        public static ISystemAllocation CreateMediaStoreX4Allocation(out Action[] manipulations)
        {
            var environment = new ResourceEnvironment();
            var isolatedContainer = new ResourceContainer() { Name = "IsolatedContainer" };
            environment.Container.Add(isolatedContainer);
            var appServer1 = new ResourceContainer() { Name = "AppServer1" };
            var databaseServer1 = new ResourceContainer() { Name = "DatabaseServer1" };
            environment.Container.Add(appServer1);
			environment.Container.Add(databaseServer1);
            var network1 = new ResourceLink();
            environment.Links.Add(network1);
            network1.Connects.Add(appServer1);
            network1.Connects.Add(databaseServer1);
            var appServer2 = new ResourceContainer() { Name = "AppServer2" };
            var databaseServer2 = new ResourceContainer() { Name = "DatabaseServer2" };
            environment.Container.Add(appServer2);
			environment.Container.Add(databaseServer2);
            var network2 = new ResourceLink();
            environment.Links.Add(network2);
            network2.Connects.Add(appServer2);
            network2.Connects.Add(databaseServer2);
            var appServer3 = new ResourceContainer() { Name = "AppServer3" };
            var databaseServer3 = new ResourceContainer() { Name = "DatabaseServer3" };
            environment.Container.Add(appServer3);
			environment.Container.Add(databaseServer3);
            var network3 = new ResourceLink();
            environment.Links.Add(network3);
            network3.Connects.Add(appServer3);
            network3.Connects.Add(databaseServer3);
            var appServer4 = new ResourceContainer() { Name = "AppServer4" };
            var databaseServer4 = new ResourceContainer() { Name = "DatabaseServer4" };
            environment.Container.Add(appServer4);
			environment.Container.Add(databaseServer4);
            var network4 = new ResourceLink();
            environment.Links.Add(network4);
            network4.Connects.Add(appServer4);
            network4.Connects.Add(databaseServer4);
            var mediaStore = new FZI.SoftwareEngineering.DeepModeling.AssemblyX4.MediaStoreX4()
            {
                AudioStore1 = appServer1,
                DBAdapter1 = appServer1,
                EncodingAdapter1 = appServer1,
                MySqlClient1 = databaseServer1,
                OggEncoder1 = appServer1,
                UserManagement1 = appServer1,
                WebForm1 = appServer1,
                AudioStore2 = appServer2,
                DBAdapter2 = appServer2,
                EncodingAdapter2 = appServer2,
                MySqlClient2 = databaseServer2,
                OggEncoder2 = appServer2,
                UserManagement2 = appServer2,
                WebForm2 = appServer2,
                AudioStore3 = appServer3,
                DBAdapter3 = appServer3,
                EncodingAdapter3 = appServer3,
                MySqlClient3 = databaseServer3,
                OggEncoder3 = appServer3,
                UserManagement3 = appServer3,
                WebForm3 = appServer3,
                AudioStore4 = appServer4,
                DBAdapter4 = appServer4,
                EncodingAdapter4 = appServer4,
                MySqlClient4 = databaseServer4,
                OggEncoder4 = appServer4,
                UserManagement4 = appServer4,
                WebForm4 = appServer4,
                Environment = environment
            };
			manipulations = new Action[12];
			manipulations[0] = () => mediaStore.MySqlClient1 = isolatedContainer;
			manipulations[1] = () => mediaStore.MySqlClient2 = isolatedContainer;
			manipulations[2] = () => mediaStore.MySqlClient3 = isolatedContainer;
			manipulations[3] = () => mediaStore.MySqlClient4 = isolatedContainer;
			manipulations[4] = () => mediaStore.MySqlClient1 = databaseServer1;
			manipulations[5] = () => mediaStore.MySqlClient2 = databaseServer2;
			manipulations[6] = () => mediaStore.MySqlClient3 = databaseServer3;
			manipulations[7] = () => mediaStore.MySqlClient4 = databaseServer4;
			manipulations[8] = () => network1.Connects.Remove(databaseServer1);
			manipulations[9] = () => network2.Connects.Remove(databaseServer2);
			manipulations[10] = () => network3.Connects.Remove(databaseServer3);
			manipulations[11] = () => network4.Connects.Remove(databaseServer4);
			return mediaStore;
        }
        public static ISystemAllocation CreateMediaStoreX8Allocation(out Action[] manipulations)
        {
            var environment = new ResourceEnvironment();
            var isolatedContainer = new ResourceContainer() { Name = "IsolatedContainer" };
            environment.Container.Add(isolatedContainer);
            var appServer1 = new ResourceContainer() { Name = "AppServer1" };
            var databaseServer1 = new ResourceContainer() { Name = "DatabaseServer1" };
            environment.Container.Add(appServer1);
			environment.Container.Add(databaseServer1);
            var network1 = new ResourceLink();
            environment.Links.Add(network1);
            network1.Connects.Add(appServer1);
            network1.Connects.Add(databaseServer1);
            var appServer2 = new ResourceContainer() { Name = "AppServer2" };
            var databaseServer2 = new ResourceContainer() { Name = "DatabaseServer2" };
            environment.Container.Add(appServer2);
			environment.Container.Add(databaseServer2);
            var network2 = new ResourceLink();
            environment.Links.Add(network2);
            network2.Connects.Add(appServer2);
            network2.Connects.Add(databaseServer2);
            var appServer3 = new ResourceContainer() { Name = "AppServer3" };
            var databaseServer3 = new ResourceContainer() { Name = "DatabaseServer3" };
            environment.Container.Add(appServer3);
			environment.Container.Add(databaseServer3);
            var network3 = new ResourceLink();
            environment.Links.Add(network3);
            network3.Connects.Add(appServer3);
            network3.Connects.Add(databaseServer3);
            var appServer4 = new ResourceContainer() { Name = "AppServer4" };
            var databaseServer4 = new ResourceContainer() { Name = "DatabaseServer4" };
            environment.Container.Add(appServer4);
			environment.Container.Add(databaseServer4);
            var network4 = new ResourceLink();
            environment.Links.Add(network4);
            network4.Connects.Add(appServer4);
            network4.Connects.Add(databaseServer4);
            var appServer5 = new ResourceContainer() { Name = "AppServer5" };
            var databaseServer5 = new ResourceContainer() { Name = "DatabaseServer5" };
            environment.Container.Add(appServer5);
			environment.Container.Add(databaseServer5);
            var network5 = new ResourceLink();
            environment.Links.Add(network5);
            network5.Connects.Add(appServer5);
            network5.Connects.Add(databaseServer5);
            var appServer6 = new ResourceContainer() { Name = "AppServer6" };
            var databaseServer6 = new ResourceContainer() { Name = "DatabaseServer6" };
            environment.Container.Add(appServer6);
			environment.Container.Add(databaseServer6);
            var network6 = new ResourceLink();
            environment.Links.Add(network6);
            network6.Connects.Add(appServer6);
            network6.Connects.Add(databaseServer6);
            var appServer7 = new ResourceContainer() { Name = "AppServer7" };
            var databaseServer7 = new ResourceContainer() { Name = "DatabaseServer7" };
            environment.Container.Add(appServer7);
			environment.Container.Add(databaseServer7);
            var network7 = new ResourceLink();
            environment.Links.Add(network7);
            network7.Connects.Add(appServer7);
            network7.Connects.Add(databaseServer7);
            var appServer8 = new ResourceContainer() { Name = "AppServer8" };
            var databaseServer8 = new ResourceContainer() { Name = "DatabaseServer8" };
            environment.Container.Add(appServer8);
			environment.Container.Add(databaseServer8);
            var network8 = new ResourceLink();
            environment.Links.Add(network8);
            network8.Connects.Add(appServer8);
            network8.Connects.Add(databaseServer8);
            var mediaStore = new FZI.SoftwareEngineering.DeepModeling.AssemblyX8.MediaStoreX8()
            {
                AudioStore1 = appServer1,
                DBAdapter1 = appServer1,
                EncodingAdapter1 = appServer1,
                MySqlClient1 = databaseServer1,
                OggEncoder1 = appServer1,
                UserManagement1 = appServer1,
                WebForm1 = appServer1,
                AudioStore2 = appServer2,
                DBAdapter2 = appServer2,
                EncodingAdapter2 = appServer2,
                MySqlClient2 = databaseServer2,
                OggEncoder2 = appServer2,
                UserManagement2 = appServer2,
                WebForm2 = appServer2,
                AudioStore3 = appServer3,
                DBAdapter3 = appServer3,
                EncodingAdapter3 = appServer3,
                MySqlClient3 = databaseServer3,
                OggEncoder3 = appServer3,
                UserManagement3 = appServer3,
                WebForm3 = appServer3,
                AudioStore4 = appServer4,
                DBAdapter4 = appServer4,
                EncodingAdapter4 = appServer4,
                MySqlClient4 = databaseServer4,
                OggEncoder4 = appServer4,
                UserManagement4 = appServer4,
                WebForm4 = appServer4,
                AudioStore5 = appServer5,
                DBAdapter5 = appServer5,
                EncodingAdapter5 = appServer5,
                MySqlClient5 = databaseServer5,
                OggEncoder5 = appServer5,
                UserManagement5 = appServer5,
                WebForm5 = appServer5,
                AudioStore6 = appServer6,
                DBAdapter6 = appServer6,
                EncodingAdapter6 = appServer6,
                MySqlClient6 = databaseServer6,
                OggEncoder6 = appServer6,
                UserManagement6 = appServer6,
                WebForm6 = appServer6,
                AudioStore7 = appServer7,
                DBAdapter7 = appServer7,
                EncodingAdapter7 = appServer7,
                MySqlClient7 = databaseServer7,
                OggEncoder7 = appServer7,
                UserManagement7 = appServer7,
                WebForm7 = appServer7,
                AudioStore8 = appServer8,
                DBAdapter8 = appServer8,
                EncodingAdapter8 = appServer8,
                MySqlClient8 = databaseServer8,
                OggEncoder8 = appServer8,
                UserManagement8 = appServer8,
                WebForm8 = appServer8,
                Environment = environment
            };
			manipulations = new Action[24];
			manipulations[0] = () => mediaStore.MySqlClient1 = isolatedContainer;
			manipulations[1] = () => mediaStore.MySqlClient2 = isolatedContainer;
			manipulations[2] = () => mediaStore.MySqlClient3 = isolatedContainer;
			manipulations[3] = () => mediaStore.MySqlClient4 = isolatedContainer;
			manipulations[4] = () => mediaStore.MySqlClient5 = isolatedContainer;
			manipulations[5] = () => mediaStore.MySqlClient6 = isolatedContainer;
			manipulations[6] = () => mediaStore.MySqlClient7 = isolatedContainer;
			manipulations[7] = () => mediaStore.MySqlClient8 = isolatedContainer;
			manipulations[8] = () => mediaStore.MySqlClient1 = databaseServer1;
			manipulations[9] = () => mediaStore.MySqlClient2 = databaseServer2;
			manipulations[10] = () => mediaStore.MySqlClient3 = databaseServer3;
			manipulations[11] = () => mediaStore.MySqlClient4 = databaseServer4;
			manipulations[12] = () => mediaStore.MySqlClient5 = databaseServer5;
			manipulations[13] = () => mediaStore.MySqlClient6 = databaseServer6;
			manipulations[14] = () => mediaStore.MySqlClient7 = databaseServer7;
			manipulations[15] = () => mediaStore.MySqlClient8 = databaseServer8;
			manipulations[16] = () => network1.Connects.Remove(databaseServer1);
			manipulations[17] = () => network2.Connects.Remove(databaseServer2);
			manipulations[18] = () => network3.Connects.Remove(databaseServer3);
			manipulations[19] = () => network4.Connects.Remove(databaseServer4);
			manipulations[20] = () => network5.Connects.Remove(databaseServer5);
			manipulations[21] = () => network6.Connects.Remove(databaseServer6);
			manipulations[22] = () => network7.Connects.Remove(databaseServer7);
			manipulations[23] = () => network8.Connects.Remove(databaseServer8);
			return mediaStore;
        }
        public static ISystemAllocation CreateMediaStoreX16Allocation(out Action[] manipulations)
        {
            var environment = new ResourceEnvironment();
            var isolatedContainer = new ResourceContainer() { Name = "IsolatedContainer" };
            environment.Container.Add(isolatedContainer);
            var appServer1 = new ResourceContainer() { Name = "AppServer1" };
            var databaseServer1 = new ResourceContainer() { Name = "DatabaseServer1" };
            environment.Container.Add(appServer1);
			environment.Container.Add(databaseServer1);
            var network1 = new ResourceLink();
            environment.Links.Add(network1);
            network1.Connects.Add(appServer1);
            network1.Connects.Add(databaseServer1);
            var appServer2 = new ResourceContainer() { Name = "AppServer2" };
            var databaseServer2 = new ResourceContainer() { Name = "DatabaseServer2" };
            environment.Container.Add(appServer2);
			environment.Container.Add(databaseServer2);
            var network2 = new ResourceLink();
            environment.Links.Add(network2);
            network2.Connects.Add(appServer2);
            network2.Connects.Add(databaseServer2);
            var appServer3 = new ResourceContainer() { Name = "AppServer3" };
            var databaseServer3 = new ResourceContainer() { Name = "DatabaseServer3" };
            environment.Container.Add(appServer3);
			environment.Container.Add(databaseServer3);
            var network3 = new ResourceLink();
            environment.Links.Add(network3);
            network3.Connects.Add(appServer3);
            network3.Connects.Add(databaseServer3);
            var appServer4 = new ResourceContainer() { Name = "AppServer4" };
            var databaseServer4 = new ResourceContainer() { Name = "DatabaseServer4" };
            environment.Container.Add(appServer4);
			environment.Container.Add(databaseServer4);
            var network4 = new ResourceLink();
            environment.Links.Add(network4);
            network4.Connects.Add(appServer4);
            network4.Connects.Add(databaseServer4);
            var appServer5 = new ResourceContainer() { Name = "AppServer5" };
            var databaseServer5 = new ResourceContainer() { Name = "DatabaseServer5" };
            environment.Container.Add(appServer5);
			environment.Container.Add(databaseServer5);
            var network5 = new ResourceLink();
            environment.Links.Add(network5);
            network5.Connects.Add(appServer5);
            network5.Connects.Add(databaseServer5);
            var appServer6 = new ResourceContainer() { Name = "AppServer6" };
            var databaseServer6 = new ResourceContainer() { Name = "DatabaseServer6" };
            environment.Container.Add(appServer6);
			environment.Container.Add(databaseServer6);
            var network6 = new ResourceLink();
            environment.Links.Add(network6);
            network6.Connects.Add(appServer6);
            network6.Connects.Add(databaseServer6);
            var appServer7 = new ResourceContainer() { Name = "AppServer7" };
            var databaseServer7 = new ResourceContainer() { Name = "DatabaseServer7" };
            environment.Container.Add(appServer7);
			environment.Container.Add(databaseServer7);
            var network7 = new ResourceLink();
            environment.Links.Add(network7);
            network7.Connects.Add(appServer7);
            network7.Connects.Add(databaseServer7);
            var appServer8 = new ResourceContainer() { Name = "AppServer8" };
            var databaseServer8 = new ResourceContainer() { Name = "DatabaseServer8" };
            environment.Container.Add(appServer8);
			environment.Container.Add(databaseServer8);
            var network8 = new ResourceLink();
            environment.Links.Add(network8);
            network8.Connects.Add(appServer8);
            network8.Connects.Add(databaseServer8);
            var appServer9 = new ResourceContainer() { Name = "AppServer9" };
            var databaseServer9 = new ResourceContainer() { Name = "DatabaseServer9" };
            environment.Container.Add(appServer9);
			environment.Container.Add(databaseServer9);
            var network9 = new ResourceLink();
            environment.Links.Add(network9);
            network9.Connects.Add(appServer9);
            network9.Connects.Add(databaseServer9);
            var appServer10 = new ResourceContainer() { Name = "AppServer10" };
            var databaseServer10 = new ResourceContainer() { Name = "DatabaseServer10" };
            environment.Container.Add(appServer10);
			environment.Container.Add(databaseServer10);
            var network10 = new ResourceLink();
            environment.Links.Add(network10);
            network10.Connects.Add(appServer10);
            network10.Connects.Add(databaseServer10);
            var appServer11 = new ResourceContainer() { Name = "AppServer11" };
            var databaseServer11 = new ResourceContainer() { Name = "DatabaseServer11" };
            environment.Container.Add(appServer11);
			environment.Container.Add(databaseServer11);
            var network11 = new ResourceLink();
            environment.Links.Add(network11);
            network11.Connects.Add(appServer11);
            network11.Connects.Add(databaseServer11);
            var appServer12 = new ResourceContainer() { Name = "AppServer12" };
            var databaseServer12 = new ResourceContainer() { Name = "DatabaseServer12" };
            environment.Container.Add(appServer12);
			environment.Container.Add(databaseServer12);
            var network12 = new ResourceLink();
            environment.Links.Add(network12);
            network12.Connects.Add(appServer12);
            network12.Connects.Add(databaseServer12);
            var appServer13 = new ResourceContainer() { Name = "AppServer13" };
            var databaseServer13 = new ResourceContainer() { Name = "DatabaseServer13" };
            environment.Container.Add(appServer13);
			environment.Container.Add(databaseServer13);
            var network13 = new ResourceLink();
            environment.Links.Add(network13);
            network13.Connects.Add(appServer13);
            network13.Connects.Add(databaseServer13);
            var appServer14 = new ResourceContainer() { Name = "AppServer14" };
            var databaseServer14 = new ResourceContainer() { Name = "DatabaseServer14" };
            environment.Container.Add(appServer14);
			environment.Container.Add(databaseServer14);
            var network14 = new ResourceLink();
            environment.Links.Add(network14);
            network14.Connects.Add(appServer14);
            network14.Connects.Add(databaseServer14);
            var appServer15 = new ResourceContainer() { Name = "AppServer15" };
            var databaseServer15 = new ResourceContainer() { Name = "DatabaseServer15" };
            environment.Container.Add(appServer15);
			environment.Container.Add(databaseServer15);
            var network15 = new ResourceLink();
            environment.Links.Add(network15);
            network15.Connects.Add(appServer15);
            network15.Connects.Add(databaseServer15);
            var appServer16 = new ResourceContainer() { Name = "AppServer16" };
            var databaseServer16 = new ResourceContainer() { Name = "DatabaseServer16" };
            environment.Container.Add(appServer16);
			environment.Container.Add(databaseServer16);
            var network16 = new ResourceLink();
            environment.Links.Add(network16);
            network16.Connects.Add(appServer16);
            network16.Connects.Add(databaseServer16);
            var mediaStore = new FZI.SoftwareEngineering.DeepModeling.AssemblyX16.MediaStoreX16()
            {
                AudioStore1 = appServer1,
                DBAdapter1 = appServer1,
                EncodingAdapter1 = appServer1,
                MySqlClient1 = databaseServer1,
                OggEncoder1 = appServer1,
                UserManagement1 = appServer1,
                WebForm1 = appServer1,
                AudioStore2 = appServer2,
                DBAdapter2 = appServer2,
                EncodingAdapter2 = appServer2,
                MySqlClient2 = databaseServer2,
                OggEncoder2 = appServer2,
                UserManagement2 = appServer2,
                WebForm2 = appServer2,
                AudioStore3 = appServer3,
                DBAdapter3 = appServer3,
                EncodingAdapter3 = appServer3,
                MySqlClient3 = databaseServer3,
                OggEncoder3 = appServer3,
                UserManagement3 = appServer3,
                WebForm3 = appServer3,
                AudioStore4 = appServer4,
                DBAdapter4 = appServer4,
                EncodingAdapter4 = appServer4,
                MySqlClient4 = databaseServer4,
                OggEncoder4 = appServer4,
                UserManagement4 = appServer4,
                WebForm4 = appServer4,
                AudioStore5 = appServer5,
                DBAdapter5 = appServer5,
                EncodingAdapter5 = appServer5,
                MySqlClient5 = databaseServer5,
                OggEncoder5 = appServer5,
                UserManagement5 = appServer5,
                WebForm5 = appServer5,
                AudioStore6 = appServer6,
                DBAdapter6 = appServer6,
                EncodingAdapter6 = appServer6,
                MySqlClient6 = databaseServer6,
                OggEncoder6 = appServer6,
                UserManagement6 = appServer6,
                WebForm6 = appServer6,
                AudioStore7 = appServer7,
                DBAdapter7 = appServer7,
                EncodingAdapter7 = appServer7,
                MySqlClient7 = databaseServer7,
                OggEncoder7 = appServer7,
                UserManagement7 = appServer7,
                WebForm7 = appServer7,
                AudioStore8 = appServer8,
                DBAdapter8 = appServer8,
                EncodingAdapter8 = appServer8,
                MySqlClient8 = databaseServer8,
                OggEncoder8 = appServer8,
                UserManagement8 = appServer8,
                WebForm8 = appServer8,
                AudioStore9 = appServer9,
                DBAdapter9 = appServer9,
                EncodingAdapter9 = appServer9,
                MySqlClient9 = databaseServer9,
                OggEncoder9 = appServer9,
                UserManagement9 = appServer9,
                WebForm9 = appServer9,
                AudioStore10 = appServer10,
                DBAdapter10 = appServer10,
                EncodingAdapter10 = appServer10,
                MySqlClient10 = databaseServer10,
                OggEncoder10 = appServer10,
                UserManagement10 = appServer10,
                WebForm10 = appServer10,
                AudioStore11 = appServer11,
                DBAdapter11 = appServer11,
                EncodingAdapter11 = appServer11,
                MySqlClient11 = databaseServer11,
                OggEncoder11 = appServer11,
                UserManagement11 = appServer11,
                WebForm11 = appServer11,
                AudioStore12 = appServer12,
                DBAdapter12 = appServer12,
                EncodingAdapter12 = appServer12,
                MySqlClient12 = databaseServer12,
                OggEncoder12 = appServer12,
                UserManagement12 = appServer12,
                WebForm12 = appServer12,
                AudioStore13 = appServer13,
                DBAdapter13 = appServer13,
                EncodingAdapter13 = appServer13,
                MySqlClient13 = databaseServer13,
                OggEncoder13 = appServer13,
                UserManagement13 = appServer13,
                WebForm13 = appServer13,
                AudioStore14 = appServer14,
                DBAdapter14 = appServer14,
                EncodingAdapter14 = appServer14,
                MySqlClient14 = databaseServer14,
                OggEncoder14 = appServer14,
                UserManagement14 = appServer14,
                WebForm14 = appServer14,
                AudioStore15 = appServer15,
                DBAdapter15 = appServer15,
                EncodingAdapter15 = appServer15,
                MySqlClient15 = databaseServer15,
                OggEncoder15 = appServer15,
                UserManagement15 = appServer15,
                WebForm15 = appServer15,
                AudioStore16 = appServer16,
                DBAdapter16 = appServer16,
                EncodingAdapter16 = appServer16,
                MySqlClient16 = databaseServer16,
                OggEncoder16 = appServer16,
                UserManagement16 = appServer16,
                WebForm16 = appServer16,
                Environment = environment
            };
			manipulations = new Action[48];
			manipulations[0] = () => mediaStore.MySqlClient1 = isolatedContainer;
			manipulations[1] = () => mediaStore.MySqlClient2 = isolatedContainer;
			manipulations[2] = () => mediaStore.MySqlClient3 = isolatedContainer;
			manipulations[3] = () => mediaStore.MySqlClient4 = isolatedContainer;
			manipulations[4] = () => mediaStore.MySqlClient5 = isolatedContainer;
			manipulations[5] = () => mediaStore.MySqlClient6 = isolatedContainer;
			manipulations[6] = () => mediaStore.MySqlClient7 = isolatedContainer;
			manipulations[7] = () => mediaStore.MySqlClient8 = isolatedContainer;
			manipulations[8] = () => mediaStore.MySqlClient9 = isolatedContainer;
			manipulations[9] = () => mediaStore.MySqlClient10 = isolatedContainer;
			manipulations[10] = () => mediaStore.MySqlClient11 = isolatedContainer;
			manipulations[11] = () => mediaStore.MySqlClient12 = isolatedContainer;
			manipulations[12] = () => mediaStore.MySqlClient13 = isolatedContainer;
			manipulations[13] = () => mediaStore.MySqlClient14 = isolatedContainer;
			manipulations[14] = () => mediaStore.MySqlClient15 = isolatedContainer;
			manipulations[15] = () => mediaStore.MySqlClient16 = isolatedContainer;
			manipulations[16] = () => mediaStore.MySqlClient1 = databaseServer1;
			manipulations[17] = () => mediaStore.MySqlClient2 = databaseServer2;
			manipulations[18] = () => mediaStore.MySqlClient3 = databaseServer3;
			manipulations[19] = () => mediaStore.MySqlClient4 = databaseServer4;
			manipulations[20] = () => mediaStore.MySqlClient5 = databaseServer5;
			manipulations[21] = () => mediaStore.MySqlClient6 = databaseServer6;
			manipulations[22] = () => mediaStore.MySqlClient7 = databaseServer7;
			manipulations[23] = () => mediaStore.MySqlClient8 = databaseServer8;
			manipulations[24] = () => mediaStore.MySqlClient9 = databaseServer9;
			manipulations[25] = () => mediaStore.MySqlClient10 = databaseServer10;
			manipulations[26] = () => mediaStore.MySqlClient11 = databaseServer11;
			manipulations[27] = () => mediaStore.MySqlClient12 = databaseServer12;
			manipulations[28] = () => mediaStore.MySqlClient13 = databaseServer13;
			manipulations[29] = () => mediaStore.MySqlClient14 = databaseServer14;
			manipulations[30] = () => mediaStore.MySqlClient15 = databaseServer15;
			manipulations[31] = () => mediaStore.MySqlClient16 = databaseServer16;
			manipulations[32] = () => network1.Connects.Remove(databaseServer1);
			manipulations[33] = () => network2.Connects.Remove(databaseServer2);
			manipulations[34] = () => network3.Connects.Remove(databaseServer3);
			manipulations[35] = () => network4.Connects.Remove(databaseServer4);
			manipulations[36] = () => network5.Connects.Remove(databaseServer5);
			manipulations[37] = () => network6.Connects.Remove(databaseServer6);
			manipulations[38] = () => network7.Connects.Remove(databaseServer7);
			manipulations[39] = () => network8.Connects.Remove(databaseServer8);
			manipulations[40] = () => network9.Connects.Remove(databaseServer9);
			manipulations[41] = () => network10.Connects.Remove(databaseServer10);
			manipulations[42] = () => network11.Connects.Remove(databaseServer11);
			manipulations[43] = () => network12.Connects.Remove(databaseServer12);
			manipulations[44] = () => network13.Connects.Remove(databaseServer13);
			manipulations[45] = () => network14.Connects.Remove(databaseServer14);
			manipulations[46] = () => network15.Connects.Remove(databaseServer15);
			manipulations[47] = () => network16.Connects.Remove(databaseServer16);
			return mediaStore;
        }
        public static ISystemAllocation CreateMediaStoreX32Allocation(out Action[] manipulations)
        {
            var environment = new ResourceEnvironment();
            var isolatedContainer = new ResourceContainer() { Name = "IsolatedContainer" };
            environment.Container.Add(isolatedContainer);
            var appServer1 = new ResourceContainer() { Name = "AppServer1" };
            var databaseServer1 = new ResourceContainer() { Name = "DatabaseServer1" };
            environment.Container.Add(appServer1);
			environment.Container.Add(databaseServer1);
            var network1 = new ResourceLink();
            environment.Links.Add(network1);
            network1.Connects.Add(appServer1);
            network1.Connects.Add(databaseServer1);
            var appServer2 = new ResourceContainer() { Name = "AppServer2" };
            var databaseServer2 = new ResourceContainer() { Name = "DatabaseServer2" };
            environment.Container.Add(appServer2);
			environment.Container.Add(databaseServer2);
            var network2 = new ResourceLink();
            environment.Links.Add(network2);
            network2.Connects.Add(appServer2);
            network2.Connects.Add(databaseServer2);
            var appServer3 = new ResourceContainer() { Name = "AppServer3" };
            var databaseServer3 = new ResourceContainer() { Name = "DatabaseServer3" };
            environment.Container.Add(appServer3);
			environment.Container.Add(databaseServer3);
            var network3 = new ResourceLink();
            environment.Links.Add(network3);
            network3.Connects.Add(appServer3);
            network3.Connects.Add(databaseServer3);
            var appServer4 = new ResourceContainer() { Name = "AppServer4" };
            var databaseServer4 = new ResourceContainer() { Name = "DatabaseServer4" };
            environment.Container.Add(appServer4);
			environment.Container.Add(databaseServer4);
            var network4 = new ResourceLink();
            environment.Links.Add(network4);
            network4.Connects.Add(appServer4);
            network4.Connects.Add(databaseServer4);
            var appServer5 = new ResourceContainer() { Name = "AppServer5" };
            var databaseServer5 = new ResourceContainer() { Name = "DatabaseServer5" };
            environment.Container.Add(appServer5);
			environment.Container.Add(databaseServer5);
            var network5 = new ResourceLink();
            environment.Links.Add(network5);
            network5.Connects.Add(appServer5);
            network5.Connects.Add(databaseServer5);
            var appServer6 = new ResourceContainer() { Name = "AppServer6" };
            var databaseServer6 = new ResourceContainer() { Name = "DatabaseServer6" };
            environment.Container.Add(appServer6);
			environment.Container.Add(databaseServer6);
            var network6 = new ResourceLink();
            environment.Links.Add(network6);
            network6.Connects.Add(appServer6);
            network6.Connects.Add(databaseServer6);
            var appServer7 = new ResourceContainer() { Name = "AppServer7" };
            var databaseServer7 = new ResourceContainer() { Name = "DatabaseServer7" };
            environment.Container.Add(appServer7);
			environment.Container.Add(databaseServer7);
            var network7 = new ResourceLink();
            environment.Links.Add(network7);
            network7.Connects.Add(appServer7);
            network7.Connects.Add(databaseServer7);
            var appServer8 = new ResourceContainer() { Name = "AppServer8" };
            var databaseServer8 = new ResourceContainer() { Name = "DatabaseServer8" };
            environment.Container.Add(appServer8);
			environment.Container.Add(databaseServer8);
            var network8 = new ResourceLink();
            environment.Links.Add(network8);
            network8.Connects.Add(appServer8);
            network8.Connects.Add(databaseServer8);
            var appServer9 = new ResourceContainer() { Name = "AppServer9" };
            var databaseServer9 = new ResourceContainer() { Name = "DatabaseServer9" };
            environment.Container.Add(appServer9);
			environment.Container.Add(databaseServer9);
            var network9 = new ResourceLink();
            environment.Links.Add(network9);
            network9.Connects.Add(appServer9);
            network9.Connects.Add(databaseServer9);
            var appServer10 = new ResourceContainer() { Name = "AppServer10" };
            var databaseServer10 = new ResourceContainer() { Name = "DatabaseServer10" };
            environment.Container.Add(appServer10);
			environment.Container.Add(databaseServer10);
            var network10 = new ResourceLink();
            environment.Links.Add(network10);
            network10.Connects.Add(appServer10);
            network10.Connects.Add(databaseServer10);
            var appServer11 = new ResourceContainer() { Name = "AppServer11" };
            var databaseServer11 = new ResourceContainer() { Name = "DatabaseServer11" };
            environment.Container.Add(appServer11);
			environment.Container.Add(databaseServer11);
            var network11 = new ResourceLink();
            environment.Links.Add(network11);
            network11.Connects.Add(appServer11);
            network11.Connects.Add(databaseServer11);
            var appServer12 = new ResourceContainer() { Name = "AppServer12" };
            var databaseServer12 = new ResourceContainer() { Name = "DatabaseServer12" };
            environment.Container.Add(appServer12);
			environment.Container.Add(databaseServer12);
            var network12 = new ResourceLink();
            environment.Links.Add(network12);
            network12.Connects.Add(appServer12);
            network12.Connects.Add(databaseServer12);
            var appServer13 = new ResourceContainer() { Name = "AppServer13" };
            var databaseServer13 = new ResourceContainer() { Name = "DatabaseServer13" };
            environment.Container.Add(appServer13);
			environment.Container.Add(databaseServer13);
            var network13 = new ResourceLink();
            environment.Links.Add(network13);
            network13.Connects.Add(appServer13);
            network13.Connects.Add(databaseServer13);
            var appServer14 = new ResourceContainer() { Name = "AppServer14" };
            var databaseServer14 = new ResourceContainer() { Name = "DatabaseServer14" };
            environment.Container.Add(appServer14);
			environment.Container.Add(databaseServer14);
            var network14 = new ResourceLink();
            environment.Links.Add(network14);
            network14.Connects.Add(appServer14);
            network14.Connects.Add(databaseServer14);
            var appServer15 = new ResourceContainer() { Name = "AppServer15" };
            var databaseServer15 = new ResourceContainer() { Name = "DatabaseServer15" };
            environment.Container.Add(appServer15);
			environment.Container.Add(databaseServer15);
            var network15 = new ResourceLink();
            environment.Links.Add(network15);
            network15.Connects.Add(appServer15);
            network15.Connects.Add(databaseServer15);
            var appServer16 = new ResourceContainer() { Name = "AppServer16" };
            var databaseServer16 = new ResourceContainer() { Name = "DatabaseServer16" };
            environment.Container.Add(appServer16);
			environment.Container.Add(databaseServer16);
            var network16 = new ResourceLink();
            environment.Links.Add(network16);
            network16.Connects.Add(appServer16);
            network16.Connects.Add(databaseServer16);
            var appServer17 = new ResourceContainer() { Name = "AppServer17" };
            var databaseServer17 = new ResourceContainer() { Name = "DatabaseServer17" };
            environment.Container.Add(appServer17);
			environment.Container.Add(databaseServer17);
            var network17 = new ResourceLink();
            environment.Links.Add(network17);
            network17.Connects.Add(appServer17);
            network17.Connects.Add(databaseServer17);
            var appServer18 = new ResourceContainer() { Name = "AppServer18" };
            var databaseServer18 = new ResourceContainer() { Name = "DatabaseServer18" };
            environment.Container.Add(appServer18);
			environment.Container.Add(databaseServer18);
            var network18 = new ResourceLink();
            environment.Links.Add(network18);
            network18.Connects.Add(appServer18);
            network18.Connects.Add(databaseServer18);
            var appServer19 = new ResourceContainer() { Name = "AppServer19" };
            var databaseServer19 = new ResourceContainer() { Name = "DatabaseServer19" };
            environment.Container.Add(appServer19);
			environment.Container.Add(databaseServer19);
            var network19 = new ResourceLink();
            environment.Links.Add(network19);
            network19.Connects.Add(appServer19);
            network19.Connects.Add(databaseServer19);
            var appServer20 = new ResourceContainer() { Name = "AppServer20" };
            var databaseServer20 = new ResourceContainer() { Name = "DatabaseServer20" };
            environment.Container.Add(appServer20);
			environment.Container.Add(databaseServer20);
            var network20 = new ResourceLink();
            environment.Links.Add(network20);
            network20.Connects.Add(appServer20);
            network20.Connects.Add(databaseServer20);
            var appServer21 = new ResourceContainer() { Name = "AppServer21" };
            var databaseServer21 = new ResourceContainer() { Name = "DatabaseServer21" };
            environment.Container.Add(appServer21);
			environment.Container.Add(databaseServer21);
            var network21 = new ResourceLink();
            environment.Links.Add(network21);
            network21.Connects.Add(appServer21);
            network21.Connects.Add(databaseServer21);
            var appServer22 = new ResourceContainer() { Name = "AppServer22" };
            var databaseServer22 = new ResourceContainer() { Name = "DatabaseServer22" };
            environment.Container.Add(appServer22);
			environment.Container.Add(databaseServer22);
            var network22 = new ResourceLink();
            environment.Links.Add(network22);
            network22.Connects.Add(appServer22);
            network22.Connects.Add(databaseServer22);
            var appServer23 = new ResourceContainer() { Name = "AppServer23" };
            var databaseServer23 = new ResourceContainer() { Name = "DatabaseServer23" };
            environment.Container.Add(appServer23);
			environment.Container.Add(databaseServer23);
            var network23 = new ResourceLink();
            environment.Links.Add(network23);
            network23.Connects.Add(appServer23);
            network23.Connects.Add(databaseServer23);
            var appServer24 = new ResourceContainer() { Name = "AppServer24" };
            var databaseServer24 = new ResourceContainer() { Name = "DatabaseServer24" };
            environment.Container.Add(appServer24);
			environment.Container.Add(databaseServer24);
            var network24 = new ResourceLink();
            environment.Links.Add(network24);
            network24.Connects.Add(appServer24);
            network24.Connects.Add(databaseServer24);
            var appServer25 = new ResourceContainer() { Name = "AppServer25" };
            var databaseServer25 = new ResourceContainer() { Name = "DatabaseServer25" };
            environment.Container.Add(appServer25);
			environment.Container.Add(databaseServer25);
            var network25 = new ResourceLink();
            environment.Links.Add(network25);
            network25.Connects.Add(appServer25);
            network25.Connects.Add(databaseServer25);
            var appServer26 = new ResourceContainer() { Name = "AppServer26" };
            var databaseServer26 = new ResourceContainer() { Name = "DatabaseServer26" };
            environment.Container.Add(appServer26);
			environment.Container.Add(databaseServer26);
            var network26 = new ResourceLink();
            environment.Links.Add(network26);
            network26.Connects.Add(appServer26);
            network26.Connects.Add(databaseServer26);
            var appServer27 = new ResourceContainer() { Name = "AppServer27" };
            var databaseServer27 = new ResourceContainer() { Name = "DatabaseServer27" };
            environment.Container.Add(appServer27);
			environment.Container.Add(databaseServer27);
            var network27 = new ResourceLink();
            environment.Links.Add(network27);
            network27.Connects.Add(appServer27);
            network27.Connects.Add(databaseServer27);
            var appServer28 = new ResourceContainer() { Name = "AppServer28" };
            var databaseServer28 = new ResourceContainer() { Name = "DatabaseServer28" };
            environment.Container.Add(appServer28);
			environment.Container.Add(databaseServer28);
            var network28 = new ResourceLink();
            environment.Links.Add(network28);
            network28.Connects.Add(appServer28);
            network28.Connects.Add(databaseServer28);
            var appServer29 = new ResourceContainer() { Name = "AppServer29" };
            var databaseServer29 = new ResourceContainer() { Name = "DatabaseServer29" };
            environment.Container.Add(appServer29);
			environment.Container.Add(databaseServer29);
            var network29 = new ResourceLink();
            environment.Links.Add(network29);
            network29.Connects.Add(appServer29);
            network29.Connects.Add(databaseServer29);
            var appServer30 = new ResourceContainer() { Name = "AppServer30" };
            var databaseServer30 = new ResourceContainer() { Name = "DatabaseServer30" };
            environment.Container.Add(appServer30);
			environment.Container.Add(databaseServer30);
            var network30 = new ResourceLink();
            environment.Links.Add(network30);
            network30.Connects.Add(appServer30);
            network30.Connects.Add(databaseServer30);
            var appServer31 = new ResourceContainer() { Name = "AppServer31" };
            var databaseServer31 = new ResourceContainer() { Name = "DatabaseServer31" };
            environment.Container.Add(appServer31);
			environment.Container.Add(databaseServer31);
            var network31 = new ResourceLink();
            environment.Links.Add(network31);
            network31.Connects.Add(appServer31);
            network31.Connects.Add(databaseServer31);
            var appServer32 = new ResourceContainer() { Name = "AppServer32" };
            var databaseServer32 = new ResourceContainer() { Name = "DatabaseServer32" };
            environment.Container.Add(appServer32);
			environment.Container.Add(databaseServer32);
            var network32 = new ResourceLink();
            environment.Links.Add(network32);
            network32.Connects.Add(appServer32);
            network32.Connects.Add(databaseServer32);
            var mediaStore = new FZI.SoftwareEngineering.DeepModeling.AssemblyX32.MediaStoreX32()
            {
                AudioStore1 = appServer1,
                DBAdapter1 = appServer1,
                EncodingAdapter1 = appServer1,
                MySqlClient1 = databaseServer1,
                OggEncoder1 = appServer1,
                UserManagement1 = appServer1,
                WebForm1 = appServer1,
                AudioStore2 = appServer2,
                DBAdapter2 = appServer2,
                EncodingAdapter2 = appServer2,
                MySqlClient2 = databaseServer2,
                OggEncoder2 = appServer2,
                UserManagement2 = appServer2,
                WebForm2 = appServer2,
                AudioStore3 = appServer3,
                DBAdapter3 = appServer3,
                EncodingAdapter3 = appServer3,
                MySqlClient3 = databaseServer3,
                OggEncoder3 = appServer3,
                UserManagement3 = appServer3,
                WebForm3 = appServer3,
                AudioStore4 = appServer4,
                DBAdapter4 = appServer4,
                EncodingAdapter4 = appServer4,
                MySqlClient4 = databaseServer4,
                OggEncoder4 = appServer4,
                UserManagement4 = appServer4,
                WebForm4 = appServer4,
                AudioStore5 = appServer5,
                DBAdapter5 = appServer5,
                EncodingAdapter5 = appServer5,
                MySqlClient5 = databaseServer5,
                OggEncoder5 = appServer5,
                UserManagement5 = appServer5,
                WebForm5 = appServer5,
                AudioStore6 = appServer6,
                DBAdapter6 = appServer6,
                EncodingAdapter6 = appServer6,
                MySqlClient6 = databaseServer6,
                OggEncoder6 = appServer6,
                UserManagement6 = appServer6,
                WebForm6 = appServer6,
                AudioStore7 = appServer7,
                DBAdapter7 = appServer7,
                EncodingAdapter7 = appServer7,
                MySqlClient7 = databaseServer7,
                OggEncoder7 = appServer7,
                UserManagement7 = appServer7,
                WebForm7 = appServer7,
                AudioStore8 = appServer8,
                DBAdapter8 = appServer8,
                EncodingAdapter8 = appServer8,
                MySqlClient8 = databaseServer8,
                OggEncoder8 = appServer8,
                UserManagement8 = appServer8,
                WebForm8 = appServer8,
                AudioStore9 = appServer9,
                DBAdapter9 = appServer9,
                EncodingAdapter9 = appServer9,
                MySqlClient9 = databaseServer9,
                OggEncoder9 = appServer9,
                UserManagement9 = appServer9,
                WebForm9 = appServer9,
                AudioStore10 = appServer10,
                DBAdapter10 = appServer10,
                EncodingAdapter10 = appServer10,
                MySqlClient10 = databaseServer10,
                OggEncoder10 = appServer10,
                UserManagement10 = appServer10,
                WebForm10 = appServer10,
                AudioStore11 = appServer11,
                DBAdapter11 = appServer11,
                EncodingAdapter11 = appServer11,
                MySqlClient11 = databaseServer11,
                OggEncoder11 = appServer11,
                UserManagement11 = appServer11,
                WebForm11 = appServer11,
                AudioStore12 = appServer12,
                DBAdapter12 = appServer12,
                EncodingAdapter12 = appServer12,
                MySqlClient12 = databaseServer12,
                OggEncoder12 = appServer12,
                UserManagement12 = appServer12,
                WebForm12 = appServer12,
                AudioStore13 = appServer13,
                DBAdapter13 = appServer13,
                EncodingAdapter13 = appServer13,
                MySqlClient13 = databaseServer13,
                OggEncoder13 = appServer13,
                UserManagement13 = appServer13,
                WebForm13 = appServer13,
                AudioStore14 = appServer14,
                DBAdapter14 = appServer14,
                EncodingAdapter14 = appServer14,
                MySqlClient14 = databaseServer14,
                OggEncoder14 = appServer14,
                UserManagement14 = appServer14,
                WebForm14 = appServer14,
                AudioStore15 = appServer15,
                DBAdapter15 = appServer15,
                EncodingAdapter15 = appServer15,
                MySqlClient15 = databaseServer15,
                OggEncoder15 = appServer15,
                UserManagement15 = appServer15,
                WebForm15 = appServer15,
                AudioStore16 = appServer16,
                DBAdapter16 = appServer16,
                EncodingAdapter16 = appServer16,
                MySqlClient16 = databaseServer16,
                OggEncoder16 = appServer16,
                UserManagement16 = appServer16,
                WebForm16 = appServer16,
                AudioStore17 = appServer17,
                DBAdapter17 = appServer17,
                EncodingAdapter17 = appServer17,
                MySqlClient17 = databaseServer17,
                OggEncoder17 = appServer17,
                UserManagement17 = appServer17,
                WebForm17 = appServer17,
                AudioStore18 = appServer18,
                DBAdapter18 = appServer18,
                EncodingAdapter18 = appServer18,
                MySqlClient18 = databaseServer18,
                OggEncoder18 = appServer18,
                UserManagement18 = appServer18,
                WebForm18 = appServer18,
                AudioStore19 = appServer19,
                DBAdapter19 = appServer19,
                EncodingAdapter19 = appServer19,
                MySqlClient19 = databaseServer19,
                OggEncoder19 = appServer19,
                UserManagement19 = appServer19,
                WebForm19 = appServer19,
                AudioStore20 = appServer20,
                DBAdapter20 = appServer20,
                EncodingAdapter20 = appServer20,
                MySqlClient20 = databaseServer20,
                OggEncoder20 = appServer20,
                UserManagement20 = appServer20,
                WebForm20 = appServer20,
                AudioStore21 = appServer21,
                DBAdapter21 = appServer21,
                EncodingAdapter21 = appServer21,
                MySqlClient21 = databaseServer21,
                OggEncoder21 = appServer21,
                UserManagement21 = appServer21,
                WebForm21 = appServer21,
                AudioStore22 = appServer22,
                DBAdapter22 = appServer22,
                EncodingAdapter22 = appServer22,
                MySqlClient22 = databaseServer22,
                OggEncoder22 = appServer22,
                UserManagement22 = appServer22,
                WebForm22 = appServer22,
                AudioStore23 = appServer23,
                DBAdapter23 = appServer23,
                EncodingAdapter23 = appServer23,
                MySqlClient23 = databaseServer23,
                OggEncoder23 = appServer23,
                UserManagement23 = appServer23,
                WebForm23 = appServer23,
                AudioStore24 = appServer24,
                DBAdapter24 = appServer24,
                EncodingAdapter24 = appServer24,
                MySqlClient24 = databaseServer24,
                OggEncoder24 = appServer24,
                UserManagement24 = appServer24,
                WebForm24 = appServer24,
                AudioStore25 = appServer25,
                DBAdapter25 = appServer25,
                EncodingAdapter25 = appServer25,
                MySqlClient25 = databaseServer25,
                OggEncoder25 = appServer25,
                UserManagement25 = appServer25,
                WebForm25 = appServer25,
                AudioStore26 = appServer26,
                DBAdapter26 = appServer26,
                EncodingAdapter26 = appServer26,
                MySqlClient26 = databaseServer26,
                OggEncoder26 = appServer26,
                UserManagement26 = appServer26,
                WebForm26 = appServer26,
                AudioStore27 = appServer27,
                DBAdapter27 = appServer27,
                EncodingAdapter27 = appServer27,
                MySqlClient27 = databaseServer27,
                OggEncoder27 = appServer27,
                UserManagement27 = appServer27,
                WebForm27 = appServer27,
                AudioStore28 = appServer28,
                DBAdapter28 = appServer28,
                EncodingAdapter28 = appServer28,
                MySqlClient28 = databaseServer28,
                OggEncoder28 = appServer28,
                UserManagement28 = appServer28,
                WebForm28 = appServer28,
                AudioStore29 = appServer29,
                DBAdapter29 = appServer29,
                EncodingAdapter29 = appServer29,
                MySqlClient29 = databaseServer29,
                OggEncoder29 = appServer29,
                UserManagement29 = appServer29,
                WebForm29 = appServer29,
                AudioStore30 = appServer30,
                DBAdapter30 = appServer30,
                EncodingAdapter30 = appServer30,
                MySqlClient30 = databaseServer30,
                OggEncoder30 = appServer30,
                UserManagement30 = appServer30,
                WebForm30 = appServer30,
                AudioStore31 = appServer31,
                DBAdapter31 = appServer31,
                EncodingAdapter31 = appServer31,
                MySqlClient31 = databaseServer31,
                OggEncoder31 = appServer31,
                UserManagement31 = appServer31,
                WebForm31 = appServer31,
                AudioStore32 = appServer32,
                DBAdapter32 = appServer32,
                EncodingAdapter32 = appServer32,
                MySqlClient32 = databaseServer32,
                OggEncoder32 = appServer32,
                UserManagement32 = appServer32,
                WebForm32 = appServer32,
                Environment = environment
            };
			manipulations = new Action[96];
			manipulations[0] = () => mediaStore.MySqlClient1 = isolatedContainer;
			manipulations[1] = () => mediaStore.MySqlClient2 = isolatedContainer;
			manipulations[2] = () => mediaStore.MySqlClient3 = isolatedContainer;
			manipulations[3] = () => mediaStore.MySqlClient4 = isolatedContainer;
			manipulations[4] = () => mediaStore.MySqlClient5 = isolatedContainer;
			manipulations[5] = () => mediaStore.MySqlClient6 = isolatedContainer;
			manipulations[6] = () => mediaStore.MySqlClient7 = isolatedContainer;
			manipulations[7] = () => mediaStore.MySqlClient8 = isolatedContainer;
			manipulations[8] = () => mediaStore.MySqlClient9 = isolatedContainer;
			manipulations[9] = () => mediaStore.MySqlClient10 = isolatedContainer;
			manipulations[10] = () => mediaStore.MySqlClient11 = isolatedContainer;
			manipulations[11] = () => mediaStore.MySqlClient12 = isolatedContainer;
			manipulations[12] = () => mediaStore.MySqlClient13 = isolatedContainer;
			manipulations[13] = () => mediaStore.MySqlClient14 = isolatedContainer;
			manipulations[14] = () => mediaStore.MySqlClient15 = isolatedContainer;
			manipulations[15] = () => mediaStore.MySqlClient16 = isolatedContainer;
			manipulations[16] = () => mediaStore.MySqlClient17 = isolatedContainer;
			manipulations[17] = () => mediaStore.MySqlClient18 = isolatedContainer;
			manipulations[18] = () => mediaStore.MySqlClient19 = isolatedContainer;
			manipulations[19] = () => mediaStore.MySqlClient20 = isolatedContainer;
			manipulations[20] = () => mediaStore.MySqlClient21 = isolatedContainer;
			manipulations[21] = () => mediaStore.MySqlClient22 = isolatedContainer;
			manipulations[22] = () => mediaStore.MySqlClient23 = isolatedContainer;
			manipulations[23] = () => mediaStore.MySqlClient24 = isolatedContainer;
			manipulations[24] = () => mediaStore.MySqlClient25 = isolatedContainer;
			manipulations[25] = () => mediaStore.MySqlClient26 = isolatedContainer;
			manipulations[26] = () => mediaStore.MySqlClient27 = isolatedContainer;
			manipulations[27] = () => mediaStore.MySqlClient28 = isolatedContainer;
			manipulations[28] = () => mediaStore.MySqlClient29 = isolatedContainer;
			manipulations[29] = () => mediaStore.MySqlClient30 = isolatedContainer;
			manipulations[30] = () => mediaStore.MySqlClient31 = isolatedContainer;
			manipulations[31] = () => mediaStore.MySqlClient32 = isolatedContainer;
			manipulations[32] = () => mediaStore.MySqlClient1 = databaseServer1;
			manipulations[33] = () => mediaStore.MySqlClient2 = databaseServer2;
			manipulations[34] = () => mediaStore.MySqlClient3 = databaseServer3;
			manipulations[35] = () => mediaStore.MySqlClient4 = databaseServer4;
			manipulations[36] = () => mediaStore.MySqlClient5 = databaseServer5;
			manipulations[37] = () => mediaStore.MySqlClient6 = databaseServer6;
			manipulations[38] = () => mediaStore.MySqlClient7 = databaseServer7;
			manipulations[39] = () => mediaStore.MySqlClient8 = databaseServer8;
			manipulations[40] = () => mediaStore.MySqlClient9 = databaseServer9;
			manipulations[41] = () => mediaStore.MySqlClient10 = databaseServer10;
			manipulations[42] = () => mediaStore.MySqlClient11 = databaseServer11;
			manipulations[43] = () => mediaStore.MySqlClient12 = databaseServer12;
			manipulations[44] = () => mediaStore.MySqlClient13 = databaseServer13;
			manipulations[45] = () => mediaStore.MySqlClient14 = databaseServer14;
			manipulations[46] = () => mediaStore.MySqlClient15 = databaseServer15;
			manipulations[47] = () => mediaStore.MySqlClient16 = databaseServer16;
			manipulations[48] = () => mediaStore.MySqlClient17 = databaseServer17;
			manipulations[49] = () => mediaStore.MySqlClient18 = databaseServer18;
			manipulations[50] = () => mediaStore.MySqlClient19 = databaseServer19;
			manipulations[51] = () => mediaStore.MySqlClient20 = databaseServer20;
			manipulations[52] = () => mediaStore.MySqlClient21 = databaseServer21;
			manipulations[53] = () => mediaStore.MySqlClient22 = databaseServer22;
			manipulations[54] = () => mediaStore.MySqlClient23 = databaseServer23;
			manipulations[55] = () => mediaStore.MySqlClient24 = databaseServer24;
			manipulations[56] = () => mediaStore.MySqlClient25 = databaseServer25;
			manipulations[57] = () => mediaStore.MySqlClient26 = databaseServer26;
			manipulations[58] = () => mediaStore.MySqlClient27 = databaseServer27;
			manipulations[59] = () => mediaStore.MySqlClient28 = databaseServer28;
			manipulations[60] = () => mediaStore.MySqlClient29 = databaseServer29;
			manipulations[61] = () => mediaStore.MySqlClient30 = databaseServer30;
			manipulations[62] = () => mediaStore.MySqlClient31 = databaseServer31;
			manipulations[63] = () => mediaStore.MySqlClient32 = databaseServer32;
			manipulations[64] = () => network1.Connects.Remove(databaseServer1);
			manipulations[65] = () => network2.Connects.Remove(databaseServer2);
			manipulations[66] = () => network3.Connects.Remove(databaseServer3);
			manipulations[67] = () => network4.Connects.Remove(databaseServer4);
			manipulations[68] = () => network5.Connects.Remove(databaseServer5);
			manipulations[69] = () => network6.Connects.Remove(databaseServer6);
			manipulations[70] = () => network7.Connects.Remove(databaseServer7);
			manipulations[71] = () => network8.Connects.Remove(databaseServer8);
			manipulations[72] = () => network9.Connects.Remove(databaseServer9);
			manipulations[73] = () => network10.Connects.Remove(databaseServer10);
			manipulations[74] = () => network11.Connects.Remove(databaseServer11);
			manipulations[75] = () => network12.Connects.Remove(databaseServer12);
			manipulations[76] = () => network13.Connects.Remove(databaseServer13);
			manipulations[77] = () => network14.Connects.Remove(databaseServer14);
			manipulations[78] = () => network15.Connects.Remove(databaseServer15);
			manipulations[79] = () => network16.Connects.Remove(databaseServer16);
			manipulations[80] = () => network17.Connects.Remove(databaseServer17);
			manipulations[81] = () => network18.Connects.Remove(databaseServer18);
			manipulations[82] = () => network19.Connects.Remove(databaseServer19);
			manipulations[83] = () => network20.Connects.Remove(databaseServer20);
			manipulations[84] = () => network21.Connects.Remove(databaseServer21);
			manipulations[85] = () => network22.Connects.Remove(databaseServer22);
			manipulations[86] = () => network23.Connects.Remove(databaseServer23);
			manipulations[87] = () => network24.Connects.Remove(databaseServer24);
			manipulations[88] = () => network25.Connects.Remove(databaseServer25);
			manipulations[89] = () => network26.Connects.Remove(databaseServer26);
			manipulations[90] = () => network27.Connects.Remove(databaseServer27);
			manipulations[91] = () => network28.Connects.Remove(databaseServer28);
			manipulations[92] = () => network29.Connects.Remove(databaseServer29);
			manipulations[93] = () => network30.Connects.Remove(databaseServer30);
			manipulations[94] = () => network31.Connects.Remove(databaseServer31);
			manipulations[95] = () => network32.Connects.Remove(databaseServer32);
			return mediaStore;
        }
        public static ISystemAllocation CreateMediaStoreX64Allocation(out Action[] manipulations)
        {
            var environment = new ResourceEnvironment();
            var isolatedContainer = new ResourceContainer() { Name = "IsolatedContainer" };
            environment.Container.Add(isolatedContainer);
            var appServer1 = new ResourceContainer() { Name = "AppServer1" };
            var databaseServer1 = new ResourceContainer() { Name = "DatabaseServer1" };
            environment.Container.Add(appServer1);
			environment.Container.Add(databaseServer1);
            var network1 = new ResourceLink();
            environment.Links.Add(network1);
            network1.Connects.Add(appServer1);
            network1.Connects.Add(databaseServer1);
            var appServer2 = new ResourceContainer() { Name = "AppServer2" };
            var databaseServer2 = new ResourceContainer() { Name = "DatabaseServer2" };
            environment.Container.Add(appServer2);
			environment.Container.Add(databaseServer2);
            var network2 = new ResourceLink();
            environment.Links.Add(network2);
            network2.Connects.Add(appServer2);
            network2.Connects.Add(databaseServer2);
            var appServer3 = new ResourceContainer() { Name = "AppServer3" };
            var databaseServer3 = new ResourceContainer() { Name = "DatabaseServer3" };
            environment.Container.Add(appServer3);
			environment.Container.Add(databaseServer3);
            var network3 = new ResourceLink();
            environment.Links.Add(network3);
            network3.Connects.Add(appServer3);
            network3.Connects.Add(databaseServer3);
            var appServer4 = new ResourceContainer() { Name = "AppServer4" };
            var databaseServer4 = new ResourceContainer() { Name = "DatabaseServer4" };
            environment.Container.Add(appServer4);
			environment.Container.Add(databaseServer4);
            var network4 = new ResourceLink();
            environment.Links.Add(network4);
            network4.Connects.Add(appServer4);
            network4.Connects.Add(databaseServer4);
            var appServer5 = new ResourceContainer() { Name = "AppServer5" };
            var databaseServer5 = new ResourceContainer() { Name = "DatabaseServer5" };
            environment.Container.Add(appServer5);
			environment.Container.Add(databaseServer5);
            var network5 = new ResourceLink();
            environment.Links.Add(network5);
            network5.Connects.Add(appServer5);
            network5.Connects.Add(databaseServer5);
            var appServer6 = new ResourceContainer() { Name = "AppServer6" };
            var databaseServer6 = new ResourceContainer() { Name = "DatabaseServer6" };
            environment.Container.Add(appServer6);
			environment.Container.Add(databaseServer6);
            var network6 = new ResourceLink();
            environment.Links.Add(network6);
            network6.Connects.Add(appServer6);
            network6.Connects.Add(databaseServer6);
            var appServer7 = new ResourceContainer() { Name = "AppServer7" };
            var databaseServer7 = new ResourceContainer() { Name = "DatabaseServer7" };
            environment.Container.Add(appServer7);
			environment.Container.Add(databaseServer7);
            var network7 = new ResourceLink();
            environment.Links.Add(network7);
            network7.Connects.Add(appServer7);
            network7.Connects.Add(databaseServer7);
            var appServer8 = new ResourceContainer() { Name = "AppServer8" };
            var databaseServer8 = new ResourceContainer() { Name = "DatabaseServer8" };
            environment.Container.Add(appServer8);
			environment.Container.Add(databaseServer8);
            var network8 = new ResourceLink();
            environment.Links.Add(network8);
            network8.Connects.Add(appServer8);
            network8.Connects.Add(databaseServer8);
            var appServer9 = new ResourceContainer() { Name = "AppServer9" };
            var databaseServer9 = new ResourceContainer() { Name = "DatabaseServer9" };
            environment.Container.Add(appServer9);
			environment.Container.Add(databaseServer9);
            var network9 = new ResourceLink();
            environment.Links.Add(network9);
            network9.Connects.Add(appServer9);
            network9.Connects.Add(databaseServer9);
            var appServer10 = new ResourceContainer() { Name = "AppServer10" };
            var databaseServer10 = new ResourceContainer() { Name = "DatabaseServer10" };
            environment.Container.Add(appServer10);
			environment.Container.Add(databaseServer10);
            var network10 = new ResourceLink();
            environment.Links.Add(network10);
            network10.Connects.Add(appServer10);
            network10.Connects.Add(databaseServer10);
            var appServer11 = new ResourceContainer() { Name = "AppServer11" };
            var databaseServer11 = new ResourceContainer() { Name = "DatabaseServer11" };
            environment.Container.Add(appServer11);
			environment.Container.Add(databaseServer11);
            var network11 = new ResourceLink();
            environment.Links.Add(network11);
            network11.Connects.Add(appServer11);
            network11.Connects.Add(databaseServer11);
            var appServer12 = new ResourceContainer() { Name = "AppServer12" };
            var databaseServer12 = new ResourceContainer() { Name = "DatabaseServer12" };
            environment.Container.Add(appServer12);
			environment.Container.Add(databaseServer12);
            var network12 = new ResourceLink();
            environment.Links.Add(network12);
            network12.Connects.Add(appServer12);
            network12.Connects.Add(databaseServer12);
            var appServer13 = new ResourceContainer() { Name = "AppServer13" };
            var databaseServer13 = new ResourceContainer() { Name = "DatabaseServer13" };
            environment.Container.Add(appServer13);
			environment.Container.Add(databaseServer13);
            var network13 = new ResourceLink();
            environment.Links.Add(network13);
            network13.Connects.Add(appServer13);
            network13.Connects.Add(databaseServer13);
            var appServer14 = new ResourceContainer() { Name = "AppServer14" };
            var databaseServer14 = new ResourceContainer() { Name = "DatabaseServer14" };
            environment.Container.Add(appServer14);
			environment.Container.Add(databaseServer14);
            var network14 = new ResourceLink();
            environment.Links.Add(network14);
            network14.Connects.Add(appServer14);
            network14.Connects.Add(databaseServer14);
            var appServer15 = new ResourceContainer() { Name = "AppServer15" };
            var databaseServer15 = new ResourceContainer() { Name = "DatabaseServer15" };
            environment.Container.Add(appServer15);
			environment.Container.Add(databaseServer15);
            var network15 = new ResourceLink();
            environment.Links.Add(network15);
            network15.Connects.Add(appServer15);
            network15.Connects.Add(databaseServer15);
            var appServer16 = new ResourceContainer() { Name = "AppServer16" };
            var databaseServer16 = new ResourceContainer() { Name = "DatabaseServer16" };
            environment.Container.Add(appServer16);
			environment.Container.Add(databaseServer16);
            var network16 = new ResourceLink();
            environment.Links.Add(network16);
            network16.Connects.Add(appServer16);
            network16.Connects.Add(databaseServer16);
            var appServer17 = new ResourceContainer() { Name = "AppServer17" };
            var databaseServer17 = new ResourceContainer() { Name = "DatabaseServer17" };
            environment.Container.Add(appServer17);
			environment.Container.Add(databaseServer17);
            var network17 = new ResourceLink();
            environment.Links.Add(network17);
            network17.Connects.Add(appServer17);
            network17.Connects.Add(databaseServer17);
            var appServer18 = new ResourceContainer() { Name = "AppServer18" };
            var databaseServer18 = new ResourceContainer() { Name = "DatabaseServer18" };
            environment.Container.Add(appServer18);
			environment.Container.Add(databaseServer18);
            var network18 = new ResourceLink();
            environment.Links.Add(network18);
            network18.Connects.Add(appServer18);
            network18.Connects.Add(databaseServer18);
            var appServer19 = new ResourceContainer() { Name = "AppServer19" };
            var databaseServer19 = new ResourceContainer() { Name = "DatabaseServer19" };
            environment.Container.Add(appServer19);
			environment.Container.Add(databaseServer19);
            var network19 = new ResourceLink();
            environment.Links.Add(network19);
            network19.Connects.Add(appServer19);
            network19.Connects.Add(databaseServer19);
            var appServer20 = new ResourceContainer() { Name = "AppServer20" };
            var databaseServer20 = new ResourceContainer() { Name = "DatabaseServer20" };
            environment.Container.Add(appServer20);
			environment.Container.Add(databaseServer20);
            var network20 = new ResourceLink();
            environment.Links.Add(network20);
            network20.Connects.Add(appServer20);
            network20.Connects.Add(databaseServer20);
            var appServer21 = new ResourceContainer() { Name = "AppServer21" };
            var databaseServer21 = new ResourceContainer() { Name = "DatabaseServer21" };
            environment.Container.Add(appServer21);
			environment.Container.Add(databaseServer21);
            var network21 = new ResourceLink();
            environment.Links.Add(network21);
            network21.Connects.Add(appServer21);
            network21.Connects.Add(databaseServer21);
            var appServer22 = new ResourceContainer() { Name = "AppServer22" };
            var databaseServer22 = new ResourceContainer() { Name = "DatabaseServer22" };
            environment.Container.Add(appServer22);
			environment.Container.Add(databaseServer22);
            var network22 = new ResourceLink();
            environment.Links.Add(network22);
            network22.Connects.Add(appServer22);
            network22.Connects.Add(databaseServer22);
            var appServer23 = new ResourceContainer() { Name = "AppServer23" };
            var databaseServer23 = new ResourceContainer() { Name = "DatabaseServer23" };
            environment.Container.Add(appServer23);
			environment.Container.Add(databaseServer23);
            var network23 = new ResourceLink();
            environment.Links.Add(network23);
            network23.Connects.Add(appServer23);
            network23.Connects.Add(databaseServer23);
            var appServer24 = new ResourceContainer() { Name = "AppServer24" };
            var databaseServer24 = new ResourceContainer() { Name = "DatabaseServer24" };
            environment.Container.Add(appServer24);
			environment.Container.Add(databaseServer24);
            var network24 = new ResourceLink();
            environment.Links.Add(network24);
            network24.Connects.Add(appServer24);
            network24.Connects.Add(databaseServer24);
            var appServer25 = new ResourceContainer() { Name = "AppServer25" };
            var databaseServer25 = new ResourceContainer() { Name = "DatabaseServer25" };
            environment.Container.Add(appServer25);
			environment.Container.Add(databaseServer25);
            var network25 = new ResourceLink();
            environment.Links.Add(network25);
            network25.Connects.Add(appServer25);
            network25.Connects.Add(databaseServer25);
            var appServer26 = new ResourceContainer() { Name = "AppServer26" };
            var databaseServer26 = new ResourceContainer() { Name = "DatabaseServer26" };
            environment.Container.Add(appServer26);
			environment.Container.Add(databaseServer26);
            var network26 = new ResourceLink();
            environment.Links.Add(network26);
            network26.Connects.Add(appServer26);
            network26.Connects.Add(databaseServer26);
            var appServer27 = new ResourceContainer() { Name = "AppServer27" };
            var databaseServer27 = new ResourceContainer() { Name = "DatabaseServer27" };
            environment.Container.Add(appServer27);
			environment.Container.Add(databaseServer27);
            var network27 = new ResourceLink();
            environment.Links.Add(network27);
            network27.Connects.Add(appServer27);
            network27.Connects.Add(databaseServer27);
            var appServer28 = new ResourceContainer() { Name = "AppServer28" };
            var databaseServer28 = new ResourceContainer() { Name = "DatabaseServer28" };
            environment.Container.Add(appServer28);
			environment.Container.Add(databaseServer28);
            var network28 = new ResourceLink();
            environment.Links.Add(network28);
            network28.Connects.Add(appServer28);
            network28.Connects.Add(databaseServer28);
            var appServer29 = new ResourceContainer() { Name = "AppServer29" };
            var databaseServer29 = new ResourceContainer() { Name = "DatabaseServer29" };
            environment.Container.Add(appServer29);
			environment.Container.Add(databaseServer29);
            var network29 = new ResourceLink();
            environment.Links.Add(network29);
            network29.Connects.Add(appServer29);
            network29.Connects.Add(databaseServer29);
            var appServer30 = new ResourceContainer() { Name = "AppServer30" };
            var databaseServer30 = new ResourceContainer() { Name = "DatabaseServer30" };
            environment.Container.Add(appServer30);
			environment.Container.Add(databaseServer30);
            var network30 = new ResourceLink();
            environment.Links.Add(network30);
            network30.Connects.Add(appServer30);
            network30.Connects.Add(databaseServer30);
            var appServer31 = new ResourceContainer() { Name = "AppServer31" };
            var databaseServer31 = new ResourceContainer() { Name = "DatabaseServer31" };
            environment.Container.Add(appServer31);
			environment.Container.Add(databaseServer31);
            var network31 = new ResourceLink();
            environment.Links.Add(network31);
            network31.Connects.Add(appServer31);
            network31.Connects.Add(databaseServer31);
            var appServer32 = new ResourceContainer() { Name = "AppServer32" };
            var databaseServer32 = new ResourceContainer() { Name = "DatabaseServer32" };
            environment.Container.Add(appServer32);
			environment.Container.Add(databaseServer32);
            var network32 = new ResourceLink();
            environment.Links.Add(network32);
            network32.Connects.Add(appServer32);
            network32.Connects.Add(databaseServer32);
            var appServer33 = new ResourceContainer() { Name = "AppServer33" };
            var databaseServer33 = new ResourceContainer() { Name = "DatabaseServer33" };
            environment.Container.Add(appServer33);
			environment.Container.Add(databaseServer33);
            var network33 = new ResourceLink();
            environment.Links.Add(network33);
            network33.Connects.Add(appServer33);
            network33.Connects.Add(databaseServer33);
            var appServer34 = new ResourceContainer() { Name = "AppServer34" };
            var databaseServer34 = new ResourceContainer() { Name = "DatabaseServer34" };
            environment.Container.Add(appServer34);
			environment.Container.Add(databaseServer34);
            var network34 = new ResourceLink();
            environment.Links.Add(network34);
            network34.Connects.Add(appServer34);
            network34.Connects.Add(databaseServer34);
            var appServer35 = new ResourceContainer() { Name = "AppServer35" };
            var databaseServer35 = new ResourceContainer() { Name = "DatabaseServer35" };
            environment.Container.Add(appServer35);
			environment.Container.Add(databaseServer35);
            var network35 = new ResourceLink();
            environment.Links.Add(network35);
            network35.Connects.Add(appServer35);
            network35.Connects.Add(databaseServer35);
            var appServer36 = new ResourceContainer() { Name = "AppServer36" };
            var databaseServer36 = new ResourceContainer() { Name = "DatabaseServer36" };
            environment.Container.Add(appServer36);
			environment.Container.Add(databaseServer36);
            var network36 = new ResourceLink();
            environment.Links.Add(network36);
            network36.Connects.Add(appServer36);
            network36.Connects.Add(databaseServer36);
            var appServer37 = new ResourceContainer() { Name = "AppServer37" };
            var databaseServer37 = new ResourceContainer() { Name = "DatabaseServer37" };
            environment.Container.Add(appServer37);
			environment.Container.Add(databaseServer37);
            var network37 = new ResourceLink();
            environment.Links.Add(network37);
            network37.Connects.Add(appServer37);
            network37.Connects.Add(databaseServer37);
            var appServer38 = new ResourceContainer() { Name = "AppServer38" };
            var databaseServer38 = new ResourceContainer() { Name = "DatabaseServer38" };
            environment.Container.Add(appServer38);
			environment.Container.Add(databaseServer38);
            var network38 = new ResourceLink();
            environment.Links.Add(network38);
            network38.Connects.Add(appServer38);
            network38.Connects.Add(databaseServer38);
            var appServer39 = new ResourceContainer() { Name = "AppServer39" };
            var databaseServer39 = new ResourceContainer() { Name = "DatabaseServer39" };
            environment.Container.Add(appServer39);
			environment.Container.Add(databaseServer39);
            var network39 = new ResourceLink();
            environment.Links.Add(network39);
            network39.Connects.Add(appServer39);
            network39.Connects.Add(databaseServer39);
            var appServer40 = new ResourceContainer() { Name = "AppServer40" };
            var databaseServer40 = new ResourceContainer() { Name = "DatabaseServer40" };
            environment.Container.Add(appServer40);
			environment.Container.Add(databaseServer40);
            var network40 = new ResourceLink();
            environment.Links.Add(network40);
            network40.Connects.Add(appServer40);
            network40.Connects.Add(databaseServer40);
            var appServer41 = new ResourceContainer() { Name = "AppServer41" };
            var databaseServer41 = new ResourceContainer() { Name = "DatabaseServer41" };
            environment.Container.Add(appServer41);
			environment.Container.Add(databaseServer41);
            var network41 = new ResourceLink();
            environment.Links.Add(network41);
            network41.Connects.Add(appServer41);
            network41.Connects.Add(databaseServer41);
            var appServer42 = new ResourceContainer() { Name = "AppServer42" };
            var databaseServer42 = new ResourceContainer() { Name = "DatabaseServer42" };
            environment.Container.Add(appServer42);
			environment.Container.Add(databaseServer42);
            var network42 = new ResourceLink();
            environment.Links.Add(network42);
            network42.Connects.Add(appServer42);
            network42.Connects.Add(databaseServer42);
            var appServer43 = new ResourceContainer() { Name = "AppServer43" };
            var databaseServer43 = new ResourceContainer() { Name = "DatabaseServer43" };
            environment.Container.Add(appServer43);
			environment.Container.Add(databaseServer43);
            var network43 = new ResourceLink();
            environment.Links.Add(network43);
            network43.Connects.Add(appServer43);
            network43.Connects.Add(databaseServer43);
            var appServer44 = new ResourceContainer() { Name = "AppServer44" };
            var databaseServer44 = new ResourceContainer() { Name = "DatabaseServer44" };
            environment.Container.Add(appServer44);
			environment.Container.Add(databaseServer44);
            var network44 = new ResourceLink();
            environment.Links.Add(network44);
            network44.Connects.Add(appServer44);
            network44.Connects.Add(databaseServer44);
            var appServer45 = new ResourceContainer() { Name = "AppServer45" };
            var databaseServer45 = new ResourceContainer() { Name = "DatabaseServer45" };
            environment.Container.Add(appServer45);
			environment.Container.Add(databaseServer45);
            var network45 = new ResourceLink();
            environment.Links.Add(network45);
            network45.Connects.Add(appServer45);
            network45.Connects.Add(databaseServer45);
            var appServer46 = new ResourceContainer() { Name = "AppServer46" };
            var databaseServer46 = new ResourceContainer() { Name = "DatabaseServer46" };
            environment.Container.Add(appServer46);
			environment.Container.Add(databaseServer46);
            var network46 = new ResourceLink();
            environment.Links.Add(network46);
            network46.Connects.Add(appServer46);
            network46.Connects.Add(databaseServer46);
            var appServer47 = new ResourceContainer() { Name = "AppServer47" };
            var databaseServer47 = new ResourceContainer() { Name = "DatabaseServer47" };
            environment.Container.Add(appServer47);
			environment.Container.Add(databaseServer47);
            var network47 = new ResourceLink();
            environment.Links.Add(network47);
            network47.Connects.Add(appServer47);
            network47.Connects.Add(databaseServer47);
            var appServer48 = new ResourceContainer() { Name = "AppServer48" };
            var databaseServer48 = new ResourceContainer() { Name = "DatabaseServer48" };
            environment.Container.Add(appServer48);
			environment.Container.Add(databaseServer48);
            var network48 = new ResourceLink();
            environment.Links.Add(network48);
            network48.Connects.Add(appServer48);
            network48.Connects.Add(databaseServer48);
            var appServer49 = new ResourceContainer() { Name = "AppServer49" };
            var databaseServer49 = new ResourceContainer() { Name = "DatabaseServer49" };
            environment.Container.Add(appServer49);
			environment.Container.Add(databaseServer49);
            var network49 = new ResourceLink();
            environment.Links.Add(network49);
            network49.Connects.Add(appServer49);
            network49.Connects.Add(databaseServer49);
            var appServer50 = new ResourceContainer() { Name = "AppServer50" };
            var databaseServer50 = new ResourceContainer() { Name = "DatabaseServer50" };
            environment.Container.Add(appServer50);
			environment.Container.Add(databaseServer50);
            var network50 = new ResourceLink();
            environment.Links.Add(network50);
            network50.Connects.Add(appServer50);
            network50.Connects.Add(databaseServer50);
            var appServer51 = new ResourceContainer() { Name = "AppServer51" };
            var databaseServer51 = new ResourceContainer() { Name = "DatabaseServer51" };
            environment.Container.Add(appServer51);
			environment.Container.Add(databaseServer51);
            var network51 = new ResourceLink();
            environment.Links.Add(network51);
            network51.Connects.Add(appServer51);
            network51.Connects.Add(databaseServer51);
            var appServer52 = new ResourceContainer() { Name = "AppServer52" };
            var databaseServer52 = new ResourceContainer() { Name = "DatabaseServer52" };
            environment.Container.Add(appServer52);
			environment.Container.Add(databaseServer52);
            var network52 = new ResourceLink();
            environment.Links.Add(network52);
            network52.Connects.Add(appServer52);
            network52.Connects.Add(databaseServer52);
            var appServer53 = new ResourceContainer() { Name = "AppServer53" };
            var databaseServer53 = new ResourceContainer() { Name = "DatabaseServer53" };
            environment.Container.Add(appServer53);
			environment.Container.Add(databaseServer53);
            var network53 = new ResourceLink();
            environment.Links.Add(network53);
            network53.Connects.Add(appServer53);
            network53.Connects.Add(databaseServer53);
            var appServer54 = new ResourceContainer() { Name = "AppServer54" };
            var databaseServer54 = new ResourceContainer() { Name = "DatabaseServer54" };
            environment.Container.Add(appServer54);
			environment.Container.Add(databaseServer54);
            var network54 = new ResourceLink();
            environment.Links.Add(network54);
            network54.Connects.Add(appServer54);
            network54.Connects.Add(databaseServer54);
            var appServer55 = new ResourceContainer() { Name = "AppServer55" };
            var databaseServer55 = new ResourceContainer() { Name = "DatabaseServer55" };
            environment.Container.Add(appServer55);
			environment.Container.Add(databaseServer55);
            var network55 = new ResourceLink();
            environment.Links.Add(network55);
            network55.Connects.Add(appServer55);
            network55.Connects.Add(databaseServer55);
            var appServer56 = new ResourceContainer() { Name = "AppServer56" };
            var databaseServer56 = new ResourceContainer() { Name = "DatabaseServer56" };
            environment.Container.Add(appServer56);
			environment.Container.Add(databaseServer56);
            var network56 = new ResourceLink();
            environment.Links.Add(network56);
            network56.Connects.Add(appServer56);
            network56.Connects.Add(databaseServer56);
            var appServer57 = new ResourceContainer() { Name = "AppServer57" };
            var databaseServer57 = new ResourceContainer() { Name = "DatabaseServer57" };
            environment.Container.Add(appServer57);
			environment.Container.Add(databaseServer57);
            var network57 = new ResourceLink();
            environment.Links.Add(network57);
            network57.Connects.Add(appServer57);
            network57.Connects.Add(databaseServer57);
            var appServer58 = new ResourceContainer() { Name = "AppServer58" };
            var databaseServer58 = new ResourceContainer() { Name = "DatabaseServer58" };
            environment.Container.Add(appServer58);
			environment.Container.Add(databaseServer58);
            var network58 = new ResourceLink();
            environment.Links.Add(network58);
            network58.Connects.Add(appServer58);
            network58.Connects.Add(databaseServer58);
            var appServer59 = new ResourceContainer() { Name = "AppServer59" };
            var databaseServer59 = new ResourceContainer() { Name = "DatabaseServer59" };
            environment.Container.Add(appServer59);
			environment.Container.Add(databaseServer59);
            var network59 = new ResourceLink();
            environment.Links.Add(network59);
            network59.Connects.Add(appServer59);
            network59.Connects.Add(databaseServer59);
            var appServer60 = new ResourceContainer() { Name = "AppServer60" };
            var databaseServer60 = new ResourceContainer() { Name = "DatabaseServer60" };
            environment.Container.Add(appServer60);
			environment.Container.Add(databaseServer60);
            var network60 = new ResourceLink();
            environment.Links.Add(network60);
            network60.Connects.Add(appServer60);
            network60.Connects.Add(databaseServer60);
            var appServer61 = new ResourceContainer() { Name = "AppServer61" };
            var databaseServer61 = new ResourceContainer() { Name = "DatabaseServer61" };
            environment.Container.Add(appServer61);
			environment.Container.Add(databaseServer61);
            var network61 = new ResourceLink();
            environment.Links.Add(network61);
            network61.Connects.Add(appServer61);
            network61.Connects.Add(databaseServer61);
            var appServer62 = new ResourceContainer() { Name = "AppServer62" };
            var databaseServer62 = new ResourceContainer() { Name = "DatabaseServer62" };
            environment.Container.Add(appServer62);
			environment.Container.Add(databaseServer62);
            var network62 = new ResourceLink();
            environment.Links.Add(network62);
            network62.Connects.Add(appServer62);
            network62.Connects.Add(databaseServer62);
            var appServer63 = new ResourceContainer() { Name = "AppServer63" };
            var databaseServer63 = new ResourceContainer() { Name = "DatabaseServer63" };
            environment.Container.Add(appServer63);
			environment.Container.Add(databaseServer63);
            var network63 = new ResourceLink();
            environment.Links.Add(network63);
            network63.Connects.Add(appServer63);
            network63.Connects.Add(databaseServer63);
            var appServer64 = new ResourceContainer() { Name = "AppServer64" };
            var databaseServer64 = new ResourceContainer() { Name = "DatabaseServer64" };
            environment.Container.Add(appServer64);
			environment.Container.Add(databaseServer64);
            var network64 = new ResourceLink();
            environment.Links.Add(network64);
            network64.Connects.Add(appServer64);
            network64.Connects.Add(databaseServer64);
            var mediaStore = new FZI.SoftwareEngineering.DeepModeling.AssemblyX64.MediaStoreX64()
            {
                AudioStore1 = appServer1,
                DBAdapter1 = appServer1,
                EncodingAdapter1 = appServer1,
                MySqlClient1 = databaseServer1,
                OggEncoder1 = appServer1,
                UserManagement1 = appServer1,
                WebForm1 = appServer1,
                AudioStore2 = appServer2,
                DBAdapter2 = appServer2,
                EncodingAdapter2 = appServer2,
                MySqlClient2 = databaseServer2,
                OggEncoder2 = appServer2,
                UserManagement2 = appServer2,
                WebForm2 = appServer2,
                AudioStore3 = appServer3,
                DBAdapter3 = appServer3,
                EncodingAdapter3 = appServer3,
                MySqlClient3 = databaseServer3,
                OggEncoder3 = appServer3,
                UserManagement3 = appServer3,
                WebForm3 = appServer3,
                AudioStore4 = appServer4,
                DBAdapter4 = appServer4,
                EncodingAdapter4 = appServer4,
                MySqlClient4 = databaseServer4,
                OggEncoder4 = appServer4,
                UserManagement4 = appServer4,
                WebForm4 = appServer4,
                AudioStore5 = appServer5,
                DBAdapter5 = appServer5,
                EncodingAdapter5 = appServer5,
                MySqlClient5 = databaseServer5,
                OggEncoder5 = appServer5,
                UserManagement5 = appServer5,
                WebForm5 = appServer5,
                AudioStore6 = appServer6,
                DBAdapter6 = appServer6,
                EncodingAdapter6 = appServer6,
                MySqlClient6 = databaseServer6,
                OggEncoder6 = appServer6,
                UserManagement6 = appServer6,
                WebForm6 = appServer6,
                AudioStore7 = appServer7,
                DBAdapter7 = appServer7,
                EncodingAdapter7 = appServer7,
                MySqlClient7 = databaseServer7,
                OggEncoder7 = appServer7,
                UserManagement7 = appServer7,
                WebForm7 = appServer7,
                AudioStore8 = appServer8,
                DBAdapter8 = appServer8,
                EncodingAdapter8 = appServer8,
                MySqlClient8 = databaseServer8,
                OggEncoder8 = appServer8,
                UserManagement8 = appServer8,
                WebForm8 = appServer8,
                AudioStore9 = appServer9,
                DBAdapter9 = appServer9,
                EncodingAdapter9 = appServer9,
                MySqlClient9 = databaseServer9,
                OggEncoder9 = appServer9,
                UserManagement9 = appServer9,
                WebForm9 = appServer9,
                AudioStore10 = appServer10,
                DBAdapter10 = appServer10,
                EncodingAdapter10 = appServer10,
                MySqlClient10 = databaseServer10,
                OggEncoder10 = appServer10,
                UserManagement10 = appServer10,
                WebForm10 = appServer10,
                AudioStore11 = appServer11,
                DBAdapter11 = appServer11,
                EncodingAdapter11 = appServer11,
                MySqlClient11 = databaseServer11,
                OggEncoder11 = appServer11,
                UserManagement11 = appServer11,
                WebForm11 = appServer11,
                AudioStore12 = appServer12,
                DBAdapter12 = appServer12,
                EncodingAdapter12 = appServer12,
                MySqlClient12 = databaseServer12,
                OggEncoder12 = appServer12,
                UserManagement12 = appServer12,
                WebForm12 = appServer12,
                AudioStore13 = appServer13,
                DBAdapter13 = appServer13,
                EncodingAdapter13 = appServer13,
                MySqlClient13 = databaseServer13,
                OggEncoder13 = appServer13,
                UserManagement13 = appServer13,
                WebForm13 = appServer13,
                AudioStore14 = appServer14,
                DBAdapter14 = appServer14,
                EncodingAdapter14 = appServer14,
                MySqlClient14 = databaseServer14,
                OggEncoder14 = appServer14,
                UserManagement14 = appServer14,
                WebForm14 = appServer14,
                AudioStore15 = appServer15,
                DBAdapter15 = appServer15,
                EncodingAdapter15 = appServer15,
                MySqlClient15 = databaseServer15,
                OggEncoder15 = appServer15,
                UserManagement15 = appServer15,
                WebForm15 = appServer15,
                AudioStore16 = appServer16,
                DBAdapter16 = appServer16,
                EncodingAdapter16 = appServer16,
                MySqlClient16 = databaseServer16,
                OggEncoder16 = appServer16,
                UserManagement16 = appServer16,
                WebForm16 = appServer16,
                AudioStore17 = appServer17,
                DBAdapter17 = appServer17,
                EncodingAdapter17 = appServer17,
                MySqlClient17 = databaseServer17,
                OggEncoder17 = appServer17,
                UserManagement17 = appServer17,
                WebForm17 = appServer17,
                AudioStore18 = appServer18,
                DBAdapter18 = appServer18,
                EncodingAdapter18 = appServer18,
                MySqlClient18 = databaseServer18,
                OggEncoder18 = appServer18,
                UserManagement18 = appServer18,
                WebForm18 = appServer18,
                AudioStore19 = appServer19,
                DBAdapter19 = appServer19,
                EncodingAdapter19 = appServer19,
                MySqlClient19 = databaseServer19,
                OggEncoder19 = appServer19,
                UserManagement19 = appServer19,
                WebForm19 = appServer19,
                AudioStore20 = appServer20,
                DBAdapter20 = appServer20,
                EncodingAdapter20 = appServer20,
                MySqlClient20 = databaseServer20,
                OggEncoder20 = appServer20,
                UserManagement20 = appServer20,
                WebForm20 = appServer20,
                AudioStore21 = appServer21,
                DBAdapter21 = appServer21,
                EncodingAdapter21 = appServer21,
                MySqlClient21 = databaseServer21,
                OggEncoder21 = appServer21,
                UserManagement21 = appServer21,
                WebForm21 = appServer21,
                AudioStore22 = appServer22,
                DBAdapter22 = appServer22,
                EncodingAdapter22 = appServer22,
                MySqlClient22 = databaseServer22,
                OggEncoder22 = appServer22,
                UserManagement22 = appServer22,
                WebForm22 = appServer22,
                AudioStore23 = appServer23,
                DBAdapter23 = appServer23,
                EncodingAdapter23 = appServer23,
                MySqlClient23 = databaseServer23,
                OggEncoder23 = appServer23,
                UserManagement23 = appServer23,
                WebForm23 = appServer23,
                AudioStore24 = appServer24,
                DBAdapter24 = appServer24,
                EncodingAdapter24 = appServer24,
                MySqlClient24 = databaseServer24,
                OggEncoder24 = appServer24,
                UserManagement24 = appServer24,
                WebForm24 = appServer24,
                AudioStore25 = appServer25,
                DBAdapter25 = appServer25,
                EncodingAdapter25 = appServer25,
                MySqlClient25 = databaseServer25,
                OggEncoder25 = appServer25,
                UserManagement25 = appServer25,
                WebForm25 = appServer25,
                AudioStore26 = appServer26,
                DBAdapter26 = appServer26,
                EncodingAdapter26 = appServer26,
                MySqlClient26 = databaseServer26,
                OggEncoder26 = appServer26,
                UserManagement26 = appServer26,
                WebForm26 = appServer26,
                AudioStore27 = appServer27,
                DBAdapter27 = appServer27,
                EncodingAdapter27 = appServer27,
                MySqlClient27 = databaseServer27,
                OggEncoder27 = appServer27,
                UserManagement27 = appServer27,
                WebForm27 = appServer27,
                AudioStore28 = appServer28,
                DBAdapter28 = appServer28,
                EncodingAdapter28 = appServer28,
                MySqlClient28 = databaseServer28,
                OggEncoder28 = appServer28,
                UserManagement28 = appServer28,
                WebForm28 = appServer28,
                AudioStore29 = appServer29,
                DBAdapter29 = appServer29,
                EncodingAdapter29 = appServer29,
                MySqlClient29 = databaseServer29,
                OggEncoder29 = appServer29,
                UserManagement29 = appServer29,
                WebForm29 = appServer29,
                AudioStore30 = appServer30,
                DBAdapter30 = appServer30,
                EncodingAdapter30 = appServer30,
                MySqlClient30 = databaseServer30,
                OggEncoder30 = appServer30,
                UserManagement30 = appServer30,
                WebForm30 = appServer30,
                AudioStore31 = appServer31,
                DBAdapter31 = appServer31,
                EncodingAdapter31 = appServer31,
                MySqlClient31 = databaseServer31,
                OggEncoder31 = appServer31,
                UserManagement31 = appServer31,
                WebForm31 = appServer31,
                AudioStore32 = appServer32,
                DBAdapter32 = appServer32,
                EncodingAdapter32 = appServer32,
                MySqlClient32 = databaseServer32,
                OggEncoder32 = appServer32,
                UserManagement32 = appServer32,
                WebForm32 = appServer32,
                AudioStore33 = appServer33,
                DBAdapter33 = appServer33,
                EncodingAdapter33 = appServer33,
                MySqlClient33 = databaseServer33,
                OggEncoder33 = appServer33,
                UserManagement33 = appServer33,
                WebForm33 = appServer33,
                AudioStore34 = appServer34,
                DBAdapter34 = appServer34,
                EncodingAdapter34 = appServer34,
                MySqlClient34 = databaseServer34,
                OggEncoder34 = appServer34,
                UserManagement34 = appServer34,
                WebForm34 = appServer34,
                AudioStore35 = appServer35,
                DBAdapter35 = appServer35,
                EncodingAdapter35 = appServer35,
                MySqlClient35 = databaseServer35,
                OggEncoder35 = appServer35,
                UserManagement35 = appServer35,
                WebForm35 = appServer35,
                AudioStore36 = appServer36,
                DBAdapter36 = appServer36,
                EncodingAdapter36 = appServer36,
                MySqlClient36 = databaseServer36,
                OggEncoder36 = appServer36,
                UserManagement36 = appServer36,
                WebForm36 = appServer36,
                AudioStore37 = appServer37,
                DBAdapter37 = appServer37,
                EncodingAdapter37 = appServer37,
                MySqlClient37 = databaseServer37,
                OggEncoder37 = appServer37,
                UserManagement37 = appServer37,
                WebForm37 = appServer37,
                AudioStore38 = appServer38,
                DBAdapter38 = appServer38,
                EncodingAdapter38 = appServer38,
                MySqlClient38 = databaseServer38,
                OggEncoder38 = appServer38,
                UserManagement38 = appServer38,
                WebForm38 = appServer38,
                AudioStore39 = appServer39,
                DBAdapter39 = appServer39,
                EncodingAdapter39 = appServer39,
                MySqlClient39 = databaseServer39,
                OggEncoder39 = appServer39,
                UserManagement39 = appServer39,
                WebForm39 = appServer39,
                AudioStore40 = appServer40,
                DBAdapter40 = appServer40,
                EncodingAdapter40 = appServer40,
                MySqlClient40 = databaseServer40,
                OggEncoder40 = appServer40,
                UserManagement40 = appServer40,
                WebForm40 = appServer40,
                AudioStore41 = appServer41,
                DBAdapter41 = appServer41,
                EncodingAdapter41 = appServer41,
                MySqlClient41 = databaseServer41,
                OggEncoder41 = appServer41,
                UserManagement41 = appServer41,
                WebForm41 = appServer41,
                AudioStore42 = appServer42,
                DBAdapter42 = appServer42,
                EncodingAdapter42 = appServer42,
                MySqlClient42 = databaseServer42,
                OggEncoder42 = appServer42,
                UserManagement42 = appServer42,
                WebForm42 = appServer42,
                AudioStore43 = appServer43,
                DBAdapter43 = appServer43,
                EncodingAdapter43 = appServer43,
                MySqlClient43 = databaseServer43,
                OggEncoder43 = appServer43,
                UserManagement43 = appServer43,
                WebForm43 = appServer43,
                AudioStore44 = appServer44,
                DBAdapter44 = appServer44,
                EncodingAdapter44 = appServer44,
                MySqlClient44 = databaseServer44,
                OggEncoder44 = appServer44,
                UserManagement44 = appServer44,
                WebForm44 = appServer44,
                AudioStore45 = appServer45,
                DBAdapter45 = appServer45,
                EncodingAdapter45 = appServer45,
                MySqlClient45 = databaseServer45,
                OggEncoder45 = appServer45,
                UserManagement45 = appServer45,
                WebForm45 = appServer45,
                AudioStore46 = appServer46,
                DBAdapter46 = appServer46,
                EncodingAdapter46 = appServer46,
                MySqlClient46 = databaseServer46,
                OggEncoder46 = appServer46,
                UserManagement46 = appServer46,
                WebForm46 = appServer46,
                AudioStore47 = appServer47,
                DBAdapter47 = appServer47,
                EncodingAdapter47 = appServer47,
                MySqlClient47 = databaseServer47,
                OggEncoder47 = appServer47,
                UserManagement47 = appServer47,
                WebForm47 = appServer47,
                AudioStore48 = appServer48,
                DBAdapter48 = appServer48,
                EncodingAdapter48 = appServer48,
                MySqlClient48 = databaseServer48,
                OggEncoder48 = appServer48,
                UserManagement48 = appServer48,
                WebForm48 = appServer48,
                AudioStore49 = appServer49,
                DBAdapter49 = appServer49,
                EncodingAdapter49 = appServer49,
                MySqlClient49 = databaseServer49,
                OggEncoder49 = appServer49,
                UserManagement49 = appServer49,
                WebForm49 = appServer49,
                AudioStore50 = appServer50,
                DBAdapter50 = appServer50,
                EncodingAdapter50 = appServer50,
                MySqlClient50 = databaseServer50,
                OggEncoder50 = appServer50,
                UserManagement50 = appServer50,
                WebForm50 = appServer50,
                AudioStore51 = appServer51,
                DBAdapter51 = appServer51,
                EncodingAdapter51 = appServer51,
                MySqlClient51 = databaseServer51,
                OggEncoder51 = appServer51,
                UserManagement51 = appServer51,
                WebForm51 = appServer51,
                AudioStore52 = appServer52,
                DBAdapter52 = appServer52,
                EncodingAdapter52 = appServer52,
                MySqlClient52 = databaseServer52,
                OggEncoder52 = appServer52,
                UserManagement52 = appServer52,
                WebForm52 = appServer52,
                AudioStore53 = appServer53,
                DBAdapter53 = appServer53,
                EncodingAdapter53 = appServer53,
                MySqlClient53 = databaseServer53,
                OggEncoder53 = appServer53,
                UserManagement53 = appServer53,
                WebForm53 = appServer53,
                AudioStore54 = appServer54,
                DBAdapter54 = appServer54,
                EncodingAdapter54 = appServer54,
                MySqlClient54 = databaseServer54,
                OggEncoder54 = appServer54,
                UserManagement54 = appServer54,
                WebForm54 = appServer54,
                AudioStore55 = appServer55,
                DBAdapter55 = appServer55,
                EncodingAdapter55 = appServer55,
                MySqlClient55 = databaseServer55,
                OggEncoder55 = appServer55,
                UserManagement55 = appServer55,
                WebForm55 = appServer55,
                AudioStore56 = appServer56,
                DBAdapter56 = appServer56,
                EncodingAdapter56 = appServer56,
                MySqlClient56 = databaseServer56,
                OggEncoder56 = appServer56,
                UserManagement56 = appServer56,
                WebForm56 = appServer56,
                AudioStore57 = appServer57,
                DBAdapter57 = appServer57,
                EncodingAdapter57 = appServer57,
                MySqlClient57 = databaseServer57,
                OggEncoder57 = appServer57,
                UserManagement57 = appServer57,
                WebForm57 = appServer57,
                AudioStore58 = appServer58,
                DBAdapter58 = appServer58,
                EncodingAdapter58 = appServer58,
                MySqlClient58 = databaseServer58,
                OggEncoder58 = appServer58,
                UserManagement58 = appServer58,
                WebForm58 = appServer58,
                AudioStore59 = appServer59,
                DBAdapter59 = appServer59,
                EncodingAdapter59 = appServer59,
                MySqlClient59 = databaseServer59,
                OggEncoder59 = appServer59,
                UserManagement59 = appServer59,
                WebForm59 = appServer59,
                AudioStore60 = appServer60,
                DBAdapter60 = appServer60,
                EncodingAdapter60 = appServer60,
                MySqlClient60 = databaseServer60,
                OggEncoder60 = appServer60,
                UserManagement60 = appServer60,
                WebForm60 = appServer60,
                AudioStore61 = appServer61,
                DBAdapter61 = appServer61,
                EncodingAdapter61 = appServer61,
                MySqlClient61 = databaseServer61,
                OggEncoder61 = appServer61,
                UserManagement61 = appServer61,
                WebForm61 = appServer61,
                AudioStore62 = appServer62,
                DBAdapter62 = appServer62,
                EncodingAdapter62 = appServer62,
                MySqlClient62 = databaseServer62,
                OggEncoder62 = appServer62,
                UserManagement62 = appServer62,
                WebForm62 = appServer62,
                AudioStore63 = appServer63,
                DBAdapter63 = appServer63,
                EncodingAdapter63 = appServer63,
                MySqlClient63 = databaseServer63,
                OggEncoder63 = appServer63,
                UserManagement63 = appServer63,
                WebForm63 = appServer63,
                AudioStore64 = appServer64,
                DBAdapter64 = appServer64,
                EncodingAdapter64 = appServer64,
                MySqlClient64 = databaseServer64,
                OggEncoder64 = appServer64,
                UserManagement64 = appServer64,
                WebForm64 = appServer64,
                Environment = environment
            };
			manipulations = new Action[192];
			manipulations[0] = () => mediaStore.MySqlClient1 = isolatedContainer;
			manipulations[1] = () => mediaStore.MySqlClient2 = isolatedContainer;
			manipulations[2] = () => mediaStore.MySqlClient3 = isolatedContainer;
			manipulations[3] = () => mediaStore.MySqlClient4 = isolatedContainer;
			manipulations[4] = () => mediaStore.MySqlClient5 = isolatedContainer;
			manipulations[5] = () => mediaStore.MySqlClient6 = isolatedContainer;
			manipulations[6] = () => mediaStore.MySqlClient7 = isolatedContainer;
			manipulations[7] = () => mediaStore.MySqlClient8 = isolatedContainer;
			manipulations[8] = () => mediaStore.MySqlClient9 = isolatedContainer;
			manipulations[9] = () => mediaStore.MySqlClient10 = isolatedContainer;
			manipulations[10] = () => mediaStore.MySqlClient11 = isolatedContainer;
			manipulations[11] = () => mediaStore.MySqlClient12 = isolatedContainer;
			manipulations[12] = () => mediaStore.MySqlClient13 = isolatedContainer;
			manipulations[13] = () => mediaStore.MySqlClient14 = isolatedContainer;
			manipulations[14] = () => mediaStore.MySqlClient15 = isolatedContainer;
			manipulations[15] = () => mediaStore.MySqlClient16 = isolatedContainer;
			manipulations[16] = () => mediaStore.MySqlClient17 = isolatedContainer;
			manipulations[17] = () => mediaStore.MySqlClient18 = isolatedContainer;
			manipulations[18] = () => mediaStore.MySqlClient19 = isolatedContainer;
			manipulations[19] = () => mediaStore.MySqlClient20 = isolatedContainer;
			manipulations[20] = () => mediaStore.MySqlClient21 = isolatedContainer;
			manipulations[21] = () => mediaStore.MySqlClient22 = isolatedContainer;
			manipulations[22] = () => mediaStore.MySqlClient23 = isolatedContainer;
			manipulations[23] = () => mediaStore.MySqlClient24 = isolatedContainer;
			manipulations[24] = () => mediaStore.MySqlClient25 = isolatedContainer;
			manipulations[25] = () => mediaStore.MySqlClient26 = isolatedContainer;
			manipulations[26] = () => mediaStore.MySqlClient27 = isolatedContainer;
			manipulations[27] = () => mediaStore.MySqlClient28 = isolatedContainer;
			manipulations[28] = () => mediaStore.MySqlClient29 = isolatedContainer;
			manipulations[29] = () => mediaStore.MySqlClient30 = isolatedContainer;
			manipulations[30] = () => mediaStore.MySqlClient31 = isolatedContainer;
			manipulations[31] = () => mediaStore.MySqlClient32 = isolatedContainer;
			manipulations[32] = () => mediaStore.MySqlClient33 = isolatedContainer;
			manipulations[33] = () => mediaStore.MySqlClient34 = isolatedContainer;
			manipulations[34] = () => mediaStore.MySqlClient35 = isolatedContainer;
			manipulations[35] = () => mediaStore.MySqlClient36 = isolatedContainer;
			manipulations[36] = () => mediaStore.MySqlClient37 = isolatedContainer;
			manipulations[37] = () => mediaStore.MySqlClient38 = isolatedContainer;
			manipulations[38] = () => mediaStore.MySqlClient39 = isolatedContainer;
			manipulations[39] = () => mediaStore.MySqlClient40 = isolatedContainer;
			manipulations[40] = () => mediaStore.MySqlClient41 = isolatedContainer;
			manipulations[41] = () => mediaStore.MySqlClient42 = isolatedContainer;
			manipulations[42] = () => mediaStore.MySqlClient43 = isolatedContainer;
			manipulations[43] = () => mediaStore.MySqlClient44 = isolatedContainer;
			manipulations[44] = () => mediaStore.MySqlClient45 = isolatedContainer;
			manipulations[45] = () => mediaStore.MySqlClient46 = isolatedContainer;
			manipulations[46] = () => mediaStore.MySqlClient47 = isolatedContainer;
			manipulations[47] = () => mediaStore.MySqlClient48 = isolatedContainer;
			manipulations[48] = () => mediaStore.MySqlClient49 = isolatedContainer;
			manipulations[49] = () => mediaStore.MySqlClient50 = isolatedContainer;
			manipulations[50] = () => mediaStore.MySqlClient51 = isolatedContainer;
			manipulations[51] = () => mediaStore.MySqlClient52 = isolatedContainer;
			manipulations[52] = () => mediaStore.MySqlClient53 = isolatedContainer;
			manipulations[53] = () => mediaStore.MySqlClient54 = isolatedContainer;
			manipulations[54] = () => mediaStore.MySqlClient55 = isolatedContainer;
			manipulations[55] = () => mediaStore.MySqlClient56 = isolatedContainer;
			manipulations[56] = () => mediaStore.MySqlClient57 = isolatedContainer;
			manipulations[57] = () => mediaStore.MySqlClient58 = isolatedContainer;
			manipulations[58] = () => mediaStore.MySqlClient59 = isolatedContainer;
			manipulations[59] = () => mediaStore.MySqlClient60 = isolatedContainer;
			manipulations[60] = () => mediaStore.MySqlClient61 = isolatedContainer;
			manipulations[61] = () => mediaStore.MySqlClient62 = isolatedContainer;
			manipulations[62] = () => mediaStore.MySqlClient63 = isolatedContainer;
			manipulations[63] = () => mediaStore.MySqlClient64 = isolatedContainer;
			manipulations[64] = () => mediaStore.MySqlClient1 = databaseServer1;
			manipulations[65] = () => mediaStore.MySqlClient2 = databaseServer2;
			manipulations[66] = () => mediaStore.MySqlClient3 = databaseServer3;
			manipulations[67] = () => mediaStore.MySqlClient4 = databaseServer4;
			manipulations[68] = () => mediaStore.MySqlClient5 = databaseServer5;
			manipulations[69] = () => mediaStore.MySqlClient6 = databaseServer6;
			manipulations[70] = () => mediaStore.MySqlClient7 = databaseServer7;
			manipulations[71] = () => mediaStore.MySqlClient8 = databaseServer8;
			manipulations[72] = () => mediaStore.MySqlClient9 = databaseServer9;
			manipulations[73] = () => mediaStore.MySqlClient10 = databaseServer10;
			manipulations[74] = () => mediaStore.MySqlClient11 = databaseServer11;
			manipulations[75] = () => mediaStore.MySqlClient12 = databaseServer12;
			manipulations[76] = () => mediaStore.MySqlClient13 = databaseServer13;
			manipulations[77] = () => mediaStore.MySqlClient14 = databaseServer14;
			manipulations[78] = () => mediaStore.MySqlClient15 = databaseServer15;
			manipulations[79] = () => mediaStore.MySqlClient16 = databaseServer16;
			manipulations[80] = () => mediaStore.MySqlClient17 = databaseServer17;
			manipulations[81] = () => mediaStore.MySqlClient18 = databaseServer18;
			manipulations[82] = () => mediaStore.MySqlClient19 = databaseServer19;
			manipulations[83] = () => mediaStore.MySqlClient20 = databaseServer20;
			manipulations[84] = () => mediaStore.MySqlClient21 = databaseServer21;
			manipulations[85] = () => mediaStore.MySqlClient22 = databaseServer22;
			manipulations[86] = () => mediaStore.MySqlClient23 = databaseServer23;
			manipulations[87] = () => mediaStore.MySqlClient24 = databaseServer24;
			manipulations[88] = () => mediaStore.MySqlClient25 = databaseServer25;
			manipulations[89] = () => mediaStore.MySqlClient26 = databaseServer26;
			manipulations[90] = () => mediaStore.MySqlClient27 = databaseServer27;
			manipulations[91] = () => mediaStore.MySqlClient28 = databaseServer28;
			manipulations[92] = () => mediaStore.MySqlClient29 = databaseServer29;
			manipulations[93] = () => mediaStore.MySqlClient30 = databaseServer30;
			manipulations[94] = () => mediaStore.MySqlClient31 = databaseServer31;
			manipulations[95] = () => mediaStore.MySqlClient32 = databaseServer32;
			manipulations[96] = () => mediaStore.MySqlClient33 = databaseServer33;
			manipulations[97] = () => mediaStore.MySqlClient34 = databaseServer34;
			manipulations[98] = () => mediaStore.MySqlClient35 = databaseServer35;
			manipulations[99] = () => mediaStore.MySqlClient36 = databaseServer36;
			manipulations[100] = () => mediaStore.MySqlClient37 = databaseServer37;
			manipulations[101] = () => mediaStore.MySqlClient38 = databaseServer38;
			manipulations[102] = () => mediaStore.MySqlClient39 = databaseServer39;
			manipulations[103] = () => mediaStore.MySqlClient40 = databaseServer40;
			manipulations[104] = () => mediaStore.MySqlClient41 = databaseServer41;
			manipulations[105] = () => mediaStore.MySqlClient42 = databaseServer42;
			manipulations[106] = () => mediaStore.MySqlClient43 = databaseServer43;
			manipulations[107] = () => mediaStore.MySqlClient44 = databaseServer44;
			manipulations[108] = () => mediaStore.MySqlClient45 = databaseServer45;
			manipulations[109] = () => mediaStore.MySqlClient46 = databaseServer46;
			manipulations[110] = () => mediaStore.MySqlClient47 = databaseServer47;
			manipulations[111] = () => mediaStore.MySqlClient48 = databaseServer48;
			manipulations[112] = () => mediaStore.MySqlClient49 = databaseServer49;
			manipulations[113] = () => mediaStore.MySqlClient50 = databaseServer50;
			manipulations[114] = () => mediaStore.MySqlClient51 = databaseServer51;
			manipulations[115] = () => mediaStore.MySqlClient52 = databaseServer52;
			manipulations[116] = () => mediaStore.MySqlClient53 = databaseServer53;
			manipulations[117] = () => mediaStore.MySqlClient54 = databaseServer54;
			manipulations[118] = () => mediaStore.MySqlClient55 = databaseServer55;
			manipulations[119] = () => mediaStore.MySqlClient56 = databaseServer56;
			manipulations[120] = () => mediaStore.MySqlClient57 = databaseServer57;
			manipulations[121] = () => mediaStore.MySqlClient58 = databaseServer58;
			manipulations[122] = () => mediaStore.MySqlClient59 = databaseServer59;
			manipulations[123] = () => mediaStore.MySqlClient60 = databaseServer60;
			manipulations[124] = () => mediaStore.MySqlClient61 = databaseServer61;
			manipulations[125] = () => mediaStore.MySqlClient62 = databaseServer62;
			manipulations[126] = () => mediaStore.MySqlClient63 = databaseServer63;
			manipulations[127] = () => mediaStore.MySqlClient64 = databaseServer64;
			manipulations[128] = () => network1.Connects.Remove(databaseServer1);
			manipulations[129] = () => network2.Connects.Remove(databaseServer2);
			manipulations[130] = () => network3.Connects.Remove(databaseServer3);
			manipulations[131] = () => network4.Connects.Remove(databaseServer4);
			manipulations[132] = () => network5.Connects.Remove(databaseServer5);
			manipulations[133] = () => network6.Connects.Remove(databaseServer6);
			manipulations[134] = () => network7.Connects.Remove(databaseServer7);
			manipulations[135] = () => network8.Connects.Remove(databaseServer8);
			manipulations[136] = () => network9.Connects.Remove(databaseServer9);
			manipulations[137] = () => network10.Connects.Remove(databaseServer10);
			manipulations[138] = () => network11.Connects.Remove(databaseServer11);
			manipulations[139] = () => network12.Connects.Remove(databaseServer12);
			manipulations[140] = () => network13.Connects.Remove(databaseServer13);
			manipulations[141] = () => network14.Connects.Remove(databaseServer14);
			manipulations[142] = () => network15.Connects.Remove(databaseServer15);
			manipulations[143] = () => network16.Connects.Remove(databaseServer16);
			manipulations[144] = () => network17.Connects.Remove(databaseServer17);
			manipulations[145] = () => network18.Connects.Remove(databaseServer18);
			manipulations[146] = () => network19.Connects.Remove(databaseServer19);
			manipulations[147] = () => network20.Connects.Remove(databaseServer20);
			manipulations[148] = () => network21.Connects.Remove(databaseServer21);
			manipulations[149] = () => network22.Connects.Remove(databaseServer22);
			manipulations[150] = () => network23.Connects.Remove(databaseServer23);
			manipulations[151] = () => network24.Connects.Remove(databaseServer24);
			manipulations[152] = () => network25.Connects.Remove(databaseServer25);
			manipulations[153] = () => network26.Connects.Remove(databaseServer26);
			manipulations[154] = () => network27.Connects.Remove(databaseServer27);
			manipulations[155] = () => network28.Connects.Remove(databaseServer28);
			manipulations[156] = () => network29.Connects.Remove(databaseServer29);
			manipulations[157] = () => network30.Connects.Remove(databaseServer30);
			manipulations[158] = () => network31.Connects.Remove(databaseServer31);
			manipulations[159] = () => network32.Connects.Remove(databaseServer32);
			manipulations[160] = () => network33.Connects.Remove(databaseServer33);
			manipulations[161] = () => network34.Connects.Remove(databaseServer34);
			manipulations[162] = () => network35.Connects.Remove(databaseServer35);
			manipulations[163] = () => network36.Connects.Remove(databaseServer36);
			manipulations[164] = () => network37.Connects.Remove(databaseServer37);
			manipulations[165] = () => network38.Connects.Remove(databaseServer38);
			manipulations[166] = () => network39.Connects.Remove(databaseServer39);
			manipulations[167] = () => network40.Connects.Remove(databaseServer40);
			manipulations[168] = () => network41.Connects.Remove(databaseServer41);
			manipulations[169] = () => network42.Connects.Remove(databaseServer42);
			manipulations[170] = () => network43.Connects.Remove(databaseServer43);
			manipulations[171] = () => network44.Connects.Remove(databaseServer44);
			manipulations[172] = () => network45.Connects.Remove(databaseServer45);
			manipulations[173] = () => network46.Connects.Remove(databaseServer46);
			manipulations[174] = () => network47.Connects.Remove(databaseServer47);
			manipulations[175] = () => network48.Connects.Remove(databaseServer48);
			manipulations[176] = () => network49.Connects.Remove(databaseServer49);
			manipulations[177] = () => network50.Connects.Remove(databaseServer50);
			manipulations[178] = () => network51.Connects.Remove(databaseServer51);
			manipulations[179] = () => network52.Connects.Remove(databaseServer52);
			manipulations[180] = () => network53.Connects.Remove(databaseServer53);
			manipulations[181] = () => network54.Connects.Remove(databaseServer54);
			manipulations[182] = () => network55.Connects.Remove(databaseServer55);
			manipulations[183] = () => network56.Connects.Remove(databaseServer56);
			manipulations[184] = () => network57.Connects.Remove(databaseServer57);
			manipulations[185] = () => network58.Connects.Remove(databaseServer58);
			manipulations[186] = () => network59.Connects.Remove(databaseServer59);
			manipulations[187] = () => network60.Connects.Remove(databaseServer60);
			manipulations[188] = () => network61.Connects.Remove(databaseServer61);
			manipulations[189] = () => network62.Connects.Remove(databaseServer62);
			manipulations[190] = () => network63.Connects.Remove(databaseServer63);
			manipulations[191] = () => network64.Connects.Remove(databaseServer64);
			return mediaStore;
        }
    }
}
