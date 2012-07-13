using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace videowatch
{
    public partial class configForm : Form
    {
        public configForm(Form1 mainform)
        {
            InitializeComponent();
            mainForm = mainform;
           // mainForm.settings = new Configuration();
            if (File.Exists("config.xml"))
            {
                mainForm.settings = Configuration.Deserialize("config.xml");

                ConfigFormToSettings();
            }        
        }

        private void tweetNewFiles_CheckedChanged(object sender, EventArgs e)
        {
                accessTokenBox.Enabled = tweetNewFiles.Checked;
                accessTokenSecret.Enabled = tweetNewFiles.Checked;
                consumerSecretBox.Enabled = tweetNewFiles.Checked;
                consumerKeyBox.Enabled = tweetNewFiles.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigFormToSettings();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsToConfigForm();
            Configuration.Serialize("config.xml", mainForm.settings);
            Hide();
        }
        public void SettingsToConfigForm()
        {
            mainForm.settings.accessSecret = accessTokenSecret.Text;
            mainForm.settings.accessToken = accessTokenBox.Text;
            mainForm.settings.consumerKey = consumerKeyBox.Text;
            mainForm.settings.consumerSecret = consumerSecretBox.Text;
            mainForm.settings.shouldTweet = tweetNewFiles.Checked;
            mainForm.settings.dirToMonitor = monitorDir.Text;

        }
        public void ConfigFormToSettings()
        {
            accessTokenBox.Text = mainForm.settings.accessToken;
            accessTokenSecret.Text = mainForm.settings.accessSecret;
            consumerSecretBox.Text = mainForm.settings.consumerSecret;
            consumerKeyBox.Text = mainForm.settings.consumerKey;
            tweetNewFiles.Checked = mainForm.settings.shouldTweet;
            monitorDir.Text = mainForm.settings.dirToMonitor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog locateDir = new FolderBrowserDialog();
            locateDir.ShowNewFolderButton = true;
            DialogResult res = locateDir.ShowDialog();
            if(res == DialogResult.OK)
                monitorDir.Text = locateDir.SelectedPath;
        }


    }
}
