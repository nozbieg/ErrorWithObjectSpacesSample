using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorWithObjectSpacesSample.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Item : XPObject
    {
        public Item(Session session) : base(session)
        { }


        string itemName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ItemName
        {
            get => itemName;
            set => SetPropertyValue(nameof(ItemName), ref itemName, value);
        }
    }
}
