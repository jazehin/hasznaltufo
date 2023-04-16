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
    public partial class FrmVevok : Form
    {
        public FrmVevok()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(Resources.ConStr);
            connection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT DISTINCT nev FROM vevo;",
                connection);
            SqlDataReader reader = command.ExecuteReader();

            cbNev.Items.Clear();
            while (reader.Read())
            {
                cbNev.Items.Add(reader.GetString(0));
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbNev.SelectedItem.ToString();

            using SqlConnection connection = new SqlConnection(Resources.ConStr);
            connection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT " +
                    "cim, " +
                    "megbizhato " +
                "FROM " +
                    "vevo " +
                "WHERE " +
                    $"nev = '{name}';",
                connection);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            tbCim.Text = reader.GetString(0);
            if (reader.GetBoolean(1)) {
                rbMegbizhatoNem.Checked = false;
                rbMegbizhatoIgen.Checked = true;
            } else {
                rbMegbizhatoNem.Checked = true;
                rbMegbizhatoIgen.Checked = false;
            }
            reader.Close();

            rtbLefoglalt.Text = "Lefoglalt járművek:";
            command = new SqlCommand(
               "SELECT tipus.nev, ufo.serules " +
               "FROM tipus " +
               "INNER JOIN ufo ON ufo.tipus = tipus.tipusId " +
               "INNER JOIN vevo ON ufo.foglalo = vevo.vevoId " +
              $"WHERE vevo.nev = '{name}';",
               connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                rtbLefoglalt.Text += $"\r\n{reader.GetString(0)}: {reader.GetInt32(1)}%";
            }
        }
    }
}
