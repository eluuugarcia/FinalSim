using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Inicializamos las variables públicas para poder acceder a ellas desde el Form2
        public static int cantidadPatrullas;
        public static int capacidadTaller;
        public static int diasEntreServicios;
        public static int tiempoReparacionInf;
        public static int tiempoReparacionSup;
        public static int primeraRoturaInf;
        public static int primeraRoturaSup;
        public static int cantDiasSimulacion;
        public static int cantIteraciones;
        public static int diaInicio;
        public static bool mostrarPatrullas;


        private bool validate(List<String> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (String.IsNullOrEmpty(array[i]))
                {
                    return false;
                }
                else if (float.Parse(array[i]) < 0 || !int.TryParse(array[i], out _))
                {
                    return false;
                }
            }

            return true;
        }


        private void iniciarButton_Click(object sender, EventArgs e)
        {
            List<String> array = new List<String>();
            array.Add(txtCantidadPatrullas.Text.Trim());
            array.Add(txtCapacidadTaller.Text.Trim());
            array.Add(txtDiasEntreServicios.Text.Trim());
            array.Add(txtTReparacionInf.Text.Trim());
            array.Add(txtTReparacionSup.Text.Trim());
            array.Add(txtPrimeraRoturaInf.Text.Trim());
            array.Add(txtPrimeraRoturaSup.Text.Trim());
            array.Add(txtCantDiasASimular.Text.Trim());
            array.Add(txtCantidadIteraciones.Text.Trim());
            array.Add(txtDiaInicio.Text.Trim());




            bool valid = validate(array);
            if (valid)
            {
                String msg = "";
                if (int.Parse(array[0]) == 0 || int.Parse(array[1]) == 0 || int.Parse(array[7]) == 0)
                {
                    msg = "Las patrullas, la capacidad del taller y la cantidad de días a simular deben ser mayores a 0.";
                    valid = false;
                    MessageBox.Show(msg);
                }
                else
                {
                    //Cargamos las variables con los datos del form

                    cantidadPatrullas = int.Parse(txtCantidadPatrullas.Text.Trim());
                    capacidadTaller = int.Parse(txtCapacidadTaller.Text.Trim());
                    diasEntreServicios = int.Parse(txtDiasEntreServicios.Text.Trim());
                    tiempoReparacionInf = int.Parse(txtTReparacionInf.Text.Trim());
                    tiempoReparacionSup = int.Parse(txtTReparacionSup.Text.Trim());
                    primeraRoturaInf = int.Parse(txtPrimeraRoturaInf.Text.Trim());
                    primeraRoturaSup = int.Parse(txtPrimeraRoturaSup.Text.Trim());
                    cantDiasSimulacion = int.Parse(txtCantDiasASimular.Text.Trim());
                    cantIteraciones = int.Parse(txtCantidadIteraciones.Text.Trim());
                    diaInicio = int.Parse(txtDiaInicio.Text.Trim());
                    mostrarPatrullas = checkBox1.Checked;


                    //Abrimos el nuevo form y cerramos el actual
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();

                }
            }

            else
            {
                MessageBox.Show("Ingrese todos los campos con números enteros positivos.");
            }



















        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
