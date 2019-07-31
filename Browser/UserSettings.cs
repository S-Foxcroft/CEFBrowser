using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser
{
    class UserSettings
    {
        private static bool writing = false;
        private static string _Home;
        public static string Home {
            get { return _Home; }
            set { _Home = value; Save(); }
        }
        public static void Load()
        {
            _Home = "https://www.google.com";
        }
        public static void Save()
        {

        }
        public static void Import(string filePath) { }
    }
}
