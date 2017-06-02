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
    /// The default implementation of the Delegate class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/DeepADL/1.0")]
    [XmlNamespacePrefixAttribute("core")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/DeepADL/1.0#//Delegate")]
    [DebuggerDisplayAttribute("Delegate {Name}")]
    public partial class Delegate : NMF.Models.Meta.MetaElement, IDelegate, NMF.Models.IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _repositoryReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveRepositoryReference);
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _typeReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveTypeReference);
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        private IInterface _type;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        event EventHandler<ValueChangedEventArgs> IType.NamespaceChanged
        {
            add
            {
                IDelegate _this_Delegate = this;
                _this_Delegate.RepositoryChanged += value;
            }
            remove
            {
                IDelegate _this_Delegate = this;
                _this_Delegate.RepositoryChanged -= value;
            }
        }
        event EventHandler<ValueChangedEventArgs> IType.NamespaceChanging
        {
            add
            {
                IDelegate _this_Delegate = this;
                _this_Delegate.RepositoryChanging += value;
            }
            remove
            {
                IDelegate _this_Delegate = this;
                _this_Delegate.RepositoryChanging -= value;
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
        
        /// <summary>
        /// The Repository property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("Delegates")]
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
        
        /// <summary>
        /// The Type property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public IInterface Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    IInterface old = this._type;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanging(e);
                    this.OnPropertyChanging("Type", e, _typeReference);
                    this._type = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetType;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetType;
                    }
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e, _typeReference);
                }
            }
        }
        
        NMF.Models.Meta.INamespace NMF.Models.Meta.IType.Namespace
        {
            get
            {
                IDelegate _this = this;
                if ((_this.Repository != null))
                {
                    return _this.Repository;
                }
                return null;
            }
            set
            {
                IDelegate _this = this;
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
        
        ICollectionExpression<NMF.Models.Meta.IClass> NMF.Models.Meta.IClass.BaseTypes
        {
            get
            {
                return new DelegateBaseTypesCollection(this);
            }
        }
        
        ICollectionExpression<NMF.Models.Meta.IReference> NMF.Models.Meta.IReferenceType.References
        {
            get
            {
                return EmptyList<NMF.Models.Meta.IReference>.Instance;
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
                return base.ReferencedElements.Concat(new DelegateReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//Delegate")));
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
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveRepositoryReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(FZI.SoftwareEngineering.DeepModeling.DeepADL.Delegate.ClassInstance)).Resolve("Repository")));
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
                oldRepository.Delegates.Remove(this);
            }
            if ((newRepository != null))
            {
                newRepository.Delegates.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository, newRepository);
            this.OnRepositoryChanged(e);
            this.OnPropertyChanged("Repository", e, _repositoryReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveTypeReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(FZI.SoftwareEngineering.DeepModeling.DeepADL.Delegate.ClassInstance)).Resolve("Type")));
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
        /// Handles the event that the Type property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetType(object sender, System.EventArgs eventArgs)
        {
            this.Type = null;
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
            if ((feature == "TYPE"))
            {
                this.Type = ((IInterface)(value));
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
            if ((attribute == "Repository"))
            {
                return new RepositoryProxy(this);
            }
            if ((attribute == "Type"))
            {
                return new TypeProxy(this);
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
            if ((reference == "Repository"))
            {
                return new RepositoryProxy(this);
            }
            if ((reference == "Type"))
            {
                return new TypeProxy(this);
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//Delegate")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Delegate class
        /// </summary>
        public class DelegateReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private Delegate _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DelegateReferencedElementsCollection(Delegate parent)
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
                    if ((this._parent.Repository != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Type != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RepositoryChanged += this.PropagateValueChanges;
                this._parent.TypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RepositoryChanged -= this.PropagateValueChanges;
                this._parent.TypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.Repository == null))
                {
                    IRepository repositoryCasted = item.As<IRepository>();
                    if ((repositoryCasted != null))
                    {
                        this._parent.Repository = repositoryCasted;
                        return;
                    }
                }
                if ((this._parent.Type == null))
                {
                    IInterface typeCasted = item.As<IInterface>();
                    if ((typeCasted != null))
                    {
                        this._parent.Type = typeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Repository = null;
                this._parent.Type = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.Repository))
                {
                    return true;
                }
                if ((item == this._parent.Type))
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
                if ((this._parent.Repository != null))
                {
                    array[arrayIndex] = this._parent.Repository;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Type != null))
                {
                    array[arrayIndex] = this._parent.Type;
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
                if ((this._parent.Repository == item))
                {
                    this._parent.Repository = null;
                    return true;
                }
                if ((this._parent.Type == item))
                {
                    this._parent.Type = null;
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Repository).Concat(this._parent.Type).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Repository property
        /// </summary>
        private sealed class RepositoryProxy : ModelPropertyChange<IDelegate, IRepository>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RepositoryProxy(IDelegate modelElement) : 
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
        /// Represents a proxy to represent an incremental access to the Type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<IDelegate, IInterface>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(IDelegate modelElement) : 
                    base(modelElement, "Type")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IInterface Value
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
    }
}

