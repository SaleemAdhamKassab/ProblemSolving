
using System;

namespace Lab.Classes
{
    public class clsDate
    {
        public int day, month, year;
    }
    internal class SaleemDate
    {
        int _day, _month, _year;
        struct yearDetails
        {
            public int days, hours, minutes, secounds;
        }

        public SaleemDate()
        {
            _day = DateTime.Now.Day;
            _month = DateTime.Now.Month;
            _year = DateTime.Now.Year;
        }
        public SaleemDate(string date)
        {
            string[] splitedDate = SaleemString.Split(date, '/');
            _day = int.Parse(splitedDate[0]);
            _month = int.Parse(splitedDate[1]);
            _year = int.Parse(splitedDate[2]);
        }
        public SaleemDate(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }
        public SaleemDate(int dateOrderInYear, int year)
        {
            clsDate date = DayOrderToDate(year, dateOrderInYear);
            _day = date.day;
            _month = date.month;
            _year = date.year;
        }

        //Shared

        static bool isLeapYear(int year) => ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) ? true : false;
        static int numberDaysInAMonth(int year, int monthNumber)
        {
            int[] NumberOfMonthDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return monthNumber == 2 ? (isLeapYear(year) ? 29 : 28) : NumberOfMonthDays[monthNumber - 1];
        }
        static bool isValidMonth(int monthNumber) => !(monthNumber < 1 || monthNumber > 12);
        static bool isValidDay(clsDate date) => !(date.day < 1 || date.day > numberDaysInAMonth(date.year, date.month));
        static int numberOfDaysInAYear(int year) => isLeapYear(year) ? 366 : 365;
        static int numberOfHoursInAYear(int year) => numberOfDaysInAYear(year) * 24;
        static int numberOfMinutesInAYear(int year) => numberOfHoursInAYear(year) * 60;
        static int numberOfSecoundsInAYear(int year) => numberOfMinutesInAYear(year) * 60;
        static string monthName(int monthNumber)
        {
            string[] monthsNames = new string[] { "Jan", "Feb", "Mar", "Apr",
                                                  "May", "Jun", "July", "Aug",
                                                  "Sep", "Oct", "Nov", "Dec" };
            return monthsNames[monthNumber - 1];
        }
        static void printWeekDay()
        {
            string[] weekDaysName = new string[] { "Sun", "Mon", "Tus", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine();

            for (int i = 0; i < weekDaysName.Length; i++)
                Console.Write(weekDaysName[i] + "  ");
            Console.WriteLine();
        }
        static void printFirstLineSpaces(int firstMonthDayIndex)
        {
            for (int i = 0; i < firstMonthDayIndex; i++)
                Console.Write("     ");
        }
        static void printMonthDays(int monthDaysCount, int firstMonthDayIndex)
        {
            int lineCounter = firstMonthDayIndex;

            printFirstLineSpaces(firstMonthDayIndex);

            for (int i = 0; i < monthDaysCount; i++)
            {
                Console.Write((i + 1).ToString("00") + "   ");

                lineCounter++;
                if (lineCounter == 7)
                {
                    Console.WriteLine();
                    lineCounter = 0;
                }
            }
            Console.WriteLine();
        }
        static int indexOfDay(int day, int month, int year)
        {
            int a = (14 - month) / 12,
                y = year - a,
                m = month + (12 * a) - 2;

            return (day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
        }

        public void Print() => Console.WriteLine(DateToString());
        public static string DateToString(clsDate date) => date.day + "/" + date.month + "/" + date.year;
        string DateToString() => DateToString();
        public enum enDateCompare { Before = -1, Equal = 0, After = 1 }
        static bool isDate1BeforeDate2(clsDate date1, clsDate date2) =>
           (date1.year < date2.year) ? true : ((date1.year == date2.year) ?
          (date1.month < date2.month ? true :
          (date1.month == date2.month ?
          date1.day < date2.day : false)) : false);
        static bool IsDate1EqualDate2(clsDate Date1, clsDate Date2)
        {
            return (Date1.year == Date2.year) ? ((Date1.month == Date2.month) ? ((Date1.day == Date2.day) ? true : false) : false) : false;
        }

        ////////////////////////////////////////////////////////////////


        //1
        static bool IsLeapYear(int year) => ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) ? true : false;
        static int NumberDaysInAMonth(int year, int monthNumber)
        {
            int[] NumberOfMonthDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return monthNumber == 2 ? (IsLeapYear(year) ? 29 : 28) : NumberOfMonthDays[monthNumber - 1];
        }
        public static clsDate DayOrderToDate(int year, int totalDayFromTheBeggingOfYear)
        {
            clsDate date = new clsDate();

            int remainingDays = totalDayFromTheBeggingOfYear;
            int MonthDays = 0;
            date.month = 1;

            while (true)
            {
                MonthDays = NumberDaysInAMonth(year, date.month);

                if (remainingDays > MonthDays)
                {
                    remainingDays -= MonthDays;
                    date.month++;
                }
                else
                {
                    date.day = remainingDays;
                    break;
                }
            }

            return date;
        }

        //2
        public static clsDate GetSysDate()
        {
            clsDate sysDate = new clsDate();

            sysDate.day = DateTime.Now.Day;
            sysDate.month = DateTime.Now.Month;
            sysDate.year = DateTime.Now.Year;

            return sysDate;
        }

        //3
        public static bool isValidDate(clsDate date) => isValidDay(date) && isValidMonth(date.month);

        //4
        static yearDetails getYearDetails(int year)
        {
            yearDetails yearDetails = new yearDetails();

            yearDetails.days = numberOfDaysInAYear(year);
            yearDetails.hours = numberOfHoursInAYear(year);
            yearDetails.minutes = numberOfMinutesInAYear(year);
            yearDetails.secounds = numberOfSecoundsInAYear(year);

            return yearDetails;
        }

        //5
        static void printMonthCalendar(int year, int monthNumber)
        {
            Console.WriteLine("_____________{0}_________________", monthName((monthNumber)));
            printWeekDay();
            printMonthDays(numberDaysInAMonth(year, monthNumber), indexOfDay(1, monthNumber, year));
            Console.WriteLine("_________________________________");
        }
        //6
        static void printYearCalander(int year)
        {
            Console.WriteLine("_____________Calender {0}_________________", year);
            Console.WriteLine();

            for (int i = 1; i <= 12; i++)
            {
                printMonthCalendar(year, i);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        //7
        public static enDateCompare CompareDates(clsDate date1, clsDate date2)
        {
            if (isDate1BeforeDate2(date1, date2))
                return enDateCompare.Before;
            else if (IsDate1EqualDate2(date1, date2))
                return enDateCompare.Equal;
            else
                return
                    enDateCompare.After;
        }

        //8	
        public static bool IsDate1AfterDate2(clsDate Date1, clsDate Date2)
        {
            return (!IsDate1BeforeDate2(Date1, Date2) && !IsDate1EqualDate2(Date1, Date2));
        }

        //9
        public static bool IsDate1BeforeDate2(clsDate Date1, clsDate Date2)
        {
            return (Date1.year < Date2.year) ? true : ((Date1.year == Date2.year) ? (Date1.month < Date2.month ? true : (Date1.month == Date2.month ? Date1.day < Date2.day : false)) : false);
        }

        //10
        public static bool IsDateBetween(clsDate Date, clsDate From, clsDate To)
        {
            //Date>=From && Date<=To
            if ((IsDate1AfterDate2(Date, From) || IsDate1EqualDate2(Date, From)) &&
                (IsDate1BeforeDate2(Date, To) || IsDate1EqualDate2(Date, To)))
            {
                return true;
            }

            //Date>=To && Date<=From
            if ((IsDate1AfterDate2(Date, To) ||IsDate1EqualDate2(Date, To))
                &&
                (IsDate1BeforeDate2(Date, From) || IsDate1EqualDate2(Date, From))
                )
            {
                return true;
            }

            return false;
        }


    }
}
