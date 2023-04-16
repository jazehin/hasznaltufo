using Microsoft.Data.SqlClient;
using hasznaltufo.res.Properties;

namespace hasznaltufo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(Resources.ConStr);
            connection.Open();
            using SqlCommand command = new SqlCommand(
                "SELECT " +
                    "tipus.nev, " +
                    "tipus.alapar, " +
                    "ufo.lopott, " +
                    "ufo.serules " +
                "FROM " +
                    "ufo " +
                    "INNER JOIN tipus ON ufo.tipus = tipus.tipusId;",
                connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string tipus = reader.GetString(0);

                double ar = reader.GetInt32(1);
                bool lopott = reader.GetBoolean(2);
                double serules = reader.GetInt32(3);

                ar *= 1 - (serules / 100);
                if (lopott) ar *= 0.8;

                string allapot = "";
                if (serules <= 25) allapot = "hibátlan";
                else if (serules <= 50) allapot = "újszerû";
                else if (serules <= 66) allapot = "megkímélt";
                else allapot = "alkatrésznek";

                dgvUfok.Rows.Add(tipus, $"{(int)ar} CP", allapot);
            }
        }

        private void OnVevokClicked(object sender, EventArgs e)
        {
            new FrmVevok().ShowDialog();
        }

        private void OnKeresoClicked(object sender, EventArgs e)
        {
            new FrmKereso().ShowDialog();
        }
    }
}