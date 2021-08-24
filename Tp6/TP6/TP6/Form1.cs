using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection();
        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Etudes\Superieur\A-Interfaces\A21 - Introduction aux interfaces homme-machine\TDs-TPs\Tp5 - Ado.net\COMPTOIR.MDB";
        private void Form1_Load(object sender, EventArgs e)
        {
            //Treeview
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"SELECT [Catégories].[Nom de catégorie], [Produits].[Nom du produit]
                                   FROM [Catégories], [Produits]
                                   WHERE [Catégories].[Code catégorie] = [Produits].[Code catégorie]
                                    ORDER BY [Catégories].[Nom de catégorie], [Produits].[Nom du produit]";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                OleDbDataReader reader = cd.ExecuteReader();
                if (reader.HasRows)
                {
                    String precedent = "";
                    int nbCate = -1;
                    int nbEnfant = 0;
                    while (reader.Read())
                    {
                        string categorie = reader.GetString(0);
                        
                        if (precedent != categorie)
                        {
                            trvCate.Nodes.Add(categorie);
                            nbCate++;
                            nbEnfant = 0;
                            
                        }
                        trvCate.Nodes[nbCate].ImageIndex = 0;
                        trvCate.Nodes[nbCate].Nodes.Add(reader.GetString(1));
                        trvCate.Nodes[nbCate].Nodes[nbEnfant].ImageIndex = 1;
                        nbEnfant++;
                        precedent = categorie;
                    }
                }
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur dans la requête SQL !");
            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }

            }


            //DataGridview

            //Création des checkbox
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"SELECT DISTINCT [Catégories].[Nom de catégorie]
                                   FROM [Catégories]";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                OleDbDataReader reader = cd.ExecuteReader();
                if (reader.HasRows)
                {
                    int y = 13;
                    while (reader.Read())
                    {
                        //Pour chaque catégorie, on génére une case à cocher
                        CheckBox cate = new CheckBox();
                        cate.AutoSize = true;
                        cate.Location = new System.Drawing.Point(304, y);
                        cate.Text = reader.GetString(0);
                        y += 20;
                        if(cate.Text != "Toutes catégories")
                        {
                            cate.Click += new System.EventHandler(Affichage_DataGridView);
                        }
                        this.Controls.Add(cate);
                    }
                }
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur dans la requête SQL !");
            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }

            }

            //On ajoute un événement au dernier bouton 
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Text == "Toutes catégories" )
                    {
                        control.Click += new System.EventHandler(ToutCocher);
                    }
                }
            }
        }

        private void ToutCocher(object sender, EventArgs e)
        {
            bool etat = ((CheckBox)sender).Checked;
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = etat;
                }
            }

            Affichage_DataGridView(sender, e);
        }

        DataTable dt = new DataTable();
        DataTable dtVide = new DataTable();
        bool dejaAppele = false;
        private void Affichage_DataGridView(object sender, EventArgs e)
        {
            if (!dejaAppele)
            {
                dgvDonnees.Visible = true;
            }

            //On récupére la liste des catégories cochées
            List<String> lstDesCochees = new List<string>();
            
            foreach(Control control in this.Controls)
            {
                if(control is CheckBox)
                {
                    if ((((CheckBox)control).Checked) && (((CheckBox)control).Text != "Toutes catégories"))
                    {
                        lstDesCochees.Add(control.Text);
                    }
                }
            }
            if (lstDesCochees.Count != 0) {
                //On génére la requête
                string requete = @"SELECT c.[Nom de catégorie], p.[Nom du produit], p.[Prix unitaire] FROM [Produits] p, [Catégories] c
                             WHERE c.[Code catégorie] = p.[Code catégorie] AND (";
                foreach (String cate in lstDesCochees)
                {
                    requete += "UCASE(c.[Nom de catégorie]) = '";
                    requete += cate.ToUpper();
                    requete += "' OR ";
                }
                requete = requete.Substring(0, requete.Length - 4);
                requete += ")";


                try
                {
                    //Ouvrir la connexion
                    connec.ConnectionString = chcon;
                    connec.Open();
                    //DataAdapteur
                    OleDbCommand cd = new OleDbCommand(requete, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter(cd);

                    da.Fill(dt);
                    dgvDonnees.DataSource = dt;
                }

                catch (InvalidOperationException)
                {
                    MessageBox.Show("Erreur de connexion à la base");
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Erreur dans la requête SQL !");
                }

                finally
                {
                    if (connec.State == ConnectionState.Open)
                    {
                        connec.Close();
                    }

                }

            }
            else {
                dgvDonnees.DataSource = dtVide;
            }

            //On cherche le nombre de produits
            MessageBox.Show(dt.Rows.Count.ToString());
                
            
            
        }
    }
}
