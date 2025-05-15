using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace _08_05_2025
{
    public partial class Form1 : Form
    {
        string name;

        public Form1()
        {
            InitializeComponent();
           
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lstRuta.View = View.Details;
            lstRuta.LabelEdit = true;
            lstRuta.FullRowSelect = true;
            lstRuta.GridLines = true;
            lstRuta.Columns.Add("Nombre", -2, HorizontalAlignment.Left);
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo dir = new DirectoryInfo(ruta);
            foreach (var fil in dir.GetFiles("*.txt"))
            {
                lstRuta.Items.Add(fil.Name);
            }
        }

        private void lstRuta_DoubleClick(object sender, EventArgs e)
        {
            name = lstRuta.SelectedItems[0].Text;
           txtLectura.Clear();
            StreamReader fichero;
            fichero = System.IO.File.OpenText(name);
            while (!fichero.EndOfStream)
                txtLectura.Text += fichero.ReadLine() + "\r\n";
            fichero.Close();

            
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            StreamWriter Copia;
            string fichero;
            fichero = txtLectura.Text;     
            Copia = System.IO.File.CreateText(name);
            Copia.WriteLine(fichero);
            Copia.Close();

        }

        private void rbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            txtLectura.Enabled = true;
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            txtLectura.Enabled = false;
        }
    }
}
