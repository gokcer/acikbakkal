using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace AcikBakkal.Module.BusinessObjects.Biz
{

    public partial class ShopProduct
    {
        public ShopProduct(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
