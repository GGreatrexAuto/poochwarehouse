using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.Navigation
{
    public static class AllProductsNavigation
    {
        public static void ClickNextPage()
        {
            AllProducts.NextPageButton.Click();
        }

        public static void ClickPreviousPage()
        {
            AllProducts.PreviousPageButton.Click();
        }
    }
}
