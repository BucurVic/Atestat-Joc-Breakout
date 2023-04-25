using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        int ok = 0;

        Random rnd = new Random();

        PictureBox[] vectorblocuri;

        public Form1()
        {
            InitializeComponent();
            adaugareblocuri();
        }

        private void configurarejoc ()
        {
            bilax = 5;
            bilay = 5;
            vitezajucator = 12;
            sfarsitjoc = false;
            bila.Left = 568;
            bila.Top = 348;
            jucator.Left = 527;

            foreach (Control x in this.Controls)
                if ((string)x.Tag == "blocuri")
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        
        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScor.Text = "Scor : " + scor + "  P - Pauza";
            if (lastanga == true && jucator.Left > 0)
                jucator.Left -= vitezajucator;
            if (ladreapta == true && jucator.Left < 1074)
                jucator.Left += vitezajucator;

            bila.Left += bilax;
            bila.Top += bilay;

            if (bila.Left < 0 || bila.Left > 1175)
                bilax *= -1;
            if (bila.Top < 0)
                bilay *= -1;
            if (bila.Bounds.IntersectsWith(jucator.Bounds))
            {
                bila.Top = 619;
                bilay = rnd.Next(7, 12) * -1;
                if (bilax < 0)
                    bilax = rnd.Next(7, 12) * -1;
                else bilax = rnd.Next(7, 12);
            }
            foreach (Control x in this.Controls)
                if ((string)x.Tag == "blocuri")
                    if (bila.Bounds.IntersectsWith(x.Bounds))
                    {
                        scor++;
                        bilay = -bilay;
                        this.Controls.Remove(x);
                    }
            if (bila.Top > 743)
            {
                terminarejoc("Ai pierdut!   Enter - Din Nou    Escape - Iesire");
                txtScor.ForeColor = Color.Red;
                scor = 0;
                ok = 0;
            }
            if (scor == 15 && ok == 0)
            {
                terminarejoc("Ai castigat!   Enter - Tura Noua    Escape - Iesire");
                txtScor.ForeColor = Color.LimeGreen;
                ok = 1;
            }
            if (scor == 30)
            {
                terminarejoc("Bravo, ai terminat jocul!   Escape - Iesire");
                txtScor.ForeColor = Color.LimeGreen;
            }
        }
        private void adaugareblocuri ()
        {
            vectorblocuri = new PictureBox[15]; 
            int contor = 0;
            int sus = 120;
            int stanga = 230;

            for (int i = 0; i < vectorblocuri.Length; i++)
            {
                vectorblocuri[i] = new PictureBox();
                vectorblocuri[i].Height = 30;
                vectorblocuri[i].Width = 100;
                vectorblocuri[i].Tag = "blocuri";
                if (contor < 5)
                {
                    contor++;
                    vectorblocuri[i].Left = stanga;
                    vectorblocuri[i].Top = sus;
                    this.Controls.Add(vectorblocuri[i]);
                    stanga += 160;
                }
                if (contor == 5)
                {
                    contor = 0;
                    sus += 80;
                    stanga = 230;
                }
            }
            configurarejoc();
        }
        private void eliminareblocuri()
        {
            foreach (PictureBox x in vectorblocuri)
                this.Controls.Remove(x);
            txtScor.ForeColor = Color.White;
            adaugareblocuri();
        }
        private void terminarejoc (string msg)
        {
            sfarsitjoc = true;
            timerjoc.Stop();
            txtScor.Text = msg;
        }
        private void TastaJos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                lastanga = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                ladreapta = true;
        }

        private void TastaSus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                lastanga = false;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                ladreapta = false;
            if (e.KeyCode == Keys.Enter && sfarsitjoc == true)
                eliminareblocuri();
            if (e.KeyCode == Keys.Enter)
            {
                timerjoc.Start();
                txtScor.ForeColor = Color.White; 
            }
            if (e.KeyCode == Keys.P)
            {
                timerjoc.Stop();
                txtScor.ForeColor = Color.Orange;
                txtScor.Text = "Scor : " + scor + "  Enter - Continua";
            }
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
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
