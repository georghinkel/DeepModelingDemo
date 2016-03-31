using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Models;
using System.IO;

namespace DeepADLCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var core = CreateCoreNamespace();
            var unit = MetaFacade.CreateCode(core, "FZI.SoftwareEngineering.DeepModeling");
            MetaFacade.GenerateCode(unit, new Microsoft.CSharp.CSharpCodeProvider(), @"..\..\..\DeepADL\DeepADL", true);
            using (var fs = File.Create(@"..\..\..\DeepADL.nmf"))
            {
                MetaRepository.Instance.Serializer.Serialize(core.Model, fs);
            }
        }
        
        private static Namespace CreateCoreNamespace()
        {
            var classClass = MetaRepository.Instance.ResolveClass(typeof(Class));
            var namespaceClass = MetaRepository.Instance.ResolveClass(typeof(Namespace));
            var referenceClass = MetaRepository.Instance.ResolveClass(typeof(Reference));
            var stringType = MetaRepository.Instance.Resolve("http://nmf.codeplex.com/nmeta/#//String/") as IPrimitiveType;

            var core = new Namespace()
            {
                Name = "DeepADL",
                Uri = new Uri("http://github.com/georghinkel/DeepADL/1.0"),
                Prefix = "core"
            };

            var coreModel = new Model()
            {
                ModelUri = core.Uri
            };
            coreModel.RootElements.Add(core);

            var componentType = new Class()
            {
                Name = "ComponentType",
                IsAbstract = false
            };
            componentType.BaseTypes.Add(classClass);
            core.Types.Add(componentType);

            var requiredInterface = new Class()
            {
                Name = "RequiredInterface",
                IsAbstract = false
            };
            requiredInterface.BaseTypes.Add(referenceClass);
            core.Types.Add(requiredInterface);

            var signature = new Class()
            {
                Name = "Signature",
                IsAbstract = false
            };
            var signatureName = new NMF.Models.Meta.Attribute()
            {
                Name = "Name",
                Type = stringType
            };
            signature.Attributes.Add(signatureName);
            signature.Identifier = signatureName;
            core.Types.Add(signature);

            var service = new Class()
            {
                Name = "Service",
                IsAbstract = false
            };
            var serviceName = new NMF.Models.Meta.Attribute()
            {
                Name = "Name",
                Type = stringType
            };
            service.Attributes.Add(serviceName);
            service.Identifier = serviceName;
            service.References.Add(new Reference()
            {
                Name = "Implements",
                ReferenceType = signature,
            });
            core.Types.Add(service);


            var assemblyContext = new Class()
            {
                Name = "AssemblyContext",
                IsAbstract = true
            };
            assemblyContext.BaseTypes.Add(referenceClass);
            ApplyReferenceConstraints(assemblyContext, true);
            assemblyContext.ConstrainReference("Refines");

            var interfaceDecl = new Class()
            {
                Name = "Interface",
                IsAbstract = false
            };
            interfaceDecl.BaseTypes.Add(classClass);
            core.Types.Add(interfaceDecl);
            interfaceDecl.References.Add(new Reference()
            {
                Name = "Signatures",
                UpperBound = -1,
                ReferenceType = signature,
                IsContainment = true
            });
            interfaceDecl.ConstrainReference("References");
            interfaceDecl.ConstrainReference("ReferenceConstraints");
            interfaceDecl.ConstrainReference("Attributes");
            interfaceDecl.ConstrainReference("AttributeConstraints");
            interfaceDecl.ConstrainReference("InstanceOf");
            interfaceDecl.ConstrainReference("Events");
            interfaceDecl.ConstrainReference("Operations");
            interfaceDecl.ConstrainReference("Identifier");
            interfaceDecl.ConstrainAttribute("IsInterface", "True");
            interfaceDecl.ConstrainAttribute("IsAbstract", "False");
            interfaceDecl.ConstrainReference("BaseTypes", assemblyContext);

            core.Types.Add(assemblyContext);

            var system = new Class()
            {
                Name = "SystemArchitecture",
                IsAbstract = false
            };
            system.BaseTypes.Add(classClass);
            system.ConstrainReference("ReferenceConstraints");
            system.ConstrainReference("Attributes");
            system.ConstrainReference("AttributeConstraints");
            system.ConstrainReference("Events");
            system.ConstrainReference("Operations");
            system.ConstrainReference("Identifier");
            system.ConstrainReference("InstanceOf");
            system.ConstrainAttribute("IsInterface", "False");
            system.ConstrainAttribute("IsAbstract", "False");
            core.Types.Add(system);

            componentType.References.Add(new Reference()
            {
                Name = "RequiredInterfaces",
                ReferenceType = requiredInterface,
                UpperBound = -1,
                Refines = classClass.LookupReference("References"),
                IsContainment = true
            });
            componentType.References.Add(new Reference()
            {
                Name = "ProvidedInterfaces",
                UpperBound = -1,
                ReferenceType = interfaceDecl,
                Refines = classClass.LookupReference("BaseTypes")
            });
            componentType.References.Add(new Reference()
            {
                Name = "Services",
                UpperBound = -1,
                ReferenceType = service,
                IsContainment = true
            });
            componentType.ConstrainReference("ReferenceConstraints");
            componentType.ConstrainReference("Attributes");
            componentType.ConstrainReference("AttributeConstraints");
            componentType.ConstrainReference("Events");
            componentType.ConstrainReference("Identifier");
            componentType.ConstrainAttribute("IsInterface", "False");
            componentType.ConstrainAttribute("IsAbstract", "False");
            componentType.ConstrainReference("Operations");
            componentType.ConstrainReference("InstanceOf");
            assemblyContext.InstanceOf = componentType;

            var baseTypeAssemblyContext = new ReferenceConstraint()
            {
                Constrains = classClass.LookupReference("BaseTypes")
            };
            baseTypeAssemblyContext.References.Add(assemblyContext);
            componentType.ReferenceConstraints.Add(baseTypeAssemblyContext);

            requiredInterface.References.Add(new Reference()
            {
                Name = "Interface",
                ReferenceType = interfaceDecl,
                Refines = referenceClass.LookupReference("ReferenceType")
            });
            ApplyReferenceConstraints(requiredInterface, false);

            var resourceContainer = new Class()
            {
                Name = "ResourceContainer"
            };
            var resourceContainerName = new NMF.Models.Meta.Attribute()
            {
                Name = "Name",
                Type = stringType,
            };
            core.Types.Add(resourceContainer);
            resourceContainer.Attributes.Add(resourceContainerName);
            resourceContainer.Identifier = resourceContainerName;

            var resourceEnvironment = new Class()
            {
                IsAbstract = false,
                Name = "ResourceEnvironment"
            };
            core.Types.Add(resourceEnvironment);
            var resourceContainerContainer = new Reference()
            {
                Name = "Environment",
                ReferenceType = resourceEnvironment,
                UpperBound = 1,
                LowerBound = 1
            };
            resourceContainer.References.Add(resourceContainerContainer);
            resourceEnvironment.References.Add(new Reference()
            {
                Name = "Container",
                IsContainment = true,
                ReferenceType = resourceContainer,
                UpperBound = -1,
                Opposite = resourceContainerContainer
            });

            assemblyContext.ConstrainReference("ReferenceType", resourceContainer);

            system.References.Add(new Reference()
            {
                Name = "AssemblyContexts",
                ReferenceType = assemblyContext,
                UpperBound = -1,
                IsContainment = true,
                Refines = classClass.LookupReference("References")
            });

            var systemSpec = new Class()
            {
                Name = "SystemSpecification",
                IsAbstract = false
            };
            core.Types.Add(systemSpec);
            systemSpec.BaseTypes.Add(classClass);
            systemSpec.ConstrainReference("BaseTypes", system);
            systemSpec.References.Add(new Reference()
            {
                Name = "PublicInterfaces",
                ReferenceType = requiredInterface,
                IsContainment = true,
                UpperBound = -1,
                Refines = classClass.LookupReference("References")
            });
            systemSpec.ConstrainReference("ReferenceConstraints");
            systemSpec.ConstrainReference("Attributes");
            systemSpec.ConstrainReference("AttributeConstraints");
            systemSpec.ConstrainReference("Events");
            systemSpec.ConstrainReference("Operations");
            systemSpec.ConstrainReference("Identifier");
            systemSpec.ConstrainAttribute("IsInterface", "False");
            systemSpec.ConstrainAttribute("IsAbstract", "False");
            systemSpec.ConstrainReference("InstanceOf");

            var allocation = new Class()
            {
                Name = "SystemAllocation",
                IsAbstract = true
            };
            core.Types.Add(allocation);
            allocation.References.Add(new Reference()
            {
                Name = "Environment",
                ReferenceType = resourceEnvironment
            });

            system.ConstrainReference("BaseTypes", allocation);

            var repository = new Class()
            {
                Name = "Repository",
                IsAbstract = false
            };
            repository.BaseTypes.Add(namespaceClass);
            var repositoryTypes = new Reference()
            {
                Name = "ComponentTypes",
                ReferenceType = componentType,
                UpperBound = -1,
                IsContainment = true,
                Refines = namespaceClass.LookupReference("Types")
            };
            repository.References.Add(repositoryTypes);
            var repositoryInterfaces = new Reference()
            {
                Name = "Interfaces",
                ReferenceType = interfaceDecl,
                UpperBound = -1,
                IsContainment = true,
                Refines = namespaceClass.LookupReference("Types")
            };
            repository.References.Add(repositoryInterfaces);
            var repositorySystemSpecs = new Reference()
            {
                Name = "SystemSpecifications",
                ReferenceType = systemSpec,
                UpperBound = -1,
                IsContainment = true,
                Refines = namespaceClass.LookupReference("Types")
            };
            repository.References.Add(repositorySystemSpecs);
            repository.ConstrainReference("ChildNamespaces");
            core.Types.Add(repository);

            componentType.References.Add(new Reference()
            {
                Name = "Repository",
                ReferenceType = repository,
                UpperBound = 1,
                LowerBound = 1,
                IsContainment = false,
                Refines = classClass.LookupReference("Namespace"),
                Opposite = repositoryTypes
            });
            interfaceDecl.References.Add(new Reference()
            {
                Name = "Repository",
                ReferenceType = repository,
                UpperBound = 1,
                LowerBound = 1,
                IsContainment = false,
                Refines = classClass.LookupReference("Namespace"),
                Opposite = repositoryInterfaces
            });
            systemSpec.References.Add(new Reference()
            {
                Name = "Repository",
                ReferenceType = repository,
                UpperBound = 1,
                LowerBound = 1,
                IsContainment = false,
                Refines = classClass.LookupReference("Namespace"),
                Opposite = repositorySystemSpecs
            });

            return core;
        }

        private static void ApplyReferenceConstraints(Class referenceType, bool isContainment)
        {
            referenceType.ConstrainAttribute("LowerBound", "1");
            referenceType.ConstrainAttribute("UpperBound", "1");
            referenceType.ConstrainAttribute("IsContainment", isContainment.ToString());
            referenceType.ConstrainAttribute("IsOrdered", "False");
            referenceType.ConstrainAttribute("IsUnique", "False");
        }
    }


    public static class Extensions
    {
        public static void ConstrainAttribute(this IClass @class, string name, string value = null)
        {
            var refinedAttribute = @class.LookupAttribute(name);
            if (refinedAttribute == null) throw new ArgumentOutOfRangeException();
            var attConst = new AttributeConstraint()
            {
                Constrains = refinedAttribute
            };
            if (value != null)
            {
                attConst.Values.Add(value);
            }
            @class.AttributeConstraints.Add(attConst);
        }

        public static void ConstrainReference(this IClass @class, string name, IModelElement value = null)
        {
            var refinedReference = @class.LookupReference(name);
            if (refinedReference == null) throw new ArgumentOutOfRangeException();
            var refConst = new ReferenceConstraint()
            {
                Constrains = refinedReference
            };
            if (value != null)
            {
                refConst.References.Add(value);
            }
            @class.ReferenceConstraints.Add(refConst);
        }
    }
}
