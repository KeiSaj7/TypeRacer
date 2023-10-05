namespace TypeRacer
{
    partial class EndGameForm
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
            this.richTextResults = new System.Windows.Forms.RichTextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextResults
            // 
            this.richTextResults.BackColor = System.Drawing.Color.White;
            this.richTextResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextResults.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextResults.Location = new System.Drawing.Point(64, 58);
            this.richTextResults.Name = "richTextResults";
            this.richTextResults.Size = new System.Drawing.Size(380, 130);
            this.richTextResults.TabIndex = 2;
            this.richTextResults.Text = "";
            this.richTextResults.TextChanged += new System.EventHandler(this.richTextResults_TextChanged);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMenu.Image = global::TypeRacer.Properties.Resources.smallmenu2;
            this.buttonMenu.Location = new System.Drawing.Point(291, 211);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(135, 53);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatAppearance.BorderSize = 0;
            this.buttonNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.ForeColor = System.Drawing.Color.Transparent;
            this.buttonNewGame.Image = global::TypeRacer.Properties.Resources.newgame;
            this.buttonNewGame.Location = new System.Drawing.Point(64, 210);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(138, 54);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.TabStop = false;
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TypeRacer.Properties.Resources.ResultsScreen;
            this.pictureBox1.Location = new System.Drawing.Point(51, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 143);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EndGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(484, 278);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.richTextResults);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EndGameForm";
            this.Text = "TypeRacer";
            this.Load += new System.EventHandler(this.EndGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextResults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonMenu;
    }
}