////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: a4x */
    public partial class Utilities
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private a4x _internal;
        
        #region Properties
        
        public a4x Utilities_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public static ItemStackProxy GetStackProxy(ItemProxy A_0) => a4x.a((aro)A_0);
        public int SomeCalculationWithUnfloatyFloats(UnfloatyFloat A_0, UnfloatyFloat A_1) => a4x.b((mv)A_0, (mv)A_1);
        
        #endregion
        
        #region Constructor
        
        public Utilities(a4x instance)
        {
            _internal = instance;
        }
        
        static Utilities()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a4x(Utilities instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Utilities(a4x instance)
        {
            return new Utilities(instance);
        }
        
        public static implicit operator bool(Utilities instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
