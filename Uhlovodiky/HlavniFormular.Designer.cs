namespace Uhlovodiky
{
    partial class HlavniFormular
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
            this.btnNazevZeVzorce = new System.Windows.Forms.Button();
            this.txtVzorec = new System.Windows.Forms.TextBox();
            this.lblVzorec = new System.Windows.Forms.Label();
            this.lblNazev = new System.Windows.Forms.Label();
            this.txtNazev = new System.Windows.Forms.TextBox();
            this.btnVzorecZNazvu = new System.Windows.Forms.Button();
            this.radioAlkan = new System.Windows.Forms.RadioButton();
            this.radioAlken = new System.Windows.Forms.RadioButton();
            this.radioAlkyn = new System.Windows.Forms.RadioButton();
            this.btnVycistit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNazevZeVzorce
            // 
            this.btnNazevZeVzorce.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNazevZeVzorce.Location = new System.Drawing.Point(10, 170);
            this.btnNazevZeVzorce.Name = "btnNazevZeVzorce";
            this.btnNazevZeVzorce.Size = new System.Drawing.Size(421, 73);
            this.btnNazevZeVzorce.TabIndex = 0;
            this.btnNazevZeVzorce.Text = "Název ze vzorce";
            this.btnNazevZeVzorce.UseVisualStyleBackColor = true;
            this.btnNazevZeVzorce.Click += new System.EventHandler(this.btnNazevZeVzorce_Click);
            // 
            // txtVzorec
            // 
            this.txtVzorec.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVzorec.Location = new System.Drawing.Point(10, 99);
            this.txtVzorec.Name = "txtVzorec";
            this.txtVzorec.Size = new System.Drawing.Size(1022, 65);
            this.txtVzorec.TabIndex = 1;
            // 
            // lblVzorec
            // 
            this.lblVzorec.AutoSize = true;
            this.lblVzorec.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVzorec.Location = new System.Drawing.Point(11, 76);
            this.lblVzorec.Name = "lblVzorec";
            this.lblVzorec.Size = new System.Drawing.Size(143, 25);
            this.lblVzorec.TabIndex = 2;
            this.lblVzorec.Text = "Sumární vzorec";
            // 
            // lblNazev
            // 
            this.lblNazev.AutoSize = true;
            this.lblNazev.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNazev.Location = new System.Drawing.Point(12, 248);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(65, 25);
            this.lblNazev.TabIndex = 4;
            this.lblNazev.Text = "Název";
            // 
            // txtNazev
            // 
            this.txtNazev.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNazev.Location = new System.Drawing.Point(11, 271);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(1021, 65);
            this.txtNazev.TabIndex = 3;
            // 
            // btnVzorecZNazvu
            // 
            this.btnVzorecZNazvu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVzorecZNazvu.Location = new System.Drawing.Point(611, 170);
            this.btnVzorecZNazvu.Name = "btnVzorecZNazvu";
            this.btnVzorecZNazvu.Size = new System.Drawing.Size(421, 73);
            this.btnVzorecZNazvu.TabIndex = 5;
            this.btnVzorecZNazvu.Text = "Vzorec z názvu";
            this.btnVzorecZNazvu.UseVisualStyleBackColor = true;
            this.btnVzorecZNazvu.Click += new System.EventHandler(this.btnVzorecZNazvu_Click);
            // 
            // radioAlkan
            // 
            this.radioAlkan.AutoSize = true;
            this.radioAlkan.Checked = true;
            this.radioAlkan.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAlkan.Location = new System.Drawing.Point(15, 10);
            this.radioAlkan.Name = "radioAlkan";
            this.radioAlkan.Size = new System.Drawing.Size(147, 54);
            this.radioAlkan.TabIndex = 6;
            this.radioAlkan.TabStop = true;
            this.radioAlkan.Text = "alkany";
            this.radioAlkan.UseVisualStyleBackColor = true;
            this.radioAlkan.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioAlken
            // 
            this.radioAlken.AutoSize = true;
            this.radioAlken.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAlken.Location = new System.Drawing.Point(171, 12);
            this.radioAlken.Name = "radioAlken";
            this.radioAlken.Size = new System.Drawing.Size(147, 54);
            this.radioAlken.TabIndex = 7;
            this.radioAlken.TabStop = true;
            this.radioAlken.Text = "alkeny";
            this.radioAlken.UseVisualStyleBackColor = true;
            this.radioAlken.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioAlkyn
            // 
            this.radioAlkyn.AutoSize = true;
            this.radioAlkyn.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAlkyn.Location = new System.Drawing.Point(328, 12);
            this.radioAlkyn.Name = "radioAlkyn";
            this.radioAlkyn.Size = new System.Drawing.Size(146, 54);
            this.radioAlkyn.TabIndex = 8;
            this.radioAlkyn.TabStop = true;
            this.radioAlkyn.Text = "alkyny";
            this.radioAlkyn.UseVisualStyleBackColor = true;
            this.radioAlkyn.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // btnVycistit
            // 
            this.btnVycistit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVycistit.Location = new System.Drawing.Point(437, 170);
            this.btnVycistit.Name = "btnVycistit";
            this.btnVycistit.Size = new System.Drawing.Size(168, 73);
            this.btnVycistit.TabIndex = 9;
            this.btnVycistit.Text = "Vyčistit";
            this.btnVycistit.UseVisualStyleBackColor = true;
            this.btnVycistit.Click += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // HlavniFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 344);
            this.Controls.Add(this.btnVycistit);
            this.Controls.Add(this.radioAlkyn);
            this.Controls.Add(this.radioAlken);
            this.Controls.Add(this.radioAlkan);
            this.Controls.Add(this.btnVzorecZNazvu);
            this.Controls.Add(this.lblNazev);
            this.Controls.Add(this.txtNazev);
            this.Controls.Add(this.lblVzorec);
            this.Controls.Add(this.txtVzorec);
            this.Controls.Add(this.btnNazevZeVzorce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HlavniFormular";
            this.Text = "Názvosloví uhlovodíků";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNazevZeVzorce;
        private TextBox txtVzorec;
        private Label lblVzorec;
        private Label lblNazev;
        private TextBox txtNazev;
        private Button btnVzorecZNazvu;
        private RadioButton radioAlkan;
        private RadioButton radioAlken;
        private RadioButton radioAlkyn;
        private Button btnVycistit;
    }
}