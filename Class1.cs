using System;
using System.Threading; //linea 32

namespace ExpendedoraG2_2024_I
{
    internal class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantproductos; //432 productos por lo que se eligio ushort
        private float precio;
        #endregion


        #region Metodos
        private void Saludar()
        {
            Console.WriteLine("Bienvenido, elige un producto");

        }

        private void LimpiarDisplay()
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
            marca = "AMS";
            precio = 18;
            Saludar();

            LimpiarDisplay(); //Se creo un metodo en la linea 23 para reutilizar codigo

            Console.WriteLine("Marca: {0}", marca);

            Saludar();

            LimpiarDisplay();

            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);

        }
        #endregion





    }
}
