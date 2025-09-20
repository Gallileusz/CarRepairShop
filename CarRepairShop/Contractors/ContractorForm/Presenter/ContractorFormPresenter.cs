using CarRepairShop.Contractors.ContractorForm.View;
using CarRepairShop.Repositories;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Contractors.ContractorForm.Presenter
{
    public class ContractorFormPresenter
    {
        private readonly IContractorForm _view;
        private readonly IGenericRepository _genericRepo;

        private int? _id;
        private Domain.Entities.Contractors _contractor;
        private readonly Regex _emailRegex;

        public ContractorFormPresenter(IContractorForm view, IGenericRepository genericRepo, int? id)
        {
            _view = view;
            _genericRepo = genericRepo;
            _id = id;
            _emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
            _view.OperationConfirmed = System.Windows.Forms.DialogResult.No;

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormIsLoaded += LoadData;
            _view.ConfirmButtonClicked += Confirm;
            _view.CancelButtonClicked += Cancel;
        }

        private void LoadData(object sender, EventArgs e)
        {
            if (_id != null && _id.HasValue)
            {
                _contractor = _genericRepo.GetAll<Domain.Entities.Contractors>().FirstOrDefault(x => x.ID == _id);

                _view.ContractorName = _contractor.Name;
                _view.ContractorSurname = _contractor.Surname;
                _view.ContractorPhoneNumber = _contractor.PhoneNumber;
                _view.ContractorEmail = _contractor.Email;
            }
        }

        private void Confirm(object sender, EventArgs e)
        {
            if (IsContractorInvalid(_view.ContractorFormResult.Contractor)) return;

            _view.OperationConfirmed = System.Windows.Forms.DialogResult.Yes;
            _view.CloseForm();
        }

        private void Cancel(object sender, EventArgs e) => _view.CloseForm();

        private bool IsContractorInvalid(Domain.Entities.Contractors contractor)
        {
            if (string.IsNullOrEmpty(contractor.Name.Trim()))
            {
                _view.ShowMessage(Translations.ContractorForm.FillNameField); return true;
            }
            if (string.IsNullOrEmpty(contractor.Surname.Trim()))
            {
                _view.ShowMessage(Translations.ContractorForm.FillSurnameField); return true;
            }
            if (string.IsNullOrEmpty(contractor.PhoneNumber.Trim()))
            {
                _view.ShowMessage(Translations.ContractorForm.FillPhoneNumberField); return true;
            }
            if (contractor.PhoneNumber.Trim().Length < 9)
            {
                _view.ShowMessage(Translations.ContractorForm.IncorrectPhoneNumber); return true;
            }
            if (string.IsNullOrEmpty(contractor.Email.Trim()))
            {
                _view.ShowMessage(Translations.ContractorForm.FillEmailField); return true;
            }
            if (!_emailRegex.IsMatch(contractor.Email))
            {
                _view.ShowMessage(Translations.ContractorForm.IncorrectEmail); return true;
            }

            return false;
        }
    }
}
