using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRepairShop.Utilities.ChangelogHandler
{
    public class ChangelogHandler : IChangelogHandler
    {
        public ChangelogEntry GetNewestVersion(List<ChangelogEntry> changelog) => Changelog.GetNewestVersion(changelog);

        public List<ChangelogEntry> LoadChangelog() => Changelog.LoadChangelog();

        public StringBuilder GetChangelogStringBuilder() // Should remain in english language, as changelog is intended for developers
        {
            var changelog = LoadChangelog();

            if (changelog != null && changelog.Any())
            {
                var sb = new StringBuilder();
                foreach (var entry in changelog.OrderByDescending(x => DateTime.Parse(x.Date)))
                {
                    sb.AppendLine($"VERSION: {entry.Version}");
                    sb.AppendLine($"DATE: {entry.Date}");

                    sb.AppendLine("CHANGES:");
                    foreach (var change in entry.Changes)
                        sb.AppendLine($"- {change}");

                    sb.AppendLine();
                }

                return sb;
            }
            else
                return null;
        }
    }
}
