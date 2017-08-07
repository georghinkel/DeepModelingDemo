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
    /// The default implementation of the Parameter class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/TwoLevelADL/1.0/SystemIndependent/")]
    [XmlNamespacePrefixAttribute("system")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/TwoLevelADL/1.0#//SystemIndependent/Parameter")]
    [DebuggerDisplayAttribute("Parameter {Name}")]
    public partial class Parameter : NamedElement, IParameter, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        private Type _type;
        
        private static Lazy<ITypedElement> _typeAttribute = new Lazy<ITypedElement>(RetrieveTypeAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Type property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public Type Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    Type old = this._type;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanging(e);
                    this.OnPropertyChanging("Type", e, _typeAttribute);
                    this._type = value;
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e, _typeAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/TwoLevelADL/1.0#//SystemIndependent/Parameter")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        private static ITypedElement RetrieveTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.SystemIndependent.Parameter.ClassInstance)).Resolve("Type")));
        }
        
        /// <summary>
        /// Raises the TypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TYPE"))
            {
                return this.Type;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TYPE"))
            {
                this.Type = ((Type)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/TwoLevelADL/1.0#//SystemIndependent/Parameter")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<IParameter, Type>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(IParameter modelElement) : 
                    base(modelElement, "Type")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Type Value
            {
                get
                {
                    return this.ModelElement.Type;
                }
                set
                {
                    this.ModelElement.Type = value;
                }
            }
        }
    }
}

