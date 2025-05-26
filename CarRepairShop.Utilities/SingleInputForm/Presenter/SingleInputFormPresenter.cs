using System;
using System.Windows.Forms;
using CarRepairShop.Utilities.SingleInputForm.View;

namespace CarRepairShop.Utilities.SingleInputForm.Presenter
{
    public class SingleInputFormPresenter
    {
        private readonly ISingleInputForm _view;
        private string _value;
        private bool _isConfirmed = false;
        private readonly string _initialTitle;
        private readonly string _initialValue;

        public SingleInputFormPresenter(ISingleInputForm view, string initialTitle = "", string initialValue = "")
        {
            _view = view;
            _initialTitle = initialTitle;
            _initialValue = initialValue;

            _view.FormLoaded += Load;
            _view.FormIsClosing += Close;
            _view.OKButtonClicked += Accept;
        }

        private void Accept(object sender, EventArgs e)
        {
            _isConfirmed = true;
            _value = _view.Value;
            _view.CloseForm();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            if (_isConfirmed == false)
                _value = string.Empty;
        }

        private void Load(object sender, EventArgs e)
        {
            _view.FormTitle = _initialTitle;
            _view.Value = _initialValue;
        }
    }
}
