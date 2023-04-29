using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Classes
{
    internal class SaleemPeriod
    {
        public clsDate StartDate;
        public clsDate EndDate;

        SaleemPeriod(clsDate StartDate, clsDate EndDate)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;

        }
        static bool IsOverlapPeriods(SaleemPeriod Period1, SaleemPeriod Period2)
        {

            if (
                SaleemDate.CompareDates(Period2.EndDate, Period1.StartDate) == SaleemDate.enDateCompare.Before
                ||
                SaleemDate.CompareDates(Period2.StartDate, Period1.EndDate) == SaleemDate.enDateCompare.After
                )
                return false;
            else
                return true;

        }
    }
}
