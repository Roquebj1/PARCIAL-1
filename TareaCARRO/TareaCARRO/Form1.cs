using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaCARRO.Clases;
using System.Media;

namespace TareaCARRO
{
    public partial class Form1 : Form
    {
        ClsAutoMotor carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("Subaru",240);
            carrito.color = "Negro";

            buttonAcelerar.Visible = true;
            buttonAltoTotal.Visible = true;
            buttonEncender.Visible = true;
            buttonInicio_Click.Visible = false;

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max}km/h");
        }

      

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            
                labelEstado.Text = $"El carro {carrito.marca} : {carrito.encender()}";
            
           

        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");
            }
            else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
                labelPalanca.Text = carrito.CambioVelocidades();
            }

        }

        private void buttonChevrolet_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("Chevrolet Tahoe", 170, "Beige");

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max}km/h");
        }

        private void buttonAltoTotal_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerCarro();
        }

        private void buttonPalanca_Click(object sender, EventArgs e)
        {
            labelPalanca.Text=carrito.PalancaCambios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReproducirAudio_Click(object sender, EventArgs e)
        {

        }

        private void buttonReproducir_Click(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/HP/Desktop/Heaven.wav";
            Player.Play();
        }

        private void labelPalanca_Click(object sender, EventArgs e)
        {

        }
    }
}