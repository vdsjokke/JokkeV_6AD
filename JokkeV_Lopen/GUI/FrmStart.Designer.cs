namespace JokkeV_Lopen
{
    partial class FrmStartLopen
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
            this.BtnInschrijven = new System.Windows.Forms.Button();
            this.BtnBewerken = new System.Windows.Forms.Button();
            this.BtnOpzoeken = new System.Windows.Forms.Button();
            this.BtnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInschrijven
            // 
            this.BtnInschrijven.Location = new System.Drawing.Point(3, 12);
            this.BtnInschrijven.Name = "BtnInschrijven";
            this.BtnInschrijven.Size = new System.Drawing.Size(159, 49);
            this.BtnInschrijven.TabIndex = 0;
            this.BtnInschrijven.Text = "Inschrijven";
            this.BtnInschrijven.UseVisualStyleBackColor = true;
            this.BtnInschrijven.Click += new System.EventHandler(this.BtnInschrijven_Click);
            // 
            // BtnBewerken
            // 
            this.BtnBewerken.Location = new System.Drawing.Point(3, 87);
            this.BtnBewerken.Name = "BtnBewerken";
            this.BtnBewerken.Size = new System.Drawing.Size(159, 49);
            this.BtnBewerken.TabIndex = 1;
            this.BtnBewerken.Text = "Bewerken";
            this.BtnBewerken.UseVisualStyleBackColor = true;
            this.BtnBewerken.Click += new System.EventHandler(this.BtnBewerken_Click);
            // 
            // BtnOpzoeken
            // 
            this.BtnOpzoeken.Location = new System.Drawing.Point(3, 167);
            this.BtnOpzoeken.Name = "BtnOpzoeken";
            this.BtnOpzoeken.Size = new System.Drawing.Size(159, 49);
            this.BtnOpzoeken.TabIndex = 2;
            this.BtnOpzoeken.Text = "Opzoeken";
            this.BtnOpzoeken.UseVisualStyleBackColor = true;
            // 
            // BtnAfsluiten
            // 
            this.BtnAfsluiten.Location = new System.Drawing.Point(3, 241);
            this.BtnAfsluiten.Name = "BtnAfsluiten";
            this.BtnAfsluiten.Size = new System.Drawing.Size(159, 49);
            this.BtnAfsluiten.TabIndex = 3;
            this.BtnAfsluiten.Text = "Afsluiten";
            this.BtnAfsluiten.UseVisualStyleBackColor = true;
            this.BtnAfsluiten.Click += new System.EventHandler(this.BtnAfsluiten_Click);
            // 
            // FrmStartLopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 297);
            this.ControlBox = false;
            this.Controls.Add(this.BtnAfsluiten);
            this.Controls.Add(this.BtnOpzoeken);
            this.Controls.Add(this.BtnBewerken);
            this.Controls.Add(this.BtnInschrijven);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStartLopen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.FrmStartLopen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInschrijven;
        private System.Windows.Forms.Button BtnBewerken;
        private System.Windows.Forms.Button BtnOpzoeken;
        private System.Windows.Forms.Button BtnAfsluiten;
    }
}

