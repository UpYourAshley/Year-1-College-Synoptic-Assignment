using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynopticApplication.Enum;

namespace SynopticApplication
{
    public class Paitent
    {
        public string Name { get; set; }

        public Int64 PhoneNumber { get; set; }

        public Address Address { get; set; }

        public string PostCode { get; set; }

        public DateStruct DOB { get; set; }

        public int NHSNumber { get; set; }

        public Drug DrugTaken { get; set; }
        public int Dose { get; set; }
        public SideEffect[] SideEffects { get; set; }

        public DateStruct FirtTakenDate { get; set; }
        public bool ContinuedToTake { get; set; }

    }

    public struct DateStruct
    {
        public int year;
        public int month;
        public int day;
    }

    public struct Address
    {
        public string postcode;
        public string addressLineOne;
        public string addressLineTwo;
        public string addressLineThree;
    }
}
