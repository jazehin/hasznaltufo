namespace hasznaltufo
{
    partial class FrmKereso
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
            dgvUfok = new DataGridView();
            tipus = new DataGridViewTextBoxColumn();
            vevo = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            tbJarmu = new TextBox();
            groupBox2 = new GroupBox();
            tbVevo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUfok).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUfok
            // 
            dgvUfok.AllowUserToAddRows = false;
            dgvUfok.AllowUserToDeleteRows = false;
            dgvUfok.AllowUserToResizeColumns = false;
            dgvUfok.AllowUserToResizeRows = false;
            dgvUfok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUfok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUfok.Columns.AddRange(new DataGridViewColumn[] { tipus, vevo });
            dgvUfok.Location = new Point(12, 72);
            dgvUfok.MultiSelect = false;
            dgvUfok.Name = "dgvUfok";
            dgvUfok.RowHeadersVisible = false;
            dgvUfok.RowTemplate.Height = 25;
            dgvUfok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUfok.Size = new Size(376, 294);
            dgvUfok.TabIndex = 3;
            // 
            // tipus
            // 
            tipus.HeaderText = "jármű típusa";
            tipus.Name = "tipus";
            tipus.ReadOnly = true;
            // 
            // vevo
            // 
            vevo.HeaderText = "vevő neve";
            vevo.Name = "vevo";
            vevo.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbJarmu);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 57);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Keresés a jármű neve alapján";
            // 
            // tbJarmu
            // 
            tbJarmu.Location = new Point(6, 22);
            tbJarmu.Name = "tbJarmu";
            tbJarmu.Size = new Size(173, 23);
            tbJarmu.TabIndex = 0;
            tbJarmu.TextChanged += OnTextBoxTextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbVevo);
            groupBox2.Location = new Point(203, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(185, 57);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Keresés a vevő neve alapján";
            // 
            // tbVevo
            // 
            tbVevo.Location = new Point(6, 22);
            tbVevo.Name = "tbVevo";
            tbVevo.Size = new Size(173, 23);
            tbVevo.TabIndex = 1;
            tbVevo.TextChanged += OnTextBoxTextChanged;
            // 
            // FrmKereso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 378);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvUfok);
            Name = "FrmKereso";
            Text = "FrmKereso";
            Load += OnFormLoad;
            ((System.ComponentModel.ISupportInitialize)dgvUfok).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUfok;
        private DataGridViewTextBoxColumn tipus;
        private DataGridViewTextBoxColumn vevo;
        private GroupBox groupBox1;
        private TextBox tbJarmu;
        private GroupBox groupBox2;
        private TextBox tbVevo;
    }
}