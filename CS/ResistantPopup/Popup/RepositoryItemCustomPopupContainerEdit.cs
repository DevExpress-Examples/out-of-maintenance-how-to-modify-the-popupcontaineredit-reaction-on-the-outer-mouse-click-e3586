using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;

namespace ResistantPopup.Popup {
    [UserRepositoryItem("RegisterCustomEditor")]
    public class RepositoryItemCustomPopupContainerEdit :RepositoryItemPopupContainerEdit {
        static RepositoryItemCustomPopupContainerEdit() {
            RegisterCustomEdtor();
        }

        internal const string CustomName = "CustomPopupContainerEdit";
        public override string EditorTypeName {
            get { return CustomName; }
        }

        public static void RegisterCustomEdtor() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomName,
                typeof(CustomPopupContainerEdit), typeof(RepositoryItemCustomPopupContainerEdit),
                typeof(PopupContainerEditViewInfo), new ButtonEditPainter(), true));
        }
    }
}
