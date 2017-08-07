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
    /// The default implementation of the Interface class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/DeepADL/1.0")]
    [XmlNamespacePrefixAttribute("core")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/DeepADL/1.0#//Interface")]
    [DebuggerDisplayAttribute("Interface {Name}")]
    public partial class Interface : NMF.Models.Meta.MetaElement, IInterface, NMF.Models.IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _signaturesReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveSignaturesReference);
        
        /// <summary>
        /// The backing field for the Signatures property
        /// </summary>
        private ObservableCompositionList<ISignature> _signatures;
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _repositoryReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveRepositoryReference);
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        event EventHandler<ValueChangedEventArgs> IType.NamespaceChanged
        {
            add
            {
                IInterface _this_IInterface = this;
                _this_IInterface.RepositoryChanged += value;
            }
            remove
            {
                IInterface _this_IInterface = this;
                _this_IInterface.RepositoryChanged -= value;
            }
        }
        event EventHandler<ValueChangedEventArgs> IType.NamespaceChanging
        {
            add
            {
                IInterface _this_IInterface = this;
                _this_IInterface.RepositoryChanging += value;
            }
            remove
            {
                IInterface _this_IInterface = this;
                _this_IInterface.RepositoryChanging -= value;
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
        
        public Interface()
        {
            this._signatures = new ObservableCompositionList<ISignature>(this);
            this._signatures.CollectionChanging += this.SignaturesCollectionChanging;
            this._signatures.CollectionChanged += this.SignaturesCollectionChanged;
        }
        
        /// <summary>
        /// The Signatures property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public ICollectionExpression<ISignature> Signatures
        {
            get
            {
                return this._signatures;
            }
        }
        
        /// <summary>
        /// The Repository property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Interfaces")]
        public IRepository Repository
        {
            get
            {
                return ModelHelper.CastAs<IRepository>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        NMF.Models.Meta.INamespace IType.Namespace
        {
            get
            {
                IInterface _this = this;
                if ((_this.Repository != null))
                {
                    return _this.Repository;
                }
                return null;
            }
            set
            {
                IInterface _this = this;
                if ((value != null))
                {
                    IRepository @__Repository = value.As<IRepository>();
                    if ((@__Repository != null))
                    {
                        _this.Repository = @__Repository;
                        return;
                    }
                }
                else
                {
                    _this.Repository = null;
                    return;
                }
                throw new System.ArgumentException("There was no suitable refining reference found for this object");
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IReference> IReferenceType.References
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IReference>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IReferenceConstraint> IClass.ReferenceConstraints
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IReferenceConstraint>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IAttribute> IStructuredType.Attributes
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IAttribute>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IAttributeConstraint> IClass.AttributeConstraints
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IAttributeConstraint>.Instance;
            }
        }
        
        NMF.Models.Meta.IClass IClass.InstanceOf
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
        
        ICollectionExpression<NMF.Models.Meta.IEvent> IReferenceType.Events
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IEvent>.Instance;
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IOperation> IStructuredType.Operations
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IOperation>.Instance;
            }
        }
        
        NMF.Models.Meta.IAttribute IClass.Identifier
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
        
        ICollectionExpression<NMF.Models.Meta.IClass> IClass.BaseTypes
        {
            get
            {
                return new InterfaceBaseTypesCollection(this);
            }
        }
        
        NMF.Models.Meta.IdentifierScope IClass.IdentifierScope
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
        
        bool IClass.IsAbstract
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
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new InterfaceChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new InterfaceReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//Interface")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Repository property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RepositoryChanging;
        
        /// <summary>
        /// Gets fired when the Repository property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RepositoryChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveSignaturesReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(Interface.ClassInstance)).Resolve("Signatures")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Signatures property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SignaturesCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Signatures", e, _signaturesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Signatures property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SignaturesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Signatures", e, _signaturesReference);
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveRepositoryReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(Interface.ClassInstance)).Resolve("Repository")));
        }
        
        /// <summary>
        /// Raises the RepositoryChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepositoryChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RepositoryChanging;
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
            IRepository oldRepository = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository = ModelHelper.CastAs<IRepository>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository, newRepository);
            this.OnRepositoryChanging(e);
            this.OnPropertyChanging("Repository", e, _repositoryReference);
        }
        
        /// <summary>
        /// Raises the RepositoryChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepositoryChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RepositoryChanged;
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
            IRepository oldRepository = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository = ModelHelper.CastAs<IRepository>(newParent);
            if ((oldRepository != null))
            {
                oldRepository.Interfaces.Remove(this);
            }
            if ((newRepository != null))
            {
                newRepository.Interfaces.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository, newRepository);
            this.OnRepositoryChanged(e);
            this.OnPropertyChanged("Repository", e, _repositoryReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "REPOSITORY"))
            {
                return this.Repository;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "SIGNATURES"))
            {
                return this._signatures;
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
            if ((feature == "REPOSITORY"))
            {
                this.Repository = ((IRepository)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "REPOSITORY"))
            {
                return new RepositoryProxy(this);
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
            if ((container == this._signatures))
            {
                return "Signatures";
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//Interface")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Interface class
        /// </summary>
        public class InterfaceChildrenCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Interface _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public InterfaceChildrenCollection(Interface parent)
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
                    count = (count + this._parent.Signatures.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Signatures.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Signatures.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                ISignature signaturesCasted = item.As<ISignature>();
                if ((signaturesCasted != null))
                {
                    this._parent.Signatures.Add(signaturesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Signatures.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if (this._parent.Signatures.Contains(item))
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
                IEnumerator<NMF.Models.IModelElement> signaturesEnumerator = this._parent.Signatures.GetEnumerator();
                try
                {
                    for (
                    ; signaturesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = signaturesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    signaturesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                ISignature signatureItem = item.As<ISignature>();
                if (((signatureItem != null) 
                            && this._parent.Signatures.Remove(signatureItem)))
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Signatures).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Interface class
        /// </summary>
        public class InterfaceReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Interface _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public InterfaceReferencedElementsCollection(Interface parent)
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
                    count = (count + this._parent.Signatures.Count);
                    if ((this._parent.Repository != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Signatures.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.RepositoryChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Signatures.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.RepositoryChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                ISignature signaturesCasted = item.As<ISignature>();
                if ((signaturesCasted != null))
                {
                    this._parent.Signatures.Add(signaturesCasted);
                }
                if ((this._parent.Repository == null))
                {
                    IRepository repositoryCasted = item.As<IRepository>();
                    if ((repositoryCasted != null))
                    {
                        this._parent.Repository = repositoryCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Signatures.Clear();
                this._parent.Repository = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if (this._parent.Signatures.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Repository))
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
                IEnumerator<NMF.Models.IModelElement> signaturesEnumerator = this._parent.Signatures.GetEnumerator();
                try
                {
                    for (
                    ; signaturesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = signaturesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    signaturesEnumerator.Dispose();
                }
                if ((this._parent.Repository != null))
                {
                    array[arrayIndex] = this._parent.Repository;
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
                ISignature signatureItem = item.As<ISignature>();
                if (((signatureItem != null) 
                            && this._parent.Signatures.Remove(signatureItem)))
                {
                    return true;
                }
                if ((this._parent.Repository == item))
                {
                    this._parent.Repository = null;
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Signatures).Concat(this._parent.Repository).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Repository property
        /// </summary>
        private sealed class RepositoryProxy : ModelPropertyChange<IInterface, IRepository>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RepositoryProxy(IInterface modelElement) : 
                    base(modelElement, "Repository")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRepository Value
            {
                get
                {
                    return this.ModelElement.Repository;
                }
                set
                {
                    this.ModelElement.Repository = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Namespace property
        /// </summary>
        private sealed class NamespaceProxy : ModelPropertyChange<NMF.Models.Meta.IType, NMF.Models.Meta.INamespace>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NamespaceProxy(NMF.Models.Meta.IType modelElement) : 
                    base(modelElement, "Namespace")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.INamespace Value
            {
                get
                {
                    return this.ModelElement.Namespace;
                }
                set
                {
                    this.ModelElement.Namespace = value;
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

