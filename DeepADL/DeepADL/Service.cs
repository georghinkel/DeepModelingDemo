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
    /// The default implementation of the Service class
    /// </summary>
    [XmlIdentifierAttribute("Name")]
    [XmlNamespaceAttribute("http://github.com/georghinkel/DeepADL/1.0")]
    [XmlNamespacePrefixAttribute("core")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/DeepADL/1.0#//Service")]
    [DebuggerDisplayAttribute("Service {Name}")]
    public partial class Service : NMF.Models.ModelElement, IService, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the Name property
        /// </summary>
        private string _name;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _nameAttribute = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveNameAttribute);
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _implementsReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveImplementsReference);
        
        /// <summary>
        /// The backing field for the Implements property
        /// </summary>
        private ISignature _implements;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The Name property
        /// </summary>
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    string old = this._name;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNameChanging(e);
                    this.OnPropertyChanging("Name", e, _nameAttribute);
                    this._name = value;
                    this.OnNameChanged(e);
                    this.OnPropertyChanged("Name", e, _nameAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Implements property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public ISignature Implements
        {
            get
            {
                return this._implements;
            }
            set
            {
                if ((this._implements != value))
                {
                    ISignature old = this._implements;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnImplementsChanging(e);
                    this.OnPropertyChanging("Implements", e, _implementsReference);
                    this._implements = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetImplements;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetImplements;
                    }
                    this.OnImplementsChanged(e);
                    this.OnPropertyChanged("Implements", e, _implementsReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ServiceReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//Service")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the current model element can be identified by an attribute value
        /// </summary>
        public override bool IsIdentified
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Gets fired before the Implements property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ImplementsChanging;
        
        /// <summary>
        /// Gets fired when the Implements property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ImplementsChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveNameAttribute()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(FZI.SoftwareEngineering.DeepModeling.DeepADL.Service.ClassInstance)).Resolve("Name")));
        }
        
        /// <summary>
        /// Raises the NameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveImplementsReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(FZI.SoftwareEngineering.DeepModeling.DeepADL.Service.ClassInstance)).Resolve("Implements")));
        }
        
        /// <summary>
        /// Raises the ImplementsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnImplementsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ImplementsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ImplementsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnImplementsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ImplementsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Implements property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetImplements(object sender, System.EventArgs eventArgs)
        {
            this.Implements = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "NAME"))
            {
                return this.Name;
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
            if ((feature == "IMPLEMENTS"))
            {
                this.Implements = ((ISignature)(value));
                return;
            }
            if ((feature == "NAME"))
            {
                this.Name = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "Implements"))
            {
                return new ImplementsProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "Implements"))
            {
                return new ImplementsProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//Service")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Gets the identifier string for this model element
        /// </summary>
        /// <returns>The identifier string</returns>
        public override string ToIdentifierString()
        {
            if ((this.Name == null))
            {
                return null;
            }
            return this.Name.ToString();
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Service class
        /// </summary>
        public class ServiceReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Service _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ServiceReferencedElementsCollection(Service parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Implements != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ImplementsChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ImplementsChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.Implements == null))
                {
                    ISignature implementsCasted = item.As<ISignature>();
                    if ((implementsCasted != null))
                    {
                        this._parent.Implements = implementsCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Implements = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.Implements))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Implements != null))
                {
                    array[arrayIndex] = this._parent.Implements;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.Implements == item))
                {
                    this._parent.Implements = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Implements).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Name property
        /// </summary>
        private sealed class NameProxy : ModelPropertyChange<IService, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NameProxy(IService modelElement) : 
                    base(modelElement, "Name")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Name;
                }
                set
                {
                    this.ModelElement.Name = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Implements property
        /// </summary>
        private sealed class ImplementsProxy : ModelPropertyChange<IService, ISignature>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ImplementsProxy(IService modelElement) : 
                    base(modelElement, "Implements")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISignature Value
            {
                get
                {
                    return this.ModelElement.Implements;
                }
                set
                {
                    this.ModelElement.Implements = value;
                }
            }
        }
    }
}

