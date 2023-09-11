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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Image = Properties.Resources.Play;
            await Task.Delay(100);
            GameForm gameForm = new GameForm(this);
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
            this.Hide();
            buttonPlay.Image = Properties.Resources.PlayUnclicked;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KeiSaj7");
        }
    }
}
