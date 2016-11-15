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
	Retorne la combinacion de los elementos unicos de dos arreglos de enteros
	Ejemplo
	[1,2,3,4,5,6],[5,6,7,8,9] -> [1,2,3,4,5,6,7,8,9]
	
*/

//Your code starts here


public class ArrangementsTogether//class
    {
        /*I chose this option because using methods c # as are the concat you use
        it first to link the two arrangements after he had joined the two arrangements
        through two for to order new arrangement low to high and finally have a method that
        I removes the numbers repeated in the arrangement will be the Distinct and already 
        entered an arrangement for printing without repetitions.*/

        public int[] arrangementsTogether(int[] array_one, int[] array_two)//method that takes two arrays as parameters
        {
            int auxiliary_variable = 0;//variable empaty
            int[] result = { };//empty array

            result = array_one.ToList().Concat(array_two.ToList()).ToArray();//arrangement linking the two into one

            Console.WriteLine("Original arrangement:");//prints the message
            for (int i = 0; i < result.Length; i++)//runs the first arrangement
            {
                Console.Write(result[i] + " ");//prints the arrangement
            }

            //Order the numbers from highest to lowest
            for (int accountant = 0; accountant < result.Length; accountant++)//comensando for entering the counter from the zero position
            {
                for (int accountant1 = accountant + 1; accountant1 < result.Length; accountant1++)//comensando for entering the counter from the one position
                {
                    if (result[accountant] > result[accountant1])//enters the condition depending on whether the first is less
                    {
                        auxiliary_variable = result[accountant];//store the number in that position
                        result[accountant] = result[accountant1];//stores the number in the other position
                        result[accountant1] = auxiliary_variable;//at the end you are left with the correct number
                    }
                }
            }
            int[] array_tree = result.Distinct().ToArray();//remove repeated numbers array
            Console.WriteLine("\n");//leave a blank line

            Console.WriteLine("Orderly arrangement");//prints the message
            //va imprimiendo los numeros de mayor a menor
            for (int accountantt = 0; accountantt < array_tree.Length; accountantt++)//runs the arrangement
            {
                Console.Write(array_tree[accountantt] + " ");//prints the response
            }

            Console.ReadKey();//Stops the console
            return array_one;//You will return this variable to the specified value

        }

    }
    class Program//class
    {
        static void Main(string[] args)//Main
        {
            ArrangementsTogether instance = new ArrangementsTogether();//creates an instance of the class
            int[] test1 = { 1, 2, 3, 6, 6, 4 };//vector containing the values
            int[] test2 = { 5, 7, 6, 6 };//vector containing the values
            int[] val = instance.arrangementsTogether(test1, test2);// values ​​obtained
            Console.ReadKey();//Stops the console

        }
    }

}