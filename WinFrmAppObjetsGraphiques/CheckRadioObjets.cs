using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmAppObjetsGraphiques
{
    public partial class CheckRadioObjets : Form
    {
        private string strTxtBoxEntrerTexte;
        public CheckRadioObjets()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radButRouge1_CheckedChanged(object sender, EventArgs e)
        {
            lblTexteAff.Text = txtBoxEntrerTexte.Text;
            lblTexteAff.BackColor = Color.Red;

        }

        private void radButRouge2_CheckedChanged(object sender, EventArgs e)
        {
            lblTexteAff.Text = txtBoxEntrerTexte.Text;
            lblTexteAff.ForeColor = Color.Red;
        }

        private void radButVert_CheckedChanged(object sender, EventArgs e)
        {
            lblTexteAff.Text = txtBoxEntrerTexte.Text;
            lblTexteAff.BackColor = Color.Green;
        }

        private void radButBleu_CheckedChanged(object sender, EventArgs e)
        {
            lblTexteAff.Text = txtBoxEntrerTexte.Text;
            lblTexteAff.BackColor = Color.Blue;
        }

        private void radButBlanc_CheckedChanged(object sender, EventArgs e)
        {
            lblTexteAff.Text = txtBoxEntrerTexte.Text;
            lblTexteAff.ForeColor = Color.White;
        }

        private void radButNoir_CheckedChanged(object sender, EventArgs e)
        {
            lblTexteAff.Text = txtBoxEntrerTexte.Text;
            lblTexteAff.ForeColor = Color.Black;
        }

        private void radButMaj_CheckedChanged(object sender, EventArgs e)
        {
            strTxtBoxEntrerTexte = txtBoxEntrerTexte.Text;

            lblTexteAff.Text = strTxtBoxEntrerTexte.ToUpper();
        }

        private void CheckRadioObjets_Load(object sender, EventArgs e)
        {

        }

        private void radButMin_CheckedChanged(object sender, EventArgs e)
        {
            strTxtBoxEntrerTexte = txtBoxEntrerTexte.Text;

            lblTexteAff.Text = strTxtBoxEntrerTexte.ToLower();
        }
    }
}
