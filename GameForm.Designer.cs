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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.timerGameStart = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.timerResult = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UserInputBox
            // 
            this.UserInputBox.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserInputBox.Location = new System.Drawing.Point(464, 478);
            this.UserInputBox.MaximumSize = new System.Drawing.Size(150, 25);
            this.UserInputBox.MaxLength = 45;
            this.UserInputBox.MinimumSize = new System.Drawing.Size(150, 25);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.Size = new System.Drawing.Size(150, 25);
            this.UserInputBox.TabIndex = 0;
            this.UserInputBox.TextChanged += new System.EventHandler(this.UserInputBox_TextChanged);
            // 
            // displayedText
            // 
            this.displayedText.Cursor = System.Windows.Forms.Cursors.Default;
            this.displayedText.Enabled = false;
            this.displayedText.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayedText.ForeColor = System.Drawing.Color.Black;
            this.displayedText.Location = new System.Drawing.Point(68, 140);
            this.displayedText.Name = "displayedText";
            this.displayedText.ReadOnly = true;
            this.displayedText.Size = new System.Drawing.Size(955, 298);
            this.displayedText.TabIndex = 1;
            this.displayedText.Text = "";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(35, 28);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(151, 51);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // timerGameStart
            // 
            this.timerGameStart.Interval = 1000;
            this.timerGameStart.Tick += new System.EventHandler(this.timerGameStart_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Wide Latin", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(429, 28);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(238, 78);
            this.labelTimer.TabIndex = 3;
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerResult
            // 
            this.timerResult.Interval = 1000;
            this.timerResult.Tick += new System.EventHandler(this.timerResult_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TypeRacer.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1081, 771);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.displayedText);
            this.Controls.Add(this.UserInputBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "GameForm";
            this.Text = "TypeRacer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
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
    }
}