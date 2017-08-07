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
    /// The public interface for AudioStore
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AudioStore))]
    [XmlDefaultImplementationTypeAttribute(typeof(AudioStore))]
    public interface IAudioStore : NMF.Models.IModelElement, IAudioStoreInterface, IAssemblyContext
    {
        
        /// <summary>
        /// The audioDB property
        /// </summary>
        [XmlElementNameAttribute("audioDB")]
        [XmlAttributeAttribute(true)]
        IAudioDBInterface AudioDB
        {
            get;
            set;
        }
        
        /// <summary>
        /// The userManagement property
        /// </summary>
        [XmlElementNameAttribute("userManagement")]
        [XmlAttributeAttribute(true)]
        IUserManagementInterface UserManagement
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the AudioDB property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AudioDBChanging;
        
        /// <summary>
        /// Gets fired when the AudioDB property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AudioDBChanged;
        
        /// <summary>
        /// Gets fired before the UserManagement property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UserManagementChanging;
        
        /// <summary>
        /// Gets fired when the UserManagement property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UserManagementChanged;
    }
}

