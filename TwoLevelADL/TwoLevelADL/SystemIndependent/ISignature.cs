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

namespace FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.SystemIndependent
{
    
    
    /// <summary>
    /// The public interface for Signature
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Signature))]
    [XmlDefaultImplementationTypeAttribute(typeof(Signature))]
    public interface ISignature : IModelElement, INamedElement
    {
        
        /// <summary>
        /// The ReturnType property
        /// </summary>
        Nullable<Type> ReturnType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Parameter property
        /// </summary>
        IOrderedSetExpression<IParameter> Parameter
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ReturnType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReturnTypeChanging;
        
        /// <summary>
        /// Gets fired when the ReturnType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReturnTypeChanged;
    }
}

