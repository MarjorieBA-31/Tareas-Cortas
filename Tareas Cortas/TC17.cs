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
	Estudiante: [Marjorie  Yosibel Blandon Aguilar]
	
	Enunciado:
	Dado un string S, encuentre todos los caracteres repetidos en el string, imprima una linea con cada caracter repetido y cuantas veces aparece
	Ejemplo:
	"abcdabeacd"
	>a,3
	>b,2
	>c,2
	>d,2
*/

//Your code starts here


  public class RepeatedLetters//Class
    {
        /*this way to solve this exercise is long but it was what I came up and 
        was creating two for that within me make comparisons of positions and
        whether there was repeated word out if had he printed me the word with
        the number of times repeated*/

        public string repeatedLetters(string array)//You are receiving a strin method as a parameter
        {
            int accountant1 = 0;//Variable empty
            int accountant2 = 0;//Variable empty
            int Letters = 0;//Variable empty
            string lowercaseWord = array.ToLower();//pone mayusculas en minusculas 
            char[] Repeatedword = lowercaseWord.ToCharArray(); //puts uppercase to lowercase
            int array2 = Repeatedword.Length;//Fitting-get new

            Console.WriteLine("original arrangement: " + array);//prints the string
            Console.WriteLine("\nRepeated letters: ");//prints the message

            for (accountant1 = 0; accountant1 < array2; accountant1++)//enter the string for a walk
            {


                Letters = 0;//Variable empty
                for (accountant2 = 0; accountant2 < array2; accountant2++)//enter the string for a walk
                {//condition asking if the letter is in a lower position that accountant1 equals the letter that is in the posicón accountant2
                    if (accountant2 < accountant1 && Repeatedword[accountant1] == Repeatedword[accountant2])
                    {

                        break;//It exits the program
                    }
                    if (Repeatedword[accountant2] == Repeatedword[accountant1])
                    {//asks whether the character that is in a position constraint is the same as the other character
                        Letters++;//variable is increased

                    }
                    if (accountant2 == array2 - 1)// comparing condition position accountant2 to the size of char back to front
                    {
                        if (Letters >= 2)//question if the letters are repeated twice more
                        {
                            Console.WriteLine(Repeatedword[accountant1] + "," + Letters);//reply prints
                        }

                    }

                }
            }
            if (Letters == 1)//if there are no repeated letters enters this condition
            {
                Console.WriteLine("No repeated letters");//reply prints
            }

            Console.ReadKey();////Stops the console
            return array;//You will return this variable to the specified value
        }
    }



    class Program//class
    {
        static void Main(string[] args)//Main
        {
            RepeatedLetters instance = new RepeatedLetters();//creates an instance of the class
            string test = "Moises";//vector containing the values
            string val = instance.repeatedLetters(test); // values ​​obtained 
        }
    }
}