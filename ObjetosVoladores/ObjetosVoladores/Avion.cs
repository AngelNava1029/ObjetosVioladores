using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosVoladores
{
    public class Avion : Vehiculo,IVolador
    {
        public EnumTiposAvion tipoAvion;
        public Avion() 
        {
            this.estado = EstadoVehiculo.APAGADO;
            this.combustible = "Queroseno";
            this.llantas = 16;
            this.capacidad = 200.000;
            this.tipoAvion = EnumTiposAvion.GUERRA;
            


        }

             public void aterrizar()
            {
                if(this.estado ==EstadoVehiculo.EN_TRANSITO)
                {
                    Console.WriteLine("listos para aterrizar");
                 
                }
            }

            public void despegar()
            {
                if (this.estado == EstadoVehiculo.ENCENDIDO)
                {
                Console.WriteLine("Ahora puede despegar el avion");
                    this.estado = EstadoVehiculo.DESPEGANDO;
                }
            }

            public string volar(int tiempo)
            {
                throw new NotImplementedException();
            }

        protected override void apagar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO)
            {
                if (this.estado == EstadoVehiculo.DETENIDO)
                {
                    Console.WriteLine("Ahora si se puede apagar");
                    this.estado = EstadoVehiculo.APAGADO;
                }
                else
                {
                    Console.WriteLine("Se debe detener el avion antes de apagarlo.");
                }
            }
            else
            {
                Console.WriteLine("Prende el avion");
            }
        }

        protected override void comunicar(string msg)
        {
            throw new NotImplementedException();
        }

        protected override void encender()
        {
            if (this.estado == EstadoVehiculo.APAGADO)
            {
                Console.WriteLine("Encendiendo motores");
                this.estado = EstadoVehiculo.ENCENDIDO;
            }
            else
            {
                Console.WriteLine("Apaga el vehiculo");
            }
        }
        public void Encender()
        {
            encender();
        }
        public string ToString()
        {
            return $"Este avion utiliza de combustible {combustible}, tiene llantas {llantas}, su capacidad es {capacidad},  su estado actual es {estado}, y el tipo de avion es {tipoAvion}";
        }
    }//clase
}