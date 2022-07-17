namespace HavaDurumuApiOdev
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
            this.btnGetir = new FontAwesome.Sharp.IconButton();
            this.cbSehirler = new System.Windows.Forms.ComboBox();
            this.lblHavaDurumu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.AutoSize = true;
            this.btnGetir.BackColor = System.Drawing.Color.Green;
            this.btnGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGetir.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            this.btnGetir.IconColor = System.Drawing.Color.White;
            this.btnGetir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGetir.IconSize = 45;
            this.btnGetir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetir.Location = new System.Drawing.Point(268, 175);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(108, 53);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Getir";
            this.btnGetir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // cbSehirler
            // 
            this.cbSehirler.FormattingEnabled = true;
            this.cbSehirler.Location = new System.Drawing.Point(259, 234);
            this.cbSehirler.Name = "cbSehirler";
            this.cbSehirler.Size = new System.Drawing.Size(127, 21);
            this.cbSehirler.TabIndex = 1;
            // 
            // lblHavaDurumu
            // 
            this.lblHavaDurumu.AutoSize = true;
            this.lblHavaDurumu.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.lblHavaDurumu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHavaDurumu.Location = new System.Drawing.Point(416, 186);
            this.lblHavaDurumu.Name = "lblHavaDurumu";
            this.lblHavaDurumu.Size = new System.Drawing.Size(0, 21);
            this.lblHavaDurumu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(220, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hava Durumu Api Uygulması";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHavaDurumu);
            this.Controls.Add(this.cbSehirler);
            this.Controls.Add(this.btnGetir);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "HavaDurumuApiForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGetir;
        private System.Windows.Forms.ComboBox cbSehirler;
        private System.Windows.Forms.Label lblHavaDurumu;
        private System.Windows.Forms.Label label1;
    }
}

