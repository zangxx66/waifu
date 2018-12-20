namespace waifu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.hair_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 发色label
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "hair_label";
            this.label1.Size = new System.Drawing.Size(400, 376);
            this.label1.TabIndex = 1;
            this.label1.Text = "发型：";
            //this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //
            // 发型text
            //
            this.hair_text.Dock = System.Windows.Forms.DockStyle.Right;
            this.hair_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hair_text.Location = new System.Drawing.Point(400,0);
            this.hair_text.Name = "hair_text";
            this.hair_text.Size = new System.Drawing.Size(400,376);
            this.hair_text.TabIndex = 2;
            this.hair_text.Text = "";
            // this.hair_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.Location = new System.Drawing.Point(0, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(800, 74);
            this.buttonExit.TabIndex = 99;
            this.buttonExit.Text = "生成老婆";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonExit.AutoSize = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.hair_text);
            this.Name = "waifu";
            this.Text = "老婆生成器v0.0.1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label hair_text;
    }
}

