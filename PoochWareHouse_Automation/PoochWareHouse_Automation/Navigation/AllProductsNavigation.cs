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
