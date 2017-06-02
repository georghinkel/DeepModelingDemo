//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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

namespace FZI.SoftwareEngineering.DeepModeling.DeepADL
{
    
    
    /// <summary>
    /// The public interface for SystemAllocation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SystemAllocation))]
    [XmlDefaultImplementationTypeAttribute(typeof(SystemAllocation))]
    public interface ISystemAllocation : NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The Environment property
        /// </summary>
        IResourceEnvironment Environment
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Environment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnvironmentChanging;
        
        /// <summary>
        /// Gets fired when the Environment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnvironmentChanged;
        
        /// <summary>
        /// Gets the SystemArchitecture for this model element
        /// </summary>
        ISystemArchitecture GetSystemArchitecture();
        
        /// <summary>
        /// Gets the referenced value for a AssemblyContexts of the enclosing SystemArchitecture.
        /// </summary>
        IResourceContainer GetAssemblyContextsValue(IAssemblyContext reference);
    }
}

