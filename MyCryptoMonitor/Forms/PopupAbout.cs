﻿using System;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using MyCryptoMonitor.Statics;

namespace MyCryptoMonitor.Forms
{
    public partial class PopupAbout : Form
    {
        #region Constructor
        public PopupAbout()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void PopupAbout_Load(object sender, EventArgs e)
        {
            Globals.SetTheme(this);
            txtVersion.Text = $"Version: {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Crowley2012/MyCryptoMonitor");
        }

        private void btnFreepik_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.freepik.com/free-icon/coin-stack_778388.htm");
        }
        #endregion
    }
}
