using System.Collections.Generic;

namespace CarRepairShop.Utilities.ChangelogHandler
{
    public interface IChangelogHandler
    {
        List<ChangelogEntry> LoadChangelog();
        ChangelogEntry GetNewestVersion(List<ChangelogEntry> changelog);
    }
}
