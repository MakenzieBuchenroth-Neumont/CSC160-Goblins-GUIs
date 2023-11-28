namespace Dungeons_Diners_Drive_Ins_Dragons_Dives.Source.Forms
{
    partial class CombatForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.button_magic = new System.Windows.Forms.Button();
            this.button_healthPotion = new System.Windows.Forms.Button();
            this.button_ranged = new System.Windows.Forms.Button();
            this.button_melee = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.manaBar = new System.Windows.Forms.ProgressBar();
            this.progressBar_enemyHealth = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar_enemyHealth);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 295);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(392, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 267);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // healthBar
            // 
            this.healthBar.ForeColor = System.Drawing.Color.Firebrick;
            this.healthBar.Location = new System.Drawing.Point(11, 428);
            this.healthBar.Maximum = 11;
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(384, 14);
            this.healthBar.TabIndex = 19;
            this.healthBar.Value = 11;
            // 
            // button_magic
            // 
            this.button_magic.Location = new System.Drawing.Point(404, 369);
            this.button_magic.Name = "button_magic";
            this.button_magic.Size = new System.Drawing.Size(385, 53);
            this.button_magic.TabIndex = 17;
            this.button_magic.Text = "Magic";
            this.button_magic.UseVisualStyleBackColor = true;
            this.button_magic.Click += new System.EventHandler(this.button_magic_Click);
            // 
            // button_healthPotion
            // 
            this.button_healthPotion.Location = new System.Drawing.Point(11, 369);
            this.button_healthPotion.Name = "button_healthPotion";
            this.button_healthPotion.Size = new System.Drawing.Size(385, 53);
            this.button_healthPotion.TabIndex = 18;
            this.button_healthPotion.Text = "Health Potion (";
            this.button_healthPotion.UseVisualStyleBackColor = true;
            this.button_healthPotion.Click += new System.EventHandler(this.button_healthPotion_Click);
            // 
            // button_ranged
            // 
            this.button_ranged.Location = new System.Drawing.Point(403, 310);
            this.button_ranged.Name = "button_ranged";
            this.button_ranged.Size = new System.Drawing.Size(385, 53);
            this.button_ranged.TabIndex = 16;
            this.button_ranged.Text = "Ranged";
            this.button_ranged.UseVisualStyleBackColor = true;
            this.button_ranged.Click += new System.EventHandler(this.button_ranged_Click);
            // 
            // button_melee
            // 
            this.button_melee.Location = new System.Drawing.Point(11, 310);
            this.button_melee.Name = "button_melee";
            this.button_melee.Size = new System.Drawing.Size(385, 53);
            this.button_melee.TabIndex = 15;
            this.button_melee.Text = "Melee";
            this.button_melee.UseVisualStyleBackColor = true;
            this.button_melee.Click += new System.EventHandler(this.button_melee_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // manaBar
            // 
            this.manaBar.ForeColor = System.Drawing.Color.Firebrick;
            this.manaBar.Location = new System.Drawing.Point(404, 428);
            this.manaBar.Maximum = 10;
            this.manaBar.Name = "manaBar";
            this.manaBar.Size = new System.Drawing.Size(384, 14);
            this.manaBar.TabIndex = 20;
            this.manaBar.Value = 10;
            // 
            // progressBar_enemyHealth
            // 
            this.progressBar_enemyHealth.Location = new System.Drawing.Point(0, -9);
            this.progressBar_enemyHealth.Name = "progressBar_enemyHealth";
            this.progressBar_enemyHealth.Size = new System.Drawing.Size(775, 28);
            this.progressBar_enemyHealth.TabIndex = 2;
            // 
            // CombatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.button_magic);
            this.Controls.Add(this.button_healthPotion);
            this.Controls.Add(this.button_ranged);
            this.Controls.Add(this.button_melee);
            this.Controls.Add(this.manaBar);
            this.Name = "CombatForm";
            this.Text = "CombatForm";
            this.Shown += new System.EventHandler(this.CombatForm_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Button button_magic;
        private System.Windows.Forms.Button button_healthPotion;
        private System.Windows.Forms.Button button_ranged;
        private System.Windows.Forms.Button button_melee;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar manaBar;
        private System.Windows.Forms.ProgressBar progressBar_enemyHealth;
    }
}