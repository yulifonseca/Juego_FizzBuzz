using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_FizzBuzz
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        int x;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            //inicio de las operaciones

            txtresultado.Text = "";

            
            if (int.TryParse(txtnumero.Text, out int limit) && limit > 0)
            {
                var fizzBuzzList = Enumerable.Range(1, limit)
                    .Select(i =>
                    {
                        // use if y el return para ir generando las palabras "fizzbuzz", una tras otra en los números divisibles
                        if (i % 3 == 0 && i % 5 == 0)
                            return "FizzBuzz";
                        if (i % 3 == 0)
                            return "Fizz";
                        if (i % 5 == 0)
                            return "Buzz";
                        return i.ToString();
                    });

                txtresultado.Text = string.Join(" ", fizzBuzzList);
                //código para que el resultado se vaya a la otra caja de texto

            }
            else
            {
                //Respuesta para un dato inválido

                MessageBox.Show("Por favor, ingrese un número entero, positivo y mayor que 0. en el cuadro de texto.", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnumero.Clear();
                txtnumero.Focus();
            }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Configurar botón de limpieza de textbox
            txtnumero.Clear();
            txtresultado.Clear();
            txtnumero.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Configura botón para regresar a la pantalla principal
            DialogResult resultado = MessageBox.Show("¿Seguro que desea regresar?", "Información Del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.No)
            {
                this.Hide();

                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
