namespace CarRepairShop.CRM
{
    public static class Queries
    {
        public static string DeleteMappings(int taskID) => $"DELETE FROM {nameof(Domain.Entities.CRM_Services)} WHERE {nameof(Domain.Entities.CRM_Services.TaskID)} = {taskID};";
    }
}
