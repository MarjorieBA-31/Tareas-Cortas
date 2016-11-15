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
	Validez de parentesis:
	Se va a recibir un string S que contienen unicamente los caracteres '(' y ')', ustedes deben escribir una funcion que valida si la secuencia de parentesis es valida,
	esto quiere decir que cada parentesis abierto tenga un parentesis que lo cierre.
	Por ejemplo:
	"()" -> True
	"((" -> False
	"(()(()))" -> True
	"(()(())))" -> False
*/

//Your code starts here


 public class ParentheticalAmount//Class
    {
        /* I chose this option because a for I can count the number of parentheses 
         * there and already out of use for conditions to see if they even each 
         * bracket and print the answer me if it is true or false.*/

        public bool parentheticalAmount(string caracter_number)//Method that receives a string as a parameter
        {

            int has_character1 = 0;//Variable empty
            int has_character2 = 0;//Variable empty
            bool answer = false;//variable false

            for (int accountant = 0; accountant < caracter_number.Length; accountant++)//loop through the array by letter.
            {
                if (caracter_number[accountant] == '(')//condition which is met by finding a parenthesis
                {
                    has_character1++;//Counter that is incremented each time the condition is met
                }
                if (caracter_number[accountant] == ')')//condition which is met by finding a parenthesis
                {
                    has_character2++;//will increase the counter
                }
            }

            if (has_character1 == has_character2)//if comparing the two variables have the same amount if not so exits
            {
                answer = true;//Change the value of the variable to true
            }
            else
            {
                answer = false;//Change the value of the variable to false
            }

            Console.WriteLine("los parentesis estan completos?: " + answer);//prints the total of words
            Console.ReadKey();//stops the console
            return answer;//You will return this variable to the specified value
        }

        static void Main(string[] args)//Main
        {
            ParentheticalAmount instance = new ParentheticalAmount();//creates an instance of the class
            string test = "(())";//vector containing the values
            bool val = instance.parentheticalAmount(test); // values ​​obtained
            Console.ReadLine();////stops the console
        }
    }
}

