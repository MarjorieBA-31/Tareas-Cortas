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
	Tarea Corta 7
	Estudiante: [Marjorie Yosibel Blandon Aguilar]
	
	Enunciado:
	Dado un arreglo de longitud N, retornar un arreglo que contenga los K caracteres mas frecuentes.
	Ejemplo:
	[1,2,3,4,3,2,5], 2 -> Queremos los dos caracteres mas frecuentes del arrelgo
	Resultado -> [2,3] 
*/

//Your code starts here


   public class repeatedNumbersInTheArray//class
    {
        /* I chose this solution because leaving only need a very fast for that through me then
         *  into the arrangement under a condition where if the number in the position of an age 
         *  equal to the next position to be printed numbers repeated*/

        public int[] repeatedNumbers(int[] Storing_numbers)//method receives an array as a parameter
        {
            Console.WriteLine("Chain Original:");//prints the message
            for (int accountant = 0; accountant < Storing_numbers.Length; accountant++)//for entering if the counter is zero and will traverse all
            {
                Console.Write(Storing_numbers[accountant] + " ");//prints the numbers array
            }
            Console.WriteLine("\n\nRepeated Numbers:");//prints the message
            Array.Sort(Storing_numbers);//method that sorts the array elements
            for (int accountant = 1; accountant < Storing_numbers.Length; accountant++)//for walking arrangement from position 1
            {
                if (Storing_numbers[accountant - 1] == Storing_numbers[accountant])//the last element of the array with the current compared to see if they match
                {

                    Console.Write(Storing_numbers[accountant] + " ");//prints repeating elements in the array
                }
            }
            Console.ReadKey();//stops the console
            return Storing_numbers;//You will return this variable to the specified value
        }

    }
    class Program//Class
    {
        static void Main(string[] args)//Main
        {
            repeatedNumbersInTheArray instance = new repeatedNumbersInTheArray();//creates an instance of the class
            int[] test = { 1,2,3,4,5,6,4,3,5,7,8,6};//vector containing the values
            int[] val = instance.repeatedNumbers(test);//values ​​obtained
            Console.ReadKey();//stops the console

        }
    }
}