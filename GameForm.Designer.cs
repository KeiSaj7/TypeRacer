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
            this.UserInputBox = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserInputBox
            // 
            this.UserInputBox.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserInputBox.Location = new System.Drawing.Point(465, 444);
            this.UserInputBox.MaximumSize = new System.Drawing.Size(150, 25);
            this.UserInputBox.MaxLength = 45;
            this.UserInputBox.MinimumSize = new System.Drawing.Size(150, 25);
            this.UserInputBox.Name = "UserInputBox";
            this.UserInputBox.Size = new System.Drawing.Size(150, 23);
            this.UserInputBox.TabIndex = 0;
            this.UserInputBox.TextChanged += new System.EventHandler(this.UserInputBox_TextChanged);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelText.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelText.Location = new System.Drawing.Point(90, 200);
            this.labelText.MaximumSize = new System.Drawing.Size(900, 200);
            this.labelText.MinimumSize = new System.Drawing.Size(900, 50);
            this.labelText.Name = "labelText";
            this.labelText.Padding = new System.Windows.Forms.Padding(10);
            this.labelText.Size = new System.Drawing.Size(900, 50);
            this.labelText.TabIndex = 1;
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelText.Paint += new System.Windows.Forms.PaintEventHandler(this.labelText_Paint);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TypeRacer.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1081, 771);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.UserInputBox);
            this.Name = "GameForm";
            this.Text = "TypeRacer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputBox;
        private System.Windows.Forms.Label labelText;
    }
}