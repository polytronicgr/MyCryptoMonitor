﻿using System.Windows.Forms;

namespace MyCryptoMonitor.Forms
{
    public partial class Password : Form
    {
        public string PasswordInput { get { return txtPassword.Text; } }

        public Password()
        {
            InitializeComponent();
        }

        private void btnUnlock_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}