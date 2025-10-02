﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarRepairShop.Utilities.ChangelogHandler
{
    internal static class Changelog
    {
        const string _changelogFileName = "changelog.json";
        const string _projectName = "CarRepairShop";

        public static List<ChangelogEntry> LoadChangelog()
        {
            string filePath = FindChangelogPath();

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                return new List<ChangelogEntry>();

            var jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<ChangelogEntry>>(jsonString);
        }

        internal static ChangelogEntry GetNewestVersion(List<ChangelogEntry> changelog) => changelog
            .OrderByDescending(entry => DateTime.Parse(entry.Date))
            .FirstOrDefault();

        private static string FindChangelogPath()
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);

            while (dir != null)
            {
                if (string.Equals(dir.Name, _projectName, StringComparison.OrdinalIgnoreCase))
                {
                    var candidate = Path.Combine(dir.FullName, _changelogFileName);
                    if (File.Exists(candidate))
                        return candidate;
                }

                dir = dir.Parent;
            }

            return null;
        }
    }
}
