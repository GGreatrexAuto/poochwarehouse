using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.Navigation
{
    public class HomePageNavigation
    {
        private HomePage _homePage;

        public HomePageNavigation()
        {
            _homePage = new HomePage();
        }

        public void ToCollectionsBedsBlankets()
        {
            _homePage.CollectionsBedsBlankets.Click();
        }

        public void ToCollectionsBowlsFood()
        {
            _homePage.CollectionsBowlsFood.Click();
        }

        public void ToCollectionsGrooming()
        {
            _homePage.CollectionsGrooming.Click();
        }

        public void ToCollectionsCollarsLeads()
        {
            _homePage.CollectionsCollarsLeads.Click();
        }

        public void ToCollectionsHealthCare()
        {
            _homePage.CollectionsHealthCare.Click();
        }

        public void ToCollectionsTraining()
        {
            _homePage.CollectionsTraining.Click();
        }

        public void ToCollectionsSmallDogsPuppies()
        {
            _homePage.CollectionsSmallDogsPuppies.Click();
        }

        public void ToCollectionsLargeDogs()
        {
            _homePage.CollectionsLargeDogs.Click();
        }

        public void ToCollectionsToysGames()
        {
            _homePage.CollectionsToysGames.Click();
        }

        public void ToCollectionsOnTheGo()
        {
            _homePage.CollectionsOnTheGo.Click();
        }

        public void ToCollectionsSummerTime()
        {
            _homePage.CollectionsSummerTime.Click();
        }

        public void ToCollectionsWinterTime()
        {
            _homePage.CollectionsWinterTime.Click();
        }
    }
}
