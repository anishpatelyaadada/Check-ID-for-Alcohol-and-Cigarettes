using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ToCheckID_11142016
{
    public partial class CheckID : Form
    {
        countDays countDay = new countDays();
        
        public CheckID()
        {
            InitializeComponent();
        }

        public int countInBetweenYear(int todayYear, int userYearInput)
        {
            StreamWriter yearAndTotalDays = new StreamWriter("C:\\Users\\kings\\Desktop\\ID Data\\yearAndTotalDays.txt");

            int totalDays = 0;
            int totalYear = 0;
            int recentYear;
            recentYear = todayYear - 1;
            int userYear;
            userYear = userYearInput + 1;

            for (int i = userYear; i <= recentYear; i++)
            {
                if (i % 4 == 0)
                {
                    totalDays += 366;
                    yearAndTotalDays.WriteLine(Convert.ToString("Year Days #" + i + " " + 366 + "\n"));
                }
                else
                {
                    totalDays += 365;
                    yearAndTotalDays.WriteLine(Convert.ToString("Year Days #" + i + " "+ 365 + "\n"));

                }
                totalYear++;
            }
            yearAndTotalDays.WriteLine(Convert.ToString("Total Days #" + totalDays + "\n"));
            yearAndTotalDays.WriteLine(Convert.ToString("Total Year #" + totalYear + "\n"));

            yearAndTotalDays.Close();
            return totalYear;
        }

        public void ToDetermineValidID(int firstYearDays, int lastYearAfterBirthDays, int lastYearBeginningDays, int totalYears, bool leapYear)
        {
            StreamWriter ToDetermineValidIDFile = new StreamWriter("C:\\Users\\kings\\Desktop\\ID Data\\ToDetermineValidIDFile.txt");
            int totalFirstandLastBeginningDays = firstYearDays + lastYearBeginningDays;

            if (firstYearDays != null && lastYearAfterBirthDays != null && lastYearBeginningDays != null)
            {
                ToDetermineValidIDFile.WriteLine(Convert.ToString("firstYearDays = " + firstYearDays + ".\n"));
                ToDetermineValidIDFile.WriteLine(Convert.ToString("lastYearAfterBirthDays = " + lastYearAfterBirthDays + ".\n"));
                ToDetermineValidIDFile.WriteLine(Convert.ToString("lastYearBeginningDays = " + lastYearBeginningDays + ".\n"));
                ToDetermineValidIDFile.WriteLine(Convert.ToString("leapYear = " + leapYear + ".\n"));

                #region to determine eligibility for cigerate
                if (totalYears >= 18)
                {                    //cigeratete eligible
                    ToDetermineValidIDFile.WriteLine(Convert.ToString("cigeratete eligible.\n"));
                    CigaretteTextBox.Text = "Cigarette \nGood";
                    CigaretteTextBox.BackColor = Color.Green;
                }
                else if (totalYears == 17)
                {
                    if (leapYear == true)
                    {
                        if (totalFirstandLastBeginningDays >= 367) // leap year true, 367 because the alcohol they will be eligible to rececive after next days
                        {                            // cigeratte eligible
                            ToDetermineValidIDFile.WriteLine(Convert.ToString("cigeratete eligible.\n"));
                            CigaretteTextBox.Text = "Cigarette \nGood";
                            CigaretteTextBox.BackColor = Color.Green;
                        }
                        else
                        {                            // not cigeratte eligible
                            ToDetermineValidIDFile.WriteLine(Convert.ToString("not cigeratte eligible.\n"));
                            CigaretteTextBox.Text = "Cigarette \nNot Good";
                            CigaretteTextBox.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        if (totalFirstandLastBeginningDays >= 366)// 366 because the alcohol they will be eligible to rececive after next days
                        {                            // cigeratte eligible
                            ToDetermineValidIDFile.WriteLine(Convert.ToString("cigeratete eligible.\n"));
                            CigaretteTextBox.Text = "Cigarette \nGood";
                            CigaretteTextBox.BackColor = Color.Green;
                        }
                        else
                        {                            // not cigeratte eligible
                            ToDetermineValidIDFile.WriteLine(Convert.ToString("not cigeratte eligible.\n"));
                            CigaretteTextBox.Text = "Cigarette \n Not Good";
                            CigaretteTextBox.BackColor = Color.Red;
                        }
                    }
                }
                else if (totalYears < 17)// if inbetween year is less than 17, the for sure they are minor
                {                    // not Alcohol eligible
                    ToDetermineValidIDFile.WriteLine(Convert.ToString("not cigeratte eligible.\n"));
                    CigaretteTextBox.Text = "Cigarette \nNot Good";
                    CigaretteTextBox.BackColor = Color.Red;
                }
                #endregion

                #region to determine eligibility for alcohol
                if (totalYears >= 21) // if inbetween year is greater than 21, then for sure the person is 21 year older
                {
                    //Alcohol eligible
                    ToDetermineValidIDFile.WriteLine(Convert.ToString("Alcohol eligible.\n"));
                    AlcoholTextBox.Text = "Alcohol \nGood";
                    AlcoholTextBox.BackColor = Color.Green;

                }
                else if (totalYears == 20)  //  if inbetween year is greater than 20, then count the days during the beginning of recent year and days after birth of that year
                {
                    if (leapYear == true)
                    {
                        if (totalFirstandLastBeginningDays >= 367) // leap year true, 367 because the alcohol they will be eligible to rececive after next days
                        {                            // Alcohol eligible
                            ToDetermineValidIDFile.WriteLine(Convert.ToString("Alcohol eligible.\n"));
                            AlcoholTextBox.Text = "Alcohol \nGood";
                            AlcoholTextBox.BackColor = Color.Green;
                        }
                        else
                        {                            // not Alcohol eligible
                            ToDetermineValidIDFile.WriteLine(Convert.ToString("not Alcohol eligible.\n"));
                            AlcoholTextBox.Text = "Alcohol \nNot Good";
                            AlcoholTextBox.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        if (totalFirstandLastBeginningDays >= 366)// 366 because the alcohol they will be eligible to rececive after next days
                        {                            // Alcohol eligible
                            ToDetermineValidIDFile.WriteLine(Convert.ToString("Alcohol eligible.\n"));
                            AlcoholTextBox.Text = "Alcohol \nGood";
                            AlcoholTextBox.BackColor = Color.Green;
                        }
                        else
                        {                            // not Alcohol eligible
                            ToDetermineValidIDFile.WriteLine(Convert.ToString("not Alcohol eligible.\n"));
                            AlcoholTextBox.Text = "Alcohol \nNot Good";
                            AlcoholTextBox.BackColor = Color.Red;
                        }
                    }
                }
                else if (totalYears < 20) // if inbetween year is less than 20, the for sure they are minor
                {                    // not Alcohol eligible
                    ToDetermineValidIDFile.WriteLine(Convert.ToString("not Alcohol eligible.\n"));
                    AlcoholTextBox.Text = "Alcohol \nNot Good";
                    AlcoholTextBox.BackColor = Color.Red;
                }
            }
            #endregion
            else
            {
                ToDetermineValidIDFile.WriteLine(Convert.ToString("The data is null.\n"));
                ToDetermineValidIDFile.WriteLine(Convert.ToString("lastYearAfterBirthDays = " + lastYearAfterBirthDays + ".\n"));
            }


            ToDetermineValidIDFile.Close();
        }

        public void ProcessTheDate_Click(object sender, EventArgs e)
        {
            #region list of define variable int,string, streamwriter, DateTime
            String inputyearString = null;
            int inputYearMonth = new int();
            int inputYearDay = new int();
            int inputYearYear = new int();
            int totalDay = new int();
            int totalYearInBetween = new int();
            StreamWriter count365DaysTextFile = new StreamWriter("C:\\Users\\kings\\Desktop\\ID Data\\count365DaysTextFile.txt");
            bool leapYear = false;
            DateTime time = DateTime.Today;
            #endregion

            if (getDate.Text.Length == 0)
            {
                this.getDate.Name = "mm/dd/yyyy";
                this.getDate.ForeColor = SystemColors.WindowText;
            }
            else
            {
                inputyearString = getDate.Text;
                inputYearMonth = Convert.ToInt32(inputyearString.Substring(0, 2));
                inputYearDay = Convert.ToInt32(inputyearString.Substring(3, 2));
                inputYearYear = Convert.ToInt32(inputyearString.Substring(6, 4));

                totalYearInBetween = countInBetweenYear(time.Year, inputYearYear);

                if (inputYearYear % 4 == 0 || time.Year % 4 == 0)
                    leapYear = true;
                else
                    leapYear = false;

                int firstYearDays = countDay.coundDaysDuringFirstYearBirth(inputYearMonth, inputYearDay, leapYear);
                int lastYearAfterBirthDays = countDay.coundDaysOfLastRunningYear(time.Month, time.Day, leapYear);
                int lastYearBeginningDays = countDay.coundDaysOfBeginningRunningYear(time.Month, time.Day, leapYear);

                ToDetermineValidID(firstYearDays, lastYearAfterBirthDays, lastYearBeginningDays, totalYearInBetween, leapYear);

                count365DaysTextFile.WriteLine(Convert.ToString("Input year is leap or not = " + leapYear + ".\n"));
                //  count365DaysTextFile.WriteLine(Convert.ToString("Recent year is leap or not = " + leapYear + ".\n"));
                count365DaysTextFile.WriteLine(Convert.ToString("Today Date = " + time.Date + ".\n"));
                count365DaysTextFile.WriteLine(Convert.ToString("Today Date = " + time.Date + ".\n"));
                count365DaysTextFile.WriteLine(Convert.ToString("Input Date = " + getDate.Text + ".\n"));
                count365DaysTextFile.WriteLine(Convert.ToString("firstYearDays = " + firstYearDays + ".\n"));
                count365DaysTextFile.WriteLine(Convert.ToString("lastYearAfterBirthDays = " + lastYearAfterBirthDays + ".\n"));
                count365DaysTextFile.WriteLine(Convert.ToString("lastYearBeginningDays = " + lastYearBeginningDays + ".\n"));
                count365DaysTextFile.WriteLine(Convert.ToString("Total Days First and last year begining = " + (lastYearBeginningDays + firstYearDays) + ".\n"));

            }
            count365DaysTextFile.Close();
        }


        private void Two_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(2));
        }

        private void Three_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(3));
        }

        private void Four_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(4));
        }

        private void Five_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(5));
        }

        private void Six_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(6));
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(7));
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(8));
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(9));
        }

        private void Dash_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString('-'));
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString(0));
        }

        private void ForwardSlash_Click(object sender, EventArgs e)
        {
            getDate.AppendText(Convert.ToString('/'));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            getDate.Text = getDate.Text.Remove(getDate.Text.Length - 1, 1);
        }    

        private void one_Click(object sender, EventArgs e)
        {
          
            getDate.AppendText(Convert.ToString(1));
        }
    }
}
