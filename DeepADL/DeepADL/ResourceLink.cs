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
    /// The default implementation of the ResourceLink class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/DeepADL/1.0")]
    [XmlNamespacePrefixAttribute("core")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/DeepADL/1.0#//ResourceLink")]
    public partial class ResourceLink : NMF.Models.ModelElement, IResourceLink, NMF.Models.IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _environmentReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveEnvironmentReference);
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _connectsReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveConnectsReference);
        
        /// <summary>
        /// The backing field for the Connects property
        /// </summary>
        private ObservableAssociationList<IResourceContainer> _connects;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        public ResourceLink()
        {
            this._connects = new ObservableAssociationList<IResourceContainer>();
            this._connects.CollectionChanging += this.ConnectsCollectionChanging;
            this._connects.CollectionChanged += this.ConnectsCollectionChanged;
        }
        
        /// <summary>
        /// The Environment property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Links")]
        public IResourceEnvironment Environment
        {
            get
            {
                return ModelHelper.CastAs<IResourceEnvironment>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The Connects property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public ICollectionExpression<IResourceContainer> Connects
        {
            get
            {
                return this._connects;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ResourceLinkReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//ResourceLink")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Environment property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnvironmentChanging;
        
        /// <summary>
        /// Gets fired when the Environment property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EnvironmentChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveEnvironmentReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(FZI.SoftwareEngineering.DeepModeling.DeepADL.ResourceLink.ClassInstance)).Resolve("Environment")));
        }
        
        /// <summary>
        /// Raises the EnvironmentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnvironmentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnvironmentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            IResourceEnvironment oldEnvironment = ModelHelper.CastAs<IResourceEnvironment>(oldParent);
            IResourceEnvironment newEnvironment = ModelHelper.CastAs<IResourceEnvironment>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldEnvironment, newEnvironment);
            this.OnEnvironmentChanging(e);
            this.OnPropertyChanging("Environment", e, _environmentReference);
        }
        
        /// <summary>
        /// Raises the EnvironmentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEnvironmentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EnvironmentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(NMF.Models.IModelElement newParent, NMF.Models.IModelElement oldParent)
        {
            IResourceEnvironment oldEnvironment = ModelHelper.CastAs<IResourceEnvironment>(oldParent);
            IResourceEnvironment newEnvironment = ModelHelper.CastAs<IResourceEnvironment>(newParent);
            if ((oldEnvironment != null))
            {
                oldEnvironment.Links.Remove(this);
            }
            if ((newEnvironment != null))
            {
                newEnvironment.Links.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldEnvironment, newEnvironment);
            this.OnEnvironmentChanged(e);
            this.OnPropertyChanged("Environment", e, _environmentReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveConnectsReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(FZI.SoftwareEngineering.DeepModeling.DeepADL.ResourceLink.ClassInstance)).Resolve("Connects")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Connects property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConnectsCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Connects", e, _connectsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Connects property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConnectsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Connects", e, _connectsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "CONNECTS"))
            {
                return this._connects;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ENVIRONMENT"))
            {
                this.Environment = ((IResourceEnvironment)(value));
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
            if ((attribute == "Environment"))
            {
                return new EnvironmentProxy(this);
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
            if ((reference == "Environment"))
            {
                return new EnvironmentProxy(this);
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//ResourceLink")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceLink class
        /// </summary>
        public class ResourceLinkReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private ResourceLink _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceLinkReferencedElementsCollection(ResourceLink parent)
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
                    if ((this._parent.Environment != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Connects.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EnvironmentChanged += this.PropagateValueChanges;
                this._parent.Connects.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EnvironmentChanged -= this.PropagateValueChanges;
                this._parent.Connects.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.Environment == null))
                {
                    IResourceEnvironment environmentCasted = item.As<IResourceEnvironment>();
                    if ((environmentCasted != null))
                    {
                        this._parent.Environment = environmentCasted;
                        return;
                    }
                }
                IResourceContainer connectsCasted = item.As<IResourceContainer>();
                if ((connectsCasted != null))
                {
                    this._parent.Connects.Add(connectsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Environment = null;
                this._parent.Connects.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.Environment))
                {
                    return true;
                }
                if (this._parent.Connects.Contains(item))
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
                if ((this._parent.Environment != null))
                {
                    array[arrayIndex] = this._parent.Environment;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<NMF.Models.IModelElement> connectsEnumerator = this._parent.Connects.GetEnumerator();
                try
                {
                    for (
                    ; connectsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = connectsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    connectsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.Environment == item))
                {
                    this._parent.Environment = null;
                    return true;
                }
                IResourceContainer resourceContainerItem = item.As<IResourceContainer>();
                if (((resourceContainerItem != null) 
                            && this._parent.Connects.Remove(resourceContainerItem)))
                {
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Environment).Concat(this._parent.Connects).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Environment property
        /// </summary>
        private sealed class EnvironmentProxy : ModelPropertyChange<IResourceLink, IResourceEnvironment>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EnvironmentProxy(IResourceLink modelElement) : 
                    base(modelElement, "Environment")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceEnvironment Value
            {
                get
                {
                    return this.ModelElement.Environment;
                }
                set
                {
                    this.ModelElement.Environment = value;
                }
            }
        }
    }
}
