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

    public partial class Order : XPObject
    {
        Shop fShop;
        [Association(@"OrderReferencesShop")]
        public Shop Shop
        {
            get { return fShop; }
            set { SetPropertyValue<Shop>(nameof(Shop), ref fShop, value); }
        }
        Customer fCustomer;
        [Association(@"OrderReferencesCustomer")]
        public Customer Customer
        {
            get { return fCustomer; }
            set { SetPropertyValue<Customer>(nameof(Customer), ref fCustomer, value); }
        }
        DateTime fDate;
        public DateTime Date
        {
            get { return fDate; }
            set { SetPropertyValue<DateTime>(nameof(Date), ref fDate, value); }
        }
        string fNote;
        public string Note
        {
            get { return fNote; }
            set { SetPropertyValue<string>(nameof(Note), ref fNote, value); }
        }
        decimal fTotal;
        public decimal Total
        {
            get { return fTotal; }
            set { SetPropertyValue<decimal>(nameof(Total), ref fTotal, value); }
        }
        [Association(@"OrderDetailReferencesOrder")]
        public XPCollection<OrderDetail> OrderDetails { get { return GetCollection<OrderDetail>(nameof(OrderDetails)); } }
    }

}
