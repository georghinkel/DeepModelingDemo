//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL;
using FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Assembly;
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

namespace FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Deployment
{
    
    
    public class EnvironmentContainersCollection : ObservableOppositeOrderedSet<IEnvironment, FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Deployment.IContainer>
    {
        
        public EnvironmentContainersCollection(IEnvironment parent) : 
                base(parent)
        {
        }
        
        private void OnItemParentChanged(object sender, ValueChangedEventArgs e)
        {
            if ((e.NewValue != this.Parent))
            {
                this.Remove(((FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Deployment.IContainer)(sender)));
            }
        }
        
        protected override void SetOpposite(FZI.SoftwareEngineering.DeepModeling.TwoLevelADL.Deployment.IContainer item, IEnvironment parent)
        {
            if ((parent != null))
            {
                item.ParentChanged += this.OnItemParentChanged;
                item.Environment = parent;
            }
            else
            {
                item.ParentChanged -= this.OnItemParentChanged;
                if ((item.Environment == this.Parent))
                {
                    item.Environment = parent;
                }
            }
        }
    }
}

