using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using xCarpaccio.client;

namespace extreme_carpaccio.tests
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void PremierTest()
        {
            decimal[] prix = new decimal[] { (decimal)1.20, (decimal)3.60 }; ;
            int[] qte = new int[] { 1, 3};

            Order unOrdre = new Order();
            unOrdre.Prices = prix;
            unOrdre.Quantities = qte;
            
            var test = new IndexModule().CalculSansTaxe(unOrdre);
            Assert.AreEqual(test, 12);
        }
    }
}
