using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vrote_Diana_Lab11.Models;
using Vrote_Diana_Lab11.Data;


namespace Vrote_Diana_Lab11

{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
