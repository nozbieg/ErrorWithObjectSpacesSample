using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using ErrorWithObjectSpacesSample.Module.BusinessObjects;
using ErrorWithObjectSpacesSample.Module.BusinessObjects.DomainComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorWithObjectSpacesSample.Module.Controllers
{
    public class PersonListViewController : ObjectViewController<ListView, Person>
    {
        PopupWindowShowAction newDCPopupAction;
        BaseDC baseDC;

        public PersonListViewController()
        {
            newDCPopupAction = new PopupWindowShowAction(this,
               $"{ GetType().FullName}.{nameof(newDCPopupAction)}",
               DevExpress.Persistent.Base.PredefinedCategory.RecordEdit)
            {
                Caption = "New BaseDC",
                ImageName = "BO_Skull",
            };
            newDCPopupAction.CustomizePopupWindowParams += NewDCPopupAction_CustomizePopupWindowParams;
        }

        private void NewDCPopupAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(NonPersistentBaseObject));
            baseDC = objectSpace.CreateObject<BaseDC>();
            baseDC.Name = "Base";
            baseDC.Items = GetItemsToItemsDC(objectSpace);
            objectSpace.CommitChanges();

            DetailView view = Application.CreateDetailView(objectSpace, baseDC);
            view.ViewEditMode = ViewEditMode.Edit;
            e.View = view;
        }

        private IList<ItemDC> GetItemsToItemsDC(IObjectSpace objectSpace)
        {
            var itemList = objectSpace.GetObjectsQuery<Item>();
            var returnList = new List<ItemDC>();
            foreach (var item in itemList)
            {
                var itemDC = objectSpace.CreateObject<ItemDC>();
                itemDC.Name = item.ItemName;
                returnList.Add(itemDC);
            }

            return returnList;
        }
    }
}
