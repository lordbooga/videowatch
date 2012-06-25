using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using Twitterizer;

namespace videowatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            cf = new configForm(this);
            isMonitoring = false;
            isMin = false;
            InitializeComponent();
            watchFolderText.Text = @"D:\Downloads\New Shows";
            fileSystemWatcher1.EnableRaisingEvents = false;
            fileList = new List<String>();
            fileList.Clear();
            if(File.Exists("monitorList.txt"))
                fileList.AddRange(File.ReadAllLines("monitorList.txt"));           
            notifyIcon.Visible = false;
            tokens.AccessToken = accessToken;
            tokens.AccessTokenSecret = accessSecret;
            tokens.ConsumerKey = consumerKey;
            tokens.ConsumerSecret = consumerSecret;
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            locateDir.ShowDialog();
            watchFolderText.Text = locateDir.SelectedPath;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!isMonitoring)
            {
                button2.Text = "Stop Monitoring";
                isMonitoring = true;
                fileSystemWatcher1.Path = watchFolderText.Text;
                fileSystemWatcher1.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                fileSystemWatcher1.EnableRaisingEvents = true;
            }
            else
            {
                button2.Text = "Start Monitoring";
                isMonitoring = false;
                fileSystemWatcher1.EnableRaisingEvents = false;
            }

        }

        private void updateTextBox(string addMe)
        {
            videoList.AppendText(addMe + "\n");
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            String newFile = e.Name;
            if ((newFile.EndsWith(".mkv") || newFile.EndsWith(".mp4") || newFile.EndsWith(".avi")) && !(fileList.Contains(e.Name)))
            {
                newFile = newFile.Replace('.', ' ');
                fileList.Add(newFile);
                updateTextBox(newFile);
                if (shouldTweet)
                {
                    
                    TwitterResponse<TwitterDirectMessage> dmResponse = TwitterDirectMessage.Send(tokens, "lordbooga", newFile + " has been downloaded");
                    if (dmResponse.Result == RequestResult.Success)
                    {
                        videoList.AppendText(newFile + " successfully tweeted\n");
                    }
                    else
                    {
                        videoList.AppendText("Error tweeting new episode name:" + dmResponse.ErrorMessage + "\n");
                    }
                }
                

            }
        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            String removeMe = e.Name;
     //      fileList.Remove(removeMe);
        }

        private void fileSystemWatcher1_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
         //   videoList.Text += "Got Rename Update";

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            Activate();
            BringToFront();
            SetTopLevel(true);
            
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                isMin = true;
                notifyIcon.Visible = true;
                notifyIcon.Text = "New Episode Notifier";
                Hide();
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon.Visible = false;
                isMin = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllLines("monitorList.txt", fileList.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cf.Show();
        }
    }
}
