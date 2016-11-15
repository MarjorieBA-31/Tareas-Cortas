/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 2
	Estudiante: [Marjorie Yosibel Blandon Aguilar]
	
	Enunciado:
	Escriba una funcion que le de vuelta a una lista, debe imprimir primero la lista original, y luego imprimir la lista invertida.
	Preferiblemente, darle vuelta a la lista sin crear una lista nueva.
*/

//Your code starts here

   public class InvestingAList//Class
    {
        /* Choose option Make two for because I found it faster to get to the answer, 
         * where it will go and print the original arrangement and the second 
         * for travels the fix this time, has the function of investing and print. */

        public int ReversedList(int[] list)//function to search the largest item in a list
        {
            int accountant = 0;//Variable empty
            Console.WriteLine("Original list");// Prints out the message
            for (accountant = 0; accountant < list.Length; accountant++)// For that runs through the settlement
            {
                Console.WriteLine(list[accountant]);// Prints the original arrangement
            }

            Console.WriteLine();//a line break or blank ago
            Console.WriteLine("Reversed list");// Prints out the message
            for (accountant = list.Length - 1; accountant >= 0; accountant--)
            /*Enters for until counter is less than or equal to zero, and the counter is subtracted,
             *  a list is subtracted since January 1 list is greater than counter for 1 */

            {
                Console.WriteLine(list[accountant]);// Print inverted arrangement.
            }

            return list.Length;//Retort this variable
        }
    }

    class Program//Class
    {
        static void Main(string[] args)//Main
        {
            InvestingAList mayor = new InvestingAList();//intancia class
            int[] test = { 8, 1, 6, 11, 7,6,8,4,1,2,3,4,5 };//int receiving method
            int val = mayor.ReversedList(test);//Call the method and the class to pass the chain defined above
            Console.Read();// It keeps the program running until a key is pressed
        }
    }
}