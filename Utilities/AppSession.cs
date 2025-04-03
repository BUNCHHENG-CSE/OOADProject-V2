using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities
{
    internal class AppSession
    {
        public static int? CurrentStaffID { get; set; }

        public static int GetStaffIDOrThrow()
        {
            return CurrentStaffID ?? throw new InvalidOperationException("No staff is currently logged in.");
        }
        private const string flagPassword = "admin1234@1234";

        public static bool DefaultUsed
        {
            get
            {
                string path = GetFlagFilePath();
                if (!File.Exists(path)) return false;

                try
                {
                    string content = EncryptionHelper.DecryptFromFile(path, flagPassword);
                    return content == "used";
                }
                catch
                {
                    return false;
                }
            }
            set
            {
                if (value)
                {
                    string path = GetFlagFilePath();
                    EncryptionHelper.EncryptToFile(path, "used", flagPassword);
                    File.SetAttributes(path, FileAttributes.Hidden);
                }
            }
        }

        private static string GetFlagFilePath()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folderPath = Path.Combine(appDataPath, "CoffeeApp");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return Path.Combine(folderPath, "used.flag");
        }        

    }
}

