using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;

namespace ResistantPopup.Popup {
    public class CustomPopupContainerForm :PopupContainerForm {
        public CustomPopupContainerForm(PopupContainerEdit ownerEdit) : base(ownerEdit) { }

        public override bool AllowMouseClick(Control control, Point mousePosition) {
            return true;
        }
    }
}
