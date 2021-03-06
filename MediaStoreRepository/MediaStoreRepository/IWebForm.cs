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
    /// The public interface for WebForm
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(WebForm))]
    [XmlDefaultImplementationTypeAttribute(typeof(WebForm))]
    public interface IWebForm : NMF.Models.IModelElement, IHTTP, IAssemblyContext
    {
        
        /// <summary>
        /// The application property
        /// </summary>
        [XmlElementNameAttribute("application")]
        [XmlAttributeAttribute(true)]
        IAudioStoreInterface Application
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Application property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ApplicationChanging;
        
        /// <summary>
        /// Gets fired when the Application property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ApplicationChanged;
    }
}

