﻿/*
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
	Tarea Corta 10
	Estudiante: [Marjorie Yosibel Blandon Aguilar]
	
	Enunciado:
	Inversion de un string: Al recibir un string S, retornar un string cuyas palabras estan invertidas, sin invertir el orden de las palabras.
	"The Sky is Blue" -> "ehT ykS si eulB"
*/

//Your code starts here

 public class InvertedWord//class
    {
        /* I chose this option by separating them with Split 
        and became a for that through me the string and within
        this for another for me to invest every word and then would print me*/

        public string invertedWord(string array1)//method that receives a string as a parameter
        {
            string answer = "";//Variable empty
            char[] delimiterChars = { ' ' };//Variable that keeps me delimiter split
            string[] words = array1.Split(delimiterChars);

            foreach (var word in words)//reccore arrangement for each element delimited space
            {
                string array_two = "";//variable that will help us to store the new string
                foreach (var accountant in word.ToCharArray())
                {//runs the arrangement and extract each word element of the variable and assigns it to the new Variable

                    array_two = accountant + array_two;//variable that adds up
                }
                answer = answer + array_two + " ";//variable that stores the string in reverse
            }
            Console.Write(answer);
            Console.ReadKey();//stops the console
            return answer;//You will return this variable to the specified value
        }
    }

    class Program//class
    {
        static void Main(string[] args)//Main
        {
            InvertedWord instance = new InvertedWord();//creates an instance of the class
            string test = "Estoy feliz los Viernes";//vector containing the values
            string val = instance.invertedWord(test);// values ​​obtained
        }
    }
}
