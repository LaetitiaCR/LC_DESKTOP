using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private string patternNum = "^[0-9]";
       
     
        //private char[] characters;
        private List<char> lstChars;

        private bool estNum;
        private bool estAlpha;
        private bool estDate;
        private bool estCaraNum;

        private bool erreurSaisie;
      
        private double varDble;

        private bool boolRegexAlpha;
        private bool boolRegexDate;
        private Boolean boolRegexNum;

        public Form1()
        {
            InitializeComponent();
            initialiserVariable();
        }

        private void initialiserVariable()
        {
            estNum = true;
            estAlpha = true;
            estDate = true;
            estCaraNum = true;

            erreurSaisie = false;
        
            boolRegexAlpha = false;
            boolRegexDate = false;
            boolRegexNum = false;

        }



        private void butValider_Click(object sender, EventArgs e)
        {


            if (validationSaisieZoneTexte() == true) {
                MessageBox.Show("Les données du fromulaire ne sont pas valides"); 

            }
            else
            {
                MessageBox.Show("'" + txtNom.Text + " " + txtDate.Text + " " + txtMont.Text + " " + txtCP.Text + "'", "Validation efféctuée");                
            }
            initialiserVariable();



            var repMsgBox = MessageBox.Show("Fin de l'application", "FIN",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (repMsgBox == DialogResult.Yes) { 
                    Application.Exit();
            }

        }



        private bool validationSaisieZoneTexte()
        {
            if (txtNom.Text != "")
            {
                boolRegexNum = Regex.IsMatch(txtNom.Text, patternNum);
                

                if (boolRegexNum == true)
                {
                    MessageBox.Show("Des caractères numériques se trouvent la chaîne Nom");
                   // estNombre = true;
                    estAlpha = false;


                }


            }




            if (txtDate.Text != "")
            {
                boolRegexDate = Regex.IsMatch(txtDate.Text, patternAlpha);

                if (boolRegexDate == true)
                {
                    MessageBox.Show("Ce n'est pas une date au format 01/12/2000");
                    estDate = false;


                }
                else { 
                   
                    DateTime dateEntrer = new DateTime();
                    dateEntrer = DateTime.Parse(txtDate.Text);
                    if (dateEntrer > DateTime.Now) {
                        MessageBox.Show("Ce n'est pas une date valide, la date doit être antérieure à la date du jour");
                    }
                }


            }


            if (txtMont.Text != "") {

                boolRegexAlpha = Regex.IsMatch(txtMont.Text, patternAlpha);
               

                if (boolRegexAlpha == true)
                {
                    MessageBox.Show("Des caractères Alpha (sauf . le séparateur de la chaine numérique) sont dans la chaîne montant");
                    estNum= false;
                }
                else {
                    varDble = Convert.ToDouble(txtMont.Text, new CultureInfo("fr-FR"));
                    if (varDble < 0) {
                        MessageBox.Show("Le montant ne peut être négatif");
                    }
                }
                
            }





            if (txtCP.Text != "") {

                lstChars = new List<char>(txtCP.Text.ToCharArray());

                int i = 0;
                foreach (char lstChar in lstChars)
                {

                    if (Char.IsDigit(lstChar) == false)
                    {
                        estCaraNum = false; //des nombres sont dan la chaine characters[], txtCP code postale
                    }





                    i++;
                }


            
                lstChars.RemoveAt(i-1);


                if (estCaraNum == false)
                {
                    MessageBox.Show("Le code postale n'est pas 5 chiffres");
                }





                //characters = txtCP.Text.ToCharArray();

                //foreach (char character in characters)
                //{
                //    if (Char.IsDigit(character) == false)
                //    {
                //        estNum = false; //des nombres sont dan la chaine characters[], txtCP code postale
                //    }

                //    Array.Clear(characters, 0, character);

                //}

                //if (estNum == false) {
                //    MessageBox.Show("Le code postale n'est pas 5 chiffres");
                //}


            }






          


            if ((estNum == false) || (estAlpha == false) || (estDate == false) || (estCaraNum == false))
            {
                erreurSaisie = true;
            }
            else {
                erreurSaisie = false;
            }

            return erreurSaisie;


        }







        private void butEff_Click(object sender, EventArgs e)
        {
            initialiserControleText();
        }


        private void initialiserControleText() {
            txtNom.Text = "";
            txtDate.Text = "";
            txtMont.Text = "";
            txtCP.Text = "";
        }

        
    }
}
