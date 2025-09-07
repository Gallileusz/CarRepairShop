using CarRepairShop.Utilities.SingleInputForm.View;
using System;
using System.Windows.Forms;

namespace CarRepairShop.Utilities.SingleInputForm.Presenter
{
    public class SingleInputFormPresenter
    {
        private readonly ISingleInputForm _view;
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
            _view.CloseForm();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            if (_isConfirmed == false)
                _view.Value = null;
        }

        private void Load(object sender, EventArgs e)
        {
            _view.FormTitle = _initialTitle;
            _view.Value = _initialValue;
        }
    }
}
