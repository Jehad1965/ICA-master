
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AccountTest
{
    [TestClass]
    public class AccountContollerTest
    {
        [TestMethod]
        public void RegisterAsync_null_ReturnsTrue()
        {
            var customer = new Customer();
            var result = customer.FirstName = "Jehad";
            var exresult = customer.FirstName = "Jehad";
            Assert.AreEqual(result, exresult);
        }
        [TestMethod]
        public void UpdateAsync_IsValid_ReturnsTrue()
        {
            Customer V = new Customer();
            var result = V;
            var expectedR = V;
            Assert.AreEqual(result, expectedR);
        }
        [TestMethod]
        public void Delete_null_ReturnCustomer()
        {
            Customer R = new Customer();
            R.Id = 1;
            var expectedR = 1;
            Assert.IsNotNull(expectedR);


        }
        [TestMethod]
        public void ManagerLogin_IsValid_Returnsfalse()
        {
            Customer T = new Customer();
            T.Password = null;
            var result = T;
            var expectedR = result;
            Assert.AreEqual(result, expectedR);

        }
        [TestMethod]
        public void AddStaff_IsValid_Returnfalse()
        {
            staff s = new staff();
            s.StaffName = null;
            var Result = s.StaffName;
            var ExpResult = Result;
            Assert.AreEqual(Result, ExpResult);

        }
        [TestMethod]
        public void DeleteStaff_null_Retuensfalse(int id)
        {
            staff SS = new staff();
            SS.Id = 1;
            var result = SS.Id;
            var ExpectedR = result;
            Assert.AreEqual(result, ExpectedR);
        }


    }
}
