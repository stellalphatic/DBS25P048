using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itec.DB;
using MySqlX.XDevAPI;

namespace Itec.Pages
{
    public static class NavigationHelper
    {

        public static void NavigateTo(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Close();
        }



    }
}
