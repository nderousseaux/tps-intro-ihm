using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trombino
{
    public partial class frmTrombino : Form
    {
        public frmTrombino()
        {
            InitializeComponent();
        }

        string[][] tabEtud =
        {
            new string[] { "DUT Info G1","Berger", "Diebold", "Gerard", "Munier", "Niefer", "Salmon" },
            new string[] {"DUT Info G2", "Baumann", "Charlier", "Freund", "Huber", "Klein", "Laluet", "Thuillier", "Tourneur","Walter", "Wendling", "Wurth", "Zorn"},
            new string[] {"LP CDED G1",  "Aufrere", "Billod", "Duval", "Eckert", "Fahrner" },
        };


        private void frmTrombino_Load(object sender, EventArgs e)
        {
            //On initialise la comboBox
            for(int i=0; i<tabEtud.GetLength(0); i++)
            {
                cboChoixPromo.Items.Add(tabEtud[i][0]);
            }
            rdoListe.Checked = false;
            rdoTrombino.Checked = false;
            btnCocher.Visible = false;
            btnRecherche.Visible = false;

        }
        
        private void cboChoixPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpEtudiant.Text = "Etudiant inscrit en " + cboChoixPromo.Text;
            if(rdoTrombino.Checked == true)
            {
                rdoTrombino_Click(sender, e);
            }
            if (rdoListe.Checked == true)
            {
                rdoListe_Click(sender, e);
            }
        }
       

        //Bouton trombino
        private void rdoTrombino_Click(object sender, EventArgs e)
        {
            
            

            if ((rdoTrombino.Checked == true) && (cboChoixPromo.SelectedIndex >= 0))
                {
                    btnCocher.Visible = true;
                    btnRecherche.Visible = true;
                    grpEtudiant.Controls.Clear();
                    //On parcourt la liste des étudiants
                    int left = 20;
                    int top = 130;
                    for (int col = 1; col < tabEtud[cboChoixPromo.SelectedIndex].Length; col++)
                    {
                        //On crée une checkbox
                        CheckBox c = new CheckBox();
                        c.AutoSize = true;
                        c.Left = left;
                        c.Top = top;
                        c.Text = tabEtud[cboChoixPromo.SelectedIndex][col];
                        grpEtudiant.Controls.Add(c);

                        
                        //On crée un picture box
                        PictureBox pic = new PictureBox();
                        pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        pic.Left = left;
                        pic.Top = top - 105;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Image = Properties.Resources.drag_petit;
                        pic.Size = new System.Drawing.Size(100, 100);
                        pic.Cursor = System.Windows.Forms.Cursors.Hand;
                        grpEtudiant.Controls.Add(pic);

                        left += 150;
                        if (left == 770)
                        {
                            top += 130;
                            left = 20;
                        }
                    }
                }
            
            
        }

        CheckedListBox l = new CheckedListBox();

        //Bouton radio
        private void rdoListe_Click(object sender, EventArgs e)
        {
            
            if ((rdoListe.Checked == true) && (cboChoixPromo.SelectedIndex >= 0))
            {
                btnRecherche.Visible = true;
                btnCocher.Visible = true;
                grpEtudiant.Controls.Clear();
                l.FormattingEnabled = true;
                l.Location = new System.Drawing.Point(6, 19);
                l.Size = new System.Drawing.Size(761, 394);
                l.CheckOnClick = true;
                grpEtudiant.Controls.Add(l);

                l.Items.Clear();

                for(int i=1; i<tabEtud[cboChoixPromo.SelectedIndex].Length; i++)
                {
                    l.Items.Add(tabEtud[cboChoixPromo.SelectedIndex][i]);
                }
                
            }
        }


        private void btnRecherche_Click(object sender, EventArgs e)
        {
            {
                String sql = "SELECT * FROM etudiant WHERE UPPER(name) IN (";

                //Si c'est le trombino
                if (rdoTrombino.Checked == true)
                {
                    int nbCoche = 0;
                    foreach (Control check in grpEtudiant.Controls)
                    {
                        if (check is CheckBox)
                        {
                            if(((CheckBox)check).Checked)
                            {
                                nbCoche += 1;
                                sql = sql + "\"" + check.Text.ToUpper() + "\",";
                            }
                            
                        }
                        
                    }
                    sql = sql.Substring(0, sql.Length - 1);
                    sql = sql + ");";

                    if (nbCoche != 0)
                    {
                        MessageBox.Show(sql);
                    }
                }
                //Si c'est une liste
                if ((rdoListe.Checked == true) && (cboChoixPromo.SelectedIndex >= 0))
                {
                    foreach (String nom in l.CheckedItems)
                    {
                        sql = sql + "\"" + nom.ToUpper() + "\"," ;
                    }
                    sql = sql.Substring(0, sql.Length - 1);
                    sql = sql + ");";
                    MessageBox.Show(sql);
                }
                
            }
            
        }

        private void btnCocher_Click(object sender, EventArgs e)
        {

            //Si c'est un trombino
            if ((rdoTrombino.Checked)&&(cboChoixPromo.SelectedIndex >= 0))
            {
                
                foreach (Control check in grpEtudiant.Controls)
                {
                    if (check is CheckBox)
                    {
                        if (btnCocher.Text == "Tout cocher")
                        {
                            ((CheckBox)check).Checked = true;

                        }
                        else
                        {
                            ((CheckBox)check).Checked = false;

                        }

                    }

                }
                

            }

            //Si c'est une list box
            else if ((rdoListe.Checked) && (cboChoixPromo.SelectedIndex >= 0))
            {
                
                foreach (CheckedListBox lst in grpEtudiant.Controls)
                {
                    bool cocher;
                    if (btnCocher.Text == "Tout cocher")
                    {
                        cocher = true;
                    }
                    else
                    {
                        cocher = false;
                    }

                    for (int i = 0; i < lst.Items.Count; i++)
                    {
                        lst.SetItemChecked(i, cocher);
                    }
                    
                }
            }


            //On change le bouton
            if (btnCocher.Text == "Tout cocher")
            {
                btnCocher.Text = "Tout décocher";

            }
            else
            {
                btnCocher.Text = "Tout cocher";

            }
        }
    }
}
