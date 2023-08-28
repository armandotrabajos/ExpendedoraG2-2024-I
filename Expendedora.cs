using System;
using System.Threading; //linea 32

namespace ExpendedoraG2_2024_I
{
    internal abstract class Expendedora //Cuando la clase padre unicamene se utiliza para mandar a llamar a sus subclases entonces se le agrega el nombre de abstract
    {
        #region Atributos
        private string marca;
        private ushort cantproductos; //432 productos por lo que se eligio ushort
        private byte temperatura; //Inicio de tema de ocultacion, linea 81 Click derecho y encapsular con acciones rapidas a la variable para crear parte del codigo de la region Propiedades
        private float precio;

        #endregion

        #region Propiedades
        public byte Temperatura
        {
            get => temperatura;
            set
            {
                if (0 < value && value < 25)
                    temperatura = value;
                else
                    temperatura = 20;
            }

        }

        public string Marca { get => marca; set => marca = value; }
        #endregion


        #region Metodos
        public void Saludar()
        {
            Console.WriteLine("Bienvenido, elige un producto");

        }

        public void LimpiarDisplay()
        {
            Thread.Sleep(2000); //Como que distrae al procesador para retrasar la siguiente linea
            Console.Clear();
        }

        public string MostrarProducto()
        {
            Console.WriteLine(" 3A: Doritos \n 3B: Churrumais ");
            Console.WriteLine("Ingrea el codigo del producto");
            string codigo = Console.ReadLine(); //codigo es tomada como variable local al ser declarada dentro de un public 
            return codigo; //Se ocupo porque si no estaba en la linea 23 de mostrarproducto no devolvia todos los valores en numero
        }

        public void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "3A":
                    Console.WriteLine("Precio:${0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", precio - 6 );
                    break ;
                default:
                    Console.WriteLine("No ingresante un producto valido");
                    break;
            }
        }
        #endregion


        #region Constructor
        public Expendedora()
        {
            Marca = "AMS";
            precio = 18;
            Saludar();

            LimpiarDisplay(); //Se creo un metodo en la linea 23 para reutilizar codigo

            

        }

        public Expendedora(bool Mantenimiento)
        {
            Temperatura = 20;
            if (Mantenimiento == true)
                Console.WriteLine("Entrando en modo mantenimiento");
            Console.WriteLine("Cambiando temperatura");
            LimpiarDisplay();
            for (int i = 0; i < 20; i++)
            {
                Temperatura++;
            }

            Console.WriteLine("Mostrando Temperatura {0} [°C]" , Temperatura); 
        }
        #endregion







    }
}
