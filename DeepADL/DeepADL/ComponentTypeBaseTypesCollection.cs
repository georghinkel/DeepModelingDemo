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
    /// The collection class to implement the refined BaseTypes reference for the ComponentType class
    /// </summary>
    public class ComponentTypeBaseTypesCollection : ICollectionExpression<NMF.Models.Meta.IClass>, ICollection<NMF.Models.Meta.IClass>
    {
        
        private IComponentType _parent;
        
        private static NMF.Models.Meta.IClass[] _standardValues = new NMF.Models.Meta.IClass[] {
                ((NMF.Models.Meta.IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://github.com/georghinkel/DeepADL/1.0#//AssemblyContext")))};
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public ComponentTypeBaseTypesCollection(IComponentType parent)
        {
            this._parent = parent;
            parent.ProvidedInterfaces.AsNotifiable().CollectionChanged += this.HandleCollectionChange;
        }
        
        /// <summary>
        /// Gets the amount of elements contained in this collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                int count = 1;
                count = (count + this._parent.ProvidedInterfaces.Count);
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
        public virtual void Add(NMF.Models.Meta.IClass item)
        {
            IInterface providedInterfacesCasted = item.As<IInterface>();
            if ((providedInterfacesCasted != null))
            {
                this._parent.ProvidedInterfaces.Add(providedInterfacesCasted);
            }
        }
        
        /// <summary>
        /// Clears the collection and resets all references that implement it.
        /// </summary>
        public virtual void Clear()
        {
            this._parent.ProvidedInterfaces.Clear();
        }
        
        /// <summary>
        /// Gets a value indicating whether the given element is contained in the collection
        /// </summary>
        /// <returns>True, if it is contained, otherwise False</returns>
        /// <param name="item">The item that should be looked out for</param>
        public virtual bool Contains(NMF.Models.Meta.IClass item)
        {
            if (ComponentTypeBaseTypesCollection._standardValues.Contains(item))
            {
                return true;
            }
            if (this._parent.ProvidedInterfaces.Contains(item))
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
        public virtual void CopyTo(NMF.Models.Meta.IClass[] array, int arrayIndex)
        {
            ComponentTypeBaseTypesCollection._standardValues.CopyTo(array, arrayIndex);
            arrayIndex = (arrayIndex + 1);
            IEnumerator<NMF.Models.Meta.IClass> providedInterfacesEnumerator = this._parent.ProvidedInterfaces.GetEnumerator();
            try
            {
                for (
                ; providedInterfacesEnumerator.MoveNext(); 
                )
                {
                    array[arrayIndex] = providedInterfacesEnumerator.Current;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            finally
            {
                providedInterfacesEnumerator.Dispose();
            }
        }
        
        /// <summary>
        /// Removes the given item from the collection
        /// </summary>
        /// <returns>True, if the item was removed, otherwise False</returns>
        /// <param name="item">The item that should be removed</param>
        public virtual bool Remove(NMF.Models.Meta.IClass item)
        {
            IInterface interfaceItem = item.As<IInterface>();
            if (((interfaceItem != null) 
                        && this._parent.ProvidedInterfaces.Remove(interfaceItem)))
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Gets an enumerator that enumerates the collection
        /// </summary>
        /// <returns>A generic enumerator</returns>
        public virtual IEnumerator<NMF.Models.Meta.IClass> GetEnumerator()
        {
            return ComponentTypeBaseTypesCollection._standardValues.Cast<NMF.Models.Meta.IClass>().Concat(this._parent.ProvidedInterfaces).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyCollection<NMF.Models.Meta.IClass> ICollectionExpression<NMF.Models.Meta.IClass>.AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable<NMF.Models.Meta.IClass> IEnumerableExpression<NMF.Models.Meta.IClass>.AsNotifiable()
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

