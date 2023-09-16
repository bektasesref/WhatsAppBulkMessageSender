using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using WhatsAppMaster.Properties;
using DeviceId;
using System.Reflection;

namespace WhatsAppMaster
{
    public partial class Auth : Form
    {
        #region Parameters
        private static readonly HttpClient client = new HttpClient();
        bool isLoggingIn = false;
        #endregion
        public Auth()
        {
            InitializeComponent();
            GetJSON();
        }
        #region Button Clicks
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length == 0)
                MessageBox.Show("Username can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBoxPassword.Text.Length == 0)
                MessageBox.Show("Password can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isLoggingIn)
                Login(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
            else
                MessageBox.Show("Already logging in. Please wait", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        #region Utilities
        private bool IsProgramActive()
        {
            if (Global.remoteConfigs.active == 0)
                return false;
            else
                return true;
        }
        private async void GetJSON()
        {
            var responseJSON = await client.GetAsync(Resources.remoteConfigURL); // https://www.esrefbektas.com/WhatsappMasterJSON.json
            var responseJSONAsString = await responseJSON.Content.ReadAsStringAsync();
            Global.remoteConfigs = JsonConvert.DeserializeObject<RemoteConfig>(responseJSONAsString);

            if (IsProgramActive())
                AutoLoginCheck();
            else
                MessageBox.Show("Maintenance ongoing. Get in touch with " + Global.remoteConfigs.supportURL + " for support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AutoLoginCheck()
        {
            AuthSimpleDB settings = new AuthSimpleDB();
            //settings.Reset();
            if (settings.UserName != "" && settings.Password != "")
                Login(settings.UserName, settings.Password);
        }
        private async void Login(string username, string password)
        {
            if (Global.remoteConfigs == null)
            {
                MessageBox.Show("Cant login Please wait a while", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!IsProgramActive())
            {
                MessageBox.Show("Maintenance ongoing. Get in touch with " + Global.remoteConfigs.supportURL + " for support", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string deviceId = new DeviceIdBuilder().AddMachineName().AddMacAddress().AddOsVersion().ToString();
            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
            isLoggingIn = true;
            var values = new Dictionary<string, string> { { "username", username }, { "password", password }, { "deviceID", deviceId }, { "version", Assembly.GetExecutingAssembly().GetName().Version.ToString() } };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(Global.remoteConfigs.authCheckURL, content);

            var responseString = await response.Content.ReadAsStringAsync();
            if (responseString == "Invalid User")
            {
                isLoggingIn = false;
                MessageBox.Show("Wrong credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (responseString == "Already Linked")
            {
                isLoggingIn = false;
                Clipboard.SetText(deviceId);
                MessageBox.Show("This device already linked with another account. If you think this is a problem, please get in touch. \n\nSerial No: \n" + deviceId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int daysLeft = Convert.ToInt32(responseString);
                if (daysLeft <= 0)
                {
                    isLoggingIn = false;
                    DialogResult error = MessageBox.Show("License finished. Want to extend?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (error == DialogResult.Yes)
                    {
                        ProcessStartInfo sInfo = new ProcessStartInfo(Global.remoteConfigs.supportURL);
                        Process.Start(sInfo);
                    }
                }
                else
                {
                    AuthSimpleDB settings = new AuthSimpleDB();
                    settings.UserName = username;
                    settings.Password = password;
                    settings.Save();

                    Form1 form1 = new Form1(username, daysLeft);
                    this.Hide();
                    form1.Show();
                }
            }
        }
        #endregion
    }
}