using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionUtilisateur
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }

        //Tableau
        String[] promotions = new string[] { "1ère année", "2ème année", "3ème année (License pro)" };


        //******************************************************************************************************************
        //Zone de texte "txtNom"
        //******************************************************************************************************************

        //Chargement du formulaire
        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            cboPromotion.Items.AddRange(promotions);
        }
        

        //******************************************************************************************************************
        //Zone de texte "txtNom"
        //******************************************************************************************************************

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e) // Touche pressé zone de texte nom
        {

            // Par défaut on interdit toute les touches
            e.Handled = true;

            //Sauf les lettres, entrée et backspace
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = false;

                //Si on presse la touche entrée, on passe a la zone du dessous
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtPrenom.Focus();
                }
            }



            // On actualise txtLogin
            remplissageLogin();
        }

        //Lorsque le texte est modifié
        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            //On actualise le login
            remplissageLogin();
        }

        //******************************************************************************************************************
        //Zone de texte "txtPrenom"
        //******************************************************************************************************************

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e) // Touche pressé zone de texte prénom
        {
            // Par défaut on interdit toutes les touches
            e.Handled = true;

            //Sauf les lettres, entrée et backspace
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = false;

                //Si on presse la touche entrée on passe a la zone du dessous
                if (e.KeyChar == (char)Keys.Enter)
                {
                    cboPromotion.Focus();
                }
            }

        }

        //Lorsque le texte est modifié
        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            //On modifie le login
            remplissageLogin();
        }

        //******************************************************************************************************************
        //ComboBox "cboPromotion"
        //******************************************************************************************************************

        // Fonction de remplissage de la case pseudo (année + deux premières lettres du prénom + quatre premières lettres du nom)
        private void remplissageLogin()
        {
            if ((txtPrenom.Text.Length >= 2) && (txtNom.Text.Length >= 4))
            {
                txtLogin.Text = (cboPromotion.SelectedIndex + 1).ToString() + txtPrenom.Text[0] + txtPrenom.Text[1] + txtNom.Text[0] + txtNom.Text[1] + txtNom.Text[2] + txtNom.Text[3];
            }

            else
            {
                txtLogin.Text = String.Empty;                   
            }
            
        }

        //Lorsqu'un item est choisi
        private void cboPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On lance la fonction de remplissage du champ pseudo
            remplissageLogin();
        }

        //Lorsque l'on appuie sur une touche comboBox
        private void cboPromotion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si la touche pressée est "entrer", on passe à la zone suivante
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtMdp.Focus();
            }
        }

        //******************************************************************************************************************
        //Boutton "btnAnnuler"
        //******************************************************************************************************************

        //Le bouton est pressé
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //On vide toutes les zones de texte
            txtNom.Text = String.Empty;
            txtPrenom.Text = String.Empty;
            txtMdp.Text = String.Empty;
            txtLogin.Text = String.Empty;
            cboPromotion.SelectedIndex = 0;
        }

    }
}
