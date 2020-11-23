using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppValidation
{
    public partial class Form1 : Form
    {
        private string patternAlpha = "^[a-zA-Z]";
        // private string patternNum = "^[0-9]*$";
        private string patternDate = '"' + @"^[0-9]+\/[0-9]+\/[0-9]+$" + '"';
        //private string varTxt;
        // private char cara;
        private char[] characters;
        private bool estNombre;
        private bool estAlpha;
        private bool estDate;
        private bool lenghtChaine;
        private bool erreurSaisie = false;


        //private string caractereNumErreur="";
        private bool boolRegexAlpha;
        private bool boolRegexDate;
        //private Boolean boolRegexNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void butValider_Click(object sender, EventArgs e)
        {
            if (validationSaisieZoneTexte() == true) {
                MessageBox.Show("Les données du fromulaire ne sont pas valides"); 
            }
            else
            {
                MessageBox.Show("'" + txtNom.Text + " " + txtDate.Text + " " + txtMont.Text + " " + txtCP.Text + "'", "validation effectuée");
            }
                
        }



        private bool validationSaisieZoneTexte()
        {
            if (txtNom.Text != "")
            {
                boolRegexAlpha = Regex.IsMatch(txtNom.Text, patternAlpha);

                if (boolRegexAlpha == false)
                {
                    MessageBox.Show("Des caractères autres que alpha sont dans la chaîne");
                    estNombre = true;
                }


            }

            

            if (txtCP.Text != "") {

                if (txtCP.Text.Length == 4)
                {


                    characters = txtCP.Text.ToCharArray();

                    foreach (char character in characters)
                    {
                        if (Char.IsDigit(character) == false)
                        {
                            estAlpha = true; //des nombres sont dan la chaine characters[], txtCP code postale
                        }


                    }

                }
                else {
                    lenghtChaine = false;
                }


            }




            if (txtDate.Text != "")
            {
                boolRegexDate = Regex.IsMatch(txtDate.Text, patternDate);

                if (boolRegexDate == false)
                {
                    MessageBox.Show("Ce n'est pas une date");
                    estDate = false;   
                }


            }



            if ((estNombre == true) || (estAlpha == true) || (estDate == false) || (lenghtChaine == false))
            {
                erreurSaisie = true;
            }
            else {
                erreurSaisie = false;
            }

            return erreurSaisie;


        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
