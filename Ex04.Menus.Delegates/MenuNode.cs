using System;
namespace Ex04.Menus.Delegates

{
    delegate void MenuNodeCallbackDel();
    public class MenuNode:MenuLevel
    {
     private Action menuNodeCallback;


         public void  InvokeInnerMethod()
        {
            menuNodeCallback.Invoke();
        }
        public MenuNode( string i_name , string i_path , string i_inputKey, Action callback):base(i_name,i_path,i_inputKey)
        {

            menuNodeCallback = callback;
        }
    }
}
