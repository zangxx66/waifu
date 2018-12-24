using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace waifu {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region 窗口透明

        // [StructLayout (LayoutKind.Sequential)]
        // public struct MARGINS {
        //     public int Left;
        //     public int Right;
        //     public int Top;
        //     public int Bottom;
        // }

        // [DllImport ("dwmapi.dll", PreserveSig = false)]
        // static extern void DwmExtendFrameIntoClientArea (IntPtr hwnd, ref MARGINS margins);

        // [DllImport ("dwmapi.dll", PreserveSig = false)]
        // static extern bool DwmIsCompositionEnabled ();

        // protected override void OnLoad(System.EventArgs e){
            
        //     if(DwmIsCompositionEnabled()){
        //         var m = new MARGINS();
        //         m.Right = m.Left = m.Top = m.Bottom = this.Width + this.Height;
        //         DwmExtendFrameIntoClientArea(this.Handle,ref m);
        //     }
        //     base.OnLoad(e);
        // }

        // protected override void OnPaintBackground(PaintEventArgs e){
        //     base.OnPaintBackground(e);
        //     if(DwmIsCompositionEnabled()){
        //         e.Graphics.Clear(Color.Snow);
        //     }
        // }

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.label1 = new System.Windows.Forms.Label ();
            this.buttonExit = new System.Windows.Forms.Button ();
            this.hair_text = new System.Windows.Forms.Label ();
            this.Attr_label = new System.Windows.Forms.Label ();
            this.Attr_text = new System.Windows.Forms.Label ();
            this.Char_label = new System.Windows.Forms.Label ();
            this.Char_text = new System.Windows.Forms.Label ();
            this.Cup_label = new System.Windows.Forms.Label ();
            this.Cup_text = new System.Windows.Forms.Label ();
            this.Skin_label = new System.Windows.Forms.Label ();
            this.Skin_text = new System.Windows.Forms.Label ();
            this.Age_label = new System.Windows.Forms.Label ();
            this.Age_text = new System.Windows.Forms.Label ();
            this.Height_label = new System.Windows.Forms.Label ();
            this.Height_text = new System.Windows.Forms.Label ();
            this.Weight_label = new System.Windows.Forms.Label ();
            this.Weight_text = new System.Windows.Forms.Label ();
            this.HairColor_label = new System.Windows.Forms.Label();
            this.HairColor_text = new System.Windows.Forms.Label();
            this.SuspendLayout ();
            // 
            // 发色label
            // 
            this.label1.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point (22, 27);
            this.label1.Name = "hair_label";
            this.label1.Size = new System.Drawing.Size (62, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "发型：";
            this.label1.AutoSize = true;
            //
            // 发型text
            //
            this.hair_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.hair_text.Location = new System.Drawing.Point (180, 27);
            this.hair_text.Name = "hair_text";
            this.hair_text.Size = new System.Drawing.Size (425, 31);
            this.hair_text.TabIndex = 2;
            this.hair_text.Text = "";
            this.hair_text.AutoSize = true;
            //
            //属性label
            //
            this.Attr_label.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Attr_label.Location = new System.Drawing.Point (22, 90);
            this.Attr_label.Name = "Attr_label";
            this.Attr_label.Size = new System.Drawing.Size (62, 31);
            this.Attr_label.AutoSize = true;
            this.Attr_label.TabIndex = 3;
            this.Attr_label.Text = "属性：";
            //
            //属性text
            //
            this.Attr_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Attr_text.Location = new System.Drawing.Point (180, 90);
            this.Attr_text.Name = "Attr_text";
            this.Attr_text.Size = new System.Drawing.Size (425, 31);
            this.Attr_text.AutoSize = true;
            this.Attr_text.TabIndex = 4;
            this.Attr_text.Text = "";
            //
            //性格label
            //
            this.Char_label.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Char_label.Location = new System.Drawing.Point (22, 153);
            this.Char_label.Name = "Char_label";
            this.Char_label.Size = new System.Drawing.Size (62, 31);
            this.Char_label.AutoSize = true;
            this.Char_label.TabIndex = 5;
            this.Char_label.Text = "性格：";
            //
            //性格text
            //
            this.Char_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Char_text.Location = new System.Drawing.Point (180, 153);
            this.Char_text.Name = "Char_text";
            this.Char_text.Size = new System.Drawing.Size (425, 31);
            this.Char_text.AutoSize = true;
            this.Char_text.TabIndex = 6;
            this.Char_text.Text = "";
            //
            //cup label
            //
            this.Cup_label.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Cup_label.Location = new System.Drawing.Point (22, 216);
            this.Cup_label.Name = "Cup_label";
            this.Cup_label.Size = new System.Drawing.Size (62, 31);
            this.Cup_label.AutoSize = true;
            this.Cup_label.TabIndex = 7;
            this.Cup_label.Text = "Cup：";
            //
            //cup text
            //
            this.Cup_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Cup_text.Location = new System.Drawing.Point (180, 216);
            this.Cup_text.Name = "Cup_text";
            this.Cup_text.Size = new System.Drawing.Size (425, 31);
            this.Cup_text.AutoSize = true;
            this.Cup_text.TabIndex = 8;
            this.Cup_text.Text = "";
            //
            //肤色label
            //
            this.Skin_label.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Skin_label.Location = new System.Drawing.Point (22, 279);
            this.Skin_label.Name = "Skin_label";
            this.Skin_label.Size = new System.Drawing.Size (62, 31);
            this.Skin_label.AutoSize = true;
            this.Skin_label.TabIndex = 9;
            this.Skin_label.Text = "肤色：";
            //
            //肤色text
            //
            this.Skin_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Skin_text.Location = new System.Drawing.Point (180, 279);
            this.Skin_text.Name = "Skin_text";
            this.Skin_text.Size = new System.Drawing.Size (425, 31);
            this.Skin_text.AutoSize = true;
            this.Skin_text.TabIndex = 10;
            this.Skin_text.Text = "";
            //
            //年龄label
            //
            this.Age_label.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Age_label.Location = new System.Drawing.Point (22, 342);
            this.Age_label.Name = "Age_label";
            this.Age_label.Size = new System.Drawing.Size (62, 31);
            this.Age_label.AutoSize = true;
            this.Age_label.TabIndex = 11;
            this.Age_label.Text = "年龄：";
            //
            //年龄text
            //
            this.Age_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Age_text.Location = new System.Drawing.Point (180, 342);
            this.Age_text.Name = "Age_text";
            this.Age_text.Size = new System.Drawing.Size (425, 31);
            this.Age_text.AutoSize = true;
            this.Age_text.TabIndex = 12;
            this.Age_text.Text = "";
            //
            //身高label
            //
            this.Height_label.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Height_label.Location = new System.Drawing.Point(22,405);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(62,31);
            this.Height_label.AutoSize = true;
            this.Height_label.TabIndex = 13;
            this.Height_label.Text = "身高：";
            //
            //身高text
            //
            this.Height_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Height_text.Location = new System.Drawing.Point(180,405);
            this.Height_text.Name = "Height_text";
            this.Height_text.Size = new System.Drawing.Size(425,31);
            this.Height_text.AutoSize = true;
            this.Height_text.TabIndex = 14;
            this.Height_text.Text = "";
            //
            //体重label
            //
            this.Weight_label.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Weight_label.Location = new System.Drawing.Point(22,468);
            this.Weight_label.Name = "Weight_label";
            this.Weight_label.Size = new System.Drawing.Size(62,31);
            this.Weight_label.AutoSize = true;
            this.Weight_label.TabIndex = 15;
            this.Weight_label.Text = "体重：";
            //
            //体重text
            //
            this.Weight_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Weight_text.Location = new System.Drawing.Point(180,468);
            this.Weight_text.Name = "Weight_text";
            this.Weight_text.Size = new System.Drawing.Size(425,31);
            this.Weight_text.AutoSize = true;
            this.Weight_text.TabIndex = 16;
            this.Weight_text.Text = "";
            //
            //发色label
            //
            this.HairColor_label.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.HairColor_label.Location = new System.Drawing.Point(22,543);
            this.HairColor_label.Name = "HairColor_label";
            this.HairColor_label.Size = new System.Drawing.Size(62,31);
            this.HairColor_label.AutoSize = true;
            this.HairColor_label.TabIndex = 17;
            this.HairColor_label.Text = "发色：";
            //
            //发色text
            //
            this.HairColor_text.Font = new System.Drawing.Font ("微软雅黑 Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.HairColor_text.Location = new System.Drawing.Point(180,543);
            this.HairColor_text.Name = "HairColor_text";
            this.HairColor_text.Size = new System.Drawing.Size(452,31);
            this.HairColor_text.AutoSize = true;
            this.HairColor_text.TabIndex = 18;
            this.HairColor_text.Text = "";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point (300, 700);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size (154, 40);
            this.buttonExit.TabIndex = 99;
            this.buttonExit.Text = "一键生成老婆";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler (this.buttonExit_Click);
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonExit.AutoSize = true;
            this.buttonExit.FlatStyle = FlatStyle.Flat;
            this.buttonExit.BackColor = Color.Cyan;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (800, 800);
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Snow;
            this.Icon = new Icon ("waifu.ico");
            this.Name = "waifu";
            this.Text = "老婆生成器 v0.0.1";
            this.ShowIcon = true;
            


            System.Windows.Forms.Label[] controlList = new System.Windows.Forms.Label[] { this.label1, this.hair_text, this.Attr_label, this.Attr_text, this.Char_label, this.Char_text, this.Cup_label, this.Cup_text, this.Skin_label, this.Skin_text, this.Age_label, this.Age_text, this.Height_label, this.Height_text, this.Weight_label, this.Weight_text,this.HairColor_label,this.HairColor_text };

            this.Controls.AddRange (controlList);
            this.Controls.Add (this.buttonExit);

            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label hair_text;
        private System.Windows.Forms.Label Attr_label;
        private System.Windows.Forms.Label Attr_text;
        private System.Windows.Forms.Label Char_label;
        private System.Windows.Forms.Label Char_text;
        private System.Windows.Forms.Label Cup_label;
        private System.Windows.Forms.Label Cup_text;
        private System.Windows.Forms.Label Skin_label;
        private System.Windows.Forms.Label Skin_text;
        private System.Windows.Forms.Label Age_label;
        private System.Windows.Forms.Label Age_text;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.Label Height_text;
        private System.Windows.Forms.Label Weight_label;
        private System.Windows.Forms.Label Weight_text;
        private System.Windows.Forms.Label HairColor_label;
        private System.Windows.Forms.Label HairColor_text;
    }
}