//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpRepository.Tests.Integration.DynamicProxyObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class MainItem
    {
        public int MainItemId { get; set; }
        public string Name { get; set; }
        public int SomeTypeId { get; set; }
    
        public virtual SomeType SomeType { get; set; }
    }
}