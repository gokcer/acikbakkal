﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace AcikBakkal.Module.BusinessObjects.Biz
{

    public partial class Product : XPObject
    {
        string fName;
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        Category fCategory;
        public Category Category
        {
            get { return fCategory; }
            set { SetPropertyValue<Category>(nameof(Category), ref fCategory, value); }
        }
        [Association(@"ShopProductReferencesProduct")]
        public XPCollection<ShopProduct> ShopProducts { get { return GetCollection<ShopProduct>(nameof(ShopProducts)); } }
    }

}
