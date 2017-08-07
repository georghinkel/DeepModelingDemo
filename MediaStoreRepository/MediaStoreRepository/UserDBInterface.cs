//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using FZI.SoftwareEngineering.DeepModeling.DeepADL;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace FZI.SoftwareEngineering.DeepModeling.Repository
{
    
    
    /// <summary>
    /// The default implementation of the UserDBInterface class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/mediaStore/Repository")]
    [XmlNamespacePrefixAttribute("repo")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/mediaStore/Repository#//UserDBInterface")]
    [DebuggerDisplayAttribute("UserDBInterface {Name}")]
    public partial class UserDBInterface : AssemblyContext, IUserDBInterface, NMF.Models.IModelElement
    {
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// Gets the ComponentType model for this type
        /// </summary>
        public new static IComponentType ComponentTypeInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/mediaStore/Repository#//UserDBInterface")));
                }
                return ((IComponentType)(_classInstance));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/mediaStore/Repository#//UserDBInterface")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the ComponentType for this model element
        /// </summary>
        public override IComponentType GetComponentType()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/mediaStore/Repository#//UserDBInterface")));
            }
            return ((IComponentType)(_classInstance));
        }
        
        /// <summary>
        /// Gets the referenced value for a RequiredInterfaces of the enclosing ComponentType.
        /// </summary>
        public override IAssemblyContext GetRequiredInterfacesValue(IRequiredInterface reference)
        {
            return ((IAssemblyContext)(this.GetReferencedElement(reference)));
        }
        
        /// <summary>
        /// Gets the referenced value for a RequiredInterfaces of the enclosing ComponentType.
        /// </summary>
        public override INotifyValue<IAssemblyContext> GetRequiredInterfacesProxy(IRequiredInterface reference)
        {
            if ((reference == null))
            {
                throw new System.ArgumentOutOfRangeException("reference");
            }
            if ((reference.UpperBound == 1))
            {
                return Observable.As<IModelElement, IAssemblyContext>(this.GetExpressionForReference(reference.Name.ToUpperInvariant()));
            }
            throw new NotSupportedException();
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/mediaStore/Repository#//UserDBInterface")));
            }
            return _classInstance;
        }
    }
}

