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
	Tarea Corta 6
	Estudiante: [Marjorie Yosibel Blandon Aguilar]
	
	Enunciado:
	El palindromo mas corto, 
	Dado un string S, usted debe formar un palindromo al agregarle caracteres al final, forme el palindromo mas corto posible en base al string S recibido
	"aace" -> aacecaa
	"abcd" -> "abcdcba"
*/

//Your code starts here

   public class Palindromo//Clase
    {
        /* I chose this option and only need two variables and where
         *  I fence for adding characters to the inverted palindrome and the 
         *  last thing you do is print it, it is a quick and easy way to do it.*/

        public string palindromo(string word_answer)//method that receives a string as a parameter
        {
            string stores_characters = "";//variable that helps us store the new string reversed
            int stored = word_answer.Length;//keeps the size of the string

            for (int accountant = stored - 2; accountant >= 0; accountant--)
            {
                /* Walk the palindrome with a for and decrements the counter variable since it
                 *  has the amount of the original palindrome and takes two spaces to print 
                 *  the missing characters in the palindrome*/

                stores_characters = stores_characters + word_answer[accountant];//assigned the missing letters to the palindrome
            }
            Console.WriteLine("EL nuevo Palindrome es:");//prints the message 
            Console.Write(word_answer + stores_characters);//prints the message with the response
            return word_answer;//You will return this variable to the specified value
        }
    }

    class Program//Clase 
    {
        static void Main(string[] args)//Mein
        {
            Palindromo instance = new Palindromo();//creates an instance of the class
            string test = "abcd";//vector containing the values
            string val = instance.palindromo(test);//values ​​obtained
            Console.ReadKey();//stops the console
        }
    }
}