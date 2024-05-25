using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseFinal
{
    public partial class Form1 : Form
    {
        private Model model;
        string coolio;
        string[] companias = {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc.",
            "Sega",
            "Sony"
        };

        private void BuscarPorID()
        {
            int idConsola = int.Parse(textBoxID.Text);
            DataTable consolaEncontrado = model.CargarRegistro(idConsola);
            if (consolaEncontrado.Rows.Count > 0)
            {
                string nombre = consolaEncontrado.Rows[0]["nombre_consola"].ToString();
                string compania = consolaEncontrado.Rows[0]["compania"].ToString();
                int anio = int.Parse(consolaEncontrado.Rows[0]["anio_lanzamiento"].ToString());
                int generacion = int.Parse(consolaEncontrado.Rows[0]["generacion"].ToString());
                textBoxConsola.Text = nombre;
                comboBoxCompania.Text = compania;
                textBoxAnio.Text = anio.ToString();
                textBoxGeneracion.Text = generacion.ToString();

            }
        }

        public Form1()
        {
            InitializeComponent();
            model = new Model();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (model.ProbarConexion())
            {
                MessageBox.Show("poggies");
            }
            else
            {
                MessageBox.Show("shrigma");
            }

        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = model.LeerTabla();
            dataGridView1.DataSource = dt;
        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            BuscarPorID();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCompania.Items.AddRange(companias);
        }

        private void buttonSiguente_Click(object sender, EventArgs e)
        {
            int idConsola = int.Parse(textBoxID.Text);
            idConsola++;
            DataTable consolaEncontrado = model.CargarRegistro(idConsola);
            if (consolaEncontrado.Rows.Count > 0)
            {
                int id = int.Parse(consolaEncontrado.Rows[0]["id_consola"].ToString());
                string nombre = consolaEncontrado.Rows[0]["nombre_consola"].ToString();
                string compania = consolaEncontrado.Rows[0]["compania"].ToString();
                int anio = int.Parse(consolaEncontrado.Rows[0]["anio_lanzamiento"].ToString());
                int generacion = int.Parse(consolaEncontrado.Rows[0]["generacion"].ToString());
                textBoxID.Text = id.ToString();
                textBoxConsola.Text = nombre;
                comboBoxCompania.Text = compania;
                textBoxAnio.Text = anio.ToString();
                textBoxGeneracion.Text = generacion.ToString();

            }
        }

    }
}
