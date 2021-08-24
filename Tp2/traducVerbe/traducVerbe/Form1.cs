using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traducVerbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //******************************************************************************************************
        //Fonctions et constantes
        //******************************************************************************************************

        string[,] tabVerbes =
        {
            {"aller", "to go", "gehen", "ir", "andare" },
            { "boire", "to drink", "trinken", "beber", "bere" },
            { "chanter", "to sing", "singen", "cantar", "cantare" },
            { "danser", "to dance", "tanzen", "bailar", "ballare" },
            { "fermer", "to close", "schliessen", "cerrar", "chiudere" },
            { "manger", "to eat", "essen", "comer", "mangiare" },
            { "travailler", "to work", "arbeiten", "trabajar", "lavorare" }
        };

        //Fonction qui traduit le verbe séléctionné dans la langue séléctionnée et qui l'affiche dans le lblResultat
        private void traduction(object sender, EventArgs e)
        {
            //Seulement si le verbe est séléctionné et si un bouton est sélectionné
            if ((cmbVerbe.SelectedIndex >= 0) && ((rdoAllemand.Checked == true)||(rdoAnglais.Checked == true) ||(rdoEspagnol.Checked == true) ||(rdoItalien.Checked == true)))
            {

                string langue = "";
                int index;

                
                //Si la langue à traduire est l'anglais
                if (rdoAnglais.Checked == true)
                {
                    langue = "Anglais";
                    index = 1;
                }
                //Si la langue à traduire est l'allemand
                else if (rdoAllemand.Checked == true)
                {
                    langue = "Allemand";
                    index = 2;
                }
                //Si la langue à traduire est l'espagnol
                else if (rdoEspagnol.Checked == true)
                {
                    langue = "Espagnol";
                    index = 3;
                }
                //Si la langue à traduire est l'italien
                else
                {
                    langue = "Italien";
                    index = 4;
                }

                lblResultat.Text = "Traduction de " + cmbVerbe.SelectedItem + " en " + langue + " : " + tabVerbes[cmbVerbe.SelectedIndex, index];
            }

        }


        //******************************************************************************************************
        //Formulaire
        //******************************************************************************************************

        //On incrémente la liste lors du chargment du formulaire
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i< tabVerbes.GetLength(0); i++)
            {
                cmbVerbe.Items.Add(tabVerbes[i, 0]);
            }
        }


        //On crée le second formulaire
        frmAjouterVerbe frm2 = new frmAjouterVerbe();

        //******************************************************************************************************
        //Boutton
        //******************************************************************************************************

        //On fait apparaitre le deuxième formulaire de la pression sur le boutton
        private void btnAjout_Click(object sender, EventArgs e)
        {
            if(frm2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(frm2.verbe);
            }
        }
        
           
    }
}
