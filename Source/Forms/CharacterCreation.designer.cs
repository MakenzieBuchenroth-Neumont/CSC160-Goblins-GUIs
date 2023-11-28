namespace Dungeons_Diners_Drive_Ins_Dragons_Dives
{
    partial class CharacterCreation
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
            this.components = new System.ComponentModel.Container();
            this.radio_race_human = new System.Windows.Forms.RadioButton();
            this.text_race = new System.Windows.Forms.TextBox();
            this.radio_race_elf = new System.Windows.Forms.RadioButton();
            this.radio_race_halfelf = new System.Windows.Forms.RadioButton();
            this.radio_race_tiefling = new System.Windows.Forms.RadioButton();
            this.radio_race_dwarf = new System.Windows.Forms.RadioButton();
            this.radio_class_fighter = new System.Windows.Forms.RadioButton();
            this.radio_class_cleric = new System.Windows.Forms.RadioButton();
            this.text_class = new System.Windows.Forms.TextBox();
            this.radio_class_wizard = new System.Windows.Forms.RadioButton();
            this.radio_class_bard = new System.Windows.Forms.RadioButton();
            this.radio_class_druid = new System.Windows.Forms.RadioButton();
            this.radio_class_rogue = new System.Windows.Forms.RadioButton();
            this.radio_class_ranger = new System.Windows.Forms.RadioButton();
            this.text_strengthReadOnly = new System.Windows.Forms.TextBox();
            this.button_str_roll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_name = new System.Windows.Forms.TextBox();
            this.button_dex_roll = new System.Windows.Forms.Button();
            this.text_dexterityReadOnly = new System.Windows.Forms.TextBox();
            this.button_con_roll = new System.Windows.Forms.Button();
            this.text_constituionReadOnly = new System.Windows.Forms.TextBox();
            this.button_int_roll = new System.Windows.Forms.Button();
            this.text_intelligenceReadOnly = new System.Windows.Forms.TextBox();
            this.button_wis_roll = new System.Windows.Forms.Button();
            this.text_wisdomReadOnly = new System.Windows.Forms.TextBox();
            this.button_chr_roll = new System.Windows.Forms.Button();
            this.text_charismaReadOnly = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_race_human
            // 
            this.radio_race_human.AutoSize = true;
            this.radio_race_human.Location = new System.Drawing.Point(3, 35);
            this.radio_race_human.Name = "radio_race_human";
            this.radio_race_human.Size = new System.Drawing.Size(86, 24);
            this.radio_race_human.TabIndex = 0;
            this.radio_race_human.TabStop = true;
            this.radio_race_human.Text = "Human";
            this.radio_race_human.UseVisualStyleBackColor = true;
            this.radio_race_human.CheckedChanged += new System.EventHandler(this.radio_race_human_CheckedChanged);
            // 
            // text_race
            // 
            this.text_race.Enabled = false;
            this.text_race.Location = new System.Drawing.Point(3, 3);
            this.text_race.Name = "text_race";
            this.text_race.ReadOnly = true;
            this.text_race.Size = new System.Drawing.Size(100, 26);
            this.text_race.TabIndex = 1;
            this.text_race.Text = "Race";
            // 
            // radio_race_elf
            // 
            this.radio_race_elf.AutoSize = true;
            this.radio_race_elf.Location = new System.Drawing.Point(3, 65);
            this.radio_race_elf.Name = "radio_race_elf";
            this.radio_race_elf.Size = new System.Drawing.Size(53, 24);
            this.radio_race_elf.TabIndex = 2;
            this.radio_race_elf.TabStop = true;
            this.radio_race_elf.Text = "Elf";
            this.radio_race_elf.UseVisualStyleBackColor = true;
            this.radio_race_elf.CheckedChanged += new System.EventHandler(this.radio_race_elf_CheckedChanged);
            // 
            // radio_race_halfelf
            // 
            this.radio_race_halfelf.AutoSize = true;
            this.radio_race_halfelf.Location = new System.Drawing.Point(3, 95);
            this.radio_race_halfelf.Name = "radio_race_halfelf";
            this.radio_race_halfelf.Size = new System.Drawing.Size(87, 24);
            this.radio_race_halfelf.TabIndex = 3;
            this.radio_race_halfelf.TabStop = true;
            this.radio_race_halfelf.Text = "Half-Elf";
            this.radio_race_halfelf.UseVisualStyleBackColor = true;
            this.radio_race_halfelf.CheckedChanged += new System.EventHandler(this.radio_race_halfelf_CheckedChanged);
            // 
            // radio_race_tiefling
            // 
            this.radio_race_tiefling.AutoSize = true;
            this.radio_race_tiefling.Location = new System.Drawing.Point(3, 125);
            this.radio_race_tiefling.Name = "radio_race_tiefling";
            this.radio_race_tiefling.Size = new System.Drawing.Size(84, 24);
            this.radio_race_tiefling.TabIndex = 4;
            this.radio_race_tiefling.TabStop = true;
            this.radio_race_tiefling.Text = "Tiefling";
            this.radio_race_tiefling.UseVisualStyleBackColor = true;
            this.radio_race_tiefling.CheckedChanged += new System.EventHandler(this.radio_race_tiefling_CheckedChanged);
            // 
            // radio_race_dwarf
            // 
            this.radio_race_dwarf.AutoSize = true;
            this.radio_race_dwarf.Location = new System.Drawing.Point(3, 155);
            this.radio_race_dwarf.Name = "radio_race_dwarf";
            this.radio_race_dwarf.Size = new System.Drawing.Size(76, 24);
            this.radio_race_dwarf.TabIndex = 5;
            this.radio_race_dwarf.TabStop = true;
            this.radio_race_dwarf.Text = "Dwarf";
            this.radio_race_dwarf.UseVisualStyleBackColor = true;
            this.radio_race_dwarf.CheckedChanged += new System.EventHandler(this.radio_race_dwarf_CheckedChanged);
            // 
            // radio_class_fighter
            // 
            this.radio_class_fighter.AutoSize = true;
            this.radio_class_fighter.Location = new System.Drawing.Point(3, 95);
            this.radio_class_fighter.Name = "radio_class_fighter";
            this.radio_class_fighter.Size = new System.Drawing.Size(84, 24);
            this.radio_class_fighter.TabIndex = 10;
            this.radio_class_fighter.TabStop = true;
            this.radio_class_fighter.Text = "Fighter";
            this.radio_class_fighter.UseVisualStyleBackColor = true;
            this.radio_class_fighter.CheckedChanged += new System.EventHandler(this.radio_class_fighter_CheckedChanged);
            // 
            // radio_class_cleric
            // 
            this.radio_class_cleric.AutoSize = true;
            this.radio_class_cleric.Location = new System.Drawing.Point(3, 65);
            this.radio_class_cleric.Name = "radio_class_cleric";
            this.radio_class_cleric.Size = new System.Drawing.Size(73, 24);
            this.radio_class_cleric.TabIndex = 8;
            this.radio_class_cleric.TabStop = true;
            this.radio_class_cleric.Text = "Cleric";
            this.radio_class_cleric.UseVisualStyleBackColor = true;
            this.radio_class_cleric.CheckedChanged += new System.EventHandler(this.radio_class_cleric_CheckedChanged);
            // 
            // text_class
            // 
            this.text_class.Enabled = false;
            this.text_class.Location = new System.Drawing.Point(3, 3);
            this.text_class.Name = "text_class";
            this.text_class.ReadOnly = true;
            this.text_class.Size = new System.Drawing.Size(100, 26);
            this.text_class.TabIndex = 7;
            this.text_class.Text = "Class";
            // 
            // radio_class_wizard
            // 
            this.radio_class_wizard.AutoSize = true;
            this.radio_class_wizard.Location = new System.Drawing.Point(3, 35);
            this.radio_class_wizard.Name = "radio_class_wizard";
            this.radio_class_wizard.Size = new System.Drawing.Size(83, 24);
            this.radio_class_wizard.TabIndex = 6;
            this.radio_class_wizard.TabStop = true;
            this.radio_class_wizard.Text = "Wizard";
            this.radio_class_wizard.UseVisualStyleBackColor = true;
            this.radio_class_wizard.CheckedChanged += new System.EventHandler(this.radio_class_wizard_CheckedChanged);
            // 
            // radio_class_bard
            // 
            this.radio_class_bard.AutoSize = true;
            this.radio_class_bard.Location = new System.Drawing.Point(3, 125);
            this.radio_class_bard.Name = "radio_class_bard";
            this.radio_class_bard.Size = new System.Drawing.Size(68, 24);
            this.radio_class_bard.TabIndex = 12;
            this.radio_class_bard.TabStop = true;
            this.radio_class_bard.Text = "Bard";
            this.radio_class_bard.UseVisualStyleBackColor = true;
            this.radio_class_bard.CheckedChanged += new System.EventHandler(this.radio_class_bard_CheckedChanged);
            // 
            // radio_class_druid
            // 
            this.radio_class_druid.AutoSize = true;
            this.radio_class_druid.Location = new System.Drawing.Point(3, 155);
            this.radio_class_druid.Name = "radio_class_druid";
            this.radio_class_druid.Size = new System.Drawing.Size(72, 24);
            this.radio_class_druid.TabIndex = 13;
            this.radio_class_druid.TabStop = true;
            this.radio_class_druid.Text = "Druid";
            this.radio_class_druid.UseVisualStyleBackColor = true;
            this.radio_class_druid.CheckedChanged += new System.EventHandler(this.radio_class_druid_CheckedChanged);
            // 
            // radio_class_rogue
            // 
            this.radio_class_rogue.AutoSize = true;
            this.radio_class_rogue.Location = new System.Drawing.Point(3, 185);
            this.radio_class_rogue.Name = "radio_class_rogue";
            this.radio_class_rogue.Size = new System.Drawing.Size(82, 24);
            this.radio_class_rogue.TabIndex = 14;
            this.radio_class_rogue.TabStop = true;
            this.radio_class_rogue.Text = "Rogue";
            this.radio_class_rogue.UseVisualStyleBackColor = true;
            this.radio_class_rogue.CheckedChanged += new System.EventHandler(this.radio_class_rogue_CheckedChanged);
            // 
            // radio_class_ranger
            // 
            this.radio_class_ranger.AutoSize = true;
            this.radio_class_ranger.Location = new System.Drawing.Point(3, 215);
            this.radio_class_ranger.Name = "radio_class_ranger";
            this.radio_class_ranger.Size = new System.Drawing.Size(87, 24);
            this.radio_class_ranger.TabIndex = 15;
            this.radio_class_ranger.TabStop = true;
            this.radio_class_ranger.Text = "Ranger";
            this.radio_class_ranger.UseVisualStyleBackColor = true;
            this.radio_class_ranger.CheckedChanged += new System.EventHandler(this.radio_class_ranger_CheckedChanged);
            // 
            // text_strengthReadOnly
            // 
            this.text_strengthReadOnly.Enabled = false;
            this.text_strengthReadOnly.Location = new System.Drawing.Point(255, 43);
            this.text_strengthReadOnly.Name = "text_strengthReadOnly";
            this.text_strengthReadOnly.ReadOnly = true;
            this.text_strengthReadOnly.Size = new System.Drawing.Size(120, 26);
            this.text_strengthReadOnly.TabIndex = 16;
            this.text_strengthReadOnly.Text = "Strength";
            // 
            // button_str_roll
            // 
            this.button_str_roll.Location = new System.Drawing.Point(255, 76);
            this.button_str_roll.Name = "button_str_roll";
            this.button_str_roll.Size = new System.Drawing.Size(120, 34);
            this.button_str_roll.TabIndex = 17;
            this.button_str_roll.Text = "Roll";
            this.button_str_roll.UseVisualStyleBackColor = true;
            this.button_str_roll.Click += new System.EventHandler(this.button_strength_roll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.text_race);
            this.panel1.Controls.Add(this.radio_race_human);
            this.panel1.Controls.Add(this.radio_race_elf);
            this.panel1.Controls.Add(this.radio_race_halfelf);
            this.panel1.Controls.Add(this.radio_race_tiefling);
            this.panel1.Controls.Add(this.radio_race_dwarf);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 260);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.text_class);
            this.panel2.Controls.Add(this.radio_class_wizard);
            this.panel2.Controls.Add(this.radio_class_cleric);
            this.panel2.Controls.Add(this.radio_class_fighter);
            this.panel2.Controls.Add(this.radio_class_bard);
            this.panel2.Controls.Add(this.radio_class_ranger);
            this.panel2.Controls.Add(this.radio_class_druid);
            this.panel2.Controls.Add(this.radio_class_rogue);
            this.panel2.Location = new System.Drawing.Point(131, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 261);
            this.panel2.TabIndex = 20;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(15, 13);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(234, 26);
            this.text_name.TabIndex = 21;
            this.text_name.Text = "Enter Name:";
            this.text_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_name_MouseClick);
            this.text_name.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // button_dex_roll
            // 
            this.button_dex_roll.Location = new System.Drawing.Point(381, 76);
            this.button_dex_roll.Name = "button_dex_roll";
            this.button_dex_roll.Size = new System.Drawing.Size(120, 34);
            this.button_dex_roll.TabIndex = 23;
            this.button_dex_roll.Text = "Roll";
            this.button_dex_roll.UseVisualStyleBackColor = true;
            this.button_dex_roll.Click += new System.EventHandler(this.button_dexterity_roll_Click);
            // 
            // text_dexterityReadOnly
            // 
            this.text_dexterityReadOnly.Enabled = false;
            this.text_dexterityReadOnly.Location = new System.Drawing.Point(381, 43);
            this.text_dexterityReadOnly.Name = "text_dexterityReadOnly";
            this.text_dexterityReadOnly.ReadOnly = true;
            this.text_dexterityReadOnly.Size = new System.Drawing.Size(120, 26);
            this.text_dexterityReadOnly.TabIndex = 22;
            this.text_dexterityReadOnly.Text = "Dexterity";
            // 
            // button_con_roll
            // 
            this.button_con_roll.Location = new System.Drawing.Point(507, 75);
            this.button_con_roll.Name = "button_con_roll";
            this.button_con_roll.Size = new System.Drawing.Size(120, 34);
            this.button_con_roll.TabIndex = 25;
            this.button_con_roll.Text = "Roll";
            this.button_con_roll.UseVisualStyleBackColor = true;
            this.button_con_roll.Click += new System.EventHandler(this.button_constitution_roll_Click);
            // 
            // text_constituionReadOnly
            // 
            this.text_constituionReadOnly.Enabled = false;
            this.text_constituionReadOnly.Location = new System.Drawing.Point(507, 42);
            this.text_constituionReadOnly.Name = "text_constituionReadOnly";
            this.text_constituionReadOnly.ReadOnly = true;
            this.text_constituionReadOnly.Size = new System.Drawing.Size(120, 26);
            this.text_constituionReadOnly.TabIndex = 24;
            this.text_constituionReadOnly.Text = "Constitution";
            // 
            // button_int_roll
            // 
            this.button_int_roll.Location = new System.Drawing.Point(255, 150);
            this.button_int_roll.Name = "button_int_roll";
            this.button_int_roll.Size = new System.Drawing.Size(120, 34);
            this.button_int_roll.TabIndex = 27;
            this.button_int_roll.Text = "Roll";
            this.button_int_roll.UseVisualStyleBackColor = true;
            this.button_int_roll.Click += new System.EventHandler(this.button_intelligence_roll_Click);
            // 
            // text_intelligenceReadOnly
            // 
            this.text_intelligenceReadOnly.Enabled = false;
            this.text_intelligenceReadOnly.Location = new System.Drawing.Point(255, 117);
            this.text_intelligenceReadOnly.Name = "text_intelligenceReadOnly";
            this.text_intelligenceReadOnly.ReadOnly = true;
            this.text_intelligenceReadOnly.Size = new System.Drawing.Size(120, 26);
            this.text_intelligenceReadOnly.TabIndex = 26;
            this.text_intelligenceReadOnly.Text = "Intelligence";
            // 
            // button_wis_roll
            // 
            this.button_wis_roll.Location = new System.Drawing.Point(381, 150);
            this.button_wis_roll.Name = "button_wis_roll";
            this.button_wis_roll.Size = new System.Drawing.Size(120, 34);
            this.button_wis_roll.TabIndex = 29;
            this.button_wis_roll.Text = "Roll";
            this.button_wis_roll.UseVisualStyleBackColor = true;
            this.button_wis_roll.Click += new System.EventHandler(this.button_wisdom_roll_Click);
            // 
            // text_wisdomReadOnly
            // 
            this.text_wisdomReadOnly.Enabled = false;
            this.text_wisdomReadOnly.Location = new System.Drawing.Point(381, 117);
            this.text_wisdomReadOnly.Name = "text_wisdomReadOnly";
            this.text_wisdomReadOnly.ReadOnly = true;
            this.text_wisdomReadOnly.Size = new System.Drawing.Size(120, 26);
            this.text_wisdomReadOnly.TabIndex = 28;
            this.text_wisdomReadOnly.Text = "Wisdom";
            // 
            // button_chr_roll
            // 
            this.button_chr_roll.Location = new System.Drawing.Point(507, 150);
            this.button_chr_roll.Name = "button_chr_roll";
            this.button_chr_roll.Size = new System.Drawing.Size(120, 34);
            this.button_chr_roll.TabIndex = 31;
            this.button_chr_roll.Text = "Roll";
            this.button_chr_roll.UseVisualStyleBackColor = true;
            this.button_chr_roll.Click += new System.EventHandler(this.button_charisma_roll_Click);
            // 
            // text_charismaReadOnly
            // 
            this.text_charismaReadOnly.Enabled = false;
            this.text_charismaReadOnly.Location = new System.Drawing.Point(507, 117);
            this.text_charismaReadOnly.Name = "text_charismaReadOnly";
            this.text_charismaReadOnly.ReadOnly = true;
            this.text_charismaReadOnly.Size = new System.Drawing.Size(120, 26);
            this.text_charismaReadOnly.TabIndex = 30;
            this.text_charismaReadOnly.Text = "Charisma";
            // 
            // button_submit
            // 
            this.button_submit.Enabled = false;
            this.button_submit.Location = new System.Drawing.Point(691, 406);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(97, 32);
            this.button_submit.TabIndex = 32;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dungeons_Diners_Drive_Ins_Dragons_Dives.Properties.Resources.parchment;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.button_chr_roll);
            this.Controls.Add(this.text_charismaReadOnly);
            this.Controls.Add(this.button_wis_roll);
            this.Controls.Add(this.text_wisdomReadOnly);
            this.Controls.Add(this.button_int_roll);
            this.Controls.Add(this.text_intelligenceReadOnly);
            this.Controls.Add(this.button_con_roll);
            this.Controls.Add(this.text_constituionReadOnly);
            this.Controls.Add(this.button_dex_roll);
            this.Controls.Add(this.text_dexterityReadOnly);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_str_roll);
            this.Controls.Add(this.text_strengthReadOnly);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_race_human;
        private System.Windows.Forms.TextBox text_race;
        private System.Windows.Forms.RadioButton radio_race_elf;
        private System.Windows.Forms.RadioButton radio_race_halfelf;
        private System.Windows.Forms.RadioButton radio_race_tiefling;
        private System.Windows.Forms.RadioButton radio_race_dwarf;
        private System.Windows.Forms.RadioButton radio_class_fighter;
        private System.Windows.Forms.RadioButton radio_class_cleric;
        private System.Windows.Forms.TextBox text_class;
        private System.Windows.Forms.RadioButton radio_class_wizard;
        private System.Windows.Forms.RadioButton radio_class_bard;
        private System.Windows.Forms.RadioButton radio_class_druid;
        private System.Windows.Forms.RadioButton radio_class_rogue;
        private System.Windows.Forms.RadioButton radio_class_ranger;
        private System.Windows.Forms.TextBox text_strengthReadOnly;
        private System.Windows.Forms.Button button_str_roll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Button button_dex_roll;
        private System.Windows.Forms.TextBox text_dexterityReadOnly;
        private System.Windows.Forms.Button button_con_roll;
        private System.Windows.Forms.TextBox text_constituionReadOnly;
        private System.Windows.Forms.Button button_int_roll;
        private System.Windows.Forms.TextBox text_intelligenceReadOnly;
        private System.Windows.Forms.Button button_wis_roll;
        private System.Windows.Forms.TextBox text_wisdomReadOnly;
        private System.Windows.Forms.Button button_chr_roll;
        private System.Windows.Forms.TextBox text_charismaReadOnly;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Button button_submit;
    }
}

