using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToCheckID_11142016
{
    class countDays
    {
        // this function count total number of day during the first year of birth, it is working perfect,        
        public int coundDaysDuringFirstYearBirth(int month, int day, bool leapYear)
        {
            int totalDaysFirstYear;
            int userMonth = month;
            int userDay = day;
            int totalDay31 = 31;
            int totalDays30 = 30;
            int totalDays28 = 28;
            int totalDays29 = 29;
            int userRecentMonthDays;
            int totalDays = 0;
            StreamWriter outputDataFileFirstYearBirth = new StreamWriter("C:\\Users\\kings\\Desktop\\ID Data\\outputDataFileFirstYearBirth.txt");

            #region count total number of day from inbetween of month because people born at different data
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                userRecentMonthDays = 31 - day;
            }
            else if (leapYear == true && month == 2)
            {
                userRecentMonthDays = 29 - day;
            }
            else if (leapYear == false && month == 2)
            {
                userRecentMonthDays = 28 - day;
            }
            else
            {
                userRecentMonthDays = 30 - day;
            }
            outputDataFileFirstYearBirth.WriteLine(Convert.ToString("userRecentMonthDays #" + userRecentMonthDays + "\n"));
            #endregion

            #region count total number of days in each month
            for (int i = month + 1; i <= 12; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    totalDays += totalDay31;
                    outputDataFileFirstYearBirth.WriteLine(Convert.ToString("Month #" + i + " " + totalDay31 + "\n"));
                }
                else if (leapYear == true && i == 2)
                {
                    totalDays += totalDays29;
                    outputDataFileFirstYearBirth.WriteLine(Convert.ToString("Month #" + i + " " + totalDays29 + "\n"));
                }
                else if (leapYear == false && i == 2)
                {
                    totalDays += totalDays28;
                    outputDataFileFirstYearBirth.WriteLine(Convert.ToString("Month #" + i + " " + totalDays28 + "\n"));
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    totalDays += totalDays30;
                    outputDataFileFirstYearBirth.WriteLine(Convert.ToString("Month #" + i + " " + totalDays30 + "\n"));
                }
            }
            #endregion
            totalDaysFirstYear = totalDays + userRecentMonthDays;
            outputDataFileFirstYearBirth.WriteLine(Convert.ToString("total before Month #" + totalDays + "\n"));
            outputDataFileFirstYearBirth.Close();
            return totalDaysFirstYear;
        }

        // this function calculate the total number of days of running year after the present date till end of the year
        public int coundDaysOfLastRunningYear(int month, int day, bool leapYear)
        {
            int totalDaysLastYear;
            int userMonth = month;
            int userDay = day;
            int totalDay31 = 31;
            int totalDays30 = 30;
            int totalDays28 = 28;
            int totalDays29 = 29;
            int userRecentMonthDays;
            int dumyRecentMonthDays;
            int totalDays = 0;
            StreamWriter outputDataFileRunningYear = new StreamWriter("C:\\Users\\kings\\Desktop\\ID Data\\outputDataFileRunningYear.txt");

            #region count total number of days in each month
            for (int i = 1; i < month; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    totalDays += totalDay31;
                    outputDataFileRunningYear.WriteLine(Convert.ToString("Month #" + i + " " + totalDay31 + "\n"));
                }
                else if (leapYear == true && i == 2)
                {
                    totalDays += totalDays29;
                    outputDataFileRunningYear.WriteLine(Convert.ToString("Month #" + i + " " + totalDays29 + "\n"));
                }
                else if (leapYear == false && i == 2)
                {
                    totalDays += totalDays28;
                    outputDataFileRunningYear.WriteLine(Convert.ToString("Month #" + i + " " + totalDays28 + "\n"));
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    totalDays += totalDays30;
                    outputDataFileRunningYear.WriteLine(Convert.ToString("Month #" + i + " " + totalDays30 + "\n"));
                }
            }
            #endregion

            #region count total number of day from inbetween of month because people born at different data
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                dumyRecentMonthDays = 31 - day;
                userRecentMonthDays = 31 - dumyRecentMonthDays;
            }
            else if (leapYear == true && month == 2)
            {
                dumyRecentMonthDays = 29 - day;
                userRecentMonthDays = 29 - dumyRecentMonthDays;
            }
            else if (leapYear == false && month == 2)
            {
                dumyRecentMonthDays = 28 - day;
                userRecentMonthDays = 28 - dumyRecentMonthDays;
            }
            else
            {
                dumyRecentMonthDays = 30 - day;
                userRecentMonthDays = 30 - dumyRecentMonthDays;
            }
            outputDataFileRunningYear.WriteLine(Convert.ToString("userRecentMonthDays #" + month + " " + userRecentMonthDays + "\n"));
            #endregion

            totalDaysLastYear = totalDays + userRecentMonthDays;
            outputDataFileRunningYear.WriteLine(Convert.ToString("total before Month #" + totalDaysLastYear + "\n"));
            outputDataFileRunningYear.Close();
            return totalDaysLastYear;
        }

        // this function calculate the total number of days of running year from the begineening to till that present date
        public int coundDaysOfBeginningRunningYear(int month, int day, bool leapYear)
        {
            int totalDaysLastYear;
            int userMonth = month;
            int userDay = day;
            int totalDay31 = 31;
            int totalDays30 = 30;
            int totalDays28 = 28;
            int totalDays29 = 29;
            int userRecentMonthDays;
            int dumyRecentMonthDays;
            int totalDays = 0;
            StreamWriter outputDataFileBeginningRunningYear = new StreamWriter("C:\\Users\\kings\\Desktop\\ID Data\\outputDataFileBeginningRunningYear.txt");

            #region count total number of days in each month
            for (int i = 1; i < month; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    totalDays += totalDay31;
                    outputDataFileBeginningRunningYear.WriteLine(Convert.ToString("Month #" + i + " " + totalDay31 + "\n"));
                }
                else if (leapYear == true && i == 2)
                {
                    totalDays += totalDays29;
                    outputDataFileBeginningRunningYear.WriteLine(Convert.ToString("Month #" + i + " " + totalDays29 + "\n"));
                }
                else if (leapYear == false && i == 2)
                {
                    totalDays += totalDays28;
                    outputDataFileBeginningRunningYear.WriteLine(Convert.ToString("Month #" + i + " " + totalDays28 + "\n"));
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    totalDays += totalDays30;
                    outputDataFileBeginningRunningYear.WriteLine(Convert.ToString("Month #" + i + " " + totalDays30 + "\n"));
                }
            }
            #endregion

            #region count total number of day from inbetween of month because people born at different data
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                dumyRecentMonthDays = 31 - day;
                userRecentMonthDays = day;
            }
            else if (leapYear == true && month == 2)
            {
                dumyRecentMonthDays = 29 - day;
                userRecentMonthDays = day;
            }
            else if (leapYear == false && month == 2)
            {
                dumyRecentMonthDays = 28 - day;
                userRecentMonthDays = day;
            }
            else
            {
                dumyRecentMonthDays = 30 - day;
                userRecentMonthDays = day;
            }
            outputDataFileBeginningRunningYear.WriteLine(Convert.ToString("userRecentMonthDays #" + month + " " + userRecentMonthDays + "\n"));
            #endregion

            totalDaysLastYear = totalDays + userRecentMonthDays;
            outputDataFileBeginningRunningYear.WriteLine(Convert.ToString("total before Month #" + totalDaysLastYear + "\n"));
            outputDataFileBeginningRunningYear.Close();
            return totalDaysLastYear;
        }
    }
}
