using System;
using CarRepairShop.Contractors.ContractorForm.View;

namespace CarRepairShop.Contractors.ContractorForm.Presenter
{
    public class ContractorFormPresenter
    {
        private IContractorForm _view;
        private Domain.Entities.Contractors _contractor;
        private bool _isConfirmed = false;

        public ContractorFormPresenter(IContractorForm view)
        {
            _view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadData;
            _view.ConfirmButtonClicked += Confirm;
            _view.CancelButtonClicked += Cancel;
            _view.FormIsClosing += Closing;
        }

        private void LoadData(object sender, EventArgs e)
        {
            if (_contractor != null)
            {
                _view.ContractorName = _contractor.Name;
                _view.ContractorSurname = _contractor.Surname;
                _view.ContractorPhoneNumber = _contractor.PhoneNumber;
                _view.ContractorEmail = _contractor.Email;
            }
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (_contractor == null)
                _contractor = new Domain.Entities.Contractors();

            _contractor.Name = _view.ContractorName;
            _contractor.Surname = _view.ContractorSurname;
            _contractor.PhoneNumber = _view.ContractorPhoneNumber;
            _contractor.Email = _view.ContractorEmail;

            if (IsContractorInvalid(_contractor)) return;

            _isConfirmed = true;
            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e)
        {
            _contractor = null;
            _view.CloseForm();
        }

        private void Closing(object sender, EventArgs e)
        {
            if (!_isConfirmed)
                _contractor = null;
        }

        private bool IsContractorInvalid(Domain.Entities.Contractors contractor)
        {
            if (string.IsNullOrEmpty(contractor.Name))
            {
                _view.ShowMessage("Uzupełnij pole imię.");
                return true;
            }
            if (string.IsNullOrEmpty(contractor.Surname))
            {
                _view.ShowMessage("Uzupełnij pole nazwisko.");
                return true;
            }
            if (string.IsNullOrEmpty(contractor.PhoneNumber))
            {
                _view.ShowMessage("Uzupełnij pole number telefonu");
                return true;
            }
            if (contractor.PhoneNumber.Trim().Length > 9)
            {
                _view.ShowMessage("Numer telefonu powinien mieć przynajmniej 9 cyfr.");
                return true;
            }
            if (string.IsNullOrEmpty(contractor.Email))
            {
                _view.ShowMessage("Uzupełnij pole email.");
                return true;
            }
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(contractor.Email, emailPattern))
            {
                _view.ShowMessage("Niepoprawny format adresu email.");
                return true;
            }

            return false;
        }

        public void SetContractor(Domain.Entities.Contractors contractor) => _contractor = contractor;

        public Domain.Entities.Contractors GetContractor() => _contractor;
    }
}
