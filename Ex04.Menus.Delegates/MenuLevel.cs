using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuLevel
    {
        private  string name;
        private  string path;
        private  string levelKey; // what should trigger the next fn
        private List<MenuLevel> subLevels;

       public string LevelKey { get=>levelKey; }
        public string Path { get=>path; }
       public string Name { get=>name; }

        public MenuLevel SearchLevelKey(string searchKey)
        {
            foreach(MenuLevel sl in subLevels )
            {
                if(sl.LevelKey == searchKey)
                {
                    return sl;
                }
            }
            return null;
        }
        public void AddSubLevel(MenuLevel subLevel)
        {
            subLevels.Add(subLevel);
        }

        public void PrintSubLevels()
        {
            if(subLevels.Count == 0)
            {
                Console.WriteLine("No sublevelsTo Show");
            }
            foreach (MenuLevel sl in subLevels)
            {
                Console.WriteLine("\t {0} - {1}" , sl.levelKey ,sl.name);
            }
        }
        public MenuLevel(string i_name , string i_path , string i_inputKey)
        {
            this.subLevels = new List<MenuLevel> () ;
            this.levelKey = i_inputKey;
            this.name = i_name;
            this.path = i_path;
        }
    }
}
