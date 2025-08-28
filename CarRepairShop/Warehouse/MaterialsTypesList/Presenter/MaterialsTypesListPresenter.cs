using CarRepairShop.AppSettings;
using CarRepairShop.Repositories;
using CarRepairShop.Warehouse.MaterialsTypesList.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Translations = CarRepairShop.Library.Texts;

namespace CarRepairShop.Warehouse.MaterialsTypesList.Presenter
{
    public class MaterialsTypesListPresenter
    {
        private readonly IMaterialTypesList _view;
        private readonly IGenericRepository _genericRepo;
        private readonly ICurrentUserService _currentUser;
        private bool _changesAccured;

        private readonly List<Domain.Entities.MaterialTypes> _materialTypes;

        public MaterialsTypesListPresenter(IMaterialTypesList view, IGenericRepository genericRepo, ICurrentUserService currentUser)
        {
            _view = view;
            _genericRepo = genericRepo;
            _currentUser = currentUser;
            _changesAccured = false;

            _materialTypes = _genericRepo.GetAll<Domain.Entities.MaterialTypes>().ToList();

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _view.FormLoaded += LoadData;
            _view.AddMaterialTypeButtonClicked += AddMaterialType;
            _view.EditMaterialTypeButtonClicked += EditMaterialType;
            _view.DeleteMaterialTypeButtonClicked += DeleteMaterialType;
            _view.CloseButtonClicked += CloseForm;
            _view.FormIsClosing += FormIsClosing;
        }

        private void LoadData(object sender, EventArgs e)
        {
            _changesAccured = false;
            _view.LoadMaterialTypesToGrid(_materialTypes);
        }

        private void AddMaterialType(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Warehouse, Utilities.Permissions.Permissions.AllowEdit)) return;

            var name = _view.ShowInputDialog(Translations.MaterialsTypesList.AddMaterialTitle, string.Empty);

            if (string.IsNullOrWhiteSpace(name)) return;

            var newMaterialType = new Domain.Entities.MaterialTypes { Name = name };
            if (_genericRepo.Insert(newMaterialType) > 0)
            {
                _changesAccured = true;
                _view.ShowMessage(string.Format(Translations.MaterialsTypesList.InsertSuccess, newMaterialType.Name));
                _materialTypes.Add(newMaterialType);
                _view.LoadMaterialTypesToGrid(_materialTypes);
            }
            else
                _view.ShowMessage(string.Format(Translations.MaterialsTypesList.InsertError, newMaterialType.Name));
        }

        private void EditMaterialType(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Warehouse, Utilities.Permissions.Permissions.AllowEdit)) return;

            if (_view.SelectedID <= 0) return;

            var materialType = _materialTypes.FirstOrDefault(mt => mt.ID == _view.SelectedID);
            var index = _materialTypes.FindIndex(x => x.ID == _view.SelectedID);
            if (materialType == null || index < 0) return;

            var newName = _view.ShowInputDialog(Translations.MaterialsTypesList.EditMaterialTitle, materialType.Name);

            if (string.IsNullOrWhiteSpace(newName) || materialType.Name == newName) return;

            if (!_view.ConfirmAction(string.Format(Translations.MaterialsTypesList.EditConfirmationBody, materialType.Name, newName), Translations.MaterialsTypesList.EditConfirmationTitle)) return;

            materialType.Name = newName;
            if (_genericRepo.Update(materialType))
            {
                _changesAccured = true;
                _view.ShowMessage(Translations.MaterialsTypesList.EditSuccess);
                _materialTypes[index] = materialType;
                _view.LoadMaterialTypesToGrid(_materialTypes);
            }
            else
                _view.ShowMessage(Translations.MaterialsTypesList.EditError);
        }

        private void DeleteMaterialType(object sender, EventArgs e)
        {
            if (!_currentUser.HasPermission(Utilities.Permissions.PermissionTabs.Warehouse, Utilities.Permissions.Permissions.AllowEdit)) return;

            var materialType = _materialTypes.FirstOrDefault(mt => mt.ID == _view.SelectedID);
            var index = _materialTypes.FindIndex(x => x.ID == _view.SelectedID);
            if (materialType == null || index < 0) return;

            if (!_view.ConfirmAction(string.Format(Translations.MaterialsTypesList.DeleteConfirmationBody, materialType.Name), Translations.MaterialsTypesList.DeleteConfirmationTitle)) return;

            if (_genericRepo.Delete(materialType))
            {
                _changesAccured = true;
                _view.ShowMessage(string.Format(Translations.MaterialsTypesList.DeleteSuccess, materialType.Name));
                _materialTypes.Remove(materialType);
                _view.LoadMaterialTypesToGrid(_materialTypes);
            }
            else
                _view.ShowMessage(string.Format(Translations.MaterialsTypesList.DeleteError, materialType.Name));
        }

        private void CloseForm(object sender, EventArgs e) => _view.CloseForm();

        private void FormIsClosing(object sender, EventArgs e) => _view.ChangesAccured = _changesAccured ? DialogResult.Yes : DialogResult.No;
    }
}
