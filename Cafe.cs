using System;


namespace ExpendedoraG2_2024_I
{
    internal class Cafe: Expendedora
    {
        public Cafe() 
        {
            Saludar();
            Console.WriteLine("Marca: {0}", Marca);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);
        }
    }
}
