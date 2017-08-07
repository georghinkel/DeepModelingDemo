using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Assembly;
using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Deployment;
using NMF.Expressions;
using NMF.Expressions.Linq;

namespace FZI.SoftwareEngineering.DeepModeling
{
    public class TwoLevelContainerAnalysis
    {
        public static IEnumerableExpression<IAssemblyConnector> GetFaultyContainers(IAllocation allocation)
        {
            return from connector in allocation.AllocatedSystem.Connectors
                   let providingAllocation = allocation.AllocationContexts
                            .FirstOrDefault(c => c.Assembly == connector.ProvidingComponent)
                   let requiringAllocation = allocation.AllocationContexts
                            .FirstOrDefault(c => c.Assembly == connector.UsingComponent)
                   where providingAllocation.Container != requiringAllocation.Container &&
                     !allocation.Environment.Links.Any(link =>
                        link.ConnectedContainers.Contains(providingAllocation.Container) &&
                        link.ConnectedContainers.Contains(requiringAllocation.Container))
                   select connector;
        }
    }
}
