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
    /// The public interface for Delegate
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Delegate))]
    [XmlDefaultImplementationTypeAttribute(typeof(Delegate))]
    public interface IDelegate : NMF.Models.IModelElement, NMF.Models.Meta.IClass
    {
        
        /// <summary>
        /// The Repository property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Delegates")]
        IRepository Repository
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Type property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IInterface Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Repository property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RepositoryChanging;
        
        /// <summary>
        /// Gets fired when the Repository property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RepositoryChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
    }
}

