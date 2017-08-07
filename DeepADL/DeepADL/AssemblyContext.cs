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
    /// The default implementation of the AssemblyContext class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/georghinkel/DeepADL/1.0")]
    [XmlNamespacePrefixAttribute("core")]
    [ModelRepresentationClassAttribute("http://github.com/georghinkel/DeepADL/1.0#//AssemblyContext")]
    [DebuggerDisplayAttribute("AssemblyContext {Name}")]
    public abstract partial class AssemblyContext : NMF.Models.Meta.MetaElement, IAssemblyContext, NMF.Models.IModelElement
    {
        
        private static Lazy<NMF.Models.Meta.IReferenceType> _ReferenceType = new Lazy<NMF.Models.Meta.IReferenceType>(RetrieveReferenceType);
        
        private static Lazy<NMF.Models.Meta.ITypedElement> _declaringTypeReference = new Lazy<NMF.Models.Meta.ITypedElement>(RetrieveDeclaringTypeReference);
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        event EventHandler<ValueChangedEventArgs> IReference.OppositeChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.OppositeChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.AnchorChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.AnchorChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.RefinesChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.RefinesChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.ReferenceTypeChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.ReferenceTypeChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.LowerBoundChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.LowerBoundChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.UpperBoundChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.UpperBoundChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.IsContainmentChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> IReference.IsContainmentChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.IsOrderedChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.IsOrderedChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.IsUniqueChanged
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.IsUniqueChanging
        {
            add
            {
            }
            remove
            {
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.TypeChanged
        {
            add
            {
                IReference _this_IReference = this;
                _this_IReference.ReferenceTypeChanged += value;
            }
            remove
            {
                IReference _this_IReference = this;
                _this_IReference.ReferenceTypeChanged -= value;
            }
        }
        event EventHandler<ValueChangedEventArgs> ITypedElement.TypeChanging
        {
            add
            {
                IReference _this_IReference = this;
                _this_IReference.ReferenceTypeChanging += value;
            }
            remove
            {
                IReference _this_IReference = this;
                _this_IReference.ReferenceTypeChanging -= value;
            }
        }
        
        NMF.Models.Meta.IReference IReference.Opposite
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
        
        NMF.Models.Meta.IClass IReference.Anchor
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
        
        NMF.Models.Meta.IReference IReference.Refines
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
        
        NMF.Models.Meta.IReferenceType IReference.ReferenceType
        {
            get
            {
                return _ReferenceType.Value;
            }
            set
            {
                if ((value != _ReferenceType.Value))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        int ITypedElement.LowerBound
        {
            get
            {
                return 1;
            }
            set
            {
                if ((value != 1))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        int ITypedElement.UpperBound
        {
            get
            {
                return 1;
            }
            set
            {
                if ((value != 1))
                {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        bool IReference.IsContainment
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
        
        bool ITypedElement.IsOrdered
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
        
        bool ITypedElement.IsUnique
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
        /// The DeclaringType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("References")]
        public NMF.Models.Meta.IReferenceType DeclaringType
        {
            get
            {
                return ModelHelper.CastAs<NMF.Models.Meta.IReferenceType>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        NMF.Models.Meta.IType ITypedElement.Type
        {
            get
            {
                NMF.Models.Meta.IReference _this = this;
                if ((_this.ReferenceType != null))
                {
                    return _this.ReferenceType;
                }
                return null;
            }
            set
            {
                NMF.Models.Meta.IReference _this = this;
                if ((value != null))
                {
                    IReferenceType @__ReferenceType = value.As<IReferenceType>();
                    if ((@__ReferenceType != null))
                    {
                        _this.ReferenceType = @__ReferenceType;
                        return;
                    }
                }
                else
                {
                    _this.ReferenceType = null;
                    return;
                }
                throw new System.ArgumentException("There was no suitable refining reference found for this object");
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//AssemblyContext")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the DeclaringType property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanging;
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
        
        /// <summary>
        /// Gets the ComponentType for this model element
        /// </summary>
        public abstract IComponentType GetComponentType();
        
        /// <summary>
        /// Gets the referenced value for a RequiredInterfaces of the enclosing ComponentType.
        /// </summary>
        [ObservableProxyAttribute(typeof(IAssemblyContext), "GetRequiredInterfacesProxy")]
        public abstract IAssemblyContext GetRequiredInterfacesValue(IRequiredInterface reference);
        
        /// <summary>
        /// Gets a proxy for the referenced value for a RequiredInterfaces of the enclosing ComponentType.
        /// </summary>
        public abstract INotifyValue<IAssemblyContext> GetRequiredInterfacesProxy(IRequiredInterface reference);
        
        private static NMF.Models.Meta.IReferenceType RetrieveReferenceType()
        {
            return NMF.Models.Repository.MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//ResourceContainer").As<NMF.Models.Meta.IReferenceType>();
        }
        
        private static NMF.Models.Meta.ITypedElement RetrieveDeclaringTypeReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.Meta.Reference.ClassInstance)).Resolve("DeclaringType")));
        }
        
        /// <summary>
        /// Raises the DeclaringTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeclaringTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeclaringTypeChanging;
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
            NMF.Models.Meta.IReferenceType oldDeclaringType = ModelHelper.CastAs<NMF.Models.Meta.IReferenceType>(oldParent);
            NMF.Models.Meta.IReferenceType newDeclaringType = ModelHelper.CastAs<NMF.Models.Meta.IReferenceType>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldDeclaringType, newDeclaringType);
            this.OnDeclaringTypeChanging(e);
            this.OnPropertyChanging("DeclaringType", e, _declaringTypeReference);
        }
        
        /// <summary>
        /// Raises the DeclaringTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeclaringTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.DeclaringTypeChanged;
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
            NMF.Models.Meta.IReferenceType oldDeclaringType = ModelHelper.CastAs<NMF.Models.Meta.IReferenceType>(oldParent);
            NMF.Models.Meta.IReferenceType newDeclaringType = ModelHelper.CastAs<NMF.Models.Meta.IReferenceType>(newParent);
            if ((oldDeclaringType != null))
            {
                oldDeclaringType.References.Remove(this);
            }
            if ((newDeclaringType != null))
            {
                newDeclaringType.References.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldDeclaringType, newDeclaringType);
            this.OnDeclaringTypeChanged(e);
            this.OnPropertyChanged("DeclaringType", e, _declaringTypeReference);
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
            if ((reference == "DECLARINGTYPE"))
            {
                return this.DeclaringType;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "DECLARINGTYPE"))
            {
                this.DeclaringType = ((NMF.Models.Meta.IReferenceType)(value));
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
            if ((reference == "DECLARINGTYPE"))
            {
                return new DeclaringTypeProxy(this);
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//AssemblyContext")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsOrdered property
        /// </summary>
        private sealed class IsOrderedProxy : ModelPropertyChange<NMF.Models.Meta.ITypedElement, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsOrderedProxy(NMF.Models.Meta.ITypedElement modelElement) : 
                    base(modelElement, "IsOrdered")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsOrdered;
                }
                set
                {
                    this.ModelElement.IsOrdered = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the IsUnique property
        /// </summary>
        private sealed class IsUniqueProxy : ModelPropertyChange<NMF.Models.Meta.ITypedElement, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsUniqueProxy(NMF.Models.Meta.ITypedElement modelElement) : 
                    base(modelElement, "IsUnique")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsUnique;
                }
                set
                {
                    this.ModelElement.IsUnique = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the LowerBound property
        /// </summary>
        private sealed class LowerBoundProxy : ModelPropertyChange<NMF.Models.Meta.ITypedElement, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LowerBoundProxy(NMF.Models.Meta.ITypedElement modelElement) : 
                    base(modelElement, "LowerBound")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.LowerBound;
                }
                set
                {
                    this.ModelElement.LowerBound = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the UpperBound property
        /// </summary>
        private sealed class UpperBoundProxy : ModelPropertyChange<NMF.Models.Meta.ITypedElement, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UpperBoundProxy(NMF.Models.Meta.ITypedElement modelElement) : 
                    base(modelElement, "UpperBound")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.UpperBound;
                }
                set
                {
                    this.ModelElement.UpperBound = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<NMF.Models.Meta.ITypedElement, NMF.Models.Meta.IType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(NMF.Models.Meta.ITypedElement modelElement) : 
                    base(modelElement, "Type")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IType Value
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
        /// Represents a proxy to represent an incremental access to the IsContainment property
        /// </summary>
        private sealed class IsContainmentProxy : ModelPropertyChange<NMF.Models.Meta.IReference, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IsContainmentProxy(NMF.Models.Meta.IReference modelElement) : 
                    base(modelElement, "IsContainment")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.IsContainment;
                }
                set
                {
                    this.ModelElement.IsContainment = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DeclaringType property
        /// </summary>
        private sealed class DeclaringTypeProxy : ModelPropertyChange<NMF.Models.Meta.IReference, NMF.Models.Meta.IReferenceType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DeclaringTypeProxy(NMF.Models.Meta.IReference modelElement) : 
                    base(modelElement, "DeclaringType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IReferenceType Value
            {
                get
                {
                    return this.ModelElement.DeclaringType;
                }
                set
                {
                    this.ModelElement.DeclaringType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Opposite property
        /// </summary>
        private sealed class OppositeProxy : ModelPropertyChange<NMF.Models.Meta.IReference, NMF.Models.Meta.IReference>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OppositeProxy(NMF.Models.Meta.IReference modelElement) : 
                    base(modelElement, "Opposite")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IReference Value
            {
                get
                {
                    return this.ModelElement.Opposite;
                }
                set
                {
                    this.ModelElement.Opposite = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ReferenceType property
        /// </summary>
        private sealed class ReferenceTypeProxy : ModelPropertyChange<NMF.Models.Meta.IReference, NMF.Models.Meta.IReferenceType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferenceTypeProxy(NMF.Models.Meta.IReference modelElement) : 
                    base(modelElement, "ReferenceType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IReferenceType Value
            {
                get
                {
                    return this.ModelElement.ReferenceType;
                }
                set
                {
                    this.ModelElement.ReferenceType = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Refines property
        /// </summary>
        private sealed class RefinesProxy : ModelPropertyChange<NMF.Models.Meta.IReference, NMF.Models.Meta.IReference>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RefinesProxy(NMF.Models.Meta.IReference modelElement) : 
                    base(modelElement, "Refines")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IReference Value
            {
                get
                {
                    return this.ModelElement.Refines;
                }
                set
                {
                    this.ModelElement.Refines = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Anchor property
        /// </summary>
        private sealed class AnchorProxy : ModelPropertyChange<NMF.Models.Meta.IReference, NMF.Models.Meta.IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AnchorProxy(NMF.Models.Meta.IReference modelElement) : 
                    base(modelElement, "Anchor")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.Meta.IClass Value
            {
                get
                {
                    return this.ModelElement.Anchor;
                }
                set
                {
                    this.ModelElement.Anchor = value;
                }
            }
        }
    }
}

