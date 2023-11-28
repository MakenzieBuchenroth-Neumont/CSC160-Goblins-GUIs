using Dungeons_Diners_Drive_Ins_Dragons_Dives.Source.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic;

namespace Dungeons_Diners_Drive_Ins_Dragons_Dives.Source.Forms
{
    public partial class CombatForm : Form
    {
        Combat combat = new Combat();
        Enemy enemy = new Enemy();
        Character playerCharacter;
        Controller controller;
        bool playerTurn = true;
        public CombatForm()
        {
            InitializeComponent();
        }

        public void setController(Controller controller) {
            this.controller = controller;
        }

        private void button_melee_Click(object sender, EventArgs e)
        {
            Panel meleeOverlayPanel = new Panel();
            if (playerTurn)
            {
                button_melee.Enabled = true;
                this.Controls.Remove(meleeOverlayPanel);
                combat.OnMelee("Strength", enemy.setStrength());
            }
            else if (!playerTurn)
            {
                button_melee.Enabled = false;
                meleeOverlayPanel.BackColor = Color.Transparent;
                meleeOverlayPanel.Size = button_melee.Size;
                meleeOverlayPanel.Location = button_melee.Location;
            }
        }

        private void button_ranged_Click(object sender, EventArgs e)
        {
            Panel rangedOverlayPanel = new Panel();
            if (playerTurn)
            {
                button_ranged.Enabled = true;
                this.Controls.Remove(rangedOverlayPanel);
                combat.OnRanged("Dexterity", enemy.setDexterity());
            }
            else if (!playerTurn)
            {
                button_ranged.Enabled = false;
                rangedOverlayPanel.BackColor = Color.Transparent;
                rangedOverlayPanel.Size = button_ranged.Size;
                rangedOverlayPanel.Location = button_ranged.Location;
            }
        }

        private void button_healthPotion_Click(object sender, EventArgs e)
        {
            Panel healthPotionOverlayPanel = new Panel();
            if (playerTurn && playerCharacter.health != playerCharacter.maxHealth)
            {
                button_healthPotion.Enabled = true;
                this.Controls.Remove(healthPotionOverlayPanel);
                combat.OnHeal();
            }
            else if (playerTurn && playerCharacter.health == playerCharacter.maxHealth)
            {
                button_healthPotion.Enabled = false;
                this.Controls.Remove(healthPotionOverlayPanel);
            }
            else if (!playerTurn)
            {
                button_healthPotion.Enabled = false;
                healthPotionOverlayPanel.BackColor = Color.Transparent;
                healthPotionOverlayPanel.Size = button_healthPotion.Size;
                healthPotionOverlayPanel.Location = button_healthPotion.Location;
            }
        }

        private void button_magic_Click(object sender, EventArgs e)
        {
            Panel magicOverlayPanel = new Panel();
            if (playerTurn && playerCharacter.mana != playerCharacter.maxMana)
            {
                button_magic.Enabled = true;
                this.Controls.Remove(magicOverlayPanel);
                combat.OnMagic("Wisdom", enemy.setWisdom());

            }
            else if (playerTurn && playerCharacter.mana == playerCharacter.maxMana)
            {
                button_magic.Enabled = false;
                this.Controls.Remove(magicOverlayPanel);
            }
            else if (!playerTurn)
            {
                button_magic.Enabled = false;
                magicOverlayPanel.BackColor = Color.Transparent;
                magicOverlayPanel.Size = button_magic.Size;
                magicOverlayPanel.Location = button_magic.Location;
            }
        }

        private void CombatForm_Shown(object sender, EventArgs e)
        {
            button_healthPotion.Text = "Health Potion (" + playerCharacter.healthPotion.ToString() + ")";
            healthBar.Maximum = playerCharacter.maxHealth;
            healthBar.Value = playerCharacter.health;
            progressBar_enemyHealth.Maximum = enemy.maxHealth;
            progressBar_enemyHealth.Value = enemy.health;
            manaBar.Maximum = playerCharacter.maxMana;
            manaBar.Value = playerCharacter.mana;

            Console.WriteLine("Max Health: " + playerCharacter.maxHealth);
            Console.WriteLine("Health: " + playerCharacter.health);
            Console.WriteLine("Max Mana: " + playerCharacter.maxMana);
            Console.WriteLine("Mana: " + playerCharacter.mana);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            healthBar.Value = playerCharacter.health;
            manaBar.Value = playerCharacter.mana;
        }
    }
}
