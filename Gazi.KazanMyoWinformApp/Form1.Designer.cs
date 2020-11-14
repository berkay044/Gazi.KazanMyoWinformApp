namespace Gazi.KazanMyoWinformApp
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
            this.components = new System.ComponentModel.Container();
            this.btnSayi1 = new System.Windows.Forms.Button();
            this.btnSayi2 = new System.Windows.Forms.Button();
            this.btnSayi3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSayi1
            // 
            this.btnSayi1.Location = new System.Drawing.Point(343, 115);
            this.btnSayi1.Name = "btnSayi1";
            this.btnSayi1.Size = new System.Drawing.Size(75, 23);
            this.btnSayi1.TabIndex = 0;
            this.btnSayi1.Text = "button1";
            this.btnSayi1.UseVisualStyleBackColor = true;
            this.btnSayi1.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnSayi2
            // 
            this.btnSayi2.Location = new System.Drawing.Point(343, 144);
            this.btnSayi2.Name = "btnSayi2";
            this.btnSayi2.Size = new System.Drawing.Size(75, 23);
            this.btnSayi2.TabIndex = 1;
            this.btnSayi2.Text = "button2";
            this.btnSayi2.UseVisualStyleBackColor = true;
            // 
            // btnSayi3
            // 
            this.btnSayi3.Location = new System.Drawing.Point(343, 173);
            this.btnSayi3.Name = "btnSayi3";
            this.btnSayi3.Size = new System.Drawing.Size(75, 23);
            this.btnSayi3.TabIndex = 2;
            this.btnSayi3.Text = "button3";
            this.btnSayi3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sonucu Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tmrButton
            // 
            this.tmrButton.Interval = 1000;
            this.tmrButton.Tick += new System.EventHandler(this.tmrButton_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSayi3);
            this.Controls.Add(this.btnSayi2);
            this.Controls.Add(this.btnSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayi1;
        private System.Windows.Forms.Button btnSayi2;
        private System.Windows.Forms.Button btnSayi3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer tmrButton;
    }
}

