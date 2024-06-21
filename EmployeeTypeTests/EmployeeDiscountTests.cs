using LaptopDiscount;

namespace EmployeeTypeTests
{


    [TestFixture]
    public class EmployeeDiscountTests
    {
        [Test]
        public void CalDiscountPrice_PartialLoadEmployee_5PercentDis()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 200
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();

            //Assert
            Assert.AreEqual(190, discountedPrice); // 5% discount is expected
        }



        [Test]
        public void CalcDisPrice_FullTime_Employee_10Per_Dis()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 150
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();

            //Assert
            Assert.AreEqual(135, discountedPrice);
        }


        [Test]
        public void CalcDiscPrice_CompanyPurchasing_20PerDis()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 200
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            //Assert
            Assert.AreEqual(160, discountedPrice); // 20% discount is expected
        }

        [Test]
        public void CalculateDiscountedPrice_NegativeVale_Invalid()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = -10
            };
            //assign
            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(-10, discountedPrice); // No discount expected as the input is not valid
        }


        [Test]
        public void CalculateDiscountedPrice_ExtremelyLowPrice_InvalidInput()
        {

            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 1
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            //Assert
            Assert.AreEqual(1, discountedPrice); // No discount expected because of invalid input as it is very low)
        }





        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}