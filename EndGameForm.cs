using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeRacer
{
    public partial class EndGameForm : Form
    {
        private GameForm gameFormReference;
        public EndGameForm(GameForm gameForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gameFormReference = gameForm;
            this.richTextResults.Rtf = @"{\rtf1\ansi\deff0" + @"{\colortbl;\red0\green255\blue0;}" + @"\ulnone " + $@"\cf1Congratulations! You've completed the sentence." + @"\par" + $@"\cf0Your time: {this.gameFormReference.ResultTime} seconds" + @"\par" + $@"\cf0WPM: {this.gameFormReference.CalculateResults()}" + @"}";
        }

        private void EndGameForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.gameFormReference.ClosingButton = false;
            this.gameFormReference.Close();
            this.Close();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            this.Close();
            this.gameFormReference.ClosingButton = true;
            this.gameFormReference.ResetGame();
        }
    }
}
