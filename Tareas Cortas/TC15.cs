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
	Encontrar duplicado: Usted va a recibir un arreglo de 100 elementos, que contiene numeros del 1 al 100, exactamente un elemento esta duplicado, 
	debe retornar el numero duplicado en el arreglo
*/

//Your code starts here

public class DuplicateNumbers//Class
    {
        /*I chose this way of doing the program because I seemed better,
         *  they used two for that through me and arrangement and by a 
         *  condition that compare me if habiain and equal number in the array
         *   if I came to the result imprimera*/
        public int duplicateNumbers(int[] numero_duplicate)//method receives an array as parameter
        {
            int answer = 0;//Variable empty
            Console.WriteLine("original arrangement:");//prints the message
            for (int accountant = 0; accountant < numero_duplicate.Length; accountant++)//runs for the arrangement
            {
                Console.Write(numero_duplicate[accountant] + " ");//imprime el arreglo original
            }
           
            for (int accountant = 0; accountant < numero_duplicate.Length - 1; accountant++)//runs the arrangement starting from scratch
            {
                for (int accountant2= accountant + 1; accountant2 < numero_duplicate.Length; accountant2++)//runs the arrangement starting from the position in which stayed the first for
                {
                    if (numero_duplicate[accountant].Equals(numero_duplicate[accountant2]))//compares if the numbers are equal
                    {
                        answer = numero_duplicate[accountant2];//answer is equal to the number doubled
                        Console.WriteLine("\n\nThe duplicate number is: " + numero_duplicate[accountant2]);//prints the message with the response
                    }
                }

            }
           
            Console.ReadKey(); //Stops the console
            return answer;//You will return this variable to the specified value
        }
    }
    class Program//Class
    {
        static void Main(string[] args)//Main
        {
            DuplicateNumbers p = new DuplicateNumbers();//You will return this variable to the specified value
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 8, 23, 24, 25, 26, 27, 28, 29, 30,
                31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                41, 22, 43, 44, 45, 46, 47, 48, 49, 50,
                51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
                61, 62, 63, 64, 65, 66, 67, 68, 69, 70,
                71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
                91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
            int val= p.duplicateNumbers(test);// values ​​obtained
            Console.ReadKey();//Stops the console

        }
    }
}

