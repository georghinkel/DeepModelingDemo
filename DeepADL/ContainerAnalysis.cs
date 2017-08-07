using NMF.Expressions;
using NMF.Expressions.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FZI.SoftwareEngineering.DeepModeling.DeepADL
{
    public class DeepContainerAnalysis
    {
        public static IEnumerableExpression<Tuple<IAssemblyContext, IRequiredInterface>> GetFaultyContainers(ISystemAllocation allocation)
        {
            return from ass in allocation.GetSystemArchitecture().AssemblyContexts
                   let container = allocation.GetAssemblyContextsValue(ass)
                   from req in ass.GetComponentType().RequiredInterfaces
                   where allocation.GetAssemblyContextsValue(ass.GetRequiredInterfacesValue(req)) != container
                      && !allocation.Environment.Links.Any(
                          l => l.Connects.Contains(container) &&
                               l.Connects.Contains(allocation.GetAssemblyContextsValue(ass.GetRequiredInterfacesValue(req))))                                
                   select Tuple.Create(ass, req);
        }
        public static IEnumerable<Tuple<IAssemblyContext, IRequiredInterface>> GetFaultyContainersEnumerable(ISystemAllocation allocation)
        {
            return from ass in allocation.GetSystemArchitecture().AssemblyContexts.AsEnumerable()
                   let container = allocation.GetAssemblyContextsValue(ass)
                   from req in ass.GetComponentType().RequiredInterfaces
                   where allocation.GetAssemblyContextsValue(ass.GetRequiredInterfacesValue(req)) != container
                      && !allocation.Environment.Links.Any(
                          l => l.Connects.Contains(container) &&
                               l.Connects.Contains(allocation.GetAssemblyContextsValue(ass.GetRequiredInterfacesValue(req))))
                   select Tuple.Create(ass, req);
        }

        public static IEnumerableExpression<Tuple<IAssemblyContext, IAssemblyContext>> GetFaultyContainers2(ISystemAllocation allocation)
        {
            return from ass in allocation.GetSystemArchitecture().AssemblyContexts
                   let container = allocation.GetAssemblyContextsValue(ass)
                   from req in ass.ReferencedElements.OfType<IAssemblyContext>()
                   where allocation.GetAssemblyContextsValue(req) != container
                      && !allocation.Environment.Links.Any(
                          l => l.Connects.Contains(container) &&
                               l.Connects.Contains(allocation.GetAssemblyContextsValue(req)))
                   select Tuple.Create(ass, req);
        }

        public static IEnumerable<Tuple<IAssemblyContext, IAssemblyContext>> GetFaultyContainers2Enumerable(ISystemAllocation allocation)
        {
            return from ass in allocation.GetSystemArchitecture().AssemblyContexts.AsEnumerable()
                   let container = allocation.GetAssemblyContextsValue(ass)
                   from req in ass.ReferencedElements.OfType<IAssemblyContext>()
                   where allocation.GetAssemblyContextsValue(req) != container
                      && !allocation.Environment.Links.Any(
                          l => l.Connects.Contains(container) &&
                               l.Connects.Contains(allocation.GetAssemblyContextsValue(req)))
                   select Tuple.Create(ass, req);
        }
    }
}
