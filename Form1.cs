using System;
using System.Windows.Forms;

namespace SobreCargaOperadores_G3_2022_II
{
    public partial class Form1 : Form
    {
        bool validaError;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            float real;
            float imaginaria;
            if (rdbSuma.Checked)
            {
                #region Sumar
                try
                {
                    validaError = false;
                    if (txtbComReal1.Text == "" || txtbComIma1.Text == "")
                    {
                        validaError = true;
                        string error = "No se deben dejar campos vacíos";
                        throw new ApplicationException(error);
                    }
                    if (!validaError)
                    {
                        errorProvider1.Clear();
                    }
                    real = float.Parse(txtbComReal1.Text);
                    imaginaria = float.Parse(txtbComIma1.Text);
                    Complejo c1 = new Complejo(real, imaginaria);


                    real = float.Parse(txtbComReal2.Text);
                    imaginaria = float.Parse(txtbComIma2.Text);
                    Complejo c2 = new Complejo(real, imaginaria);

                    Complejo c3 = c1 + c2;
                    lbResultado.Text = c3.ToString();
                }
                catch (ApplicationException error)
                {
                    errorProvider1.SetError(lbImaginario1, error.Message);
                }

                catch (FormatException error)
                {
                    MessageBox.Show(error.Message);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                #endregion
            }
            if ( rdbConjuga.Checked  )
            {
                try
                {
                    real = float.Parse(txtbComReal1.Text);
                    imaginaria = float.Parse(txtbComIma1.Text);
                    Complejo c1 = new Complejo(real, imaginaria);
                    lbResultado.Text = (~c1).ToString();
                }
                catch(FormatException error )
                {
                    MessageBox.Show(error.Message);

                }

            }


        }

        private void rdbSuma_CheckedChanged(object sender, EventArgs e)
        {
            lbConjugado.Visible = false;
            lbOperador.Text = "+";
            btnSumar.Text = "Sumar";
        }

        private void rdbResta_CheckedChanged(object sender, EventArgs e)
        {
            lbConjugado.Visible = false;
            lbOperador.Text = "-";
            btnSumar.Text = "Resta";
        }

        private void rdbMultiplica_CheckedChanged(object sender, EventArgs e)
        {
            lbConjugado.Visible = false;
            lbOperador.Text = "*";
            btnSumar.Text = "Multiplicar";
        }

        private void rdbConjuga_CheckedChanged(object sender, EventArgs e)
        {
            lbConjugado.Visible = true;

            lbOperador.Text = "";
            btnSumar.Text = "Conjugar";
        }
    }
}
