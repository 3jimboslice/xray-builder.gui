﻿using System.Windows.Forms;

namespace XRayBuilderGUI
{
    public partial class frmPreviewXR : Form
    {
        public frmPreviewXR()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
