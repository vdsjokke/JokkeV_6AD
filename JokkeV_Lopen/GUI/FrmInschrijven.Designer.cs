namespace JokkeV_Lopen
{
    partial class FrmInschrijven
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
            this.BtnBevestigen = new System.Windows.Forms.Button();
            this.BtnTerug = new System.Windows.Forms.Button();
            this.CmbAfstand = new System.Windows.Forms.ComboBox();
            this.txtnaam = new System.Windows.Forms.TextBox();
            this.rbbetaald = new System.Windows.Forms.RadioButton();
            this.lblwelkom = new System.Windows.Forms.Label();
            this.lblnaam = new System.Windows.Forms.Label();
            this.lblafstand = new System.Windows.Forms.Label();
            this.rbNbetaald = new System.Windows.Forms.RadioButton();
            this.lblbetaald = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBevestigen
            // 
            this.BtnBevestigen.Location = new System.Drawing.Point(560, 436);
            this.BtnBevestigen.Name = "BtnBevestigen";
            this.BtnBevestigen.Size = new System.Drawing.Size(161, 64);
            this.BtnBevestigen.TabIndex = 0;
            this.BtnBevestigen.Text = "Bevestigen";
            this.BtnBevestigen.UseVisualStyleBackColor = true;
            this.BtnBevestigen.Click += new System.EventHandler(this.BtnBevestigen_Click);
            // 
            // BtnTerug
            // 
            this.BtnTerug.Location = new System.Drawing.Point(412, 436);
            this.BtnTerug.Name = "BtnTerug";
            this.BtnTerug.Size = new System.Drawing.Size(101, 64);
            this.BtnTerug.TabIndex = 1;
            this.BtnTerug.Text = "Terug";
            this.BtnTerug.UseVisualStyleBackColor = true;
            this.BtnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // CmbAfstand
            // 
            this.CmbAfstand.FormattingEnabled = true;
            this.CmbAfstand.Items.AddRange(new object[] {
            "5 km ",
            "10 km",
            "15 km"});
            this.CmbAfstand.Location = new System.Drawing.Point(54, 241);
            this.CmbAfstand.Name = "CmbAfstand";
            this.CmbAfstand.Size = new System.Drawing.Size(283, 37);
            this.CmbAfstand.TabIndex = 2;
            this.CmbAfstand.Text = "Kies een afstand:";
            // 
            // txtnaam
            // 
            this.txtnaam.Location = new System.Drawing.Point(54, 147);
            this.txtnaam.Name = "txtnaam";
            this.txtnaam.Size = new System.Drawing.Size(261, 34);
            this.txtnaam.TabIndex = 3;
            // 
            // rbbetaald
            // 
            this.rbbetaald.AutoSize = true;
            this.rbbetaald.Location = new System.Drawing.Point(54, 329);
            this.rbbetaald.Name = "rbbetaald";
            this.rbbetaald.Size = new System.Drawing.Size(116, 33);
            this.rbbetaald.TabIndex = 4;
            this.rbbetaald.TabStop = true;
            this.rbbetaald.Text = "Betaald";
            this.rbbetaald.UseVisualStyleBackColor = true;
            // 
            // lblwelkom
            // 
            this.lblwelkom.AutoSize = true;
            this.lblwelkom.Location = new System.Drawing.Point(196, 24);
            this.lblwelkom.Name = "lblwelkom";
            this.lblwelkom.Size = new System.Drawing.Size(405, 29);
            this.lblwelkom.TabIndex = 5;
            this.lblwelkom.Text = "Welkom bij het inschrijvingsformulier";
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Location = new System.Drawing.Point(49, 96);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(216, 29);
            this.lblnaam.TabIndex = 6;
            this.lblnaam.Text = "Vul hier je naam in:";
            // 
            // lblafstand
            // 
            this.lblafstand.AutoSize = true;
            this.lblafstand.Location = new System.Drawing.Point(49, 199);
            this.lblafstand.Name = "lblafstand";
            this.lblafstand.Size = new System.Drawing.Size(415, 29);
            this.lblafstand.TabIndex = 7;
            this.lblafstand.Text = "Selecteer de afstand die je wilt lopen:";
            // 
            // rbNbetaald
            // 
            this.rbNbetaald.AutoSize = true;
            this.rbNbetaald.Location = new System.Drawing.Point(54, 368);
            this.rbNbetaald.Name = "rbNbetaald";
            this.rbNbetaald.Size = new System.Drawing.Size(164, 33);
            this.rbNbetaald.TabIndex = 8;
            this.rbNbetaald.TabStop = true;
            this.rbNbetaald.Text = "Niet betaald";
            this.rbNbetaald.UseVisualStyleBackColor = true;
            // 
            // lblbetaald
            // 
            this.lblbetaald.AutoSize = true;
            this.lblbetaald.Location = new System.Drawing.Point(49, 297);
            this.lblbetaald.Name = "lblbetaald";
            this.lblbetaald.Size = new System.Drawing.Size(319, 29);
            this.lblbetaald.TabIndex = 9;
            this.lblbetaald.Text = "Heb je direct betaald of niet?";
            // 
            // FrmInschrijven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.lblbetaald);
            this.Controls.Add(this.rbNbetaald);
            this.Controls.Add(this.lblafstand);
            this.Controls.Add(this.lblnaam);
            this.Controls.Add(this.lblwelkom);
            this.Controls.Add(this.rbbetaald);
            this.Controls.Add(this.txtnaam);
            this.Controls.Add(this.CmbAfstand);
            this.Controls.Add(this.BtnTerug);
            this.Controls.Add(this.BtnBevestigen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmInschrijven";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInschrijven";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBevestigen;
        private System.Windows.Forms.Button BtnTerug;
        private System.Windows.Forms.ComboBox CmbAfstand;
        private System.Windows.Forms.TextBox txtnaam;
        private System.Windows.Forms.RadioButton rbbetaald;
        private System.Windows.Forms.Label lblwelkom;
        private System.Windows.Forms.Label lblnaam;
        private System.Windows.Forms.Label lblafstand;
        private System.Windows.Forms.RadioButton rbNbetaald;
        private System.Windows.Forms.Label lblbetaald;
    }
}