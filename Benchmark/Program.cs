using FZI.SoftwareEngineering.DeepModeling;
using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Deployment;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using NMF.Expressions;
using NMF.Expressions.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FZI.SoftwareEngineering.DeepModeling.DeepADL;
using System.IO;

namespace FZI.SoftwareEngineering.DeepModeling.Benchmark
{
    delegate ISystemAllocation DeepModelCreator(out Action[] manipulations);
    class Program
    {
        static void Main(string[] args)
        {
            MeasureAll();
            File.WriteAllText("results.csv", "Solution;Size;Mode;Phase;Actual;Expected;Time\n");
            for (int i = 0; i < 10; i++)
            {
                MeasureAll();
            }
        }

        private static void MeasureAll()
        {
            for (int size = 1; size <= 64; size *= 2)
            {
                MeasureTwoLevel(size, TwoLevelBatch, false);
                MeasureTwoLevel(size, TwoLevelIncremental, true);
            }

            MeasureDeep(DeepMediaStoreGenerator.CreateMediaStoreX1Allocation, 1);
            MeasureDeep(DeepMediaStoreGenerator.CreateMediaStoreX2Allocation, 2);
            MeasureDeep(DeepMediaStoreGenerator.CreateMediaStoreX4Allocation, 4);
            MeasureDeep(DeepMediaStoreGenerator.CreateMediaStoreX8Allocation, 8);
            MeasureDeep(DeepMediaStoreGenerator.CreateMediaStoreX16Allocation, 16);
            MeasureDeep(DeepMediaStoreGenerator.CreateMediaStoreX32Allocation, 32);
            MeasureDeep(DeepMediaStoreGenerator.CreateMediaStoreX64Allocation, 64);
        }

        private static void MeasureDeep(DeepModelCreator generator, int size)
        {
            //MeasureDeep(generator, size, DeepBatchEnumerable, "DeepEnumerable", false);
            //MeasureDeep(generator, size, DeepBatchAltEnumerable, "DeepAltEnumerable", false);
            MeasureDeep(generator, size, DeepBatch, "Deep", false);
            MeasureDeep(generator, size, DeepBatchAlt, "DeepAlt", false);
            MeasureDeep(generator, size, DeepIncremental, "Deep", true);
            MeasureDeep(generator, size, DeepIncrementalAlt, "DeepAlt", true);
        }

        private static void MeasureTwoLevel(int size, Func<IAllocation, Func<int>> mode, bool incremental)
        {
            var root = MediaStoreGenerator.CreateMediaStore(size, out Action[] manipulations);
            Func<Func<int>> query = () => mode(root.Allocation);
            MeasureSize(size, query, manipulations, "TwoLevel", incremental);
        }

        private static void MeasureDeep(DeepModelCreator generator, int size, Func<ISystemAllocation, Func<int>> mode, string tool, bool incremental)
        {
            var allocation = generator(out Action[] manipulations);
            Func<Func<int>> query = () => mode(allocation);
            MeasureSize(size, query, manipulations, tool, incremental);
        }

        private static Func<int> TwoLevelBatch(IAllocation allocation)
        {
            var query = TwoLevelContainerAnalysis.GetFaultyContainers(allocation);
            return () => query.Count();
        }

        private static Func<int> TwoLevelIncremental(IAllocation allocation)
        {
            var query = TwoLevelContainerAnalysis.GetFaultyContainers(allocation);
            var queryInc = Observable.Expression(() => query.Count());
            return () => queryInc.Value;
        }

        private static Func<int> DeepBatchEnumerable(ISystemAllocation allocation)
        {
            var query = DeepContainerAnalysis.GetFaultyContainersEnumerable(allocation);
            return () => query.Count();
        }

        private static Func<int> DeepBatch(ISystemAllocation allocation)
        {
            var query = DeepContainerAnalysis.GetFaultyContainers(allocation);
            return () => query.Count();
        }

        private static Func<int> DeepBatchAlt(ISystemAllocation allocation)
        {
            var query = DeepContainerAnalysis.GetFaultyContainers2(allocation);
            return () => query.Count();
        }

        private static Func<int> DeepBatchAltEnumerable(ISystemAllocation allocation)
        {
            var query = DeepContainerAnalysis.GetFaultyContainers2Enumerable(allocation);
            return () => query.Count();
        }

        private static Func<int> DeepIncremental(ISystemAllocation allocation)
        {
            var query = DeepContainerAnalysis.GetFaultyContainers(allocation);
            var queryInc = Observable.Expression(() => query.Count());
            return () => queryInc.Value;
        }

        private static Func<int> DeepIncrementalAlt(ISystemAllocation allocation)
        {
            var query = DeepContainerAnalysis.GetFaultyContainers2(allocation);
            var queryInc = Observable.Expression(() => query.Count());
            return () => queryInc.Value;
        }

        private static void MeasureSize(int size, Func<Func<int>> solution, Action[] manipulations, string tool, bool incremental)
        {
            var mode = incremental ? "incremental" : "batch";
            Console.WriteLine($"Now measuring {tool} in {mode} mode for size {size}");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var count = solution();
            var initial = count();
            stopwatch.Stop();
            Emit(size, initial, 0, stopwatch.Elapsed, tool, incremental, true);
            for (int i = 0; i < size; i++)
            {
                stopwatch.Restart();
                manipulations[i]();
                var update = count();
                stopwatch.Stop();
                Emit(size, update, 3 * (i + 1), stopwatch.Elapsed, tool, incremental, false);
            }
            for (int i = 0; i < size; i++)
            {
                stopwatch.Restart();
                manipulations[size + i]();
                var update = count();
                stopwatch.Stop();
                Emit(size, update, 3 * (size - i - 1), stopwatch.Elapsed, tool, incremental, false);
            }
            for (int i = 0; i < size; i++)
            {
                stopwatch.Restart();
                manipulations[2*size + i]();
                var update = count();
                stopwatch.Stop();
                Emit(size, update, 3 * (i + 1), stopwatch.Elapsed, tool, incremental, false);
            }
        }

        private static void Emit(int size, int actual, int expected, TimeSpan time, string solution, bool incremental, bool isInitial)
        {
            var mode = isInitial ? "Initial" : "Update";
            var inc = incremental ? "Incremental" : "Batch";
            File.AppendAllText("results.csv", $"{solution};{size};{inc};{mode};{actual};{expected};{time.Ticks}\n");
        }
    }
}
