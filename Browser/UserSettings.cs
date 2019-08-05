using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser
{
    class UserSettings
    {
        private static bool writing = false;
        private static string _Home;
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/CBrowser";
        private static string filePath = path + "/Settings.set";
        public static string Home {
            get { return _Home; }
            set { _Home = value; Save(); }
        }
        public static void Load()
        {
            _Home = "https://www.google.com";
            try
            {
                string[] fileLines = File.ReadAllLines(filePath);
                foreach (string line in fileLines)
                {
                    int splitIndex = line.IndexOf('=');
                    string varName = line.Substring(0,splitIndex);
                    string varValue = line.Substring(splitIndex+1);
                    switch (varName)
                    {
                        case "Home":
                            _Home = varValue;
                            return;
                        default:
                            return;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("DBG: Settings file not found.");
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            }
        }
        public static void Save()
        {
            while (writing) { } // wait
            writing = true;
            File.WriteAllLines(filePath, new string[] {
                "Home="+_Home
            });
            writing = false;
        }
        public static void Import(string loc) {
            
            if (File.Exists(filePath))
            {
                //copy the file and rotate it in.
                File.Copy(loc, filePath + ".tmp");
                if (File.Exists(filePath + ".old")) File.Delete(filePath + ".old");
                File.Move(filePath, filePath + ".old");
                File.Move(filePath + ".tmp", filePath);
            }
            else File.Copy(loc, filePath);
            Load();
        }
    }
}
