using System;
namespace ObjetosVoladores
{
	public class Dron : Vehiculo,IVolador
	{
		public Dron()
            //metodo muy especial de la clase: CONSTRUCTOR!!!!
		{
            Console.WriteLine("creando Dron!");
            this.estado = EstadoVehiculo.APAGADO;
            this.combustible = "Baterias AAA";
            this.llantas = 0;
            this.capacidad = 0.0;

		}

        public void aterrizar()
        {
            throw new NotImplementedException();
        }

        public void despegar()
        {
            if (this.estado == EstadoVehiculo.ENCENDIDO)
            {
                Console.WriteLine("Ahora puede despegar el dron" );
                this.estado = EstadoVehiculo.DESPEGANDO;
            }
        }

        public string volar(int tiempo)
        {
            throw new NotImplementedException();
        }

        protected override void apagar()
        {
            if(this.estado == EstadoVehiculo.ENCENDIDO)
            {
                if (this.estado == EstadoVehiculo.DETENIDO)
                {
                    Console.WriteLine("Ahora si se puede apagar.");
                    this.estado = EstadoVehiculo.APAGADO;
                }
                else
                {
                    Console.WriteLine("Se debe detener el vehiculo antes de apagarlo.");
                }
            }
            else
            {
                Console.WriteLine("se debe apagar antes de prender ");
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
                Console.WriteLine("Apaga el carro");
            }
        }
        public void Encender()
        {
            encender();
        }
        public string ToString()
        {
            return $"Este dron utiliza de combustible {combustible}, tiene llantas {llantas}, su capacidad es {capacidad}, y su estado actual es {estado}";
        }
    }//clase
}

