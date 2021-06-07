
namespace fuku0520
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tya = new System.Windows.Forms.Button();
            this.senbe = new System.Windows.Forms.Button();
            this.kyaku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tya
            // 
            this.tya.Location = new System.Drawing.Point(12, 12);
            this.tya.Name = "tya";
            this.tya.Size = new System.Drawing.Size(75, 23);
            this.tya.TabIndex = 0;
            this.tya.Text = "茶葉";
            this.tya.UseVisualStyleBackColor = true;
            this.tya.Click += new System.EventHandler(this.tya_Click);
            // 
            // senbe
            // 
            this.senbe.Location = new System.Drawing.Point(127, 12);
            this.senbe.Name = "senbe";
            this.senbe.Size = new System.Drawing.Size(75, 23);
            this.senbe.TabIndex = 1;
            this.senbe.Text = "煎餅";
            this.senbe.UseVisualStyleBackColor = true;
            this.senbe.Click += new System.EventHandler(this.senbe_Click);
            // 
            // kyaku
            // 
            this.kyaku.Location = new System.Drawing.Point(70, 55);
            this.kyaku.Name = "kyaku";
            this.kyaku.Size = new System.Drawing.Size(75, 23);
            this.kyaku.TabIndex = 2;
            this.kyaku.Text = "客";
            this.kyaku.UseVisualStyleBackColor = true;
            this.kyaku.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kyaku);
            this.Controls.Add(this.senbe);
            this.Controls.Add(this.tya);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tya;
        private System.Windows.Forms.Button senbe;
        private System.Windows.Forms.Button kyaku;
    }
}

