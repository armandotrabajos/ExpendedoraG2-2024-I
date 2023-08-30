using System;


namespace ExpendedoraG2_2024_I
{
    internal class Cafe : Expendedora
    {

        #region Propiedades
        public override byte Temperatura
        {
            get => base.Temperatura;
            set
            {
                if (50 < value && value < 70)
                {
                    temperatura = value;
                }
                else
                {
                    temperatura = 60;
                }//Al generar nos aparece como base.Temperatura = value; , eliminar y poner nuestro codigo para que no salga de nuevo Temperatura=20 que es de la clase principal
            }
        }//Al poner override y la variable que queremos que puede ser repetida y genera 

        #endregion  

        public Cafe()
        {

            Saludar(); //No nos dejaba antes porque estaba en private, lo cambiamos a public, public lo puedo utilizar en cualquier clase, private se utiliza unicamente en la clase que
            Temperatura = 60;
            Console.WriteLine("Temperatura: {0} [°C]", Temperatura);
            LimpiarDisplay();         
            string codigo = MostrarProducto();
            LimpiarDisplay();
            Precio = 10;
            MostrarPrecio(codigo);
        }

        public Cafe(bool Mantenimiento) //Constructor y public es el modificador de acceso //Tema de la sobrecarga
        {
            if (Mantenimiento)
                Console.WriteLine("Entrando a modo mantenimiento");
            else
                Saludar();
        }

        public Cafe(int CantidadProductos) //Cuando es booleno no se pone == porque solo es true or false //Tema de la sobrecarga
        {
            Console.WriteLine("La expendedora de cafe contiene {0}", CantidadProductos);
        }

        #region Metodos
        public override string MostrarProducto()
        {
            Console.WriteLine("4C: Americano \n 4D: Expresso");
            string codigo = Console.ReadLine();

            return codigo;

        }

        public override void MostrarPrecio(string codigo){

            switch (codigo)
            {
                case "4C":
                    Console.WriteLine("precio ${0}", Precio + 3);
                    break;

                case "4D":
                    Console.WriteLine("precio ${0}", Precio + 6);
                    break;
            }


        }

        #endregion

    }
}
