using System.Collections.Generic;

namespace CarRepairShop.Utilities.ChangelogHandler
{
    public class ChangelogEntry
    {
        public string Version { get; set; }
        public string Date { get; set; }
        public List<string> Changes { get; set; }
    }
}
