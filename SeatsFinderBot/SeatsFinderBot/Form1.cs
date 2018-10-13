using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Net;
using OpenQA.Selenium.Support.UI;

namespace SeatsFinderBot
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subjectText_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberText_TextChanged(object sender, EventArgs e)
        {

        }

        private void sectionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private static bool IsElementPresent(ChromeDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private static String SuperPowerAutomates_add(String username, String password, String sectionNum)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");

            var driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://go.oasis.asu.edu/addclass/?STRM=2197&ACAD_CAREER=GRAD");

            //Login
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@src='https://weblogin.asu.edu/cgi-bin/login?callapp=https%3A//go.oasis.asu.edu/waitframeset.html%3Fdelay%3D3500%26url%3Dhttps%253A//cs.oasis.asu.edu/asucsprd/golink/%253F/EMPLOYEE/PSFT_ASUCSPRD/s/WEBLIB_ASU_SA.ASU_SA_ISCRIPT.FieldFormula.IScript_SA%253FURL%253D/EMPLOYEE/PSFT_ASUCSPRD/c/SA_LEARNER_SERVICES.SSR_SSENRL_CART.GBL%25253FSTRM%25253D2187%252526ACAD_CAREER%25253DGRAD%252526Page%25253DSSR_SSENRL_ADD%252526Action%25253DA%252526INSTITUTION%25253DASU00%252526golink%25253DY']")));
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.ClassName("submit")).Click();

            //...
            driver.SwitchTo().Frame(0);
            driver.SwitchTo().Frame(0);
            driver.SwitchTo().Frame(2);

            //Empty Shopping Cards
            while (IsElementPresent(driver, By.Id("P_DELETE$0")))
            {
                driver.FindElement(By.Id("P_DELETE$0")).Click();
            }

            Thread.Sleep(2000);

            //Enter Section Number
            driver.FindElement(By.Id("DERIVED_REGFRM1_CLASS_NBR")).SendKeys(sectionNum);
            driver.FindElement(By.Id("DERIVED_REGFRM1_SSR_PB_ADDTOLIST2$9$")).Click();

            //Add Class
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("DERIVED_CLS_DTL_NEXT_PB$280$")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("DERIVED_REGFRM1_LINK_ADD_ENRL$82$")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("DERIVED_REGFRM1_SSR_PB_SUBMIT")).Click();

            //Get Status
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("win0divDERIVED_REGFRM1_SSR_STATUS_LONG$200$$0"));
            var status = driver.PageSource.ToString();
            var FinalStatus = "";
            System.Diagnostics.Debug.WriteLine("status: " + driver.PageSource);
            if (status.Contains("Error"))
            {
                System.Diagnostics.Debug.WriteLine("status: Error");
                FinalStatus = "Error";
            }
            else if (status.Contains("Success"))
            {
                System.Diagnostics.Debug.WriteLine("status: Success");
                FinalStatus = "Success";
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("status: Unknown");
                FinalStatus = "Unknown";
            }
            System.Diagnostics.Debug.WriteLine("FinalStatus: " + FinalStatus);
            return FinalStatus;
        }

        private static String SuperPowerAutomates_swap(String username, String password, String sectionNum)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");

            var driver = new ChromeDriver(options); 

            driver.Navigate().GoToUrl("https://go.oasis.asu.edu/swapclass/?STRM=2197&ACAD_CAREER=GRAD&ASU_CLASS_NBR=" + sectionNum);

            //Login
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@src='https://weblogin.asu.edu/cgi-bin/login?callapp=https%3A//go.oasis.asu.edu/waitframeset.html%3Fdelay%3D3500%26url%3Dhttps%253A//cs.oasis.asu.edu/asucsprd/golink/%253F/EMPLOYEE/PSFT_ASUCSPRD/s/WEBLIB_ASU_SA.ASU_SA_ISCRIPT.FieldFormula.IScript_SA%253FURL%253D/EMPLOYEE/PSFT_ASUCSPRD/c/SA_LEARNER_SERVICES.SSR_SSENRL_SWAP.GBL%25253FSTRM%25253D2187%252526ACAD_CAREER%25253DGRAD%252526ASU_CLASS_NBR%25253D" + sectionNum + "%252526Page%25253DSSR_SSENRL_SWAP%252526Action%25253DA%252526INSTITUTION%25253DASU00%252526golink%25253DY']")));
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.ClassName("submit")).Click();

            //...
            driver.SwitchTo().Frame(0);
            driver.SwitchTo().Frame(0);
            driver.SwitchTo().Frame(2);

            //Empty Shopping Cards
            while (IsElementPresent(driver, By.Id("P_DELETE$0")))
            {
                driver.FindElement(By.Id("P_DELETE$0")).Click();
            }

            //Thread.Sleep(2000);

            // wwSelect class from dropdownlist
            var dropdownlist = driver.FindElement(By.Id("DERIVED_REGFRM1_DESCR50$225$"));

            // create select element object 
            var selectElement = new SelectElement(dropdownlist);

            // select by value
            selectElement.SelectByValue("79036");

            // Click Enter
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("DERIVED_REGFRM1_SSR_PB_ADDTOLIST2$106$")).Click();

            // Click Next
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("DERIVED_CLS_DTL_NEXT_PB")).Click();

            // Click Finish Swaping
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("DERIVED_REGFRM1_SSR_PB_SUBMIT")).Click();

            //Get Status
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("win0divDERIVED_REGFRM1_SSR_STATUS_LONG$200$$0"));
            var status = driver.PageSource.ToString();
            var FinalStatus = "";
            System.Diagnostics.Debug.WriteLine("status: " + driver.PageSource);
            if (status.Contains("Error"))
            {
                System.Diagnostics.Debug.WriteLine("status: Error");
                FinalStatus = "Error";
            }
            else if (status.Contains("Success"))
            {
                System.Diagnostics.Debug.WriteLine("status: Success");
                FinalStatus = "Success";
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("status: Unknown");
                FinalStatus = "Unknown";
            }
            System.Diagnostics.Debug.WriteLine("FinalStatus: " + FinalStatus);
            return FinalStatus;
        }

        private void runAction()
        {
            WebClient client = new WebClient();

            //test 
            //String Test = SuperPowerAutomates_swap("dxiao6", "Xg7DuWfTo6L7aYcukqKg");

            //    01/05/2009 6:01 PM
            string currentTime = DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt");

            string sec = sectionText.Text;
            string res = reservedText.Text;
            string gui = guidText.Text;


            try
            {
                string classStatus = client.DownloadString("https://seatsfinderweb.azurewebsites.net/api/WebAPI?checkClassStatus=true&prefix=&number=&location=Tempe&term=Spring+2019&sectionNumber=" + sec + "&reservedSeats=" + res);

                System.Diagnostics.Debug.WriteLine("classStatus: " + classStatus);

                if (classStatus == "\"FULL\"")
                {
                    // Do nothing
                    client.DownloadString("http://seatsfinderweb.azurewebsites.net/api/WebAPI?GetSuperPowerVMTaskSchedulerStatus=true&guid=" + gui + "&taskID=" + sec + "&time=" + currentTime + "&status=FULL");

                }
                else if (classStatus == "\"OPEN\"")
                {
                    if (swapRadio.Checked)
                    {
                        String FinalStatus = SuperPowerAutomates_swap(userText.Text, passwordText.Text, sectionText.Text);

                        client.DownloadString("http://seatsfinderweb.azurewebsites.net/api/WebAPI?GetSuperPowerVMTaskSchedulerStatus=true&guid=" + gui + "&taskID=" + sec + "&time=" + currentTime + "&status=OPEN");

                        // [Error, Success, Unknown]
                        System.Diagnostics.Debug.WriteLine(FinalStatus);
                    }
                    else if (addRadio.Checked)
                    {
                        String FinalStatus = SuperPowerAutomates_add(userText.Text, passwordText.Text, sectionText.Text);

                        client.DownloadString("http://seatsfinderweb.azurewebsites.net/api/WebAPI?GetSuperPowerVMTaskSchedulerStatus=true&guid=" + gui + "&taskID=" + sec + "&time=" + currentTime + "&status=OPEN");

                        // [Error, Success, Unknown]
                        System.Diagnostics.Debug.WriteLine(FinalStatus);
                    }
                    else
                    {

                    }

                }
                //GetSuperPowerVMTaskSchedulerStatus(string guid, string taskID, string time, bool status)

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception Catched.");

                try
                {
                    client.DownloadString("http://seatsfinderweb.azurewebsites.net/api/WebAPI?GetSuperPowerVMTaskSchedulerStatus=true&guid=" + gui + "&taskID=" + sec + "&time=" + currentTime + "&status=Exception");
                }
                catch (Exception ex2)
                {
                    System.Diagnostics.Debug.WriteLine(ex2);
                }

                System.Diagnostics.Debug.WriteLine(ex);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(1);

            var timer = new System.Threading.Timer(
            e1 => runAction(),
            null,
            TimeSpan.Zero,
            TimeSpan.FromSeconds(10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
