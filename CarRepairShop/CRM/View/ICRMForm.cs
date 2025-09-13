using CarRepairShop.CRM.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.CRM.View
{
    public interface ICRMForm
    {
        event EventHandler FormIsLoaded;
        event EventHandler ComboboxSelectionChanged;
        event EventHandler VehiclesDataGridViewCellClick;
        event EventHandler RequiredServicesDataGridViewCellClick;
        event EventHandler IncreaseQuantityButtonClicked;
        event EventHandler DecreaseQuantityButtonClicked;
        event EventHandler ConfirmButtonClicked;
        event EventHandler CancelButtonClicked;
        event EventHandler TaskClosedCheckBoxCheckedChanged;
        event EventHandler<FormClosedEventArgs> FormIsClosed;
        int SelectedContractorID { get; set; }
        int SelectedVehicleID { get; set; }
        List<int> SelectedRequiredServiceID { get; set; }
        int SelectedServiceID { get; }
        Dictionary<int, int> SelectedServiceQuantities { get; }
        DateTime CreationDate { get; set; }
        DateTime CloseDate { get; set; }
        int MechanicID { get; set; }
        string MechanicName { get; set; }
        string MechanicSurname { get; set; }
        string TaskComment { get; set; }
        decimal TotalPrice { get; set; }
        bool TaskClosed { get; set; }
        DialogResult OperationConfirmed { get; set; }

        CRMFormResult Result { get; }
        void LoadContractors(List<Models.ContractorModel> contractors);
        void LoadContractorVehicles(List<Domain.Entities.ContractorsCars> contractorsCars);
        void LoadRequiredServices(List<Domain.Entities.Services> services);
        void LoadSelectedServices(List<Models.RequiredServicesModel> services);
        void SelectAllSelectedServices();
        void ChangeTaskStatus(bool taskClosed);
        void CloseForm();
        void ShowMessage(string message, string title);
        bool ConfirmAction(string message, string title);
        void ChangeTaskClosedAccesability(bool enabled);
    }
}
