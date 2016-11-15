/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 1
	Estudiante: [Marjorie Yosibel Blandon Aguilar]
	
	Enunciado:
	Encontrar el K-esimo elemento las grande en un arreglo desordenado, notese que es el k-esimo elemento en el arreglo ordenado, no el k-esimo elemento distinto.
	ejemplo:
	[3,2,1,5,6,4], k=2 -> retorna 5
*/

//Your code starts here



  public class Kesimo//Class
    {
        /*I chose this option because what we did was create two for where
        I recorrienra in arrangement and once it was ordered from highest
        to lowest, followed another was created for to print the values ​​in which
        they put a condition that if a variable aid was equal to the arrangement 
        that the response would print the number in the position that is the kth element*/

        public int[] kesimo(int[] quantity, int entry_number)//method receives an integer and an array as a parameter
        {
            int auxiliary_variable = 0;// Variable empty
            int counter_help = 1;// Variable empty
            int accountantt = 0;// Variable empty
            //Order the numbers from highest to lowest
            for (int accountant = 0; accountant < quantity.Length; accountant++)//comensando for entering the counter from the zero position
            {
                for (int accountant1 = accountant + 1; accountant1 < quantity.Length; accountant1++)//comensando for entering the counter from the one position
                {
                    if (quantity[accountant] < quantity[accountant1])//enters the condition depending on whether the first is less
                    {
                        auxiliary_variable = quantity[accountant];//store the number in that position
                        quantity[accountant] = quantity[accountant1];//stores the number in the other position
                        quantity[accountant1] = auxiliary_variable;//at the end you are left with the correct number
                    }
                }
            }
            //you are printing the numbers high to low
            for (accountantt = 0; accountantt < quantity.Length; accountantt++)//arranging for print runs 
            {
                if (counter_help == entry_number)//enters the condition if the two variables are equal
                {
                    Console.Write("\nEl K-esimo elemento es:  \n" + quantity[accountantt]);//prints the message and the response
                }
                counter_help++;//asta is increased to be equal to integer
            }
            return quantity;//returns the array
        }

    }
    public class Program//class
    {

        static void Main(string[] args)//Main
        {
            Kesimo instance = new Kesimo();//creates an instance of the class
            int[] test = { 3, 2, 1, 5, 6, 4 };//vector containing the values
            int user_number = 2;//Number I want you to return me or greater
            int[] val = instance.kesimo(test, user_number);// values ​​obtained
            Console.Read();//Stops the console
        }

    }

}