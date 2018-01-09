using System;

namespace BillEngineWithTDD
{
public  class CDR
    {
        private int PhoneNo;
        private int ReceivePhoneNo;
        private DateTime StartTime;
        private DateTime Duration;
        private double bill;
        private int v1;
        private int v2;
        private DateTime dateTime;
        private int v3;
       
        public CDR()
        {
          
        }

        public CDR(int v1, int v2, DateTime dateTime, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dateTime = dateTime;
            this.v3 = v3;
        }

        public CDR(int PhoneNo, int ReceivePhoneNo, DateTime StartTime, DateTime Duration, double bill)
        {
            this.PhoneNo = PhoneNo;
            this.ReceivePhoneNo = ReceivePhoneNo;
            this.StartTime = StartTime;
            this.Duration = Duration;
            this.bill = bill;
          
        }
      /*  public string Package
        {
            get { return package; }
            set { package = value; }
        }*/
        public int PhOneNo
        {
            get { return PhoneNo; }
            set { PhoneNo = value; }
        }

        public int ReceiVePhoneNo
        {
            get { return ReceivePhoneNo; }
            set { ReceivePhoneNo = value; }
        }
        public DateTime StaRtTime
        {
            get { return StartTime; }
            set { StartTime = value; }
        }
        public DateTime DuRation
        {
            get { return Duration; }
            set { Duration = value; }
        }
        public double Bill
        {
            get { return bill; }
            set { bill = value; }
        }
    }
}
