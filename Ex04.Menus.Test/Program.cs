using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Start();
            Console.WriteLine("Stuff");
            string ui = Console.ReadLine();
            Console.WriteLine(ui);
            Console.ReadLine();
        }
        public static void Start()
        {
            MenuApp app = new MenuApp();
            MenuLevel showCapitals = new MenuLevel("Show Capitals", "Menu->Capitals", "1");
            MenuLevel showDateTime = new MenuLevel("Show Date/Time", "Menu->Show Date/Time", "2");
            MenuNode exit = new MenuNode("Exit", "Menu->Show Date/Time", "0", delegate {

                Console.WriteLine("Exit but not really");
            }); ;



            app.AddsubLevelsToTopLevel(showCapitals);
            app.AddsubLevelsToTopLevel(showDateTime);
            app.AddsubLevelsToTopLevel(exit);
            string userFailureInputMessage = "Wrong input";
            app.Start(userFailureInputMessage);

        }
        public Program()
        {

        }

    }
}
