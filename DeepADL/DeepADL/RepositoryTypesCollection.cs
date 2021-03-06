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
    /// The collection class to implement the refined Types reference for the Repository class
    /// </summary>
    public class RepositoryTypesCollection : ICollectionExpression<NMF.Models.Meta.IType>, ICollection<NMF.Models.Meta.IType>
    {
        
        private IRepository _parent;
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public RepositoryTypesCollection(IRepository parent)
        {
            this._parent = parent;
            parent.ComponentTypes.AsNotifiable().CollectionChanged += this.HandleCollectionChange;
            parent.Interfaces.AsNotifiable().CollectionChanged += this.HandleCollectionChange;
            parent.SystemSpecifications.AsNotifiable().CollectionChanged += this.HandleCollectionChange;
            parent.Delegates.AsNotifiable().CollectionChanged += this.HandleCollectionChange;
        }
        
        /// <summary>
        /// Gets the amount of elements contained in this collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                int count = 0;
                count = (count + this._parent.ComponentTypes.Count);
                count = (count + this._parent.Interfaces.Count);
                count = (count + this._parent.SystemSpecifications.Count);
                count = (count + this._parent.Delegates.Count);
                return count;
            }
        }
        
        /// <summary>
        /// Gets a value indicating that the collection is not read-only
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        
        /// <summary>
        /// Returns that this composed collection is always attached.
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired when the contents of this collection changes
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        
        /// <summary>
        /// Fires the CollectionChanged event
        /// </summary>
        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
        {
            System.Collections.Specialized.NotifyCollectionChangedEventHandler handler = this.CollectionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private void HandleCollectionChange(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
        {
            this.OnCollectionChanged(eventArgs);
        }
        
        /// <summary>
        /// Adds the given element to the collection
        /// </summary>
        /// <param name="item">The item to add</param>
        public virtual void Add(NMF.Models.Meta.IType item)
        {
            IComponentType componentTypesCasted = item.As<IComponentType>();
            if ((componentTypesCasted != null))
            {
                this._parent.ComponentTypes.Add(componentTypesCasted);
            }
            IInterface interfacesCasted = item.As<IInterface>();
            if ((interfacesCasted != null))
            {
                this._parent.Interfaces.Add(interfacesCasted);
            }
            ISystemSpecification systemSpecificationsCasted = item.As<ISystemSpecification>();
            if ((systemSpecificationsCasted != null))
            {
                this._parent.SystemSpecifications.Add(systemSpecificationsCasted);
            }
            IDelegate delegatesCasted = item.As<IDelegate>();
            if ((delegatesCasted != null))
            {
                this._parent.Delegates.Add(delegatesCasted);
            }
        }
        
        /// <summary>
        /// Clears the collection and resets all references that implement it.
        /// </summary>
        public virtual void Clear()
        {
            this._parent.ComponentTypes.Clear();
            this._parent.Interfaces.Clear();
            this._parent.SystemSpecifications.Clear();
            this._parent.Delegates.Clear();
        }
        
        /// <summary>
        /// Gets a value indicating whether the given element is contained in the collection
        /// </summary>
        /// <returns>True, if it is contained, otherwise False</returns>
        /// <param name="item">The item that should be looked out for</param>
        public virtual bool Contains(NMF.Models.Meta.IType item)
        {
            if (this._parent.ComponentTypes.Contains(item))
            {
                return true;
            }
            if (this._parent.Interfaces.Contains(item))
            {
                return true;
            }
            if (this._parent.SystemSpecifications.Contains(item))
            {
                return true;
            }
            if (this._parent.Delegates.Contains(item))
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
        public virtual void CopyTo(NMF.Models.Meta.IType[] array, int arrayIndex)
        {
            IEnumerator<NMF.Models.Meta.IType> componentTypesEnumerator = this._parent.ComponentTypes.GetEnumerator();
            try
            {
                for (
                ; componentTypesEnumerator.MoveNext(); 
                )
                {
                    array[arrayIndex] = componentTypesEnumerator.Current;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            finally
            {
                componentTypesEnumerator.Dispose();
            }
            IEnumerator<NMF.Models.Meta.IType> interfacesEnumerator = this._parent.Interfaces.GetEnumerator();
            try
            {
                for (
                ; interfacesEnumerator.MoveNext(); 
                )
                {
                    array[arrayIndex] = interfacesEnumerator.Current;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            finally
            {
                interfacesEnumerator.Dispose();
            }
            IEnumerator<NMF.Models.Meta.IType> systemSpecificationsEnumerator = this._parent.SystemSpecifications.GetEnumerator();
            try
            {
                for (
                ; systemSpecificationsEnumerator.MoveNext(); 
                )
                {
                    array[arrayIndex] = systemSpecificationsEnumerator.Current;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            finally
            {
                systemSpecificationsEnumerator.Dispose();
            }
            IEnumerator<NMF.Models.Meta.IType> delegatesEnumerator = this._parent.Delegates.GetEnumerator();
            try
            {
                for (
                ; delegatesEnumerator.MoveNext(); 
                )
                {
                    array[arrayIndex] = delegatesEnumerator.Current;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            finally
            {
                delegatesEnumerator.Dispose();
            }
        }
        
        /// <summary>
        /// Removes the given item from the collection
        /// </summary>
        /// <returns>True, if the item was removed, otherwise False</returns>
        /// <param name="item">The item that should be removed</param>
        public virtual bool Remove(NMF.Models.Meta.IType item)
        {
            IComponentType componentTypeItem = item.As<IComponentType>();
            if (((componentTypeItem != null) 
                        && this._parent.ComponentTypes.Remove(componentTypeItem)))
            {
                return true;
            }
            IInterface interfaceItem = item.As<IInterface>();
            if (((interfaceItem != null) 
                        && this._parent.Interfaces.Remove(interfaceItem)))
            {
                return true;
            }
            ISystemSpecification systemSpecificationItem = item.As<ISystemSpecification>();
            if (((systemSpecificationItem != null) 
                        && this._parent.SystemSpecifications.Remove(systemSpecificationItem)))
            {
                return true;
            }
            IDelegate delegateItem = item.As<IDelegate>();
            if (((delegateItem != null) 
                        && this._parent.Delegates.Remove(delegateItem)))
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Gets an enumerator that enumerates the collection
        /// </summary>
        /// <returns>A generic enumerator</returns>
        public virtual IEnumerator<NMF.Models.Meta.IType> GetEnumerator()
        {
            return Enumerable.Empty<NMF.Models.Meta.IType>().Concat(this._parent.ComponentTypes).Concat(this._parent.Interfaces).Concat(this._parent.SystemSpecifications).Concat(this._parent.Delegates).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        public virtual INotifyCollection<NMF.Models.Meta.IType> AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable<NMF.Models.Meta.IType> IEnumerableExpression<NMF.Models.Meta.IType>.AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable IEnumerableExpression.AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Attaches this collection class
        /// </summary>
        public void Attach()
        {
        }
        
        /// <summary>
        /// Detaches this collection class
        /// </summary>
        public void Detach()
        {
        }
    }
}

