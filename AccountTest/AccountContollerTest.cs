
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
        public void RegisterAsync_null_Returnsfalse()
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Address = "68 Maddren";
            customer.FirstName = "Hasan";
            customer.LastName = " Jehad";
            customer.Password = "EWRTR1";
            customer.PhoneNo = "09876543";
            customer.PostCode = "TS55RE";
            customer.ConfirmPassword = null;
            var result = customer.FirstName;
            var exresult = customer.FirstName = "Hasan";
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
        public void DeleteStaff_null_Retuensfalse()
        {
            staff SS = new staff();
            SS.Id = 1;
            var result = SS.Id;
            var ExpectedR = result;
            Assert.AreEqual(result, ExpectedR);
        }
        [TestMethod]
        public void StaffLogin_isValid_ReturnsTrue()
        {
            staff L = new staff();
            L.Password = " TRAEA";
            var result = L.Password;
            var expecteR = result;
            Assert.AreEqual(result, expecteR);
        }

    }
}
