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
using System.Text.RegularExpressions;

namespace TypeRacer
{
    public partial class GameForm : Form
    {
        private Form1 form1Reference;
        private string[] words;
        private string[] correctWords = new string[0];
        private int currentWordIndex = 0;
        private int countdownSeconds = 4;
        private int resultTime = 0;
        private bool closingButton = true;
       
        public GameForm(Form1 form1)
        {
            InitializeComponent();
            this.form1Reference = form1;
            this.words = GetWords().Item1;
            displayedText.Text = GetWords().Item2;
        }   

        private void GameForm_Load(object sender, EventArgs e)
        {   
            UserInputBox.Enabled = false;
            timerGameStart.Start();
        }
        
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.closingButton)
            {
                Application.Exit();
            }
        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form1Reference.Show();
        }

        private (string[],string) GetWords()
        {
            string path = "sentences.txt";
            string[] text = File.ReadAllLines(path);
            var r = new Random();
            var randomLineIndex = r.Next(0, text.Length - 1);
            string[] words = Regex.Split(text[randomLineIndex], @"(?<= )");
            return (words, text[randomLineIndex]);
        }

        private int CalculateResults()
        {
            float WPM = (((float)this.words.Length)/this.resultTime)*60;
            return (int)WPM;
        }

        private void UserInputBox_TextChanged(object sender, EventArgs e)
        {
            
            string userInput = UserInputBox.Text;
            if (this.currentWordIndex < this.words.Length && userInput == this.words[this.currentWordIndex]){
                UserInputBox.Clear();   
                this.correctWords = this.correctWords.Append(words[currentWordIndex]).ToArray();
                if (this.currentWordIndex == this.words.Length-1)
                {
                    string rtfText = @"{\rtf1\ansi\deff0" + @"{\colortbl;\red0\green255\blue0;}" + @"\ulnone " + $@"\cf1{string.Join("", this.correctWords)}" + @"}";
                    displayedText.Rtf = rtfText;
                }
                else
                {
                    string rtfText = @"{\rtf1\ansi\deff0" + @"{\colortbl;\red0\green255\blue0;}" + @"\ulnone " + $@"\cf1{string.Join("", this.correctWords)}" + @"\ul" + $@" \cf0{this.words[this.currentWordIndex + 1]}" + @"\ulnone" + $@"\cf0{string.Join("", this.words.Skip(this.currentWordIndex + 2))}" + @"}";
                    displayedText.Rtf = rtfText;
                }

                this.currentWordIndex++;  
                if (this.currentWordIndex == this.words.Length)
                {
                    timerResult.Stop();
                    MessageBox.Show($"Congratulations! You've completed the sentence.\nYour time: {this.resultTime}\nWPM: {CalculateResults()}");
                    this.resultTime = 0;
                    this.currentWordIndex = 0;
                    this.correctWords = new string[0];
                    this.words = GetWords().Item1;
                    displayedText.Text = GetWords().Item2;
                    timerGameStart.Start();
                }
            }
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.closingButton = false;
            DialogResult choice = MessageBox.Show("When you leave you can't comeback to your current game again.\nDo you want to leave?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                this.Close();
                this.form1Reference.Show();
            }


        }

        private void timerGameStart_Tick(object sender, EventArgs e)
        {
            this.countdownSeconds--;
            if(this.countdownSeconds <= 0)
            {
                timerGameStart.Stop();
                labelTimer.Text = "START!";
                string rtfText = @"{\rtf1\ansi\deff0" + @"{\colortbl;\red0\green255\blue0;}" + @"\ul" + $@"\cf0{words[0]}" + @"\ulnone " + $@"\cf0{string.Join("", words.Skip(1))}" + @"}";
                displayedText.Rtf = rtfText;
                UserInputBox.Enabled = true;
                UserInputBox.Focus();
                timerResult.Start();
                
            }
            else
            {
                labelTimer.Text = countdownSeconds.ToString();
            }
        }

        private void timerResult_Tick(object sender, EventArgs e)
        {
            this.resultTime++;
        }
    }
}   
