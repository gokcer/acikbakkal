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

    public partial class PhoneVerification : XPObject
    {
        string fPhone;
        public string Phone
        {
            get { return fPhone; }
            set { SetPropertyValue<string>(nameof(Phone), ref fPhone, value); }
        }
        string fVerificationCode;
        public string VerificationCode
        {
            get { return fVerificationCode; }
            set { SetPropertyValue<string>(nameof(VerificationCode), ref fVerificationCode, value); }
        }
        DateTime fDate;
        public DateTime Date
        {
            get { return fDate; }
            set { SetPropertyValue<DateTime>(nameof(Date), ref fDate, value); }
        }
        bool fConsumed;
        public bool Consumed
        {
            get { return fConsumed; }
            set { SetPropertyValue<bool>(nameof(Consumed), ref fConsumed, value); }
        }
    }

}
