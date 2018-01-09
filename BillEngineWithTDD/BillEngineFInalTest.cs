using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
namespace BillEngineWithTDD
{

    [TestFixture]
    public class BillEngineFInalTest
    {
        private GnerateFinalBill _sut;

        public GnerateFinalBill Sut { get => _sut; set => _sut = value; }

        // private ISortManager _sut;
        // here we create reference for mocking object. Mocking framework helps 
        // to create proxy object for given interface. in this case  IFileManager. 
        // private Mock<IFileManager> _mockFileManager;

        [SetUp]
        public void Setup()
        {
            // Create instance of Mocking object 
            //_mockFileManager = new Mock<IFileManager>();
            //  _sut = new SortManager(_mockFileManager.Object);
        }

        [Test]
        public void First_three_digits_represent_the_extension_it_is_equal_then_consider_as_local_else_cosider_as_longCall()
        {
            // Arrange
            List<CDR> BillList = new List<CDR>();
            // const string fileName = "number.csv";
            // List<string> numbers = new List<string> { "3", "2", "1" };
            // Method mocking. Here we say wheneve ReadCsvFile method of proxy object
            // being called returns the numbers
            // _mockFileManager.Setup(c => c.ReadCsvFile(fileName)).Returns(numbers);

            // Act
            //  var result = _sut.Sort(fileName);

            // Assert
            //   Assert.AreEqual(result.Count, 3);
            // Assert.AreEqual(result[0], 1);
            // Assert.AreEqual(result[1], 2);
            // Assert.AreEqual(result[2], 3);
        }

        [Test]
        public void Generate_CallFromDifferentExtentionNumber_ShouldReturnTheBill()
        {
            List<CDR> ListOfCallFrom1Number = new List<CDR>();
            // Arrange
            CDR cdrForTest = new CDR(0711535724, 0711591231, new DateTime(2017, 12, 23, 9, 0, 0), new DateTime(1, 10, 10, 9, 0, 0), 100);
            List<Customer> CustomerList = new List<Customer>();
            //Customer(string FullNmae, string Billingaddress, int PhoneNumber, string PackageCode, DateTime RegisteredDate)
            Customer Costomerfortest = new Customer("kaja", "karampakam", 0771234567, "2324", new DateTime(2017, 12, 23, 9, 0, 0));
            //   CDR cdrForTest = new CDR(0711535724, 0711593911, new DateTime(2017, 12, 23, 9, 0, 0), 58);
            ListOfCallFrom1Number.Add(cdrForTest);
            CustomerList.Add(Costomerfortest);
            string expected = "Customer Name: FirstName SecondName" +
                "\nPhone number: 711535724" +
                "\nAddress: Address1, Address2." +
                "\nTotal Amount to Pay: LKR: 178.6";

            // Act
            Sut.GnerateFinalForPackageA(cdrForTest);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, Sut.GetTheBillForPackageA(CustomerList));
        }


        [Test]
        public void Generate_WhenGivingOneCustomerAndOneCDRWihtLocalCallInOffPeakHoursLessThanAMiniuteCallDuration_ShouldReturnTheBill()
        {
            List<CDR> ListOfCallFrom1Number = new List<CDR>();
            // Arrange
            CDR cdrForTest = new CDR(0711535724, 0711591231, new DateTime(2017, 12, 23, 9, 0, 0), new DateTime(0, 0, 0, 9, 0, 0), 100);
            List<Customer> CustomerList = new List<Customer>();
            //Customer(string FullNmae, string Billingaddress, int PhoneNumber, string PackageCode, DateTime RegisteredDate)
            Customer Costomerfortest = new Customer("kaja", "karampakam", 0771234567, "2324", new DateTime(2017, 12, 23, 9, 0, 0));
            //   CDR cdrForTest = new CDR(0711535724, 0711593911, new DateTime(2017, 12, 23, 9, 0, 0), 58);
            ListOfCallFrom1Number.Add(cdrForTest);
            CustomerList.Add(Costomerfortest);
            string expected = "Customer Name: FirstName SecondName" +
                "\nPhone number: 711535724" +
                "\nAddress: Address1, Address2." +
                "\nTotal Amount to Pay: LKR: 143.3";

            // Act
            Sut.GnerateFinalForPackageA(cdrForTest);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, Sut.GetTheBillForPackageA(CustomerList));
        }


        [Test]
        public void Generate_WhenGivingOneCustomerAndOneCDRWihtLocalCallInPeakHoursLessThanAMiniuteCallDuration_ShouldReturnTheBill()
        {
            List<CDR> ListOfCallFrom1Number = new List<CDR>();
            // Arrange
            CDR cdrForTest = new CDR(0711535724, 0711591231, new DateTime(2017, 12, 23, 9, 0, 0), new DateTime(0, 0, 0, 9, 9, 9), 100);
            List<Customer> CustomerList = new List<Customer>();
            //Customer(string FullNmae, string Billingaddress, int PhoneNumber, string PackageCode, DateTime RegisteredDate)
            Customer Costomerfortest = new Customer("kaja", "karampakam", 0771234567, "2324", new DateTime(2017, 12, 23, 9, 0, 0));
            //   CDR cdrForTest = new CDR(0711535724, 0711593911, new DateTime(2017, 12, 23, 9, 0, 0), 58);
            ListOfCallFrom1Number.Add(cdrForTest);
            CustomerList.Add(Costomerfortest);
            string expected = "Customer Name: FirstName SecondName" +
                "\nPhone number: 711535724" +
                "\nAddress: Address1, Address2." +
                "\nTotal Amount to Pay: LKR: 123.6";

            // Act
            Sut.GnerateFinalForPackageA(cdrForTest);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, Sut.GetTheBillForPackageA(CustomerList));
        }
        [Test]
        public void Generate_WhenCustermerCallToSameNumber_ShouldReturnTheBill()
        {
            List<CDR> ListOfCallFrom1Number = new List<CDR>();
            // Arrange
            CDR cdrForTest = new CDR(0711535724, 0711591231, new DateTime(2017, 12, 23, 9, 0, 0), new DateTime(0, 0, 0, 9, 0, 0), 100);
            List<Customer> CustomerList = new List<Customer>();
            //Customer(string FullNmae, string Billingaddress, int PhoneNumber, string PackageCode, DateTime RegisteredDate)
            Customer Costomerfortest = new Customer("kaja", "karampakam", 0771234567, "2324", new DateTime(2017, 12, 23, 9, 0, 0));
            //   CDR cdrForTest = new CDR(0711535724, 0711593911, new DateTime(2017, 12, 23, 9, 0, 0), 58);
            ListOfCallFrom1Number.Add(cdrForTest);
            CustomerList.Add(Costomerfortest);
            string expected = "Customer Name: FirstName SecondName" +
                "\nPhone number: 711535724" +
                "\nAddress: Address1, Address2." +
                "\nTotal Amount to Pay: LKR: 100.00";

            // Act
            Sut.GnerateFinalForPackageA(cdrForTest);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, Sut.GetTheBillForPackageA(CustomerList));
        }

        public void Generate_WhenGivingOnePackageTypeWithOtherDetails_ShouldReturnTheBill()
        {
            List<CDR> ListOfCallFrom1Number = new List<CDR>();
            // Arrange
            CDR cdrForTest = new CDR(0711535724, 0711591231, new DateTime(2017, 12, 23, 9, 0, 0), new DateTime(0, 0, 0, 9, 0, 0), 100);
            List<Customer> CustomerList = new List<Customer>();
            //Customer(string FullNmae, string Billingaddress, int PhoneNumber, string PackageCode, DateTime RegisteredDate)
            Customer Costomerfortest = new Customer("kaja", "karampakam", 0771234567, "2324", new DateTime(2017, 12, 23, 9, 0, 0));
            //   CDR cdrForTest = new CDR(0711535724, 0711593911, new DateTime(2017, 12, 23, 9, 0, 0), 58);
            ListOfCallFrom1Number.Add(cdrForTest);
            CustomerList.Add(Costomerfortest);
            string expected = "Customer Name: FirstName SecondName" +
                "\nPhone number: 711535724" +
                "\nAddress: Address1, Address2." +
                "\nTotal Amount to Pay: LKR: 167.89";

            // Act
            Sut.GnerateFinalForPackageA(cdrForTest);

            // Assert
            NUnit.Framework.Assert.AreEqual(expected, Sut.GetTheBillForPackageD(CustomerList));
        }
    }
}
