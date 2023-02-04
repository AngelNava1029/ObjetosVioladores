using System;
namespace ObjetosVoladores
{
	public abstract class Vehiculo
	{
		//propiedades
		protected string combustible;
		protected int llantas;
		protected double capacidad;
		protected EstadoVehiculo estado;
		//METODOS ABSTRACTOS
		protected abstract void comunicar(string msg);
		protected abstract void encender();
		protected abstract void apagar();
        
        
        

		public Vehiculo()
		{
		}

	}//terminacion de clase
	public enum EstadoVehiculo
	{
		APAGADO,ENCENDIDO,DETENIDO,EN_TRANSITO,DESPEGANDO
	}
}

