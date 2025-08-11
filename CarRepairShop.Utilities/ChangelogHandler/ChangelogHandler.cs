using System.Collections.Generic;

namespace CarRepairShop.Utilities.ChangelogHandler
{
    public class ChangelogHandler : IChangelogHandler
    {
        public ChangelogEntry GetNewestVersion(List<ChangelogEntry> changelog) => Changelog.GetNewestVersion(changelog);

        public List<ChangelogEntry> LoadChangelog() => Changelog.LoadChangelog();
    }
}
