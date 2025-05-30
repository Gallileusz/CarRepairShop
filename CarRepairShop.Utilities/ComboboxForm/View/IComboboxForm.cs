using System;
using System.Collections.Generic;

namespace CarRepairShop.Utilities.ComboboxForm.View
{
    public interface IComboboxForm
    {
        event EventHandler FormIsLoaded;
        event EventHandler FormIsClosing;
        event EventHandler ButtonOkClicked;

        string Title { get; set; }
        string ComboboxDisplayValue { get; set; }
        string ComboboxValueMember { get; set; }
        object SelectedItem { get; set; }
        void CloseForm();
        void SetComboboxDataSource(List<object> entities);
    }
}