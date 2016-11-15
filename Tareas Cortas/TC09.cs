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
	Rotacion de palabras en un string: Al recibir un string, se debe retornar un nuevo string en el que se roten sus palabras.
	Ejemplo:
	"the sky is blue" -> "blue is sky the"
	
	
*/

//Your code starts here


    public class RotateWords//Clase
    {
        /*I chose this option by separating them with Split and became
         *  a for that through me the string reversing the positions 
         *  and within that going for printing on the answers.*/

        public string rotateWords(string array)//Method that receives a string as a parameter
        {
            char[]delimiter = { ' ' };//variable holds the blank arrangement
            string[] number_of_words = array.Split(delimiter);//It makes me split when you have blanks
            string answer = "";//variable that stores a value
            Console.WriteLine("Original vector");//prints the message
            for (int accountant = 0; accountant < number_of_words.Length; accountant++)//runs the arrangement
            {
                Console.Write(number_of_words[accountant] + " ");//prints the arrangement ariginal
            }
            Console.WriteLine();//Leave a space online
            Console.WriteLine();//leaves a space online
            Console.WriteLine("Chain in a different order");//prints the message
            for (int i = number_of_words.Length - 1; i >= 0; i--)//runs the arrangement
            {
                answer = number_of_words[i];//It takes the value of the array
                Console.Write(answer + " ");//prints the inverted arrangement
            }

            Console.WriteLine();//leaves a space online
            Console.ReadKey();//stops the console
            return answer;//You will return this variable to the specified value
        }



        static void Main(string[] args)//main principal
        {
            RotateWords instance = new RotateWords();//creates an instance of the class
            string test = "the sky is blue";//vector containing the values
            string val = instance.rotateWords(test);// values ​​obtained 
            Console.ReadLine();//stops the console
        }
    }

}