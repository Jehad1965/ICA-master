using Assignment.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReveiwTest
{
    [TestClass]
    public class ReviewTest
    {
        [TestMethod]
        public void WriteReview_isValid_ReturnsTrue()
        {
            Review R = new Review();
            R.ProductId = 1;
            var result = R.ProductId;
            var expectedR = 1;
            
            Assert.AreEqual(result,expectedR);

            }
         [TestMethod]
         public void HideReview_isValid_ReturnsTrue()
        {
            Review RV= new Review();
            RV.IsHide = true;
            RV.Id = 1;
            RV.ProductId = 1;
            RV.ProductName = "Tomato";
            RV.Rating = 4;
            RV.CustomerName = "Hassan";
            var result = RV.IsHide;
            Assert.IsTrue(result);
        }
        }
    }

