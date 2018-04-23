Imports Microsoft.VisualBasic
Imports System
Namespace ResistantPopup
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.customPopupContainerEdit1 = New ResistantPopup.Popup.CustomPopupContainerEdit()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			CType(Me.customPopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl1.SuspendLayout()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customPopupContainerEdit1
			' 
			Me.customPopupContainerEdit1.Location = New System.Drawing.Point(13, 13)
			Me.customPopupContainerEdit1.Name = "customPopupContainerEdit1"
			Me.customPopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.customPopupContainerEdit1.Properties.PopupControl = Me.popupContainerControl1
			Me.customPopupContainerEdit1.Size = New System.Drawing.Size(100, 20)
			Me.customPopupContainerEdit1.TabIndex = 0
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Controls.Add(Me.buttonEdit1)
			Me.popupContainerControl1.Location = New System.Drawing.Point(28, 61)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(200, 100)
			Me.popupContainerControl1.TabIndex = 1
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(4, 4)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(100, 20)
			Me.buttonEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 268)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Controls.Add(Me.customPopupContainerEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.customPopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl1.ResumeLayout(False)
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customPopupContainerEdit1 As ResistantPopup.Popup.CustomPopupContainerEdit
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit

	End Class
End Namespace

