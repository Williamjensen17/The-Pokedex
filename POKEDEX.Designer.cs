namespace The_Pokedex
{
    partial class POKEDEX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POKEDEX));
            btnTestCon = new Button();
            rtbQuery = new RichTextBox();
            dgvOut = new DataGridView();
            btn_Species = new Button();
            btnPokemon = new Button();
            btnTrainers = new Button();
            btnAbility = new Button();
            btnType = new Button();
            btnPC = new Button();
            btnTrainerPokemons = new Button();
            btnGymTrainers = new Button();
            btnStats = new Button();
            btnMove = new Button();
            btnMethod = new Button();
            btnItem = new Button();
            btnGymTrainerGames = new Button();
            btnGym = new Button();
            btnVersion = new Button();
            btnEvolution = new Button();
            btnTime = new Button();
            lblTableBtns = new Label();
            cmbDatabase = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvOut).BeginInit();
            SuspendLayout();
            // 
            // btnTestCon
            // 
            btnTestCon.Location = new Point(12, 40);
            btnTestCon.Name = "btnTestCon";
            btnTestCon.Size = new Size(146, 61);
            btnTestCon.TabIndex = 0;
            btnTestCon.Text = "Run Query";
            btnTestCon.UseVisualStyleBackColor = true;
            btnTestCon.Click += btnTestCon_Click;
            // 
            // rtbQuery
            // 
            rtbQuery.Location = new Point(177, 40);
            rtbQuery.Name = "rtbQuery";
            rtbQuery.Size = new Size(776, 98);
            rtbQuery.TabIndex = 1;
            rtbQuery.Text = "";
            // 
            // dgvOut
            // 
            dgvOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOut.Location = new Point(177, 187);
            dgvOut.Name = "dgvOut";
            dgvOut.Size = new Size(776, 526);
            dgvOut.TabIndex = 2;
            // 
            // btn_Species
            // 
            btn_Species.Location = new Point(1127, 187);
            btn_Species.Name = "btn_Species";
            btn_Species.Size = new Size(121, 63);
            btn_Species.TabIndex = 3;
            btn_Species.Text = "Pokemon Species";
            btn_Species.UseVisualStyleBackColor = true;
            btn_Species.Click += btn_Species_Click;
            // 
            // btnPokemon
            // 
            btnPokemon.Location = new Point(1127, 118);
            btnPokemon.Name = "btnPokemon";
            btnPokemon.Size = new Size(121, 63);
            btnPokemon.TabIndex = 4;
            btnPokemon.Text = "Pokemons";
            btnPokemon.UseVisualStyleBackColor = true;
            btnPokemon.Click += btnPokemon_Click;
            // 
            // btnTrainers
            // 
            btnTrainers.Location = new Point(1127, 394);
            btnTrainers.Name = "btnTrainers";
            btnTrainers.Size = new Size(121, 63);
            btnTrainers.TabIndex = 5;
            btnTrainers.Text = "Trainers";
            btnTrainers.UseVisualStyleBackColor = true;
            btnTrainers.Click += btnTrainers_Click;
            // 
            // btnAbility
            // 
            btnAbility.Location = new Point(985, 49);
            btnAbility.Name = "btnAbility";
            btnAbility.Size = new Size(121, 63);
            btnAbility.TabIndex = 6;
            btnAbility.Text = "Abilities";
            btnAbility.UseVisualStyleBackColor = true;
            btnAbility.Click += btnAbility_Click;
            // 
            // btnType
            // 
            btnType.Location = new Point(1127, 532);
            btnType.Name = "btnType";
            btnType.Size = new Size(121, 63);
            btnType.TabIndex = 7;
            btnType.Text = "Type";
            btnType.UseVisualStyleBackColor = true;
            btnType.Click += btnType_Click;
            // 
            // btnPC
            // 
            btnPC.Location = new Point(1127, 49);
            btnPC.Name = "btnPC";
            btnPC.Size = new Size(121, 63);
            btnPC.TabIndex = 8;
            btnPC.Text = "PC";
            btnPC.UseVisualStyleBackColor = true;
            btnPC.Click += btnPC_Click;
            // 
            // btnTrainerPokemons
            // 
            btnTrainerPokemons.Location = new Point(1127, 463);
            btnTrainerPokemons.Name = "btnTrainerPokemons";
            btnTrainerPokemons.Size = new Size(121, 63);
            btnTrainerPokemons.TabIndex = 9;
            btnTrainerPokemons.Text = "Trainer Pokemons";
            btnTrainerPokemons.UseVisualStyleBackColor = true;
            btnTrainerPokemons.Click += btnTrainerPokemons_Click;
            // 
            // btnGymTrainers
            // 
            btnGymTrainers.Location = new Point(985, 325);
            btnGymTrainers.Name = "btnGymTrainers";
            btnGymTrainers.Size = new Size(121, 63);
            btnGymTrainers.TabIndex = 10;
            btnGymTrainers.Text = "Gym Trainers";
            btnGymTrainers.UseVisualStyleBackColor = true;
            btnGymTrainers.Click += btnGymTrainers_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(1127, 256);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(121, 63);
            btnStats.TabIndex = 18;
            btnStats.Text = "Stats";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(985, 601);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(121, 63);
            btnMove.TabIndex = 17;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnMethod
            // 
            btnMethod.Location = new Point(985, 532);
            btnMethod.Name = "btnMethod";
            btnMethod.Size = new Size(121, 63);
            btnMethod.TabIndex = 16;
            btnMethod.Text = "Method";
            btnMethod.UseVisualStyleBackColor = true;
            btnMethod.Click += btnMethod_Click;
            // 
            // btnItem
            // 
            btnItem.Location = new Point(985, 463);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(121, 63);
            btnItem.TabIndex = 15;
            btnItem.Text = "Item";
            btnItem.UseVisualStyleBackColor = true;
            btnItem.Click += btnItem_Click;
            // 
            // btnGymTrainerGames
            // 
            btnGymTrainerGames.Location = new Point(985, 394);
            btnGymTrainerGames.Name = "btnGymTrainerGames";
            btnGymTrainerGames.Size = new Size(121, 63);
            btnGymTrainerGames.TabIndex = 14;
            btnGymTrainerGames.Text = "Gym Trainer Games";
            btnGymTrainerGames.UseVisualStyleBackColor = true;
            btnGymTrainerGames.Click += btnGymTrainerGames_Click;
            // 
            // btnGym
            // 
            btnGym.Location = new Point(985, 256);
            btnGym.Name = "btnGym";
            btnGym.Size = new Size(121, 63);
            btnGym.TabIndex = 13;
            btnGym.Text = "Gym";
            btnGym.UseVisualStyleBackColor = true;
            btnGym.Click += btnGym_Click;
            // 
            // btnVersion
            // 
            btnVersion.Location = new Point(985, 187);
            btnVersion.Name = "btnVersion";
            btnVersion.Size = new Size(121, 63);
            btnVersion.TabIndex = 12;
            btnVersion.Text = "Game Versions";
            btnVersion.UseVisualStyleBackColor = true;
            btnVersion.Click += btnVersion_Click;
            // 
            // btnEvolution
            // 
            btnEvolution.Location = new Point(985, 118);
            btnEvolution.Name = "btnEvolution";
            btnEvolution.Size = new Size(121, 63);
            btnEvolution.TabIndex = 11;
            btnEvolution.Text = "Evolution";
            btnEvolution.UseVisualStyleBackColor = true;
            btnEvolution.Click += btnEvolution_Click;
            // 
            // btnTime
            // 
            btnTime.Location = new Point(1127, 325);
            btnTime.Name = "btnTime";
            btnTime.Size = new Size(121, 63);
            btnTime.TabIndex = 19;
            btnTime.Text = "Time";
            btnTime.UseVisualStyleBackColor = true;
            btnTime.Click += btnTime_Click;
            // 
            // lblTableBtns
            // 
            lblTableBtns.AutoSize = true;
            lblTableBtns.Location = new Point(1075, 9);
            lblTableBtns.Name = "lblTableBtns";
            lblTableBtns.Size = new Size(78, 15);
            lblTableBtns.TabIndex = 20;
            lblTableBtns.Text = "Table Queries";
            // 
            // cmbDatabase
            // 
            cmbDatabase.FormattingEnabled = true;
            cmbDatabase.Location = new Point(12, 107);
            cmbDatabase.Name = "cmbDatabase";
            cmbDatabase.Size = new Size(146, 23);
            cmbDatabase.TabIndex = 21;
            cmbDatabase.SelectedIndexChanged += cmbDatabase_SelectedIndexChanged;
            // 
            // POKEDEX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 741);
            Controls.Add(cmbDatabase);
            Controls.Add(lblTableBtns);
            Controls.Add(btnTime);
            Controls.Add(btnStats);
            Controls.Add(btnMove);
            Controls.Add(btnMethod);
            Controls.Add(btnItem);
            Controls.Add(btnGymTrainerGames);
            Controls.Add(btnGym);
            Controls.Add(btnVersion);
            Controls.Add(btnEvolution);
            Controls.Add(btnGymTrainers);
            Controls.Add(btnTrainerPokemons);
            Controls.Add(btnPC);
            Controls.Add(btnType);
            Controls.Add(btnAbility);
            Controls.Add(btnTrainers);
            Controls.Add(btnPokemon);
            Controls.Add(btn_Species);
            Controls.Add(dgvOut);
            Controls.Add(rtbQuery);
            Controls.Add(btnTestCon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "POKEDEX";
            Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)dgvOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestCon;
        private RichTextBox rtbQuery;
        private DataGridView dgvOut;
        private Button btn_Species;
        private Button btnPokemon;
        private Button btnTrainers;
        private Button btnAbility;
        private Button btnType;
        private Button btnPC;
        private Button btnTrainerPokemons;
        private Button btnGymTrainers;
        private Button btnStats;
        private Button btnMove;
        private Button btnMethod;
        private Button btnItem;
        private Button btnGymTrainerGames;
        private Button btnGym;
        private Button btnVersion;
        private Button btnEvolution;
        private Button btnTime;
        private Label lblTableBtns;
        private ComboBox cmbDatabase;
    }
}
