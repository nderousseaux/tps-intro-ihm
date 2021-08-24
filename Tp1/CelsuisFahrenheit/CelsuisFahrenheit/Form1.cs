using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsuisFahrenheit
{
    public partial class frmCelsiusFahrenheit : Form
    {
        public frmCelsiusFahrenheit()
        {
            InitializeComponent();
        }

        //TODO : Raccourci clavier

        private bool hadVirgule(string pChaine)  // Fonction qui indique si il y a une virgule à l'intérieur d'une chaine
        {

            //Il n'y a pas de virgule
            bool virgule = false;

            //On incrémente le nombre de virgule à chaque virgule trouvée
            for (int i = 0; i < pChaine.Length; i++)
            {
                if (pChaine[i] == ',')
                {
                    virgule = true;
                }
            }
            return virgule;
        }

        private bool hadMoins(string pChaine) //Fonction qui indique si il y a un moins à l'intérieur d'une chaine
        {
            //Il n'y a pas de moins
            bool moins = false;

            //On incrémente le nombre de moins à chaque moins trouvée
            for (int i = 0; i < pChaine.Length; i++)
            {
                if (pChaine[i] == '-')
                {
                    moins = true;
                }
            }
            return moins;
        }

        private void convertionCelsiusFahrenheit() // Fonction que convertit la zone Celsius en Fahrenheit
        {
            
            if ((txtCelsius.Text != String.Empty) && (txtCelsius.Text != "-"))
            {
                double celsius = double.Parse(txtCelsius.Text);
                txtFahrenheit.Text = (32 + 1.8 * celsius).ToString();
            }
            
        }

        private void convertionFahrenheitCelsius() // Fonction que convertit la zone Fahrenheit en Celsius
        {
            if ((txtFahrenheit.Text != String.Empty) && (txtFahrenheit.Text != "-"))
            {
                double fahrenheit = double.Parse(txtFahrenheit.Text);
                txtCelsius.Text = ((fahrenheit - 32) / 1.8).ToString();
            }
        }

        private void btnRAZ_Click(object sender, EventArgs e) // Remise à zero
        {
            
            txtCelsius.Text = String.Empty;
            txtFahrenheit.Text = String.Empty;
        }

        private void radCelsiusFahrenheit_CheckedChanged(object sender, EventArgs e) //Boutton radio Celsius --> Fahrenheit coché
        {
            // Si le boutton est coché
            if (radCelsiusFahrenheit.Checked)
            {
                convertionCelsiusFahrenheit();
            }

        }

        private void radFahrenheitCelsius_CheckedChanged(object sender, EventArgs e) //Boutton radio Fahrenheit --> Celsius coché
        {
            // Si le boutton est coché
            if (radFahrenheitCelsius.Checked)
            {
                convertionFahrenheitCelsius();
            }
        }

        private void txtCelsius_KeyPress(object sender, KeyPressEventArgs e) //Zone de texte celsius, touche pressée
        {
            //Par défaut, on autorise pas l'entrée de caractère
            e.Handled = true;

            //Sauf si le caractère est un chiffre ou un retour arrière
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }

            //Sauf si le caractère est une virgule et qu'il n'y a pas encore de virgule dans la zone de texte
            if (((e.KeyChar == ',')||(e.KeyChar == '.')) && (!hadVirgule(txtCelsius.Text)))
            {
                e.Handled = false;

                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }

            }              

            //Sauf si le caractère est un moin, qu'il n'y à pas encore de moins et que le curseur est au début
            if ((e.KeyChar == '-') && (!hadMoins(txtCelsius.Text)) && (txtCelsius.SelectionStart==0))
            {
                e.Handled = false;
            }

            //Si on clique sur la touche entrée, on convertit
            if (e.KeyChar == (char)Keys.Enter)
            {
                convertionCelsiusFahrenheit();
            }

        }

        private void txtFahrenheit_KeyPress(object sender, KeyPressEventArgs e) //Zone de texte fahrenheit, touche pressée
        {
            //Par défaut, on autorise pas l'entrée de caractère
            e.Handled = true;

            //Sauf si le caractère est un chiffre ou un retour arrière
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }

            //Sauf si le caractère est une virgule et qu'il n'y a pas encore de virgule dans la zone de texte
            if (((e.KeyChar == ',') || (e.KeyChar == '.')) && (!hadVirgule(txtFahrenheit.Text)))
            {
                e.Handled = false;

                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }

            }

            //Sauf si le caractère est un moin, qu'il n'y à pas encore de moins et que le curseur est au début
            if ((e.KeyChar == '-') && (!hadMoins(txtFahrenheit.Text)) && (txtFahrenheit.SelectionStart == 0))
            {
                e.Handled = false;
            }

            //Si on clique sur la touche entrée, on convertit
            if (e.KeyChar == (char)Keys.Enter)
            {
                convertionFahrenheitCelsius();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e) // Bouton quitter
        {
            Application.Exit();
        }
    }
}
