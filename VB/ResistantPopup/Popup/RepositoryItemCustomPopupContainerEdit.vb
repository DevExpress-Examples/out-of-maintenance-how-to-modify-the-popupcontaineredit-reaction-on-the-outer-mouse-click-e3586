Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator

Namespace ResistantPopup.Popup
	<UserRepositoryItem("RegisterCustomEditor")> _
	Public Class RepositoryItemCustomPopupContainerEdit
		Inherits RepositoryItemPopupContainerEdit
		Shared Sub New()
			RegisterCustomEdtor()
		End Sub

		Friend Const CustomName As String = "CustomPopupContainerEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomName
			End Get
		End Property

		Public Shared Sub RegisterCustomEdtor()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomName, GetType(CustomPopupContainerEdit), GetType(RepositoryItemCustomPopupContainerEdit), GetType(PopupContainerEditViewInfo), New ButtonEditPainter(), True))
		End Sub
	End Class
End Namespace
