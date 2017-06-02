using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZI.SoftwareEngineering.DeepModeling.DeepADL
{
    class ContainerAnalysis
    {
        public IEnumerable<Tuple<IAssemblyContext, IRequiredInterface>> GetFaultyContainers(ISystemAllocation allocation)
        {
            return from ass in allocation.GetSystemArchitecture().AssemblyContexts
                   let container = allocation.GetAssemblyContextsValue(ass)
                   from req in ass.GetComponentType().RequiredInterfaces
                   where allocation.GetAssemblyContextsValue(ass.GetRequiredInterfacesValue(req)) == container
                      || allocation.Environment.Links.Any(
                          l => l.Connects.Contains(container) &&
                               l.Connects.Contains(allocation.GetAssemblyContextsValue(ass.GetRequiredInterfacesValue(req))))                                
                   select Tuple.Create(ass, req);
        }

        public IEnumerable<Tuple<IAssemblyContext, IAssemblyContext>> GetFaultyContainers2(ISystemAllocation allocation)
        {
            return from ass in allocation.GetSystemArchitecture().AssemblyContexts
                   let container = allocation.GetAssemblyContextsValue(ass)
                   from req in ass.ReferencedElements.OfType<IAssemblyContext>().Distinct()
                   where allocation.GetAssemblyContextsValue(req) == container
                      || allocation.Environment.Links.Any(
                          l => l.Connects.Contains(container) &&
                               l.Connects.Contains(allocation.GetAssemblyContextsValue(req)))
                   select Tuple.Create(ass, req);
        }
    }
}
