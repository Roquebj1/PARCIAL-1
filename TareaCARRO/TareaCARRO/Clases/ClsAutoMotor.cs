using System;
using System.Collections.Generic;
using System.Text;

namespace TareaCARRO.Clases
{
    class ClsAutoMotor
    {
        public String marca { get; }
        public int vel_max { get; }
        public String color { get; set; }
        private int velocidadActural = 0;

        public bool EncenderMp3 { get; set; } = false;

        public bool encendido { get; set; } = false;

        private int primera = 10;
        private int pasarasegunda = 19;
        private int segunda = 20;
        private int pasaratercera = 29;
        private int tercera = 30;
        private int pasaracuarta = 39;
        private int cuarta = 40;
        private int pasaraquinta = 50;
        private int quinta = 50;
        private int sobrepasar = 60;


        public ClsAutoMotor(string marcaCarro, int MaxVel)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
        }

        public ClsAutoMotor(String marcaCarro, int MaxVel, String colorCarro)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
            this.color = colorCarro;
        }

        public string DetenerCarro()
        {
            if (!encendido)
            {
                return "Enciende el carro";
            }
            velocidadActural = 0;
            return "Auto Detenido";
        }

        public string encender()
        {
            string respuesta = "";
            if (encendido)
            {
                encendido = false;
                respuesta = "El carro está apagado";
            }
            else
            {

                encendido = true;
                respuesta = "Listo maneja con precacuión";
            }
            velocidadActural = 0;
            return respuesta;
        }
        public String Acelerar()
        {
            if (!encendido)
            {
                return "Enciende el carro";
            }

            if (velocidadActural > vel_max)
            {
                velocidadActural = vel_max;
                return $"Límite alcanzado{ vel_max}Km/h";
            }
            else
            {
                velocidadActural = velocidadActural + 10;
                return $"Vas a {velocidadActural} Km/h";
            }
        } 

        public string PalancaCambios()
        {
            string Cambios = "";
            if ((velocidadActural == primera) || (velocidadActural < segunda))
            {
                Cambios = "PRIMERA";
            }else
                if ((velocidadActural==segunda) || (velocidadActural<tercera))
            {
                Cambios = "SEGUNDA";
            }else
                if ((velocidadActural==tercera) || (velocidadActural<cuarta))
            {
                Cambios = "TERCERA";
            }else
                if ((velocidadActural==cuarta) || (velocidadActural<=quinta))
            {
                Cambios = "CUARTA";
            }else
                if (velocidadActural>=sobrepasar)
            {
                Cambios = "Tu vida y la de otros prevalece, recuerda es mejor llegar tarde a nunca llegar";
            }
            return Cambios;
        }
        public string CambioVelocidades()
        {
            string cambios = "";
            if (velocidadActural==pasarasegunda)
            {
                cambios = "Por favor hacer el cambio a segunda para no forzar el motor y tener mejor velocidad";
            }else
                if (velocidadActural==pasaratercera)
            {
                cambios = "Por favor hacer el cambio a tercera para no forzar el motor y tener mejor velocidad";
            }else
                if (velocidadActural==pasaracuarta)
            {
                cambios = "Por favor hacer el cambio a cuarta para no forzar el motor y tener mejor velocidad";
            }else
                if (velocidadActural == pasaraquinta)
            {
                cambios = "Por favor hacer el cambio a quinta para no forzar el motor y tener mejor velocidad";
            }
            return cambios;
        }
    }
}