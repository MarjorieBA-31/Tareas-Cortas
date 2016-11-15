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
	Haga una funcion que compare versiones, retornando -1 si el primer numero es mayor, 1 si el segundo numero es mayor y 0 y son iguales.
	Pueden asumir que los strings solo contienen numeros y el caracter '.'
	No hay un limite para la cantidad de subversiones que se pueden enviar: 1.1.1.1.1.1.1.1.1.1 es valido.
	0.1 < 1.0 < 1.0.1
	
*/

//Your code starts here

 public class Compare_numbers//Clase
    {
        /* Option this chose for being a felling, ropes it did was to turn so much 
         * double and then to create three conditions depending on if it was major,
         *  minor or equal it enters a condition and the response obtains a certain 
         *  value and at the end of impressions of yes same, this one is an easy */

        public int Compare_versions(string entry_number1, string entry_number2)//Method that has two string as a parameter
        {
            double number_one = Convert.ToDouble(entry_number1);//I declare I turn the double variable and the parameter string for double
            double number_two = Convert.ToDouble(entry_number2);//I declare I turn the double variable and the parameter string for double
            int answer = 0;//Variable empty
            if (number_one > number_two)//enters the condition if the number1 is greater than number2
            {
                answer = -1;//We give it the value -1
                Console.WriteLine(" El numero es= " + answer);//prints the message with the response
            }
            if (number_one < number_two)//enters the condition if the number1 is less than number2
            {
                answer = 1;//We give it the value 1
                Console.WriteLine(" El numero es= " + answer);//prints the message with the response
            }
            if (number_one == number_two)//enters the condition if the number1 is equal to number2
            {
                answer = 0;//We give it the value 0
                Console.WriteLine(" El numero es= " + answer);//prints the message with the response
            }
            return answer;//You will return this variable to the specified value

        }

        static void Main(string[] args)//Main
        {
            Compare_numbers instance = new Compare_numbers();//creates an instance of the class
            string test = "1.1.2";//vector containing the values
            string test1 = "2.1.2";//vector containing the values
            int val = instance.Compare_versions(test, test1); //values ​​obtained
            Console.ReadLine();//stops the console
            Console.ReadKey();//stops the console
        }
    }
}

