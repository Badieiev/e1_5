using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_5
{
    class Judge
    {
        string name;
        public string Name
        {
            get {return name; }
        }
        int preferences;
        public int Preferences
        {
            get {return preferences; }
        } 

        public Judge(string name, int pref)
        {
            this.name = name;
            preferences = pref;
        }
    }
}
