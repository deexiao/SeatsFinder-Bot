using System;
using System.Collections.Generic;
using System.Drawing;
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

        List<string> l = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(860, 980);
            this.MaximumSize = new Size(860, 980);
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

        private static String SuperPowerAutomates_add(String username, String password, String sectionNum, String semesterCombo)
        {
            System.Diagnostics.Debug.WriteLine("in SuperPowerAutomates_add");

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");

            var driver = new ChromeDriver(options);

            string STRM = "";

            if (semesterCombo == "Spring+2019") STRM = "2191";

            if (semesterCombo == "Spring+2020") STRM = "2201";

            if (semesterCombo == "Spring+2021") STRM = "2211";

            if (semesterCombo == "Spring+2022") STRM = "2221";

            if (semesterCombo == "Spring+2023") STRM = "2231";

            if (semesterCombo == "Spring+2024") STRM = "2241";

            if (semesterCombo == "Spring+2025") STRM = "2251";



            if (semesterCombo == "Fall+2019") STRM = "2197";

            if (semesterCombo == "Fall+2020") STRM = "2207";

            if (semesterCombo == "Fall+2021") STRM = "2217";

            if (semesterCombo == "Fall+2022") STRM = "2227";

            if (semesterCombo == "Fall+2023") STRM = "2237";

            if (semesterCombo == "Fall+2024") STRM = "2247";

            if (semesterCombo == "Fall+2025") STRM = "2257";

            driver.Navigate().GoToUrl("https://go.oasis.asu.edu/addclass/?STRM="+ STRM + "&ACAD_CAREER=GRAD");

            //Login
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@src='https://weblogin.asu.edu/cgi-bin/login?callapp=https%3A//go.oasis.asu.edu/waitframeset.html%3Fdelay%3D3500%26url%3Dhttps%253A//cs.oasis.asu.edu/asucsprd/golink/%253F/EMPLOYEE/PSFT_ASUCSPRD/s/WEBLIB_ASU_SA.ASU_SA_ISCRIPT.FieldFormula.IScript_SA%253FURL%253D/EMPLOYEE/PSFT_ASUCSPRD/c/SA_LEARNER_SERVICES.SSR_SSENRL_CART.GBL%25253FSTRM%25253D"+ STRM + "%252526ACAD_CAREER%25253DGRAD%252526Page%25253DSSR_SSENRL_ADD%252526Action%25253DA%252526INSTITUTION%25253DASU00%252526golink%25253DY']")));
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

        private static String SuperPowerAutomates_swap(String username, String password, String sectionNum, String swapWith, String semesterCombo)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");

            var driver = new ChromeDriver(options);

            string STRM = "";

            if (semesterCombo == "Spring+2019") STRM = "2191";
            if (semesterCombo == "Spring+2020") STRM = "2201";
            if (semesterCombo == "Spring+2021") STRM = "2211";
            if (semesterCombo == "Spring+2022") STRM = "2221";
            if (semesterCombo == "Spring+2023") STRM = "2231";
            if (semesterCombo == "Spring+2024") STRM = "2241";
            if (semesterCombo == "Spring+2025") STRM = "2251";

            if (semesterCombo == "Fall+2019") STRM = "2197";
            if (semesterCombo == "Fall+2020") STRM = "2207";
            if (semesterCombo == "Fall+2021") STRM = "2217";
            if (semesterCombo == "Fall+2022") STRM = "2227";          
            if (semesterCombo == "Fall+2023") STRM = "2237";
            if (semesterCombo == "Fall+2024") STRM = "2247";
            if (semesterCombo == "Fall+2025") STRM = "2257";

            driver.Navigate().GoToUrl("https://go.oasis.asu.edu/swapclass/?STRM="+ STRM + "&ACAD_CAREER=GRAD&ASU_CLASS_NBR=" + sectionNum);

            string s = "https://weblogin.asu.edu/cgi-bin/login?callapp=https%3A//go.oasis.asu.edu/waitframeset.html%3Fdelay%3D3500%26url%3Dhttps%253A//cs.oasis.asu.edu/asucsprd/golink/%253F/EMPLOYEE/PSFT_ASUCSPRD/s/WEBLIB_ASU_SA.ASU_SA_ISCRIPT.FieldFormula.IScript_SA%253FURL%253D/EMPLOYEE/PSFT_ASUCSPRD/c/SA_LEARNER_SERVICES.SSR_SSENRL_SWAP.GBL%25253FSTRM%25253D"+ STRM + "%252526ACAD_CAREER%25253DGRAD%252526ASU_CLASS_NBR%25253D"+ sectionNum +"%252526Page%25253DSSR_SSENRL_SWAP%252526Action%25253DA%252526INSTITUTION%25253DASU00%252526golink%25253DY";
         
            //Login
            driver.SwitchTo().Frame(driver.FindElement(By.XPath($"//frame[contains(text(), s)]")));
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

            // wwSelect class from dropdownlist
            var dropdownlist = driver.FindElement(By.Id("DERIVED_REGFRM1_DESCR50$225$"));

            // create select element object 
            var selectElement = new SelectElement(dropdownlist);

            // select by value
            selectElement.SelectByValue(swapWith);

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

        private string runAction(string semester, string reserved)
        {
            WebClient client = new WebClient();

            string currentTime = DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm tt");

            string sec = sectionText.Text;

            try
            {
                System.Diagnostics.Debug.WriteLine("semesterCombo.Text: " + semester);
                System.Diagnostics.Debug.WriteLine("reservedCombo.Text: " + reserved);

                string classStatus = client.DownloadString("http://www.seatsfinder.tk/api/WebAPI?checkClassStatus=true&prefix=&number=&location=Tempe&term=" + semester + "&sectionNumber=" + sec + "&reservedSeats=" + reserved);

                System.Diagnostics.Debug.WriteLine("classStatus: " + classStatus);

                System.Diagnostics.Debug.WriteLine("classStatus: " + classStatus);

                if (classStatus == "\"FULL\"")
                {
                    SetCloseClass();
                    return "FULL.";
                }
                else if (classStatus == "\"OPEN\"")
                {
                    SetOpenClass();

                    if (addRadio.Checked)
                    {
                        SuperPowerAutomates_add(userText.Text, passwordText.Text, sectionText.Text, semester);
                    }
                    if (swapRadio.Checked)
                    {
                        SuperPowerAutomates_swap(userText.Text, passwordText.Text, sectionText.Text, swapWith.Text, semester);
                    }
                    return "OPEN.";
                }
            }
            catch (Exception ex)
            {
                return "ERROR CATCHED";
            }
            return "\n";
        }

        delegate void SetTextCallback(string text, int i);
        delegate void SetTextCallback2();
        delegate void SetTextCallback3();

        private void SetText(string text, int i)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, i });
            }
            else
            {
                classCheckedTimes.Text = i.ToString();
                if(l.Count > 20)
                {
                    l.Clear();
                }
                else
                {
                    l.Add("Next check is " + DateTime.Now.AddSeconds(10).ToString("MM/dd/yyyy h:mm:ss tt") + "");

                    this.label2.Text = string.Join("\n", l);
                }
            }
        }

        private void SetOpenClass()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label2.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetOpenClass);
                this.Invoke(d, new object[] { });
            }
            else
            {
                l.Add("Checked, the class is OPEN");
                classOpenTimes.Text = (Convert.ToInt32(classOpenTimes.Text) + 1).ToString();
            }
        }

        private void SetCloseClass()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.label2.InvokeRequired)
            {
                SetTextCallback3 d = new SetTextCallback3(SetCloseClass);
                this.Invoke(d, new object[] { });
            }
            else
            {
                l.Add("Checked, the class is CLOSED");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!swapRadio.Checked && !addRadio.Checked)
            {
                warningLabel.Text = "Please select one of the radio button: Swap or Add.";
            }
            else if(swapRadio.Checked && swapWith.Text == "")
            {
                warningLabel.Text = "Please enter which class you want to swap with (the class you already enrolled).";
            }
            else if(userText.Text == "")
            {
                warningLabel.Text = "Please enter your asu user name.";
            }
            else if (passwordText.Text == "")
            {
                warningLabel.Text = "Please enter your asu password.";
            }
            else if(sectionText.Text == "")
            {
                warningLabel.Text = "Please enter the class number you want to track.";
            }
            else if(swapWith.Text.Length != 5 && swapRadio.Checked)
            {
                warningLabel.Text = "Please enter the correct format of class number (check if contain spaces)";
            }
            else if (sectionText.Text.Length != 5)
            {
                warningLabel.Text = "Please enter the correct format of class number (check if contain spaces)";
            }
            else
            {
                string semester = semesterCombo.Text;
                string reserved = reservedCombo.Text;
                warningLabel.ForeColor = System.Drawing.Color.Blue;
                warningLabel.Text = "Running now, close the app if you want to stop.";
                label2.Text = "Checking...";
                l.Add("Checking...");
                var startTimeSpan = TimeSpan.Zero;
                var periodTimeSpan = TimeSpan.FromMinutes(1);
                int i = 0;
                var timer = new System.Threading.Timer((e1) => {
                    string str = runAction(semester, reserved);
                    i++;
                    SetText(str, i);
                }, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            swapWith.Enabled = false;
            swapWith.Text = "";
        }

        private void swapRadio_CheckedChanged(object sender, EventArgs e)
        {
            swapWith.Enabled = true;
        }

    }
}
