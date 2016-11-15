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
	Haga una funcion que imprima los primeros 100 elementos de la secuencia de fibonacci
	Fibonacci -> https://en.wikipedia.org/wiki/Fibonacci_number
*/

//Your code starts here


  public class Fibonacci
    {/*He chose this option because it is small, the first thing 
        we did was go a for that out till it was less than 100 in this 
        hiba comparing first number with the second and so on, 
        adding up the numbers at the same time and Print to*/
        public int fibonacci()
        {
            int number_one = 1; //uninitialized variable 1
            int number_two = 0; //uninitialized variable 0
            int answer = 0;//uninitialized variable 0

            Console.WriteLine("0");//prints the zero
            for (int accountant = 0; accountant < 100; accountant++)//till it ends for less than 100
            {
                number_two = number_one;//la variable numero 2 tomara el valor de la variable numero 1
                number_one = answer;//a la variable numero 1 se le asigna el valos de la variable asnwer
                answer = number_one + number_two;//suma el numero que hay en la variable y la variable 2
                Console.WriteLine(answer);//prints the answer
            }

            Console.ReadKey();//Stops the console
            return answer;//You will return this variable to the specified value
        }
    }

    class Program//Class
    {
        static void Main(string[] args)//Main
        {
            Fibonacci instance = new Fibonacci();//creates an instance of the class
            int letter = instance.fibonacci();// values ​​obtained
        }
    }
}