namespace CarRepairShop.Authentication.ConnectionSettings.DTO
{
    public record SettingsComparer
    {
        public string DemoConnectionString { get; init; }
        public bool ProductionConnection { get; init; }
        public Domain.Entities.Languages Language { get; init; }
    }
}
