namespace JokkeV_Lopen
{
    partial class FrmAanpassen
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
            this.btnterug = new System.Windows.Forms.Button();
            this.BtnAanpassen = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lblbetaald = new System.Windows.Forms.Label();
            this.rbNbetaald = new System.Windows.Forms.RadioButton();
            this.lblafstand = new System.Windows.Forms.Label();
            this.lblnaam = new System.Windows.Forms.Label();
            this.rbbetaald = new System.Windows.Forms.RadioButton();
            this.txtnaam = new System.Windows.Forms.TextBox();
            this.CmbAfstand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbAanpassen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnterug
            // 
            this.btnterug.Location = new System.Drawing.Point(51, 497);
            this.btnterug.Margin = new System.Windows.Forms.Padding(5);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(131, 42);
            this.btnterug.TabIndex = 0;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click_1);
            // 
            // BtnAanpassen
            // 
            this.BtnAanpassen.Location = new System.Drawing.Point(219, 497);
            this.BtnAanpassen.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAanpassen.Name = "BtnAanpassen";
            this.BtnAanpassen.Size = new System.Drawing.Size(145, 42);
            this.BtnAanpassen.TabIndex = 1;
            this.BtnAanpassen.Text = "Aanpassen";
            this.BtnAanpassen.UseVisualStyleBackColor = true;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(391, 497);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(5);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(131, 42);
            this.btnVerwijder.TabIndex = 2;
            this.btnVerwijder.Text = "Verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // lblbetaald
            // 
            this.lblbetaald.AutoSize = true;
            this.lblbetaald.Location = new System.Drawing.Point(46, 344);
            this.lblbetaald.Name = "lblbetaald";
            this.lblbetaald.Size = new System.Drawing.Size(314, 29);
            this.lblbetaald.TabIndex = 16;
            this.lblbetaald.Text = "Is er betaald of niet betaald?";
            // 
            // rbNbetaald
            // 
            this.rbNbetaald.AutoSize = true;
            this.rbNbetaald.Location = new System.Drawing.Point(51, 415);
            this.rbNbetaald.Name = "rbNbetaald";
            this.rbNbetaald.Size = new System.Drawing.Size(164, 33);
            this.rbNbetaald.TabIndex = 15;
            this.rbNbetaald.TabStop = true;
            this.rbNbetaald.Text = "Niet betaald";
            this.rbNbetaald.UseVisualStyleBackColor = true;
            // 
            // lblafstand
            // 
            this.lblafstand.AutoSize = true;
            this.lblafstand.Location = new System.Drawing.Point(46, 246);
            this.lblafstand.Name = "lblafstand";
            this.lblafstand.Size = new System.Drawing.Size(318, 29);
            this.lblafstand.TabIndex = 14;
            this.lblafstand.Text = "Selecteer de nieuwe afstand";
            // 
            // lblnaam
            // 
            this.lblnaam.AutoSize = true;
            this.lblnaam.Location = new System.Drawing.Point(46, 143);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(273, 29);
            this.lblnaam.TabIndex = 13;
            this.lblnaam.Text = "Geef de nieuwe naam in";
            // 
            // rbbetaald
            // 
            this.rbbetaald.AutoSize = true;
            this.rbbetaald.Location = new System.Drawing.Point(51, 376);
            this.rbbetaald.Name = "rbbetaald";
            this.rbbetaald.Size = new System.Drawing.Size(116, 33);
            this.rbbetaald.TabIndex = 12;
            this.rbbetaald.TabStop = true;
            this.rbbetaald.Text = "Betaald";
            this.rbbetaald.UseVisualStyleBackColor = true;
            // 
            // txtnaam
            // 
            this.txtnaam.Location = new System.Drawing.Point(51, 194);
            this.txtnaam.Name = "txtnaam";
            this.txtnaam.Size = new System.Drawing.Size(261, 34);
            this.txtnaam.TabIndex = 11;
            // 
            // CmbAfstand
            // 
            this.CmbAfstand.FormattingEnabled = true;
            this.CmbAfstand.Items.AddRange(new object[] {
            "5 km ",
            "10 km",
            "15 km"});
            this.CmbAfstand.Location = new System.Drawing.Point(51, 288);
            this.CmbAfstand.Name = "CmbAfstand";
            this.CmbAfstand.Size = new System.Drawing.Size(283, 37);
            this.CmbAfstand.TabIndex = 10;
            this.CmbAfstand.Text = "Kies een afstand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kies een persoon om aan te passen:";
            // 
            // CmbAanpassen
            // 
            this.CmbAanpassen.FormattingEnabled = true;
            this.CmbAanpassen.Location = new System.Drawing.Point(51, 81);
            this.CmbAanpassen.Name = "CmbAanpassen";
            this.CmbAanpassen.Size = new System.Drawing.Size(283, 37);
            this.CmbAanpassen.TabIndex = 18;
            this.CmbAanpassen.Text = "Kies een persoon";
            // 
            // FrmAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.CmbAanpassen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbetaald);
            this.Controls.Add(this.rbNbetaald);
            this.Controls.Add(this.lblafstand);
            this.Controls.Add(this.lblnaam);
            this.Controls.Add(this.rbbetaald);
            this.Controls.Add(this.txtnaam);
            this.Controls.Add(this.CmbAfstand);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.BtnAanpassen);
            this.Controls.Add(this.btnterug);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAanpassen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnterug;
        private System.Windows.Forms.Button BtnAanpassen;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label lblbetaald;
        private System.Windows.Forms.RadioButton rbNbetaald;
        private System.Windows.Forms.Label lblafstand;
        private System.Windows.Forms.Label lblnaam;
        private System.Windows.Forms.RadioButton rbbetaald;
        private System.Windows.Forms.TextBox txtnaam;
        private System.Windows.Forms.ComboBox CmbAfstand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAanpassen;
    }
}