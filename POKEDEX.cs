using DotNetEnv;
using MySql.Data.MySqlClient;
using System.Data;

namespace The_Pokedex
{
    public partial class POKEDEX : Form
    {
        private readonly string _connectionString;

        public POKEDEX()
        {
            InitializeComponent();

            Env.Load();
            
            _connectionString = Env.GetString("DB_CONNECTION_STRING");
            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                MessageBox.Show("Database connection string is not set. Please check your .env file.");
                Environment.Exit(1);
            }
        }

        private void Query(string sql)
        {
            try
            {
                using MySqlConnection conn = new MySqlConnection(_connectionString);
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
                string queryForThisCase = rtbQuery.Text;
                Query(queryForThisCase);
            }
            else
            {
                string queryForThisCase = "SELECT * FROM Pokemons";
                Query(queryForThisCase);
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