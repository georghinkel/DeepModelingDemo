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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace FZI.SoftwareEngineering.DeepModeling.Repository
{
    
    
    /// <summary>
    /// The default implementation of the MediaStoreSystem class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/mediaStore/Repository")]
    [XmlNamespacePrefixAttribute("repo")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/mediaStore/Repository#//MediaStoreSystem")]
    [DebuggerDisplayAttribute("MediaStoreSystem {Name}")]
    public partial class MediaStoreSystem : NMF.Models.Meta.Type, IMediaStoreSystem, NMF.Models.IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _frontendReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveFrontendReference);
        
        /// <summary>
        /// The backing field for the Frontend property
        /// </summary>
        private IHTTP _frontend;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _assemblyContextsReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveAssemblyContextsReference);
        
        /// <summary>
        /// The backing field for the AssemblyContexts property
        /// </summary>
        private ObservableCompositionList<IAssemblyContext> _assemblyContexts;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        event EventHandler<ValueChangedEventArgs> IClass.IdentifierChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.IdentifierChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.InstanceOfChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.InstanceOfChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.IdentifierScopeChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.IdentifierScopeChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.IsAbstractChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IClass.IsAbstractChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        
        public MediaStoreSystem()
        {
            this._assemblyContexts = new ObservableCompositionList<IAssemblyContext>(this);
            this._assemblyContexts.CollectionChanging += this.AssemblyContextsCollectionChanging;
            this._assemblyContexts.CollectionChanged += this.AssemblyContextsCollectionChanged;
        }
        
        /// <summary>
        /// The Frontend property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public IHTTP Frontend
        {
            get
            {
                return this._frontend;
            }
            set
            {
                if ((this._frontend != value))
                {
                    IHTTP old = this._frontend;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFrontendChanging(e);
                    this.OnPropertyChanging("Frontend", e, _frontendReference);
                    this._frontend = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetFrontend;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetFrontend;
                    }
                    this.OnFrontendChanged(e);
                    this.OnPropertyChanged("Frontend", e, _frontendReference);
                }
            }
        }
        
        /// <summary>
        /// The AssemblyContexts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public ICollectionExpression<IAssemblyContext> AssemblyContexts
        {
            get
            {
                return this._assemblyContexts;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IReference> NMF.Models.Meta.IReferenceType.References
        {
            get
            {
                return new SystemArchitectureReferencesCollection(this);
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IReferenceConstraint> NMF.Models.Meta.IClass.ReferenceConstraints
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IReferenceConstraint>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IAttribute> NMF.Models.Meta.IStructuredType.Attributes
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IAttribute>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IAttributeConstraint> NMF.Models.Meta.IClass.AttributeConstraints
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IAttributeConstraint>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IEvent> NMF.Models.Meta.IReferenceType.Events
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IEvent>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IOperation> NMF.Models.Meta.IStructuredType.Operations
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IOperation>.Instance;
            }
        }
        
        NMF.Models.Meta.IAttribute NMF.Models.Meta.IClass.Identifier
        {
            get
            {
                return null;
            }
            set
            {
                if ((value != null))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        NMF.Models.Meta.IClass NMF.Models.Meta.IClass.InstanceOf
        {
            get
            {
                return null;
            }
            set
            {
                if ((value != null))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IClass> NMF.Models.Meta.IClass.BaseTypes
        {
            get
            {
                return new SystemArchitectureBaseTypesCollection(this);
            }
        }
        
        NMF.Models.Meta.IdentifierScope NMF.Models.Meta.IClass.IdentifierScope
        {
            get
            {
                return NMF.Models.Meta.IdentifierScope.Local;
            }
            set
            {
                if ((value != NMF.Models.Meta.IdentifierScope.Local))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        bool NMF.Models.Meta.IClass.IsAbstract
        {
            get
            {
                return false;
            }
            set
            {
                if ((value != false))
                {
                    throw new System.NotSupportedException();
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
                return base.ReferencedElements.Concat(new MediaStoreSystemReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/mediaStore/Repository#//MediaStoreSystem")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Frontend property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FrontendChanging;
        
        /// <summary>
        /// Gets fired when the Frontend property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> FrontendChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveFrontendReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(FZI.SoftwareEngineering.DeepModeling.Repository.MediaStoreSystem.ClassInstance)).Resolve("Frontend")));
        }
        
        /// <summary>
        /// Raises the FrontendChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFrontendChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FrontendChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FrontendChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFrontendChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.FrontendChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Frontend property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetFrontend(object sender, System.EventArgs eventArgs)
        {
            this.Frontend = null;
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveAssemblyContextsReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(FZI.SoftwareEngineering.DeepModeling.DeepADL.SystemArchitecture.ClassInstance)).Resolve("AssemblyContexts")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AssemblyContexts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssemblyContextsCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("AssemblyContexts", e, _assemblyContextsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AssemblyContexts property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AssemblyContextsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AssemblyContexts", e, _assemblyContextsReference);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ASSEMBLYCONTEXTS"))
            {
                return this._assemblyContexts;
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
            if ((feature == "FRONTEND"))
            {
                this.Frontend = ((IHTTP)(value));
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
            if ((attribute == "Frontend"))
            {
                return new FrontendProxy(this);
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
            if ((reference == "Frontend"))
            {
                return new FrontendProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._assemblyContexts))
            {
                return "AssemblyContexts";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/mediaStore/Repository#//MediaStoreSystem")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the MediaStoreSystem class
        /// </summary>
        public class MediaStoreSystemReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private MediaStoreSystem _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public MediaStoreSystemReferencedElementsCollection(MediaStoreSystem parent)
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
                    if ((this._parent.Frontend != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.AssemblyContexts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.FrontendChanged += this.PropagateValueChanges;
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.FrontendChanged -= this.PropagateValueChanges;
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.Frontend == null))
                {
                    IHTTP frontendCasted = item.As<IHTTP>();
                    if ((frontendCasted != null))
                    {
                        this._parent.Frontend = frontendCasted;
                        return;
                    }
                }
                IAssemblyContext assemblyContextsCasted = item.As<IAssemblyContext>();
                if ((assemblyContextsCasted != null))
                {
                    this._parent.AssemblyContexts.Add(assemblyContextsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Frontend = null;
                this._parent.AssemblyContexts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.Frontend))
                {
                    return true;
                }
                if (this._parent.AssemblyContexts.Contains(item))
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
                if ((this._parent.Frontend != null))
                {
                    array[arrayIndex] = this._parent.Frontend;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<NMF.Models.IModelElement> assemblyContextsEnumerator = this._parent.AssemblyContexts.GetEnumerator();
                try
                {
                    for (
                    ; assemblyContextsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = assemblyContextsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    assemblyContextsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.Frontend == item))
                {
                    this._parent.Frontend = null;
                    return true;
                }
                IAssemblyContext assemblyContextItem = item.As<IAssemblyContext>();
                if (((assemblyContextItem != null) 
                            && this._parent.AssemblyContexts.Remove(assemblyContextItem)))
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Frontend).Concat(this._parent.AssemblyContexts).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Frontend property
        /// </summary>
        private sealed class FrontendProxy : ModelPropertyChange<IMediaStoreSystem, IHTTP>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FrontendProxy(IMediaStoreSystem modelElement) : 
                    base(modelElement, "Frontend")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IHTTP Value
            {
                get
                {
                    return this.ModelElement.Frontend;
                }
                set
                {
                    this.ModelElement.Frontend = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsAbstract property
        /// </summary>
        private sealed class IsAbstractProxy : ModelPropertyChange<NMF.Models.Meta.IClass, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsAbstractProxy(NMF.Models.Meta.IClass modelElement) : 
                    base(modelElement, "IsAbstract")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsAbstract;
                }
                set
                {
                    this.ModelElement.IsAbstract = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IdentifierScope property
        /// </summary>
        private sealed class IdentifierScopeProxy : ModelPropertyChange<NMF.Models.Meta.IClass, NMF.Models.Meta.IdentifierScope>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IdentifierScopeProxy(NMF.Models.Meta.IClass modelElement) : 
                    base(modelElement, "IdentifierScope")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IdentifierScope Value
            {
                get
                {
                    return this.ModelElement.IdentifierScope;
                }
                set
                {
                    this.ModelElement.IdentifierScope = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the InstanceOf property
        /// </summary>
        private sealed class InstanceOfProxy : ModelPropertyChange<NMF.Models.Meta.IClass, NMF.Models.Meta.IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InstanceOfProxy(NMF.Models.Meta.IClass modelElement) : 
                    base(modelElement, "InstanceOf")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IClass Value
            {
                get
                {
                    return this.ModelElement.InstanceOf;
                }
                set
                {
                    this.ModelElement.InstanceOf = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Identifier property
        /// </summary>
        private sealed class IdentifierProxy : ModelPropertyChange<NMF.Models.Meta.IClass, NMF.Models.Meta.IAttribute>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IdentifierProxy(NMF.Models.Meta.IClass modelElement) : 
                    base(modelElement, "Identifier")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IAttribute Value
            {
                get
                {
                    return this.ModelElement.Identifier;
                }
                set
                {
                    this.ModelElement.Identifier = value;
                }
            }
        }
    }
}

