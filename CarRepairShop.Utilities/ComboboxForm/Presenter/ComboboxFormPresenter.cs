using CarRepairShop.Utilities.ComboboxForm.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRepairShop.Utilities.ComboboxForm.Presenter
{
    public class ComboboxFormPresenter
    {
        private IComboboxForm _view;
        private List<object> _entities;
        private object _selectedItem;

        private bool _isConfirmed = false;

        public ComboboxFormPresenter(IComboboxForm view, IEnumerable<object> entities, object toSelect = null)
        {
            _view = view;
            _entities = entities.ToList();
            if (toSelect != null)
                _selectedItem = toSelect;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadForm;
            _view.ButtonOkClicked += ButtonClicked;
            _view.FormIsClosing += FormClosing;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            _view.SetComboboxDataSource(_entities);
            if (_selectedItem != null)
                _view.SelectedItem = _selectedItem;
        }

        private void FormClosing(object sender, EventArgs e) => _view.SelectedItem = _isConfirmed ? _view.SelectedItem : null;

        private void ButtonClicked(object sender, EventArgs e)
        {
            _isConfirmed = true;
            _view.CloseForm();
        }
    }
}
