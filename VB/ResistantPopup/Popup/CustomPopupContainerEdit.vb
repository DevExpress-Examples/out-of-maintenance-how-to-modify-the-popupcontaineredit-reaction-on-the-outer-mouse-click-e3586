Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Popup

Namespace ResistantPopup.Popup
	Public Class CustomPopupContainerEdit
		Inherits PopupContainerEdit
		Shared Sub New()
			RepositoryItemCustomPopupContainerEdit.RegisterCustomEdtor()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomPopupContainerEdit.CustomName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomPopupContainerEdit
			Get
				Return CType(MyBase.Properties, RepositoryItemCustomPopupContainerEdit)
			End Get
		End Property

		Protected Overrides Function CreatePopupForm() As PopupBaseForm
			If Properties.PopupControl Is Nothing Then
				Return Nothing
			Else
				Return New CustomPopupContainerForm(Me)
			End If
		End Function
	End Class
End Namespace
