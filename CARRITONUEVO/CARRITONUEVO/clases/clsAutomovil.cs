using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARRITONUEVO.clases
{
    class clsAutomovil
    {
        public String marca { get; } 
        public int velocidadActual { get; set; } 
        private bool encendido = false; 
        private bool apagado = false;
        public int cambios { get; private set; } 
        public string Color { get; set; }
        private bool retroceder = false;

        public string Acelerar()
        {
            if (velocidadActual < 20 && this.cambios == 1) 
            {
                velocidadActual = velocidadActual + 5;
                return $"VAs a una velocidad de {velocidadActual }";
            }
            else
            {
                if (velocidadActual < 35 && this.cambios == 2)
                {
                    velocidadActual = velocidadActual + 5;
                    return $"Vas a una velocidad de {velocidadActual }";
                }
                else
                {
                    if (velocidadActual < 45 && this.cambios == 3)
                    {
                        velocidadActual = velocidadActual + 5;
                        return $"Vas a una velocidad de {velocidadActual }";
                    }
                    else
                    {
                        if (velocidadActual < 55 && this.cambios == 4)
                        {
                            velocidadActual = velocidadActual + 5;
                            return $"Vas a una velocidad de {velocidadActual }";
                        }
                        else
                        {
                            if (velocidadActual < 60 && this.cambios == 5)
                            {
                                velocidadActual = velocidadActual + 5;
                                return $"Vas a una velocidad de {velocidadActual}";
                            }
                            else
                            {
                                return "Llegaste al limite de velocidad"; 
                            }
                        }
                    }
                }
            }
        }

        public void meterPrimera()
        {
            this.cambios = 1; 
        }
        public void meterSegunda()
        {
            this.cambios = 2;
        }
        public void meterTercera()
        {
            this.cambios = 3;
        }
        public void meterCuarta()
        {
            this.cambios = 4;
        }

        public void meterQuinta()
        {
            this.cambios = 5;
        }

        public string meterR()
        {
            if (retroceder)  
            {
                return "Tienes que presionar R";
            }
            else 
            {
                return "Listo!, vas en reversa";
            }
        }
        public bool estaEncendido()
        { 
            return encendido; 
        }

        public clsAutomovil(string marcaCarro )
        {
            this.marca = marcaCarro; 
        }

        public string encenderMotor()
        {
            this.cambios = 1;
            if (encendido)
            {
                return "El carro ya esta encendido";
            }
            else
            {
                encendido = true;
                velocidadActual = 0;
                return "Listo el carro esta enciendido";
            }
        }
        public string DetenerAuto()
        {
            velocidadActual = 0;
            return $"La velocidad es de {velocidadActual }";
        }
        public string FrenarAuto()
        {
            velocidadActual = velocidadActual - 5;
            return $"La velocidad es de {velocidadActual}";
        }
        public string apagarMotor()
        {
            if (apagado)
            {
                return "El carro esta apagado";
            }
            else
            {
                return "El carro ya esta apagado";
            }
        }
    }

}

