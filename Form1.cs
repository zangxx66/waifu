using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using waifu.Helper;

namespace waifu {
    public partial class Form1 : Form {

        private DataHelper _dataHelper = new DataHelper ();

        

        public Form1 () {
            InitializeComponent ();
        }

        private void buttonExit_Click (object sender, EventArgs e) {
            //发型
            var hair = _dataHelper.GetHairData ();
            this.hair_text.Text = hair;

            //属性
            var attr = _dataHelper.GetAttrData ();
            this.Attr_text.Text = attr;

            //性格
            var character = _dataHelper.GetCharData ();
            this.Char_text.Text = character;

            //cup
            var cup = _dataHelper.GetCupData ();
            this.Cup_text.Text = cup;

            //肤色
            var skin = _dataHelper.GetSkinData ();
            this.Skin_text.Text = skin;

            //年龄
            var age = _dataHelper.GetAgeData ();
            this.Age_text.Text = age;

            //身高
            var height = _dataHelper.GetHeightData ();
            this.Height_text.Text = height + "cm";

            //体重
            var weight = _dataHelper.GetWeightData ();
            this.Weight_text.Text = weight + "kg";

            //发色
            var r = new Random ().Next (0, 255);
            var g = new Random ().Next (0, 255);
            var b = new Random ().Next (0, 255);
            this.HairColor_text.Text = System.Drawing.ColorTranslator.ToHtml (System.Drawing.Color.FromArgb (r, g, b));
            this.HairColor_text.BackColor = System.Drawing.Color.FromArgb (r, g, b);
        }
    }
}