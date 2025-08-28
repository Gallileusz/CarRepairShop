using CarRepairShop.Texts;

namespace CarRepairShop.Library
{
    public class ConsumableMaterial
    {
        public string ProvideMaterialTypeName => SharedTexts.ConsumableMaterial_ProvideNewMaterialsName;
        public string InsertSuccess => SharedTexts.ConsumableMaterial_MaterialInsertSuccess;
        public string InsertError => SharedTexts.ConsumableMaterial_MaterialInsertError;
        public string NameCannotBeEmpty => SharedTexts.ConsuambleMaterial_NameCannotBeEmpty;
        public string SelectMaterialType => SharedTexts.ConsumableMaterial_SelectMaterialType;
        public string ProvideMaterialName => SharedTexts.ConsumableMaterial_ProvideMaterialName;
        public string CorrectMaterialQuantity => SharedTexts.ConsumableMaterial_CorrectMaterialQuantity;
        public string MaterialExistsAlready => SharedTexts.ConsumableMaterial_MaterialExistsAlready;
    }
}
