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

namespace deconecte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet dsLocal = new DataSet();
        OleDbConnection connec = new OleDbConnection();
        string chcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Etudes\Superieur\A-Interfaces\A21 - Introduction aux interfaces homme-machine\TDs-TPs\Tp9 - déconnecté\deconecte\deconecte\Voyages2010.mdb";

        private void Form1_Load(object sender, EventArgs e)
        {
            //On incrémente la combobox villes
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();

                //Requête
                string requete = "SELECT nomVille FROM tblVilles;";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                OleDbDataReader reader = cd.ExecuteReader();
                while(reader.Read() == true)
                {
                    cboVilles.Items.Add(reader.GetString(0));
                    
                }

            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("La table n'existe pas !");


            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }

            }
            //chargerBdd();
            //chargerComboBox();
            //comboBox1.SelectedIndex = 5;


        }

        private void chargerBdd()
        {
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();
                DataTable schemaTable = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                
                string requete;
                foreach (DataRow ligne in schemaTable.Rows)
                {
                    String nomDeTable = ligne[2].ToString();
                    requete = "SELECT * FROM [" + nomDeTable + "]";
                    OleDbCommand cd = new OleDbCommand(requete, connec);
                    OleDbDataAdapter da = new OleDbDataAdapter(cd);
                    da.Fill(dsLocal, nomDeTable);
                }
                connec.Close();

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

        Boolean initFinie = false;
        private void chargerComboBox()
        {
            comboBox1.DataSource = dsLocal.Tables["tblVoyages"];
            comboBox1.DisplayMember = "Destination";
            comboBox1.ValueMember = "CodeVoyage";
            initFinie = true;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initFinie)
            {
                DataTable dt = new DataTable();
                String filtre = "CodeVoyage = '" + comboBox1.SelectedValue.ToString() + "'";
                if(dsLocal.Tables["tblReservations"].Select(filtre).Count() != 0)
                {
                    dt = dsLocal.Tables["tblReservations"].Select(filtre).CopyToDataTable();
                }
                

                dataGridView1.DataSource = dt;

                

                String message = "Nombre de réservations à destination de " + comboBox1.Text + ":" + dsLocal.Tables["tblReservations"].Select(filtre).Count();
                label1.Text = message;
            }

            MessageBox.Show(monthCalendar1.SelectionStart.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //On supprime la table
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();

                //Requête
                string requete = "DROP TABLE tblClientsParisiens";
                OleDbCommand cd = new OleDbCommand();
                cd.Connection = connec;
                cd.CommandType = CommandType.Text;
                cd.CommandText = requete;

                //Execution de la requête
                cd.ExecuteNonQuery();
                
                
            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("La table n'existe pas !");
                
                
            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }

            }

            //On lance la PS
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();


                //Requête
                OleDbCommand cd1 = new OleDbCommand();
                cd1.Connection = connec;
                cd1.CommandType = CommandType.StoredProcedure;
                cd1.CommandText = "rqtClientsParisiens";

                //Execution de la requête
                cd1.ExecuteNonQuery();

            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("Erreur lors de la requete sql");


            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Vérifie que la table existe
            try
            {
                //Ouvrir la connexion
                connec.ConnectionString = chcon;
                connec.Open();

                //On cherche si la table existe

                DataTable table = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                foreach (DataRow ligne in table.Rows)
                {
                    if (ligne[2].ToString() == "tblClientsVilleParametree")
                    {
                        OleDbCommand cd = new OleDbCommand();
                        cd.Connection = connec;
                        cd.CommandType = CommandType.Text;
                        cd.CommandText = "DROP TABLE tblClientsVilleParametree";
                        cd.ExecuteNonQuery();
                    }
                }


                //Requête
                OleDbCommand cd1 = new OleDbCommand();
                cd1.Connection = connec;
                cd1.CommandType = CommandType.StoredProcedure;
                cd1.CommandText = "rqtClientsVillesAuChoix";
                    
                //TODO : Problème ici
                //On crée le paramètre 
                OleDbParameter paramEmpId = new OleDbParameter();
                paramEmpId.ParameterName = "@empid";
                paramEmpId.OleDbType = OleDbType.Char;
                paramEmpId.Direction = ParameterDirection.Input;
                MessageBox.Show(cboVilles.SelectedItem.ToString());
                paramEmpId.Value = cboVilles.SelectedItem.ToString();
                    

                cd1.Parameters.Add(paramEmpId);

                    
                //Execution de la requête
                cd1.ExecuteNonQuery();

            }

            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion à la base");
            }
            catch (OleDbException)
            {
                MessageBox.Show("La table n'existe pas !");


            }

            finally
            {
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }

            }

          
        }
    }
}
