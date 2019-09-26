using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace ArchivosResumenActividad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Es el boton seleccionar que lo que hace es como examinar o seleccionar el archivo, imagen... que quieres seleccionar
        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            

            if (f.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = f.FileName;
            }
        }

        //Es el boton salir que lo que hace es salir de la aplicacion
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Es el boton abrir que lo que hace una vez has seleccionado lo que queries al darle a abrir lo abre
        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text);
        }
    }
}
