using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TypeRacer
{
    public partial class GameForm : Form
    {
        private Form1 form1Reference;
        private string[] correctWords;
        private string displayedText;
        private int currentWordIndex = 0;
        public GameForm(Form1 form1)
        {
            InitializeComponent();
            this.form1Reference = form1;
            this.correctWords = GetCorrectWords().Item1;
            this.displayedText = GetCorrectWords().Item2;
            labelText.Text = displayedText;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private static (string[],string) GetCorrectWords()
        {
            string path = "sentences.txt";
            string[] text = File.ReadAllLines(path);
            var r = new Random();
            var randomLineIndex = r.Next(0, text.Length - 1);
            string[] correctWords = text[randomLineIndex].Split(' ');
            return (correctWords, text[randomLineIndex]);
        }
        private void labelText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserInputBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = UserInputBox.Text.Trim();
            if(currentWordIndex < correctWords.Length && userInput == correctWords[currentWordIndex])
            {
                UserInputBox.Clear();
                currentWordIndex++;
                if(currentWordIndex == correctWords.Length)
                {
                    MessageBox.Show("Congratulations! You've completed the sentence.");
                    currentWordIndex = 0;
                    displayedText = GetCorrectWords().Item2;
                    labelText.Text = displayedText;
                }
            }

        }
    }
}
