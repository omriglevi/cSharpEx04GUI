using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuApp
    {
        MenuLevel menuTopLevel;

        public MenuApp()
        {
            this.menuTopLevel = new MenuLevel("Menu", "Menu", "q-quit");
        }

        public void AddsubLevelsToTopLevel(MenuLevel menuLevelToAdd)
        {
            menuTopLevel.AddSubLevel(menuLevelToAdd);
        }




        private bool ValidateUserInput(string userInput ,  List<MenuLevel> subLevels)
        {

            foreach (MenuLevel sl in subLevels)
            {
                if(sl.LevelKey == userInput)
                {
                    return true;
                }
            }
            return false;
        }

        private string  GetUserInput ( string msg)
        {
            bool isValidInput = false;
            string userInput = string.Empty;
            while(!isValidInput)
            {
                
                Console.WriteLine(msg);
                userInput = Console.ReadLine();
                if (userInput == string.Empty)
                {
                    isValidInput = true;
                }
            }
            return userInput;
        }

        private MenuLevel GetUserInputAndReturnLevel( MenuLevel menuLevel , string msgToUser )
        {
            string userInput = GetUserInput(msgToUser);
           MenuLevel levelKeySearchResult= menuLevel.SearchLevelKey(userInput);
            return levelKeySearchResult;
        }

        public void Start(string msg_userInputFailure)
        {
            MenuLevel current_level = menuTopLevel;
            string userInput = string.Empty;


            //current_level.PrintSubLevels();
            Console.WriteLine("f:");
            Console.ReadLine();
               
                
            
            

        }
    }
}
