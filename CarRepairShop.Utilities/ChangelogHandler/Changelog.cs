using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarRepairShop.Utilities.ChangelogHandler
{
    internal static class Changelog
    {
        private const string _changelogFileName = "changelog.json";

        public static List<ChangelogEntry> LoadChangelog()
        {
            var filePath = FindChangelogPath();

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return new List<ChangelogEntry>();

            var jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<ChangelogEntry>>(jsonString);
        }

        internal static ChangelogEntry GetNewestVersion(List<ChangelogEntry> changelog) => changelog
            .OrderByDescending(entry => DateTime.Parse(entry.Date))
            .FirstOrDefault()
            ?? new ChangelogEntry { Version = "N/A" };

        private static string FindChangelogPath()
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            var candidate = Path.Combine(dir.FullName, _changelogFileName);
            if (File.Exists(candidate))
                return candidate;

            return null;
        }
    }
}
