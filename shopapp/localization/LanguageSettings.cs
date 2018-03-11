using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.localization
{
    public static class LanguageSettings
    {
        public const string ENGLISH = "en";
        public const string RUSSIAN = "ru";

        private static string _lang;

        public static string CurrentLanguage 
        {
            set { _lang = value; }
            get { return _lang; }
        }
    }
}
