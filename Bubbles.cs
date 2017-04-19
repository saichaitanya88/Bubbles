using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Windows.Forms;

namespace Bubbles
{
    public partial class Bubbles : Form
    {
        List<string> Tips { get; set; }
        Random Random { get; set; }
        DateTime NotesFileLoadedAt { get; set; }
        string FilePath { get; set; }

        public Bubbles(string path)
        {
            InitializeComponent();

            Tips = new List<string>();
            Random = new Random();
            FilePath = path;
        }
        public void Application_ApplicationExit(object sender, EventArgs e)
        {
            Dispose();
        }

        public void Start()
        {
            LoadTipsFromFilePath();
            ShowTip();
        }

        private void LoadTipsFromFilePath()
        {
            Tips.Clear();
            Tips = File.ReadAllLines(FilePath).ToList();
            NotesFileLoadedAt = File.GetLastWriteTime(FilePath);
        }

        private void ReloadTipsIfFileUpdated()
        {
            if (NotesFileLoadedAt != File.GetLastWriteTime(FilePath))
                LoadTipsFromFilePath();
        }

        private void ShowTip()
        {
            Visible = true;
            tipTextbox.Text = RandomTip();
            SetTimeout(GetBubbleDuration(), OnCloseTip);
        }
        
        string RandomTip()
        {
            return Tips.ElementAt(Random.Next(Tips.Count));
        }

        private int GetBubbleDuration()
        {
            return int.Parse(GetConfigProperty("BubbleDuration")) * 60 * 1000;
        }

        private void OnCloseTip(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Stop();
            timer.Dispose();
            Visible = false;
            QueueNextTip();
            ReloadTipsIfFileUpdated();
        }

        private void SetTimeout(int duration, EventHandler tickAction)
        {
            Timer timer = new Timer();
            timer.Interval = duration;
            timer.Start();
            timer.Tick += tickAction;
        }

        private void QueueNextTip()
        {
            SetTimeout(GetTipInterval(), OnShowTip);
        }

        private int GetTipInterval()
        {
            return int.Parse(GetConfigProperty("TipInterval")) * 60 * 1000;
        }

        private void OnShowTip(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            timer.Stop();
            timer.Dispose();
            ShowTip();
        }

        private void Debug(string info)
        {
            if (IsSilentMode())
            {
                return;
            }

            Console.WriteLine(info);
        }
        
        private bool IsSilentMode()
        {
            return bool.Parse(GetConfigProperty("SilentMode"));
        }

        private string GetConfigProperty(string key)
        {
            return ConfigurationSettings.AppSettings.Get(key).ToString();
        }

        private void Bubbles_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
