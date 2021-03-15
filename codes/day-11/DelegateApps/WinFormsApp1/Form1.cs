using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EventHandler eventHandler = new EventHandler(this.ButtonClicked);
            button1.Click += eventHandler;
        }
        //control: button1 (Button)
        //event: Click
        private void ButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("button clicked");
        }
    }
}
