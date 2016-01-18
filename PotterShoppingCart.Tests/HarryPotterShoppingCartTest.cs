using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class HarryPotterShoppingCartTest
    {
        [TestMethod()]
        public void ShoppingCartTest_buy_BookName_1_BookCount_1_Total_100()
        {
            List<BookList> BookLists = new List<BookList>()
            {
             new  BookList(){ BookName = "HarryPotter1",BookCount = 1}
            };
            int price = 100;

        }
    }
    public class BookList
    {
        public string BookName { get; set; }
        public int BookCount { get; set; }
    }
}
