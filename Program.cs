using ExpendedoraG2_2024_I;

internal class Program
{
    private static void Main(string[] args)
    {
        //Expendedora miExpendedora = new Expendedora(true); 
        //Instancia si le agregamos el abstrast, ya no se puede crear la instancia, para ver el error quitar de este comentario las //

        //var miSnack= new Snack(); //Por default se ejecuta el constructor de la clase padre, se ejecuto el primero que no tiene parametros, supuestamente mandaria a llamar la clase saludar() pero tambien mando a llamar al constructor, la explicacion esta detras

        //La herencia se hace en la subclase y se representa en la clase principal 

        var miCafe = new Cafe();
    }
}