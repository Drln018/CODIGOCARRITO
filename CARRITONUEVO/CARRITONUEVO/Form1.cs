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
using CARRITONUEVO.clases; 

namespace CARRITONUEVO
{
    public partial class Form1 : Form
    {
        clsAutomovil carrito; 
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer bocina = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Bocina.wav");
        SoundPlayer sEncender = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Encender.wav");
        SoundPlayer sAcelerar = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Acelerar.wav");
        SoundPlayer sFrenar = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Frenar.wav");
        SoundPlayer sApagar = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Apagar.wav");
        private string ruta = ""; 

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            //creamos el carro
            carrito = new clsAutomovil("Toyota"); 
            carrito.Color = "rojo";
            labelDatos.Text = $"Se creo el carrio {carrito.marca} color {carrito.Color}";
        }

        private void buttonEncender_Click_1(object sender, EventArgs e)
        {
            this.sEncender.Play();
            string respuesta = carrito.encenderMotor();
            labelDatos.Text = respuesta;
        }

        private void buttonAcelerar_Click_1(object sender, EventArgs e)
        {
            this.sAcelerar.Play();
            labelVelocidad.Text = carrito.Acelerar();
            if (carrito.estaEncendido())
            {
                labelDatos.Text = $"El auto esta encendido puede continuar";
            }
            else
            {
                MessageBox.Show($"Lo lamento el carro{carrito} esta apagado");
            }
        }

        private void buttonFrenar_Click_1(object sender, EventArgs e)
        {
            labelVelocidad.Text = carrito.FrenarAuto();
        }
        private void buttonDetener_Click(object sender, EventArgs e)
        {
            this.sFrenar.Play();
            labelVelocidad.Text = carrito.DetenerAuto();
        }
        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            this.sApagar.Play();
            labelApagar.Text = carrito.apagarMotor();
            labelDatos.Text = "";
            labelVelocidad.Text = "";
        }

        private void buttonBocina_Click_1(object sender, EventArgs e)
        {
            this.bocina.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carrito.meterPrimera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carrito.meterSegunda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carrito.meterTercera();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carrito.meterCuarta();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carrito.meterQuinta();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelDatos.Text = carrito.meterR();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                ruta = openFileDialog1.FileName; 
                textRuta.Text = ruta; 
            }
        }

        private void buttonReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta; 
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop(); 
        }

        private void buttonPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); 
        }

    }
}
