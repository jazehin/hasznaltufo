using hasznaltufo.res.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hasznaltufo
{
    public partial class FrmKereso : Form
    {
        public FrmKereso()
        {
            InitializeComponent();
        }

        private void OnTextBoxTextChanged(object sender, EventArgs e)
        {
            RefreshTable(tbJarmu.Text, tbVevo.Text);
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable(string jarmu = "", string vevo = "")
        {
            using SqlConnection connection = new SqlConnection(Resources.ConStr);
            connection.Open();

            SqlCommand command = new SqlCommand(
               "SELECT tipus.nev, vevo.nev " +
               "FROM tipus " +
               "INNER JOIN ufo ON ufo.tipus = tipus.tipusId " +
               "INNER JOIN vevo ON ufo.foglalo = vevo.vevoId " +
               "WHERE 1 = 1" +
               (string.IsNullOrWhiteSpace(jarmu) ? "" : $" AND tipus.nev LIKE '%{jarmu}%'") +
               (string.IsNullOrWhiteSpace(vevo) ? "" : $" AND vevo.nev LIKE '%{vevo}%'") +
              $";",
                connection);
            using SqlDataReader reader = command.ExecuteReader();

            dgvUfok.Rows.Clear();
            while (reader.Read())
            {
                dgvUfok.Rows.Add(reader[0], reader[1]);
            }
        }
    }
}
