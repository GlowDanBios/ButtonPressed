using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonPressed
{
    public partial class Form1 : Form
    {
        private int times = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (times == 0)
            {
                this.button1.Text = "Вы нажа-а-а-а-ли меня!!!!";
                times++;
            }
            else this.Close();
        }
    }
}