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

namespace updatecomptoir
{
    public partial class frmCommande : Form
    {
        public frmCommande()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection();
        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Etudes\Superieur\A-Interfaces\A21 - Introduction aux interfaces homme-machine\TDs-TPs\Tp5 - Ado.net\COMPTOIR.MDB";
        DataTable dtClient = new DataTable();
        DataTable dtEmployes = new DataTable();
        //Variables globales
        int codeCommande;

        //Au démarrage
        private void frmCommande_Load(object sender, EventArgs e)
        {
            //On trouve le nombre le code commande
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = "SELECT MAX([N° Commande]) FROM Commandes";
                OleDbCommand cm = new OleDbCommand(requete, connec);
                cm.CommandType = CommandType.Text;
                codeCommande = (int)cm.ExecuteScalar() +1;
                txtNumCommande.Text = codeCommande.ToString();
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



            //On initialise la table des clients
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = "SELECT * FROM Clients";
                OleDbCommand cm = new OleDbCommand(requete, connec);
                OleDbDataAdapter da = new OleDbDataAdapter(cm);
                da.Fill(dtClient);

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

            //On initialise la comboBox client concernée
            cboClientConc.DataSource = dtClient;
            cboClientConc.DisplayMember = "Société";
            cboClientConc.ValueMember = "Code client";


            //On initialise la table des employés
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                string requete = "SELECT * FROM [Employés]";
                OleDbCommand cm = new OleDbCommand(requete, connec);
                OleDbDataAdapter da = new OleDbDataAdapter(cm);
                da.Fill(dtEmployes);

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

            //On initialise la comboBox employé responsable
            cboEmployeResp.DataSource = dtEmployes;
            cboEmployeResp.DisplayMember = "Nom";
            cboEmployeResp.ValueMember = "N° Employé";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Si le champ destinataire est non vide
            if (txtDestinataire.Text != String.Empty)
            {
                //On prépare une insertion sql
                try
                {
                    //Ouvrir la connexion
                    connec.ConnectionString = chcon;
                    connec.Open();
                    string jour = mClDateCommande.SelectionStart.Day.ToString();
                    string mois = mClDateCommande.SelectionStart.Month.ToString();
                    string annee = mClDateCommande.SelectionStart.Year.ToString();
                    string date = mois + "/" + jour + "/" + annee;
                    string requete = @"INSERT INTO [Commandes]([N° Commande], [Code Client], [N° Employé], [Date commande], [Destinataire])
                                    VALUES (" + txtNumCommande.Text +
                                    " , '" + cboClientConc.SelectedValue +
                                    "' , " + cboEmployeResp.SelectedValue +
                                    " , #" + date +
                                    "# , '" + txtDestinataire.Text + "')";
                    OleDbCommand cm = new OleDbCommand(requete, connec);
                    cm.ExecuteNonQuery();
                    codeCommande++;
                    txtNumCommande.Text = codeCommande.ToString();
                    MessageBox.Show("Requête réussie !");
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
                MessageBox.Show("Le champ destinataire est vide !");
            }
        }
    }
}
