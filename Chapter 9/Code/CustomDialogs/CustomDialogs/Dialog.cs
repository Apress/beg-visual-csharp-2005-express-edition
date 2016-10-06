using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomDialogs
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        public string UserName
        {
            get { return nameBox.Text; }
        }
    }
}