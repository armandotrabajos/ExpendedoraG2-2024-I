using System;


namespace ExpendedoraG2_2024_I
{
    internal class Snack : Expendedora //La herencia es con dos puntos y escoger cual es la clase padre
    {
        public Snack()
        {
            Saludar(); //No nos dejaba antes porque estaba en private, lo cambiamos a public, public lo puedo utilizar en cualquier clase, private se utiliza unicamente en la clase que esta 
        }
    }
}
