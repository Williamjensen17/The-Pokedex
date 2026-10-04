using DotNetEnv;
using MySql.Data.MySqlClient;
using System.Data;

namespace The_Pokedex
{
    public partial class POKEDEX : Form
    {
        private readonly string _server;
        private readonly string _port;
        private readonly string _user;
        private readonly string _password;

        public POKEDEX()
        {
            InitializeComponent();

            Env.Load();

            _server = Env.GetString("DB_SERVER");
            _port = Env.GetString("DB_PORT");
            _user = Env.GetString("DB_USER");
            _password = Env.GetString("DB_PASSWORD");

            if (string.IsNullOrWhiteSpace(_server) ||
                string.IsNullOrWhiteSpace(_port) ||
                string.IsNullOrWhiteSpace(_user) ||
                string.IsNullOrWhiteSpace(_password))
            {
                MessageBox.Show("Database settings are missing in the .env file.");
                Environment.Exit(1);
            }

            LoadDatabases();
        }

        private string BuildConnectionString(string database)
        {
            return $"server={_server};port={_port};database={database};uid={_user};pwd={_password};";
        }

        private void LoadDatabases()
        {
            try
            {
                string masterConnectionString =
                    $"server={_server};port={_port};uid={_user};pwd={_password};";

                using MySqlConnection conn = new MySqlConnection(masterConnectionString);
                conn.Open();

                string sql = "SHOW DATABASES";
                using MySqlCommand cmd = new MySqlCommand(sql, conn);
                using MySqlDataReader reader = cmd.ExecuteReader();

                cmbDatabase.Items.Clear();

                while (reader.Read())
                {
                    cmbDatabase.Items.Add(reader.GetString(0));
                }

                if (cmbDatabase.Items.Count > 0)
                {
                    cmbDatabase.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading databases: {ex.Message}");
            }
        }

        private void Query(string sql)
        {
            try
            {
                if (cmbDatabase.SelectedItem == null)
                {
                    MessageBox.Show("Please select a database first.");
                    return;
                }

                string database = cmbDatabase.SelectedItem.ToString()!;
                string connectionString = BuildConnectionString(database);

                using MySqlConnection conn = new MySqlConnection(connectionString);
                using MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvOut.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing query: {ex.Message}");
                dgvOut.DataSource = new DataTable();
            }
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbQuery.Text))
            {
                Query(rtbQuery.Text);
            }
            else
            {
                Query("SELECT * FROM Pokemons");
            }
        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbQuery.Text))
            {
                Query(rtbQuery.Text);
            }
        }

        private void btn_Species_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Pokemon_Species";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnPokemon_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Pokemons";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Trainers";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnAbility_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Abilities";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Type";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM PC";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnTrainerPokemons_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Trainer_Pokemons";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnGymTrainers_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Gym_Trainers";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Time";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnEvolution_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Evolution";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Game_Version";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnGym_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Gym";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnGymTrainerGames_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Gym_Trainer_Games";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Item";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Method";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Move";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            string queryForThisCase = "SELECT * FROM Stats";
            rtbQuery.Text = queryForThisCase;
            Query(queryForThisCase);
        }
    }
}