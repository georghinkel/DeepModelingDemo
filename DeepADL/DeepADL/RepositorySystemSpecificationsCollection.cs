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
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace FZI.SoftwareEngineering.DeepModeling.DeepADL
{
    
    
    public class RepositorySystemSpecificationsCollection : ObservableOppositeList<IRepository, ISystemSpecification>
    {
        
        public RepositorySystemSpecificationsCollection(IRepository parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((ISystemSpecification)(sender)));
        }
        
        protected override void SetOpposite(ISystemSpecification item, IRepository parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.Repository = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.Repository == this.Parent))
                {
                    item.Repository = parent;
                }
            }
        }
    }
}

