Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup

Namespace ResistantPopup.Popup
	Public Class CustomPopupContainerForm
		Inherits PopupContainerForm
		Public Sub New(ByVal ownerEdit As PopupContainerEdit)
			MyBase.New(ownerEdit)
		End Sub

		Public Overrides Function AllowMouseClick(ByVal control As Control, ByVal mousePosition As Point) As Boolean
			Return True
		End Function
	End Class
End Namespace
