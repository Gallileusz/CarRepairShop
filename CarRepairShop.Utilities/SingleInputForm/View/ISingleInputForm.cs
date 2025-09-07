using System;
using System.Windows.Forms;

namespace CarRepairShop.Utilities.SingleInputForm.View
{
    public interface ISingleInputForm
    {
        event EventHandler FormLoaded;
        event FormClosingEventHandler FormIsClosing;
        event EventHandler OKButtonClicked;
        string FormTitle { get; set; }
#nullable enable
        string? Value { get; set; }
        void CloseForm();
    }
}
