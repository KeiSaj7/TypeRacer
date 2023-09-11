namespace TypeRacer
{
    partial class GameForm
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
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.displayedText = new System.Windows.Forms.RichTextBox();
            this.timerGameStart = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.timerResult = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInputBox
            // 
            this.UserInputBox.BackColor = System.Drawing.Color.White;
            this.UserInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInputBox.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputBox.Location = new System.Drawing.Point(846, 866);
            this.UserInputBox.MaxLength = 45;
            this.UserInputBox.MinimumSize = new System.Drawing.Size(214, 49);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.Size = new System.Drawing.Size(214, 39);
            this.UserInputBox.TabIndex = 0;
            this.UserInputBox.TextChanged += new System.EventHandler(this.UserInputBox_TextChanged);
            // 
            // displayedText
            // 
            this.displayedText.BackColor = System.Drawing.Color.White;
            this.displayedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayedText.Cursor = System.Windows.Forms.Cursors.Default;
            this.displayedText.Enabled = false;
            this.displayedText.Font = new System.Drawing.Font("Montserrat", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayedText.ForeColor = System.Drawing.Color.Black;
            this.displayedText.Location = new System.Drawing.Point(253, 258);
            this.displayedText.Name = "displayedText";
            this.displayedText.ReadOnly = true;
            this.displayedText.Size = new System.Drawing.Size(1426, 472);
            this.displayedText.TabIndex = 1;
            this.displayedText.Text = "";
            this.displayedText.TextChanged += new System.EventHandler(this.displayedText_TextChanged);
            // 
            // timerGameStart
            // 
            this.timerGameStart.Interval = 1000;
            this.timerGameStart.Tick += new System.EventHandler(this.timerGameStart_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.BackColor = System.Drawing.Color.White;
            this.labelTimer.Font = new System.Drawing.Font("Montserrat", 80.24999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(626, 335);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(651, 265);
            this.labelTimer.TabIndex = 3;
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerResult
            // 
            this.timerResult.Interval = 1000;
            this.timerResult.Tick += new System.EventHandler(this.timerResult_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TypeRacer.Properties.Resources.TextInput;
            this.pictureBox2.Location = new System.Drawing.Point(829, 856);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 72);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TypeRacer.Properties.Resources.TextScreen;
            this.pictureBox1.Location = new System.Drawing.Point(212, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1500, 536);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMenu.Image = global::TypeRacer.Properties.Resources.Menu;
            this.buttonMenu.Location = new System.Drawing.Point(79, 43);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(225, 123);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.UserInputBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.displayedText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "GameForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "TypeRacer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputBox;
        private System.Windows.Forms.RichTextBox displayedText;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Timer timerGameStart;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timerResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}