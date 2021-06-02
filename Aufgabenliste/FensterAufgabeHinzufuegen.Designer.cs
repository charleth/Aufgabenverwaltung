
namespace Aufgabenliste
{
    partial class FensterAufgabeHinzufuegen
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
            this.labelBezeichnung = new System.Windows.Forms.Label();
            this.labelMitarbeiter = new System.Windows.Forms.Label();
            this.labelAbgabedatum = new System.Windows.Forms.Label();
            this.buttonAufgabeHinzufuegen = new System.Windows.Forms.Button();
            this.MonthCalendarAbgabedatumWaehlen = new System.Windows.Forms.MonthCalendar();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxMitarbeiter = new System.Windows.Forms.TextBox();
            this.comboBoxErledigungsgrad = new System.Windows.Forms.ComboBox();
            this.labelErledigungsgrad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBezeichnung.Location = new System.Drawing.Point(10, 13);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(84, 13);
            this.labelBezeichnung.TabIndex = 0;
            this.labelBezeichnung.Text = "Bezeichnung:";
            // 
            // labelMitarbeiter
            // 
            this.labelMitarbeiter.AutoSize = true;
            this.labelMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMitarbeiter.Location = new System.Drawing.Point(9, 54);
            this.labelMitarbeiter.Name = "labelMitarbeiter";
            this.labelMitarbeiter.Size = new System.Drawing.Size(142, 13);
            this.labelMitarbeiter.TabIndex = 1;
            this.labelMitarbeiter.Text = "Zuständiger Mitarbeiter:";
            // 
            // labelAbgabedatum
            // 
            this.labelAbgabedatum.AutoSize = true;
            this.labelAbgabedatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbgabedatum.Location = new System.Drawing.Point(9, 96);
            this.labelAbgabedatum.Name = "labelAbgabedatum";
            this.labelAbgabedatum.Size = new System.Drawing.Size(88, 13);
            this.labelAbgabedatum.TabIndex = 2;
            this.labelAbgabedatum.Text = "Abgabedatum:";
            // 
            // buttonAufgabeHinzufuegen
            // 
            this.buttonAufgabeHinzufuegen.Location = new System.Drawing.Point(13, 351);
            this.buttonAufgabeHinzufuegen.Name = "buttonAufgabeHinzufuegen";
            this.buttonAufgabeHinzufuegen.Size = new System.Drawing.Size(433, 45);
            this.buttonAufgabeHinzufuegen.TabIndex = 3;
            this.buttonAufgabeHinzufuegen.Text = "Aufgabe hinzufügen";
            this.buttonAufgabeHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonAufgabeHinzufuegen.Click += new System.EventHandler(this.buttonAufgabeHinzufuegen_Click);
            // 
            // MonthCalendarAbgabedatumWaehlen
            // 
            this.MonthCalendarAbgabedatumWaehlen.Location = new System.Drawing.Point(177, 94);
            this.MonthCalendarAbgabedatumWaehlen.Name = "MonthCalendarAbgabedatumWaehlen";
            this.MonthCalendarAbgabedatumWaehlen.TabIndex = 4;
            this.MonthCalendarAbgabedatumWaehlen.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AbgabedatumWaehlen_DateChanged);
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(177, 13);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(227, 20);
            this.textBoxBezeichnung.TabIndex = 5;
            // 
            // textBoxMitarbeiter
            // 
            this.textBoxMitarbeiter.Location = new System.Drawing.Point(177, 54);
            this.textBoxMitarbeiter.Name = "textBoxMitarbeiter";
            this.textBoxMitarbeiter.Size = new System.Drawing.Size(227, 20);
            this.textBoxMitarbeiter.TabIndex = 6;
            // 
            // comboBoxErledigungsgrad
            // 
            this.comboBoxErledigungsgrad.FormattingEnabled = true;
            this.comboBoxErledigungsgrad.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.comboBoxErledigungsgrad.Location = new System.Drawing.Point(177, 298);
            this.comboBoxErledigungsgrad.MaxDropDownItems = 10;
            this.comboBoxErledigungsgrad.Name = "comboBoxErledigungsgrad";
            this.comboBoxErledigungsgrad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxErledigungsgrad.Sorted = true;
            this.comboBoxErledigungsgrad.TabIndex = 7;
            // 
            // labelErledigungsgrad
            // 
            this.labelErledigungsgrad.AutoSize = true;
            this.labelErledigungsgrad.Location = new System.Drawing.Point(13, 302);
            this.labelErledigungsgrad.Name = "labelErledigungsgrad";
            this.labelErledigungsgrad.Size = new System.Drawing.Size(111, 13);
            this.labelErledigungsgrad.TabIndex = 8;
            this.labelErledigungsgrad.Text = "Erledigungsgrad (in %)";
            // 
            // FensterAufgabeHinzufuegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 442);
            this.Controls.Add(this.labelErledigungsgrad);
            this.Controls.Add(this.comboBoxErledigungsgrad);
            this.Controls.Add(this.textBoxMitarbeiter);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.MonthCalendarAbgabedatumWaehlen);
            this.Controls.Add(this.buttonAufgabeHinzufuegen);
            this.Controls.Add(this.labelAbgabedatum);
            this.Controls.Add(this.labelMitarbeiter);
            this.Controls.Add(this.labelBezeichnung);
            this.Name = "FensterAufgabeHinzufuegen";
            this.Text = "Aufgabe hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.Label labelMitarbeiter;
        private System.Windows.Forms.Label labelAbgabedatum;
        private System.Windows.Forms.Button buttonAufgabeHinzufuegen;
        private System.Windows.Forms.MonthCalendar MonthCalendarAbgabedatumWaehlen;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.TextBox textBoxMitarbeiter;
        private System.Windows.Forms.ComboBox comboBoxErledigungsgrad;
        private System.Windows.Forms.Label labelErledigungsgrad;
    }
}