using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using waifu.Helper;

namespace waifu
{
    public partial class Form1 : Form
    {

        private DataHelper _dataHelper = new DataHelper(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var hair = _dataHelper.GetHairData();
            this.hair_text.Text = hair;
        }
    }
}
