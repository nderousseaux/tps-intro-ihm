using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace tp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection();
        string chcon = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = F:\Etudes\Superieur\A-Interfaces\A21 - Introduction aux interfaces homme-machine\TDs-TPs\Tp5 - Ado.net\tp5\tp5\COMPTOIR.MDB";
        private void btnExo1_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = "SELECT COUNT(*) FROM Clients";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                int nbClients = (int)cd.ExecuteScalar();
                MessageBox.Show("Il y a " + nbClients.ToString() + " clients dans la bdd !");
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
                if(connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }
                
            }

        }

        private void btnExo2_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"SELECT COUNT(*) FROM Commandes 
                                WHERE [Code client] = 
                                (SELECT [Code client] FROM Clients
                                WHERE UCASE([Société]) = 'ERNST HANDEL')";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                int nbClients = (int)cd.ExecuteScalar();
                MessageBox.Show("Il y a " + nbClients.ToString() + " commandes de Erns Handel dans la bdd !");
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

        private void btnExo4_Click(object sender, EventArgs e)
        {
            //On définit le groupBox comme étant visible
            grpCate.Visible = !(grpCate.Visible);
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {            
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"SELECT COUNT(*) FROM Produits 
                            WHERE [Code catégorie] = 
                            (SELECT [Code catégorie] FROM [Catégories]
                            WHERE UCASE([Nom de Catégorie]) = '"+ txtCate.Text.ToUpper() +"')";
                //string requete = @"SELECT COUNT(*) FROM Produits";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                int nbClients = (int)cd.ExecuteScalar();
                MessageBox.Show("Il y a " + nbClients.ToString() + " produits de la catégorie " + txtCate.Text + " dans la bdd !");
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

        private void btnExo3_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"SELECT AVG([Prix unitaire]) FROM Produits";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                String prixMoyen = cd.ExecuteScalar().ToString();
                MessageBox.Show("Le prix moyen des produits de la bdd est " + prixMoyen + "€ !");
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

        private void btnExo5_Click(object sender, EventArgs e)
        {
            grpChoix.Visible = !(grpChoix.Visible);

            //On charge les catégories dans la comboBox
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"SELECT [Nom de catégorie] FROM [Catégories]";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                OleDbDataReader dr = cd.ExecuteReader();
                while(dr.Read())
                {
                    cboCate.Items.Add(dr.GetString(0));
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"SELECT COUNT(*) FROM [Produits]
                                WHERE [Code catégorie] = 
                                    (SELECT [Code catégorie] FROM [Catégories]
                                    WHERE UCASE([Nom de catégorie]) = '" + cboCate.SelectedItem.ToString().ToUpper() + "')";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                String nbDeProduit = cd.ExecuteScalar().ToString();
                MessageBox.Show("Il y a " + nbDeProduit + " produits dans la catégorie " + cboCate.SelectedItem.ToString() + " !");
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

        private void btnExo6_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"UPDATE [Produits] SET [Prix unitaire] = [Prix unitaire] * 1.1
                                    WHERE [Code catégorie] = (
                                        SELECT [Code catégorie] FROM [Catégories]
                                        WHERE UCASE([Nom de catégorie]) = 'BOISSONS')";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                String nbDeLignesModifiee = cd.ExecuteNonQuery().ToString();
                MessageBox.Show(nbDeLignesModifiee + " lignes ont étés modifiées !");
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

        private void btnExoRetablissement_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"UPDATE [Produits] SET [Prix unitaire] = [Prix unitaire] * 0.9
                                    WHERE [Code catégorie] = (
                                        SELECT [Code catégorie] FROM [Catégories]
                                        WHERE UCASE([Nom de catégorie]) = 'BOISSONS')";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                String nbDeLignesModifiee = cd.ExecuteNonQuery().ToString();
                MessageBox.Show(nbDeLignesModifiee + " lignes ont étés modifiées !");
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

        List<string> lstCate = new List<string>();
        private void btnExo7_Click(object sender, EventArgs e)
        {
            grpCateDyna.Visible = !(grpCateDyna.Visible);

            //On charge les catégories dans la comboBox
            
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = @"SELECT [Nom de catégorie] FROM [Catégories]";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                OleDbDataReader dr = cd.ExecuteReader();
                while (dr.Read())
                {
                    lstCate.Add(dr.GetString(0));
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


            int x = 9;
            int y = 32;
            foreach(String categorie in lstCate)
            {
                CheckBox ckbCate = new CheckBox();
                ckbCate.AutoSize = true;
                ckbCate.Location = new System.Drawing.Point(x, y);
                ckbCate.Text = categorie;
                ckbCate.Tag = categorie;
                grpCateDyna.Controls.Add(ckbCate);

                x += 200;
                if (x > 1000)
                {
                    y += 50;
                    x = 9;
                }
            }
        }

        private void btnRecherche3_Click(object sender, EventArgs e)
        {
            if (lstCate.Count() != 0)
            {
                //On crée la liste des conditions
                List<string> lstConditions = new List<string>();
                foreach (Control cate in grpCateDyna.Controls)

                if (cate is CheckBox)
                {
                    if (((CheckBox)cate).Checked)
                    {
                        string condition = "UCASE([Nom de catégorie]) = '";
                        condition += cate.Tag.ToString().ToUpper();
                        condition += "'";
                        lstConditions.Add(condition);
                    }

                }

                try
                {
                    //Ouvrir la connexion
                    connec.ConnectionString = chcon;
                    connec.Open();
                    string requete = @"SELECT COUNT(*) FROM [Produits]
                                WHERE ";
                    //On ajoute la liste des conditions
                    foreach(String condition in lstConditions)
                    {
                        requete += "[Code catégorie] = (SELECT [Code catégorie] FROM [Catégories] WHERE ";
                        requete += condition;
                        requete += ") OR ";
                    }
                    requete = requete.Substring(0, requete.Length - 3);
                    //On ajoute la fin

                    
                    OleDbCommand cd = new OleDbCommand();
                    cd.Connection = connec;
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = requete;

                    //Execution de la requête
                    String nbDeProduit = cd.ExecuteScalar().ToString();
                    MessageBox.Show("Il y a " + nbDeProduit + " dans les catégories sélectionnées !");
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
            else
            {
                MessageBox.Show("Sélectionnez une catégorie !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
