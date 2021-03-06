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
    /// The default implementation of the SystemArchitecture class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/DeepADL/1.0")]
    [XmlNamespacePrefixAttribute("core")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/DeepADL/1.0#//SystemArchitecture")]
    [DebuggerDisplayAttribute("SystemArchitecture {Name}")]
    public partial class SystemArchitecture : NMF.Models.Meta.Type, ISystemArchitecture, NMF.Models.IModelElement
    {
        
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
        
        public SystemArchitecture()
        {
            this._assemblyContexts = new ObservableCompositionList<IAssemblyContext>(this);
            this._assemblyContexts.CollectionChanging += this.AssemblyContextsCollectionChanging;
            this._assemblyContexts.CollectionChanged += this.AssemblyContextsCollectionChanged;
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
        
        ICollectionExpression<NMF.Models.Meta.IReference> IReferenceType.References
        {
            get
            {
                return new SystemArchitectureReferencesCollection(this);
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
        
        ICollectionExpression<NMF.Models.Meta.IClass> IClass.BaseTypes
        {
            get
            {
                return new SystemArchitectureBaseTypesCollection(this);
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
                return base.Children.Concat(new SystemArchitectureChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SystemArchitectureReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//SystemArchitecture")));
                }
                return _classInstance;
            }
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveAssemblyContextsReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(SystemArchitecture.ClassInstance)).Resolve("AssemblyContexts")));
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//SystemArchitecture")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SystemArchitecture class
        /// </summary>
        public class SystemArchitectureChildrenCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private SystemArchitecture _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SystemArchitectureChildrenCollection(SystemArchitecture parent)
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
                    count = (count + this._parent.AssemblyContexts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
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
                this._parent.AssemblyContexts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.AssemblyContexts).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SystemArchitecture class
        /// </summary>
        public class SystemArchitectureReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private SystemArchitecture _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SystemArchitectureReferencedElementsCollection(SystemArchitecture parent)
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
                    count = (count + this._parent.AssemblyContexts.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AssemblyContexts.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
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
                this._parent.AssemblyContexts.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
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
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.AssemblyContexts).GetEnumerator();
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

