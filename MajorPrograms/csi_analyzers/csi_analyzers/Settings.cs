using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_analyzers
{
    class Settings
    {
        private static Settings settings;
        private readonly Properties.Settings preferences;

        private Settings()
        {
            preferences = Properties.Settings.Default;
            RetrieveSettings();
        }

        public static Settings Instance => settings ?? (settings = new Settings());
        public string Difficulty { get; private set; }
        public string ImportedScenesPath { get; private set; }
        public bool CanImport { get; private set; }

        public void SaveSettings(string difficulty, bool canImport = false, string importedScenesPath = "")
        {
            preferences[Constants.DIFFICULTY_KEY] = Difficulty = difficulty;
            preferences[Constants.CAN_IMPORT_KEY] = CanImport = canImport;
            preferences[Constants.IMPORTED_SCENES_PATH_KEY] = ImportedScenesPath = importedScenesPath;
            preferences.Save();
        }

        private void RetrieveSettings()
        {
            Difficulty = (string)preferences[Constants.DIFFICULTY_KEY];
            CanImport = (bool)preferences[Constants.CAN_IMPORT_KEY];
            ImportedScenesPath = (string)preferences[Constants.IMPORTED_SCENES_PATH_KEY];
        }
    }
}
