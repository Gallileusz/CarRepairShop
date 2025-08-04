namespace CarRepairShop.MainForm.Models.Tabs.CRM
{
    public class CRM_Model
    {
        public int ID { get; set; }
        public string TaskCreatorFullname { get; set; }
        public string CustomerFullname { get; set; }
        public string VehicleDetails { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public bool Completed { get; set; }
        public string EndDate { get; set; }
        public string Services { get; set; }
        public decimal Price { get; set; }
    }
}
