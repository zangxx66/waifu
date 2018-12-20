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

            var attr = _dataHelper.GetAttrData();
            this.Attr_text.Text = attr;

            var character = _dataHelper.GetCharData();
            this.Char_text.Text = character;

            var cup = _dataHelper.GetCupData();
            this.Cup_text.Text = cup;

            var skin = _dataHelper.GetSkinData();
            this.Skin_text.Text = skin;
        }
    }
}
