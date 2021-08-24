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
    public partial class frmAjouterVerbe : Form
    {
        public frmAjouterVerbe()
        {
            
            InitializeComponent();
        }

        //******************************************************************************************************
        //Boutton
        //******************************************************************************************************

        //Lors du click sur le bouton valider, on ajoute le verbe à la liste)
        private void btnAjout_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
            
        }


        //Envoi du verbe au formulaire père:
        public string verbe
        {
            get { return txtVerbe.Text; }
            set { txtVerbe.Text = verbe; }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            txtVerbe.Text = String.Empty;
            
        }
    }
}
