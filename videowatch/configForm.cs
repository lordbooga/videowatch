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
            xmlConfig = new Configuration();
            if (File.Exists("config.xml"))
            {
                xmlConfig = Configuration.Deserialize("config.xml");
                mainForm.accessSecret = xmlConfig.accessSecret;
                mainForm.accessToken = xmlConfig.accessToken;
                mainForm.consumerKey = xmlConfig.consumerKey;
                mainForm.consumerSecret = xmlConfig.consumerSecret;
                mainForm.shouldTweet = xmlConfig.shouldTweet;
                accessTokenBox.Text = mainForm.accessToken;
                accessTokenSecret.Text = mainForm.accessSecret;
                consumerSecretBox.Text = mainForm.accessToken;
                consumerKeyBox.Text = mainForm.accessToken;
                tweetNewFiles.Checked = mainForm.shouldTweet;
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
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xmlConfig.accessToken = accessTokenBox.Text;
            xmlConfig.accessSecret = accessTokenSecret.Text;
            xmlConfig.consumerKey = consumerKeyBox.Text;
            xmlConfig.consumerSecret = consumerSecretBox.Text;
            xmlConfig.shouldTweet = tweetNewFiles.Checked;

            mainForm.accessSecret = xmlConfig.accessSecret;
            mainForm.accessToken = xmlConfig.accessToken;
            mainForm.consumerKey = xmlConfig.consumerKey;
            mainForm.consumerSecret = xmlConfig.consumerSecret;
            mainForm.shouldTweet = xmlConfig.shouldTweet;

            Configuration.Serialize("config.xml", xmlConfig);
            Hide();
        }

    }
}
