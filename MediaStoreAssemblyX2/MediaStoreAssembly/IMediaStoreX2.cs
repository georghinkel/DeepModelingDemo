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

namespace FZI.SoftwareEngineering.DeepModeling.AssemblyX2
{
    
    
    /// <summary>
    /// The public interface for MediaStoreX2
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(MediaStoreX2))]
    [XmlDefaultImplementationTypeAttribute(typeof(MediaStoreX2))]
    public interface IMediaStoreX2 : NMF.Models.IModelElement, ISystemAllocation
    {
        
        /// <summary>
        /// The WebForm1 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer WebForm1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AudioStore1 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer AudioStore1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The UserManagement1 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer UserManagement1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EncodingAdapter1 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer EncodingAdapter1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OggEncoder1 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer OggEncoder1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DBAdapter1 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer DBAdapter1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MySqlClient1 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer MySqlClient1
        {
            get;
            set;
        }
        
        /// <summary>
        /// The WebForm2 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer WebForm2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The AudioStore2 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer AudioStore2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The UserManagement2 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer UserManagement2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The EncodingAdapter2 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer EncodingAdapter2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OggEncoder2 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer OggEncoder2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The DBAdapter2 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer DBAdapter2
        {
            get;
            set;
        }
        
        /// <summary>
        /// The MySqlClient2 property
        /// </summary>
        [XmlAttributeAttribute(true)]
        IResourceContainer MySqlClient2
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the WebForm1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WebForm1Changing;
        
        /// <summary>
        /// Gets fired when the WebForm1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WebForm1Changed;
        
        /// <summary>
        /// Gets fired before the AudioStore1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AudioStore1Changing;
        
        /// <summary>
        /// Gets fired when the AudioStore1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AudioStore1Changed;
        
        /// <summary>
        /// Gets fired before the UserManagement1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UserManagement1Changing;
        
        /// <summary>
        /// Gets fired when the UserManagement1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UserManagement1Changed;
        
        /// <summary>
        /// Gets fired before the EncodingAdapter1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EncodingAdapter1Changing;
        
        /// <summary>
        /// Gets fired when the EncodingAdapter1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EncodingAdapter1Changed;
        
        /// <summary>
        /// Gets fired before the OggEncoder1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OggEncoder1Changing;
        
        /// <summary>
        /// Gets fired when the OggEncoder1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OggEncoder1Changed;
        
        /// <summary>
        /// Gets fired before the DBAdapter1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DBAdapter1Changing;
        
        /// <summary>
        /// Gets fired when the DBAdapter1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DBAdapter1Changed;
        
        /// <summary>
        /// Gets fired before the MySqlClient1 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MySqlClient1Changing;
        
        /// <summary>
        /// Gets fired when the MySqlClient1 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MySqlClient1Changed;
        
        /// <summary>
        /// Gets fired before the WebForm2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WebForm2Changing;
        
        /// <summary>
        /// Gets fired when the WebForm2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> WebForm2Changed;
        
        /// <summary>
        /// Gets fired before the AudioStore2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AudioStore2Changing;
        
        /// <summary>
        /// Gets fired when the AudioStore2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AudioStore2Changed;
        
        /// <summary>
        /// Gets fired before the UserManagement2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UserManagement2Changing;
        
        /// <summary>
        /// Gets fired when the UserManagement2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> UserManagement2Changed;
        
        /// <summary>
        /// Gets fired before the EncodingAdapter2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EncodingAdapter2Changing;
        
        /// <summary>
        /// Gets fired when the EncodingAdapter2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EncodingAdapter2Changed;
        
        /// <summary>
        /// Gets fired before the OggEncoder2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OggEncoder2Changing;
        
        /// <summary>
        /// Gets fired when the OggEncoder2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OggEncoder2Changed;
        
        /// <summary>
        /// Gets fired before the DBAdapter2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DBAdapter2Changing;
        
        /// <summary>
        /// Gets fired when the DBAdapter2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DBAdapter2Changed;
        
        /// <summary>
        /// Gets fired before the MySqlClient2 property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MySqlClient2Changing;
        
        /// <summary>
        /// Gets fired when the MySqlClient2 property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> MySqlClient2Changed;
    }
}
