using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorWithObjectSpacesSample.Module.BusinessObjects.DomainComponent
{
    [DomainComponent]
    public class BaseDC : NonPersistentBaseObject
    {
        public BaseDC()
        {

        }


        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(ref name, value);
        }

        public IList<ItemDC> Items;
    }
}
