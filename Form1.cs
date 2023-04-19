using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtestatBreakoutio
{
    public partial class Form1 : Form
    {
        bool lastanga;
        bool ladreapta;
        bool sfarsitjoc;

        int scor;
        int bilax;
        int bilay;
        int vitezajucator;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            configurarejoc();
        }

        private void configurarejoc ()
        {
            scor = 0;
            bilax = 5;
            bilay = 5;
            vitezajucator = 12;
            txtScor.Text = "Scor: " + scor;

            timerjoc.Start();

            foreach (Control x in this.Controls)
                if ((string)x.Tag == "blocuri")
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        
        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            if (lastanga == true && jucator.Left > 0)
                jucator.Left -= vitezajucator;
            if (ladreapta == true && jucator.Left < 1074)
                jucator.Left += vitezajucator;

            bila.Left += bilax;
            bila.Top += bilay;

            if (bila.Left < 0 || bila.Left > 1175)
                bilax = -bilax;
        }

        private void TastaJos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                lastanga = true;
            if (e.KeyCode == Keys.Right)
                ladreapta = true;
        }

        private void TastaSus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                lastanga = false;
            if (e.KeyCode == Keys.Right)
                ladreapta = false;
        }












        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtScor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

    }
}
