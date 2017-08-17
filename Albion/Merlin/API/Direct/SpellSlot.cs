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
    /* Internal type: adu */
    public class SpellSlot
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private adu _internal;
        
        #region Properties
        
        public adu SpellSlot_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public float GetCooldownPercent(GameTimeStamp A_0) => _internal.j((GameTimeStamp)A_0);
        public GameTimeStamp GetCooldownTimeStamp() => _internal.l();
        public CastSpellDescriptor GetSpellDescriptor() => _internal.h();
        
        #endregion
        
        #region Constructor
        
        public SpellSlot(adu instance)
        {
            _internal = instance;
        }
        
        static SpellSlot()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator adu(SpellSlot instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SpellSlot(adu instance)
        {
            return new SpellSlot(instance);
        }
        
        #endregion
    }
}