using System.Collections.Generic;
using System.Text;

namespace CarRepairShop.Utilities.ChangelogHandler
{
    public interface IChangelogHandler
    {
        List<ChangelogEntry> LoadChangelog();
        ChangelogEntry GetNewestVersion(List<ChangelogEntry> changelog);
        StringBuilder GetChangelogStringBuilder();
    }
}
