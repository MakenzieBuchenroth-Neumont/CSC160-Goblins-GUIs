namespace Dungeons_Diners_Drive_Ins_Dragons_Dives
{
    partial class DialogueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogueForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_speakerName = new System.Windows.Forms.Label();
            this.text_dialogBox = new System.Windows.Forms.RichTextBox();
            this.listBox_options = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(231, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 214);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.text_speakerName);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 435);
            this.panel2.TabIndex = 3;
            // 
            // text_speakerName
            // 
            this.text_speakerName.AutoSize = true;
            this.text_speakerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.text_speakerName.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_speakerName.Location = new System.Drawing.Point(11, 248);
            this.text_speakerName.Name = "text_speakerName";
            this.text_speakerName.Size = new System.Drawing.Size(50, 26);
            this.text_speakerName.TabIndex = 0;
            this.text_speakerName.Text = "Guard";
            // 
            // text_dialogBox
            // 
            this.text_dialogBox.Enabled = false;
            this.text_dialogBox.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_dialogBox.Location = new System.Drawing.Point(12, 280);
            this.text_dialogBox.Name = "text_dialogBox";
            this.text_dialogBox.ReadOnly = true;
            this.text_dialogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.text_dialogBox.Size = new System.Drawing.Size(578, 158);
            this.text_dialogBox.TabIndex = 0;
            this.text_dialogBox.Text = "u k bro?";
            // 
            // listBox_options
            // 
            this.listBox_options.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_options.FormattingEnabled = true;
            this.listBox_options.ItemHeight = 38;
            this.listBox_options.Items.AddRange(new object[] {
            "Ja",
            "Nej",
            "ATTACK",
            "rizz em"});
            this.listBox_options.Location = new System.Drawing.Point(596, 282);
            this.listBox_options.Name = "listBox_options";
            this.listBox_options.Size = new System.Drawing.Size(192, 156);
            this.listBox_options.TabIndex = 7;
            // 
            // DialogueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dungeons_Diners_Drive_Ins_Dragons_Dives.Properties.Resources.village;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_options);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_dialogBox);
            this.Controls.Add(this.panel2);
            this.Name = "DialogueForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label text_speakerName;
        private System.Windows.Forms.RichTextBox text_dialogBox;
        private System.Windows.Forms.ListBox listBox_options;
    }
}