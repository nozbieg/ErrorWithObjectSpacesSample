using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Xpo;

namespace ErrorWithObjectSpacesSample.Module.BusinessObjects.DomainComponent
{
    [DomainComponent]
    public class ItemDC : NonPersistentBaseObject
    {
        public ItemDC()
        {
        }


        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(ref name, value);
        }
    }
}
