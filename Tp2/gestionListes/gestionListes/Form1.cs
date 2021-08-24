using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionListes
{
    public partial class frmGestionListes : Form
    {
        public frmGestionListes()
        {
            InitializeComponent();
        }

        //*****************************************************************************************
        //Formulaire
        //*****************************************************************************************

        //Chargement du formulaire
        private void frmGestionListes_Load(object sender, EventArgs e)
        {
            lstGauche.Items.Add("Nom");
            lstGauche.Items.Add("Prénom");
            lstGauche.Items.Add("Adresse");
        }


        //*****************************************************************************************
        //Boutons
        //*****************************************************************************************

       //Clic sur le bouton "Tout les items à gauche sont envoyés à droite"
        private void btnToutGD_Click(object sender, EventArgs e)
        {
            //On envoie tout les éléments de la liste de gauche sur la liste de droite
            //lstDroite.Items.AddRange(lstGauche.Items);
            //lstGauche.Items.Clear();

            for(int i = 0; i<lstGauche.Items.Count; i++)
            {
                lstDroite.Items.Add(lstGauche.Items[i]);
            }
            lstGauche.Items.Clear();
        }

        //Clic sur le bouton "Les items sélectionnés à gauche sont envoyés à droite"
        private void btnGD_Click(object sender, EventArgs e)
        {

            
            //On envoie tout les éléments sélectionnés vers la droite
            for (int i = 0; i < lstGauche.SelectedItems.Count; i++)
            {
                lstDroite.Items.Add(lstGauche.SelectedItems[i]);
            }

            //On supprime à gauche les éléments sélectionnées
            for (int i = lstGauche.SelectedItems.Count-1; i >= 0; i--)
            {
                lstGauche.Items.Remove(lstGauche.SelectedItems[i]);
            }
            
        }

        //Clic sur le bouton "Ajouter un nouvel item"
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            //On affiche la zone de texte
            txtNouveau.Visible = !txtNouveau.Visible;
            lblNouveau.Visible = !lblNouveau.Visible;

            //On met le focus sur la zone de texte
            txtNouveau.Focus();
        }


        //*****************************************************************************************
        //Zones de texte
        //*****************************************************************************************

        //Touche pressée dans la zone de texte "Nouvel Item"
        private void txtNouveau_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si la touche tapée est entrée
            if(e.KeyChar == (char)Keys.Enter)
            {
                
                bool existe = false; //Le mot n'est pas dans la liste...jusqu'à preuve du contraire !

                //On parcourt la liste : si il existe un doublon, on renvoie un message d'erreur, sinon, on intégre l'item dans la liste
                foreach (string mot in lstGauche.Items)
                {
                    //Il existe un doublon, on affiche un message d'erreur et on quite la boucle
                    if(mot.ToUpper() == txtNouveau.Text.ToUpper().Trim())
                    {
                        existe = true;
                        break;
                    }
                }

                //Même chose pour la liste droite
                foreach (string mot in lstDroite.Items)
                {
                    //Il existe un doublon, on affiche un message d'erreur et on quite la boucle
                    if (mot.ToUpper() == txtNouveau.Text.ToUpper().Trim())
                    {
                        existe = true;
                        break;
                    }
                }

                //Si le mot n'existe pas déjà, on l'ajoute à la liste
                if (existe == false)
                {
                    lstGauche.Items.Add(txtNouveau.Text);
                    errorProvider1.SetError(txtNouveau, "");
                }
                //Sinon on génére un message d'erreur
                else
                {
                    errorProvider1.SetError(txtNouveau, "L'élément est déjà présent dans la liste !");
                }

            }
        }
    }
}
