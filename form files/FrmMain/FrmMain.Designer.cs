namespace hasznaltufo
{
    partial class FrmMain
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
            menu = new MenuStrip();
            vEVŐKToolStripMenuItem = new ToolStripMenuItem();
            kERESŐToolStripMenuItem = new ToolStripMenuItem();
            dgvUfok = new DataGridView();
            tipus = new DataGridViewTextBoxColumn();
            ar = new DataGridViewTextBoxColumn();
            allapot = new DataGridViewTextBoxColumn();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUfok).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menu.Items.AddRange(new ToolStripItem[] { vEVŐKToolStripMenuItem, kERESŐToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(652, 40);
            menu.TabIndex = 1;
            menu.Text = "menu";
            // 
            // vEVŐKToolStripMenuItem
            // 
            vEVŐKToolStripMenuItem.ForeColor = Color.Red;
            vEVŐKToolStripMenuItem.Name = "vEVŐKToolStripMenuItem";
            vEVŐKToolStripMenuItem.Size = new Size(99, 36);
            vEVŐKToolStripMenuItem.Text = "VEVŐK";
            vEVŐKToolStripMenuItem.Click += OnVevokClicked;
            // 
            // kERESŐToolStripMenuItem
            // 
            kERESŐToolStripMenuItem.ForeColor = Color.LimeGreen;
            kERESŐToolStripMenuItem.Name = "kERESŐToolStripMenuItem";
            kERESŐToolStripMenuItem.Size = new Size(109, 36);
            kERESŐToolStripMenuItem.Text = "KERESŐ";
            kERESŐToolStripMenuItem.Click += OnKeresoClicked;
            // 
            // dgvUfok
            // 
            dgvUfok.AllowUserToAddRows = false;
            dgvUfok.AllowUserToDeleteRows = false;
            dgvUfok.AllowUserToResizeColumns = false;
            dgvUfok.AllowUserToResizeRows = false;
            dgvUfok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUfok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUfok.Columns.AddRange(new DataGridViewColumn[] { tipus, ar, allapot });
            dgvUfok.Location = new Point(12, 43);
            dgvUfok.MultiSelect = false;
            dgvUfok.Name = "dgvUfok";
            dgvUfok.RowHeadersVisible = false;
            dgvUfok.RowTemplate.Height = 25;
            dgvUfok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUfok.Size = new Size(628, 395);
            dgvUfok.TabIndex = 2;
            // 
            // tipus
            // 
            tipus.HeaderText = "típus";
            tipus.Name = "tipus";
            tipus.ReadOnly = true;
            // 
            // ar
            // 
            ar.HeaderText = "ár";
            ar.Name = "ar";
            ar.ReadOnly = true;
            // 
            // allapot
            // 
            allapot.HeaderText = "állapot";
            allapot.Name = "allapot";
            allapot.ReadOnly = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(dgvUfok);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "FrmMain";
            Text = "USEDUFO.glx kínálata";
            Load += OnFormLoad;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUfok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
        private ToolStripMenuItem vEVŐKToolStripMenuItem;
        private ToolStripMenuItem kERESŐToolStripMenuItem;
        private DataGridView dgvUfok;
        private DataGridViewTextBoxColumn tipus;
        private DataGridViewTextBoxColumn ar;
        private DataGridViewTextBoxColumn allapot;
    }
}