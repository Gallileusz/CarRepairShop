namespace CarRepairShop.CRM
{
    public static class Queries
    {
        public static string DeleteCRMTasks(int taskID) => $"DELETE FROM {nameof(Domain.Entities.CRM_Task)} WHERE {nameof(Domain.Entities.CRM_Task.TaskID)} = {taskID};";
    }
}
