<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3586)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomPopupContainerEdit.cs](./CS/ResistantPopup/Popup/CustomPopupContainerEdit.cs) (VB: [CustomPopupContainerEdit.vb](./VB/ResistantPopup/Popup/CustomPopupContainerEdit.vb))
* [CustomPopupContainerForm.cs](./CS/ResistantPopup/Popup/CustomPopupContainerForm.cs) (VB: [CustomPopupContainerForm.vb](./VB/ResistantPopup/Popup/CustomPopupContainerForm.vb))
* [RepositoryItemCustomPopupContainerEdit.cs](./CS/ResistantPopup/Popup/RepositoryItemCustomPopupContainerEdit.cs) (VB: [RepositoryItemCustomPopupContainerEdit.vb](./VB/ResistantPopup/Popup/RepositoryItemCustomPopupContainerEdit.vb))
<!-- default file list end -->
# How to modify the PopupContainerEdit reaction on the outer mouse click


<p>By default, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemPopupContainerEdit_CloseOnOuterMouseClicktopic"><u>RepositoryItemPopupContainerEdit.CloseOnOuterMouseClick</u></a> property allows you to specify that the PopupContainerEdit should not close the pop-up window if the user clicks within another pop-up window opened by the control placed within the pop-up Form. However, there is no way to keep the pop-up window if the user clicks within the PopupContainerEdit owner Form. This example demonstrates how to create the editor inherited from the PopupContainerEdit that does not close its pop-up Form, unless the drop-down button or Escape keyboard key is pressed.</p><p>To implement this functionality, it is necessary to create a custom PopupContainerForm descendant, and override its AlllowMouseClick method. You can put any complex logic within this method to calculate whether or not the pop-up window should be closed in a certain situation. This example simply returns the True value in, any case.</p><p><strong>See also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/A1237">How to register a custom editor for use in the XtraGrid</a></p>

<br/>


