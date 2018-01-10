using System;
using System.Collections.Generic;

namespace BillEngineWithTDD
{
    public class GnerateFinalBill
    {
      
        CDR nm = new CDR();
        Customer pm = new Customer();
        
        double WithOutTaxbill;
    
            public double GnerateFinalForPackageA(CDR cdrForTest)
            {
            int PhoneNoEx = Convert.ToInt32(nm.PhOneNo.ToString().Substring(0, 3));
           // int PhoneNoEx = nm.PhOneNo.Substring(0, 3);
            int REceivePhoneEx = Convert.ToInt32(nm.ReceiVePhoneNo.ToString().Substring(0, 3));
         double DurationInMinite =nm.DuRation.Minute;
          
                    if (Convert.ToDateTime("10:00") <= nm.StaRtTime && nm.StaRtTime <= Convert.ToDateTime("18:00") && (PhoneNoEx != REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
                    {
                        WithOutTaxbill = nm.Bill + DurationInMinite * 5;
                        nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
                    }

                    else if (Convert.ToDateTime("10:00") >= nm.StaRtTime && nm.StaRtTime >= Convert.ToDateTime("18:00") && (PhoneNoEx == REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
                    {
                        WithOutTaxbill = nm.Bill + DurationInMinite * 4;
                        nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
                    }
                    else if (Convert.ToDateTime("10:00") <= nm.StaRtTime && nm.StaRtTime <= Convert.ToDateTime("18:00") && (PhoneNoEx == REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
                    {
                        WithOutTaxbill = nm.Bill + DurationInMinite * 3;
                        nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
                    }
                    else if (Convert.ToDateTime("10:00") >= nm.StaRtTime && nm.StaRtTime >= Convert.ToDateTime("18:00") && (PhoneNoEx != REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
                    {
                        WithOutTaxbill = nm.Bill + DurationInMinite * 2;
                        nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
                    }
                    else
                    {
                        nm.Bill = nm.Bill;
                    }
         
            return nm.Bill;
        }

        internal double GetTheBillForPackageA(List<Customer> customerList)
        {
            throw new NotImplementedException();
        }

        public double GnerateFinalForPackageB(CDR cdrForTest)
        {
            //•	Make the first minute of all local off-peak calls free of charge for Package B
            int PhoneNoEx = Convert.ToInt32(nm.PhOneNo.ToString().Substring(0, 3));
            // int PhoneNoEx = nm.PhOneNo.Substring(0, 3);
            int REceivePhoneEx = Convert.ToInt32(nm.ReceiVePhoneNo.ToString().Substring(0, 3));

            double DurationInSecound = nm.DuRation.Second;
            if (Convert.ToDateTime("08:00") <= nm.StaRtTime && nm.StaRtTime <= Convert.ToDateTime("20:00") && (PhoneNoEx != REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInSecound * 6;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }

            else if (Convert.ToDateTime("08:00") >= nm.StaRtTime && nm.StaRtTime >= Convert.ToDateTime("20:00") && (PhoneNoEx == REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                if(DurationInSecound<=60)
                {
                    nm.Bill = nm.Bill;
                }
                else
                {
                    WithOutTaxbill = nm.Bill + DurationInSecound * 5-(DurationInSecound*60*5);
                    nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
                }
               
            }
            else if (Convert.ToDateTime("08:00") <= nm.StaRtTime && nm.StaRtTime <= Convert.ToDateTime("20:00") && (PhoneNoEx == REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInSecound * 4;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }
            else if (Convert.ToDateTime("08:00") >= nm.StaRtTime && nm.StaRtTime >= Convert.ToDateTime("20:00") && (PhoneNoEx != REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInSecound * 3;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }
            else
            {
                nm.Bill = nm.Bill;
            }


            return nm.Bill;
        }
        public double GnerateFinalForPackageC(CDR cdrForTest)
        {
            int PhoneNoEx = Convert.ToInt32(nm.PhOneNo.ToString().Substring(0, 3));
            // int PhoneNoEx = nm.PhOneNo.Substring(0, 3);
            int REceivePhoneEx = Convert.ToInt32(nm.ReceiVePhoneNo.ToString().Substring(0, 3));
            double DurationInMinite = nm.DuRation.Minute;
            if (Convert.ToDateTime("09:00") <= nm.StaRtTime && nm.StaRtTime <= Convert.ToDateTime("18:00") && (PhoneNoEx != REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInMinite * 3;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }

            else if (Convert.ToDateTime("09:00") >= nm.StaRtTime && nm.StaRtTime >= Convert.ToDateTime("18:00") && (PhoneNoEx == REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInMinite * 2;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }
            else if (Convert.ToDateTime("09:00") <= nm.StaRtTime && nm.StaRtTime <= Convert.ToDateTime("18:00") && (PhoneNoEx == REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInMinite * 2;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }
            else if (Convert.ToDateTime("09:00") >= nm.StaRtTime && nm.StaRtTime >= Convert.ToDateTime("18:00") && (PhoneNoEx != REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInMinite * 1;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }
            else
            {
                nm.Bill = nm.Bill;
            }


            return nm.Bill;
        }
        public double GnerateFinalForPackageD(CDR cdrForTest)
        {
            int PhoneNoEx = Convert.ToInt32(nm.PhOneNo.ToString().Substring(0, 3));
            // int PhoneNoEx = nm.PhOneNo.Substring(0, 3);
            int REceivePhoneEx = Convert.ToInt32(nm.ReceiVePhoneNo.ToString().Substring(0, 3));
            double DurationInSecound = nm.DuRation.Second;
            if (Convert.ToDateTime("08:00") <= nm.StaRtTime && nm.StaRtTime <= Convert.ToDateTime("20:00") && (PhoneNoEx != REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInSecound * 5;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }

            else if (Convert.ToDateTime("08:00") >= nm.StaRtTime && nm.StaRtTime >= Convert.ToDateTime("20:00") && (PhoneNoEx == REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInSecound * 4;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }
            else if (Convert.ToDateTime("08:00") <= nm.StaRtTime && nm.StaRtTime <= Convert.ToDateTime("20:00") && (PhoneNoEx == REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInSecound * 3;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }
            else if (Convert.ToDateTime("08:00") >= nm.StaRtTime && nm.StaRtTime >= Convert.ToDateTime("20:00") && (PhoneNoEx != REceivePhoneEx) && (nm.PhOneNo != nm.ReceiVePhoneNo))
            {
                WithOutTaxbill = nm.Bill + DurationInSecound * 2;
                nm.Bill = WithOutTaxbill + (WithOutTaxbill % 20);
            }
            else
            {
                nm.Bill = nm.Bill;
            }


            return nm.Bill;
        }
       

        internal void GetTheBillForPackageA(Customer customerList)
        {
            double x = GnerateFinalForPackageA();
         Console.WriteLine(x);
            //  string expected = "Customer Name: FirstName SecondName" +
            // "\nPhone number: 711535724" +
            //   "\nAddress: Address1, Address2." +
            //  "\nTotal Amount to Pay: LKR: 123.6";
            Console.WriteLine("Customer Name:"+ pm.Fullnmae + "\nPhone number:"+pm.Phonenumber + "\nAddress:"+pm.BillingAddress+ "\nTotal Amount to Pay:" + GnerateFinalForPackageA());
            //throw new NotImplementedException();
        }

        internal double GetTheBillForPackageD(List<Customer> customerList)
        {
            throw new NotImplementedException();
        }

        internal void GetTheBillForPackageB(Customer customerList)
        {
            double x = GnerateFinalForPackageB();
            Console.WriteLine(x);
            //  string expected = "Customer Name: FirstName SecondName" +
            // "\nPhone number: 711535724" +
            //   "\nAddress: Address1, Address2." +
            //  "\nTotal Amount to Pay: LKR: 123.6";
            Console.WriteLine("Customer Name:" + pm.Fullnmae + "\nPhone number:" + pm.Phonenumber + "\nAddress:" + pm.BillingAddress + "\nTotal Amount to Pay:" + GnerateFinalForPackageA());
            //throw new NotImplementedException();
        }

        private double GnerateFinalForPackageB()
        {
            throw new NotImplementedException();
        }

        internal void GetTheBillForPackageC(Customer customerList)
        {
            double x = GnerateFinalForPackageC();
            Console.WriteLine(x);
            //  string expected = "Customer Name: FirstName SecondName" +
            // "\nPhone number: 711535724" +
            //   "\nAddress: Address1, Address2." +
            //  "\nTotal Amount to Pay: LKR: 123.6";
            Console.WriteLine("Customer Name:" + pm.Fullnmae + "\nPhone number:" + pm.Phonenumber + "\nAddress:" + pm.BillingAddress + "\nTotal Amount to Pay:" + GnerateFinalForPackageA());
            //throw new NotImplementedException();
        }

        private double GnerateFinalForPackageC()
        {
            throw new NotImplementedException();
        }

        internal void GetTheBillForPackageD(Customer customerList)
        {
            double x = GnerateFinalForPackageD();
            Console.WriteLine(x);
            //  string expected = "Customer Name: FirstName SecondName" +
            // "\nPhone number: 711535724" +
            //   "\nAddress: Address1, Address2." +
            //  "\nTotal Amount to Pay: LKR: 123.6";
            Console.WriteLine("Customer Name:" + pm.Fullnmae + "\nPhone number:" + pm.Phonenumber + "\nAddress:" + pm.BillingAddress + "\nTotal Amount to Pay:" + GnerateFinalForPackageA());
            //throw new NotImplementedException();
        }

        private double GnerateFinalForPackageD()
        {
            throw new NotImplementedException();
        }

        private double GnerateFinalForPackageA()
        {
            throw new NotImplementedException();
        }
    }
}


