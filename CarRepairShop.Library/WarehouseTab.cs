using CarRepairShop.Texts;

namespace CarRepairShop.Library
{
    public class WarehouseTab
    {
        public string All => SharedTexts.WarehouseTab_All;
        public string AddNewMaterial => SharedTexts.WatehouseTab_AddConsuambleMaterial;
        public string InsertedSuccessfully => SharedTexts.WarehouseTab_MaterialAddedSuccessfully;
        public string InsertError => SharedTexts.WarehouseTab_InsertingMaterialError;
        public string EditMaterial => SharedTexts.WarehouseTab_MaterialEdit;
        public string UpdatedSuccessfully => SharedTexts.WarehouseTab_MaterialUpdatedSuccessfully;
        public string UpdateError => SharedTexts.WarehouseTab_MaterialUpdateError;
        public string DeleteBody => SharedTexts.WarehouseTab_DeleteMaterialBody;
        public string DeleteHeader => SharedTexts.WarehouseTab_DeleteMaterialHeader;
        public string DeletedSuccessfully => SharedTexts.WarehouseTab_MaterialDeletedSuccessfully;
        public string DeleteError => SharedTexts.WarehouseTab_MaterialDeleteError;

        public string MaterialName => SharedTexts.WarehouseTab_DataGridViewColumnMaterialName;
        public string MaterialTypeName => SharedTexts.WarehouseTab_DataGridViewColumnMaterialTypeName;
        public string Quantity => SharedTexts.WarehouseTab_DataGridViewColumnQuantity;
    }
}
