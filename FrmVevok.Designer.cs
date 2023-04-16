namespace hasznaltufo
{
    partial class FrmVevok
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
            cbNev = new ComboBox();
            label1 = new Label();
            tbCim = new TextBox();
            groupBox1 = new GroupBox();
            rtbLefoglalt = new RichTextBox();
            rbMegbizhatoIgen = new RadioButton();
            rbMegbizhatoNem = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbNev
            // 
            cbNev.FormattingEnabled = true;
            cbNev.Location = new Point(12, 12);
            cbNev.Name = "cbNev";
            cbNev.Size = new Size(265, 23);
            cbNev.TabIndex = 0;
            cbNev.SelectedIndexChanged += OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Cím:";
            // 
            // tbCim
            // 
            tbCim.Location = new Point(50, 47);
            tbCim.Name = "tbCim";
            tbCim.Size = new Size(227, 23);
            tbCim.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMegbizhatoNem);
            groupBox1.Controls.Add(rbMegbizhatoIgen);
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 109);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Megbízható?";
            // 
            // rtbLefoglalt
            // 
            rtbLefoglalt.Location = new Point(12, 202);
            rtbLefoglalt.Name = "rtbLefoglalt";
            rtbLefoglalt.Size = new Size(265, 170);
            rtbLefoglalt.TabIndex = 4;
            rtbLefoglalt.Text = "";
            // 
            // rbMegbizhatoIgen
            // 
            rbMegbizhatoIgen.AutoSize = true;
            rbMegbizhatoIgen.Location = new Point(49, 48);
            rbMegbizhatoIgen.Name = "rbMegbizhatoIgen";
            rbMegbizhatoIgen.Size = new Size(48, 19);
            rbMegbizhatoIgen.TabIndex = 0;
            rbMegbizhatoIgen.TabStop = true;
            rbMegbizhatoIgen.Text = "igen";
            rbMegbizhatoIgen.UseVisualStyleBackColor = true;
            // 
            // rbMegbizhatoNem
            // 
            rbMegbizhatoNem.AutoSize = true;
            rbMegbizhatoNem.Location = new Point(164, 48);
            rbMegbizhatoNem.Name = "rbMegbizhatoNem";
            rbMegbizhatoNem.Size = new Size(49, 19);
            rbMegbizhatoNem.TabIndex = 1;
            rbMegbizhatoNem.TabStop = true;
            rbMegbizhatoNem.Text = "nem";
            rbMegbizhatoNem.UseVisualStyleBackColor = true;
            // 
            // FrmVevok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 384);
            Controls.Add(rtbLefoglalt);
            Controls.Add(groupBox1);
            Controls.Add(tbCim);
            Controls.Add(label1);
            Controls.Add(cbNev);
            Name = "FrmVevok";
            Text = "FrmVevok";
            Load += OnFormLoad;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbNev;
        private Label label1;
        private TextBox tbCim;
        private GroupBox groupBox1;
        private RadioButton rbMegbizhatoNem;
        private RadioButton rbMegbizhatoIgen;
        private RichTextBox rtbLefoglalt;
    }
}