using Juego_FizzBuzz.Avisos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Configuro el botón de salir del juego
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Información Del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.No)
            {
                this.Close();

            }
            
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            //Creo un form para dar las instrucciones

            this.Hide();

            Aviso_login aviso_Login = new Aviso_login();
            aviso_Login.ShowDialog();

            
        }

        
    }


}
