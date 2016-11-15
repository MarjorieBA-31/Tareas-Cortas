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
	Tarea Corta 4
	Estudiante: [Marjorie Yosibel Blandon Aguilar]
	
	Enunciado:
	Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
	La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
	Palindromo: https://es.wikipedia.org/wiki/Pal%C3%ADndromo
*/

//Your code starts here

public class LoginPalindrome//class
    {
        /* What I did was go a invirtiere for me where the string in the same 
         * there is a condition for comparing the original palindrome with which 
         * it is investing and if you are like me print the true end and if not false*/

        public bool Palindrome(string palindrome1)//Method receives a string as a parameter
        {
            string palindrome2 = "";//Variable empty
            string stored = "";//Variable empty
            int medium_between_the_array = 0;//Variable empty
            bool answer = false;//Variable empty
            medium_between_the_array = palindrome1.Length;//Variable tl is equal to the string arrangement
            for (int accountant = medium_between_the_array - 1; accountant >= 0; accountant--)
            {
                /*program between the for if counter is equal to the arrangement and until counter is equal to or less than zero, 
                the counter decrementsVariable tl is equal to the string arrangement*/

                stored = palindrome1.Substring(accountant, 1);//is assigned the value of the settlement in this position the arrangement
                palindrome2 = palindrome2 + stored;//It adds up positions
            }
            if (palindrome1.Equals(palindrome2))//if the variable in position 1 is equal to the other variable enters this if
            {
                answer = true;//Changes from true to falsify because if palindrome
            }
            else
            {
                answer = false;//it is false because it is not palindrome
            }
            Console.WriteLine("Palabra Palindrome: {0}", answer);//prints the message with the response
            return answer;//Retort this variable
        }
    }

    public class Program//class
    {
        static void Main(string[] args)//Main
        {
            LoginPalindrome instance = new LoginPalindrome();//intancia class
            string test = "reconocer";//arreglo que almacena la palabra
            bool val = instance.Palindrome(test);//Call the method and the class to pass the chain defined above
            Console.Read();// It keeps the program running until a key is pressed
        }
    }
}

