//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL;
using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.SystemIndependent;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Assembly
{
    
    
    /// <summary>
    /// The default implementation of the System class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/TwoLevelADL/1.0/Assembly/")]
    [XmlNamespacePrefixAttribute("assembly")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/TwoLevelADL/1.0#//Assembly/System")]
    [DebuggerDisplayAttribute("System {Name}")]
    [XmlElementNameAttribute("System")]
    public partial class System0 : CompositeComponent, ISystem0, IModelElement
    {
        
        private static IClass _classInstance;
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/TwoLevelADL/1.0#//Assembly/System")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/TwoLevelADL/1.0#//Assembly/System")));
            }
            return _classInstance;
        }
    }
}

