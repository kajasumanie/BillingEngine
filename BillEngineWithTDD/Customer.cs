using System;

namespace BillEngineWithTDD
{
  public class Customer
    {
        private string FullNmae;
        private string Billingaddress;
        private int PhoneNumber;
        private string PackageCode;
        private DateTime RegisteredDate;
        public Customer()
        {
        }
        public Customer(string FullNmae, string Billingaddress, int PhoneNumber, string PackageCode, DateTime RegisteredDate)
        {
            this.FullNmae = FullNmae;
            this.Billingaddress = Billingaddress;
            this.PhoneNumber = PhoneNumber;
            this.PackageCode = PackageCode;
            this.RegisteredDate = RegisteredDate;
        }
        
        public string Fullnmae
        {
            get { return FullNmae; }
            set { FullNmae = value; }
        }

        public string BillingAddress
        {
            get { return Billingaddress; }
            set { Billingaddress = value; }
        }
        public int Phonenumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        public string Packagecode
        {
            get { return PackageCode; }
            set { PackageCode = value; }
        }
        public DateTime Registereddate
        {
            get { return RegisteredDate; }
            set { RegisteredDate = value; }
        }
    }
}
