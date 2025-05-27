using System;
using System.Windows.Forms;

namespace CarRepairShop.Contractors.ContractorForm.View
{
    public interface IContractorForm
    {
        event EventHandler FormIsLoaded;
        event EventHandler FormIsClosing;
        event EventHandler ConfirmButtonClicked;
        event EventHandler CancelButtonClicked;
        string FormTitle { get; set; }
        string ContractorName { get; set; }
        string ContractorSurname { get; set; }
        string ContractorEmail { get; set; }
        string ContractorPhoneNumber { get; set; }
        void SetDialogResult(DialogResult result);
        void ShowMessage(string message);
        bool ConfirmAction(string message, string title);
        void CloseForm();
    }
}
