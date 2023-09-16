using AutoIt;
using System;
using System.IO;
using System.Linq;
using System.Drawing;
using OpenQA.Selenium;
using System.Threading;
using WebDriverManager;
using System.Reflection;
using System.Diagnostics;
using OpenQA.Selenium.Edge;
using System.Windows.Forms;
using System.Globalization;
using WebDriverManager.Helpers;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WebDriverManager.DriverConfigs.Impl;

namespace WhatsAppMaster
{
    public partial class Form1 : Form
    {
        #region Parameters
        private IWebDriver webDriver;
        private string scheme = "https://web.whatsapp.com/send?phone={0}&text={1}";
        private List<string> unSentNumbers = new List<string>(), listNumbers = new List<string>(), listNames = new List<string>();

        private bool mouseDown;
        private Point lastLocation;

        private int sentIndex;
        private bool isFileExists, hasWhatsAppOpened, isWhatsappOpening, isSending, isFileTypeImage;

        #endregion
        public Form1(string username, int daysLeft)
        {
            InitializeComponent();
            new DriverManager().SetUpDriver(new EdgeConfig(), VersionResolveStrategy.MatchingBrowser, Architecture.Auto);
            SetProfileDetails(username, daysLeft);
            //MessageBox.Show(RegistryHelper.GetInstalledBrowserVersionWin("chrome.exe"));
            InitializeSelenium();
            labelVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        #region Events
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllDriverProcesses();
        }
        #endregion
        #region Button Clicks
        #region Tabs

        private void tabMainPage_Click(object sender, EventArgs e)
        {
            OpenTab(panelMainPage, "Home Page");
        }
        private void tabWhatsApp_Click(object sender, EventArgs e)
        {
            if (CheckWhatsAppLink())
            {
                SetStatus("WhatsApp Linking");
                webDriver.Manage().Window.Maximize();
                new Thread(new ThreadStart(CheckLoginState)).Start();
            }
        }
        private void tabContact_Click(object sender, EventArgs e)
        {
            OpenTab(panelMessages, "Add Contact");
        }
        private void tabMessageScheme_Click_1(object sender, EventArgs e)
        {
            OpenTab(panelFile, "Add Message");
        }
        private void tabAddFile_Click(object sender, EventArgs e)
        {
            OpenTab(panelFile, "Add File");
        }

        private void tabReports_Click(object sender, EventArgs e)
        {
            OpenTab(panelReport, "Reports");
        }
        #endregion
        private void buttonFilePick_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                textBoxFileName.Text = fileName;
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!hasWhatsAppOpened)
            {
                MessageBox.Show("You have to link WhatsApp first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isSending)
                return;
            if (textBoxNumbers.Text.Contains(Environment.NewLine))
            {
                listNumbers = Regex.Split(textBoxNumbers.Text, Environment.NewLine).ToList();
                listNames = Regex.Split(textBoxNames.Text, Environment.NewLine).ToList();
            }
            else
            {
                listNumbers.Add(textBoxNumbers.Text);
                listNames.Add(textBoxNames.Text);
            }
            if (listNames.Count != listNumbers.Count)
            {
                MessageBox.Show("Name and number count must be same. Be sure that you don't have an extra line.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSending = true;
            //webDriver.Manage().Window.Maximize();
            SetStatus("Message Sending Started");

            progressBarStatus.Value = 0;
            progressBarStatus.Maximum = listNumbers.Count;

            textBoxUnSent.Text = "";


            string fileName = textBoxFileName.Text.ToLower();
            if (fileName.EndsWith("png") || fileName.EndsWith("jpg") || fileName.EndsWith("jpeg") || fileName.EndsWith("mp4") || fileName.EndsWith("mpeg"))
                isFileTypeImage = true;
            else
                isFileTypeImage = false;

            isFileExists = textBoxFileName.Text != "";

            if (isFileExists)
                ForceSend();
            else
                new Thread(new ThreadStart(ForceSend)).Start();
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Utilities
        private void InitializeSelenium()
        {
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("--user-data-dir=" + Application.StartupPath + "\\BrowserData");
            options.AddArgument("userDataFolder=" + Application.StartupPath + "\\BrowserData");
            options.AddArgument("disable-infobars");
            options.AddArgument("--disable-logging");
            //options.AddArgument("--start-maximized");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--log-level=3");
            //options.AddArgument("headless");
            var driverService = EdgeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            webDriver = new EdgeDriver(driverService, options);
            //m_driver = new ChromeDriver(Application.StartupPath, options);
            webDriver.Manage().Window.Minimize();
        }
        private void OpenTab(Panel openingPanel, string titleText)
        {
            panelMainPage.Visible = false;
            panelMessages.Visible = false;
            panelReport.Visible = false;
            panelFile.Visible = false;

            if (openingPanel != null)
                openingPanel.Visible = true;
            labelPageTitle.Text = titleText;
        }
        private void CloseAllDriverProcesses()
        {
            if (webDriver != null)
            {
                webDriver.Close();
                webDriver.Quit();
                webDriver.Dispose();
                webDriver = null;
            }
            foreach (var process in Process.GetProcessesByName("msedgedriver"))
                process.Kill();
        }
        private void SetProfileDetails(string username, int daysLeft)
        {
            labelProfileName.Text = username;
            labelDaysLeft.Text = daysLeft + " Days Left";
        }

        private void buttonFilePicker_Click(object sender, EventArgs e)
        {
        FILE_PICKER:
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fs = new FileInfo(openFileDialog.FileName);
                double MBOfFile = Math.Round((fs.Length / 1048576d), 2);
                if (MBOfFile >= 16)
                    if (MessageBox.Show("Files larger than 16 MB cannot be selected. Select another file or reduce the size", "Wrong Process", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        goto FILE_PICKER;
                string fileName = openFileDialog.FileName;
                textBoxFileName.Text = fileName;

                labelFileMB.Text = MBOfFile + " MB";
            }
        }

        private bool CheckWhatsAppLink()
        {
            if (hasWhatsAppOpened)
            {
                MessageBox.Show("WhatsApp Already Linked", "Wrong Process", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (!isWhatsappOpening)
                {
                    isWhatsappOpening = true;
                    return true;
                }
                else
                {
                    MessageBox.Show("WhatsApp is still linking", "Wrong Process", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            textboxMessage.Paste("{Name}");
        }

        private void buttonFileReset_Click(object sender, EventArgs e)
        {
            textBoxFileName.Clear();
            labelFileMB.Text = "";
        }

        private void textBoxNumbers_TextChanged(object sender, EventArgs e)
        {
            labelNumberLength.Text = Regex.Split(textBoxNumbers.Text, Environment.NewLine).ToList().Count().ToString();
        }

        private void textBoxNames_TextChanged(object sender, EventArgs e)
        {
            labelNameLength.Text = Regex.Split(textBoxNames.Text, Environment.NewLine).ToList().Count().ToString();
        }

        private void panel14_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel14_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel14_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void SetStatus(string statusText)
        {
            labelStatus.Invoke((MethodInvoker)(() => labelStatus.Text = statusText));
        }
        #region Flow
        private void CheckLoginState()
        {
            webDriver.Url = "https://web.whatsapp.com";

            IWebElement elementMainPage = null;
            while (elementMainPage == null)
            {
                try
                {
                    elementMainPage = webDriver.FindElement(By.XPath(Global.remoteConfigs.mainPageProfileIcon));
                }
                catch (Exception) { }
            }


            SetStatus("Waiting to Start Sending");

            //webDriver.Manage().Window.Size = new System.Drawing.Size(1, 1);
            //WindowState = FormWindowState.Normal;
            hasWhatsAppOpened = true;
            isWhatsappOpening = false;
        }
        private void LoadNextUrl()
        {
            string number = listNumbers[sentIndex].Trim();
            number = number.Replace(" ", "");
            if (number.Length == 11)
                number = "9" + number;
            else if (number.Length == 10)
                number = "90" + number;
            webDriver.Url = String.Format(scheme, number, textboxMessage.Text.Replace("{Name}", listNames[sentIndex]).Replace(System.Environment.NewLine, "%0a"));
        }
        private void ForceSend()
        {
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Thread.Sleep(Global.remoteConfigs.defaultSleep);
                LoadNextUrl();


                progressBarStatus.Invoke((MethodInvoker)(() => progressBarStatus.Value++));
                labelProgress.Invoke((MethodInvoker)(() => labelProgress.Text = (sentIndex + 1) + "/" + listNumbers.Count));

                IWebElement elementFooterArea = null;
                IWebElement elementBanArea = null;
                IWebElement elementNumberNotFound = null;


                while (elementFooterArea == null)
                {
                    try
                    {
                        elementFooterArea = webDriver.FindElement(By.CssSelector(Global.remoteConfigs.footerArea));
                        elementBanArea = webDriver.FindElement(By.CssSelector(Global.remoteConfigs.banArea));
                        if (elementBanArea != null && elementBanArea.Text.Contains("gönderemezsiniz") || elementBanArea.Text.Contains("blocked"))
                        {
                            textBoxUnSent.Invoke((MethodInvoker)(() => textBoxUnSent.Text += listNumbers[sentIndex] + System.Environment.NewLine));
                            unSentNumbers.Add(listNumbers[sentIndex]);
                            goto FLOW_CONTINUE;
                        }

                    }
                    catch (Exception)
                    {
                        try
                        {
                            elementNumberNotFound = webDriver.FindElement(By.CssSelector(Global.remoteConfigs.numberNotFound));
                            if (elementNumberNotFound != null && elementNumberNotFound.Displayed && elementNumberNotFound.Text.ToLowerInvariant() == (CultureInfo.InstalledUICulture.Name == "en-US" ? "okay" : "tamam"))
                            {
                                textBoxUnSent.Invoke((MethodInvoker)(() => textBoxUnSent.Text += listNumbers[sentIndex] + System.Environment.NewLine));
                                unSentNumbers.Add(listNumbers[sentIndex]);
                                goto FLOW_CONTINUE;
                            }
                        }
                        catch (Exception) { }
                    }
                }

                IWebElement elementMessageArea = null;
                while (elementMessageArea == null)
                {
                    try
                    {
                        elementMessageArea = webDriver.FindElement(By.XPath(Global.remoteConfigs.messageArea));
                    }
                    catch (Exception)
                    {

                    }
                }

                IWebElement elementMessageSendButton = null;
                while (elementMessageSendButton == null)
                {
                    try
                    {
                        elementMessageSendButton = webDriver.FindElement(By.XPath(Global.remoteConfigs.send));
                    }
                    catch (Exception) { }
                }


                while (!elementMessageSendButton.Displayed || !elementMessageSendButton.Enabled)
                {
                    Thread.Sleep(Global.remoteConfigs.defaultSleep);
                }
                elementMessageSendButton.Click();

                if (isFileExists)
                {
                    IWebElement elementAttachmentButton = null;
                    while (elementAttachmentButton == null)
                    {
                        try
                        {
                            elementAttachmentButton = webDriver.FindElement(By.XPath(Global.remoteConfigs.attachment));
                        }
                        catch (Exception) { }
                    }

                    while (!elementAttachmentButton.Displayed || !elementAttachmentButton.Enabled)
                    {
                        Thread.Sleep(Global.remoteConfigs.defaultSleep);
                    }
                    elementAttachmentButton.Click();

                    IWebElement elementAttachmentTypeButton = null;
                    while (elementAttachmentTypeButton == null)
                    {
                        try
                        {
                            elementAttachmentTypeButton = webDriver.FindElement(By.XPath(isFileTypeImage ? Global.remoteConfigs.attachmentImage : Global.remoteConfigs.attachmentDocument));
                        }
                        catch (Exception) { }
                    }
                    while (!elementAttachmentTypeButton.Displayed || !elementAttachmentTypeButton.Enabled)
                    {
                        Thread.Sleep(Global.remoteConfigs.defaultSleep);
                    }
                    elementAttachmentTypeButton.Click();

                    AutoItX.WinWait(CultureInfo.InstalledUICulture.Name == "en-US" ? "Open" : "Aç", "");
                    //AutoItX.WinExists(CultureInfo.InstalledUICulture.Name == "en-US" ? "Open" : "Aç", "");
                    AutoItX.ControlFocus(CultureInfo.InstalledUICulture.Name == "en-US" ? "Open" : "Aç", "", "");
                    Thread.Sleep(100);
                    AutoItX.Send(textBoxFileName.Text);
                    AutoItX.Send("{ENTER}");

                    IWebElement elementFileSendButton = null;
                    while (elementFileSendButton == null)
                    {
                        try
                        {
                            elementFileSendButton = webDriver.FindElement(By.XPath(Global.remoteConfigs.sendFile));
                        }
                        catch (Exception) { }
                    }

                    while (!elementFileSendButton.Displayed || !elementFileSendButton.Enabled)
                    {
                        Thread.Sleep(Global.remoteConfigs.defaultSleep);
                    }

                    Thread.Sleep(Global.remoteConfigs.defaultSleep);
                    elementFileSendButton.Click();
                    Thread.Sleep(Global.remoteConfigs.defaultSleep);

                    IWebElement elementCheckIfFileSent = null;
                    while (elementCheckIfFileSent == null)
                    {
                        try
                        {
                            elementCheckIfFileSent = webDriver.FindElement(By.CssSelector(Global.remoteConfigs.checkIfFileSent));
                        }
                        catch (Exception) { }
                    }
                    while (!elementCheckIfFileSent.Displayed || !elementCheckIfFileSent.Enabled)
                    {
                        Thread.Sleep(Global.remoteConfigs.defaultSleep);
                    }
                }
            FLOW_CONTINUE:
                sentIndex++;
            }
            Finished();
        }
        private void Finished()
        {
            sentIndex = 0;
            SetStatus("Message Sending Finished");
            webDriver.Manage().Window.Minimize();
            MessageBox.Show("Message Sending Completed", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isSending = false;
            listNumbers.Clear();
            listNames.Clear();
            if (unSentNumbers.Count > 0)
                MessageBox.Show("You can check incorrect numbers on the Reports page", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            unSentNumbers.Clear();
        }
        #endregion
        #endregion
    }
}