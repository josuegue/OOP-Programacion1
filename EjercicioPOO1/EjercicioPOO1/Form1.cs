using EjercicioPOO1.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EjercicioPOO1
{

    public partial class Form1 : Form
    {
        ClsAutomovil carrito;//variable global 
        public Form1()
        {
            InitializeComponent();
        }


        
        private void BotonInicio_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutomovil("Ford Mustang", 200); // se debe de imporatar la libreria de ClsAutomovil                                                             //enacapsulamiento  
            string CarroCreado = "El carro esta Creado";
            labelCrear.Text = CarroCreado;
            borrarDatos();
           
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            labelApagar.Text = "    ";
            carrito.EncenderMotor();
            labelDatos.Text = carrito.marca + " encendido";
            
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Acelerar();
            }
            else
            {
                MessageBox.Show($"Lo lamento el  {carrito.marca} esta apagado");
            }
        }

        private void buttonPrimera_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.primera();
            }
            else
            {
                MessageBox.Show($"Lo lamento el  {carrito.marca} esta apagado");
            }
        }
        private void buttonSegunda_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.segunda();
            }
            else
            {
                MessageBox.Show($"Lo lamento el  {carrito.marca} esta apagado");
            }

        }

        private void buttonTercera_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.tercera();
            }
            else
            {
                MessageBox.Show($"Lo lamento el  {carrito.marca} esta apagado");
            }
        }

        private void buttonCuarta_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.cuarta();
            }
            else
            {
                MessageBox.Show($"Lo lamento el  {carrito.marca} esta apagado");
            }
        }

        private void buttonQuinta_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.quinta();
            }
            else
            {
                MessageBox.Show($"Lo lamento el  {carrito.marca} esta apagado");
            }
        }

        private void buttonSexta_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.sexta();
            }
            else
            {
                MessageBox.Show($"Lo lamento el  {carrito.marca} esta apagado");
            }
        }
        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                string Freno = carrito.FrenarRapido();
                labelVelocidad.Text = Freno;
            }
            else
            {
                MessageBox.Show($"Lo lamento  {carrito.marca} esta apagado");
            }
        }
        private void buttonDisminuir_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                string disminucion = carrito.DisminuirVelociad();
                labelVelocidad.Text = disminucion;
            }
            else
            {
                MessageBox.Show($"Lo lamento  {carrito.marca} esta apagado");
            }
        }


        private void buttonApagar_Click(object sender, EventArgs e)
        {
            string off = carrito.Apagado();
            labelApagar.Text = off;
            borrarDatos();
        }

        public void borrarDatos()
        {
            
            
            labelVelocidad.Text = "    ";
            labelDatos.Text = "    ";
        }
    }
}
