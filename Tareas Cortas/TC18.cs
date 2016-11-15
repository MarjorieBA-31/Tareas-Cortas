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
	Tarea Corta 18
	Estudiante: [Marjorie Yosibel Blandon Aguilar]
	
	Enunciado:
	Retorne los elementos comunes en dos arreglos de enteros
	Ejemplo:
	[1,2,3,4,5,6,7],[6,7,8,9,0] -> [6,7]
*/

//Your code starts here


 public class RepeatedNumbers//Class
    {
        /*I chose this way because it is the shortest first imprimi the two original
         *  arrangements for later use two numbers to compare repetiod they had in the settlement,
         *   and right there I printed the answer*/

        public int[] repeatedNumbers(int[] array_one, int[] array_two)//method receives two arrays as parameters/
        {

            Console.Write("Under number one: \n"); //prints the message
            for (int accountant = 0; accountant < array_one.Length; accountant++)//runs the first arrangement
            {
                Console.Write(array_one[accountant] + ",");//prints the arrangement
            }
            Console.Write("\n\n");//leaves blanks
            Console.Write("Under number two: \n");//prints the message
            for (int accountant = 0; accountant < array_two.Length; accountant++)//runs through the second array
            {
                Console.Write(array_two[accountant] + ",");//prints the arrangement
            }
            Console.Write("\n\n");
            Console.Write("Repeated numbers are: \n");//prints the message
            for (int accountant1= 0; accountant1 < array_one.Length; accountant1++)//runs the first arrangement
            {
                for (int accountant2 = 0; accountant2 < array_two.Length; accountant2++)//runs through the second array
                {
                    if (array_one[accountant1] == array_two[accountant2])// if the number in the array one equals number in the array enters the condition
                    {
                        Console.Write(array_one[accountant1] + ",");//prints the answer
                    }
                }

            }

            Console.ReadKey();//Stops the console
            return array_one;//You will return this variable to the specified value
        }

    }
    class Program//class
    {
        static void Main(string[] args)//Mein
        {
            RepeatedNumbers myCoint = new RepeatedNumbers();//creates an instance of the class
            int[] test1 = { 1,5,3,6,8,3,7,4};//vector containing the values
            int[] test2 = { 33, 4, 66, 77, 22 ,8,88,99,11,55 };//vector containing the values
            int[] val = myCoint.repeatedNumbers(test1, test2); // values ​​obtained 
        }
    }
}
