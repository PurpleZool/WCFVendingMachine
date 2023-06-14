using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMainClient
{
    public partial class WebForm : Form
    {
        public WebForm(string caption , string text)
        {
            InitializeComponent();
            this.Text = caption;
            this.webBrowser1.DocumentText = text;
        }

        private void WebForm_Load(object sender, EventArgs e)
        {

        }
    }
}
