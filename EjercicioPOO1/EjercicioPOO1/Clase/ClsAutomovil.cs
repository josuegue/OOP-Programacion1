using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace EjercicioPOO1.Clase
{
    class ClsAutomovil
    {
        public string marca { get; }
        public int vel_max { get; }
        public int velocidadActual { get; set; }//get = obtener y set = asigancion de valor
        private bool encendido = false;
        public string color { get; set; } 

        SoundPlayer sonidoEncendido = new SoundPlayer(@"C:/Users/Flor/source/repos/EjercicioPOO1/EjercicioPOO1/Sonidos/Encendido.wav");
        SoundPlayer sonidoPrimera = new SoundPlayer(@"C:/Users/Flor/source/repos/EjercicioPOO1/EjercicioPOO1/Sonidos/AceleracionCorta.wav");
        SoundPlayer sonidoDisminuir = new SoundPlayer(@"C:/Users/Flor/source/repos/EjercicioPOO1/EjercicioPOO1/Sonidos/Disminuir.wav");
        SoundPlayer sonidoFrenar = new SoundPlayer(@"C:/Users/Flor/source/repos/EjercicioPOO1/EjercicioPOO1/Sonidos/Freno.wav");
        public ClsAutomovil(string MarcaCarro, int velocidadMax)//constructor 
        {
            this.marca = MarcaCarro;
            this.vel_max = velocidadMax;
        }
        public void EncenderMotor() //metodo
        {
            if (!encendido)
            {
                this.encendido = true;
                this.sonidoEncendido.Play();
                velocidadActual = 0;
            }
        }

        public bool EstaEncendido()
        {
            return encendido;
        }

        public string Acelerar()
        {
            return "Mete primera ";
        }

        public string  primera()
        {
            
            if (this.velocidadActual < 40)
            {
                this.sonidoPrimera.Play();
                this.velocidadActual += 10;
                return $"Vas a {velocidadActual} km/h";
            }
            else
            {
                return $"Llegaste al maximo {velocidadActual} km/h. ¡Mete segunda! ";
            }
        }

    
        public string segunda()
        {
            
            if (this.velocidadActual < 70)
            {
                this.sonidoPrimera.Play();
                this.velocidadActual += 10;
                return $"Vas a {velocidadActual} km/h";
            }
            else
            {
                return $"Llegaste al maximo {velocidadActual} km/h. ¡Mete tercera! ";
            }
        }
        public string tercera()
        {
            
            if (this.velocidadActual < 100)
            {
                this.sonidoPrimera.Play();
                this.velocidadActual += 10;
                return $"Vas a {velocidadActual} km/h";
            }
            else
            {
                return $"Llegaste al maximo {velocidadActual} km/h. ¡Mete cuarta! ";
            }
        }

        public string cuarta()
        {
            
            if (this.velocidadActual < 130)
            {
                this.sonidoPrimera.Play();
                this.velocidadActual += 10;
                return $"Vas a {velocidadActual} km/h";
            }
            else
            {
                return $"Llegaste al maximo {velocidadActual} km/h. ¡Mete quinta! ";
            }
        }
        public string quinta()
        {
            
            if (this.velocidadActual < 160)
            {
                this.sonidoPrimera.Play();
                this.velocidadActual += 10;
                return $"Vas a {velocidadActual} km/h";
            }
            else
            {
                return $"Llegaste al maximo {velocidadActual} km/h. ¡Mete sexta! ";
            }
        }
        public string sexta()
        {
            
            if (this.velocidadActual < vel_max)
            {
                this.sonidoPrimera.Play();
                this.velocidadActual += 10;
                return $"Vas a {velocidadActual} km/h";
            }
            else
            {
                return $"Llegaste al maximo {velocidadActual} km/h. ¡Llegaste al maximo ! ";
            }
        }
        public string FrenarRapido()
        {
            this.sonidoFrenar.Play();
            this.velocidadActual = 0;
            return $"Se freno el Carro";
        }
        public string DisminuirVelociad()
        {
            if (this.velocidadActual == 0)
            {
                return $"El carro ya se freno";
            }
            else
            {
                this.sonidoDisminuir.Play();
                this.velocidadActual -= 10;
                return $"El carro va a {velocidadActual} km/h";
            }
        }

        public string Apagado()
        {
            encendido = false;
            return "El carro ya esta apagado";

        }
    }
}
