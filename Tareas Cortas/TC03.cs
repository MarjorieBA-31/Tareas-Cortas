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
	Tarea Corta 3
	Estudiante: [Marjorie  Yosibel Blandon Aguilar]
	
	Enunciado:
	Cree una funcion que identifique si un elemento existe en una lista, debe retornar la cantidad de veces que el elemento aparece en la lista, retornara 0 si no aparece.
*/

  public class NumberExistsInAnArray//Class
    {
        /*I chose to do it with a for loop because once I runs through the 
        settlement and in the for this condition which will increase me a variable,
        if given case there is a repeated number and when it comes out completely from
        for the number of times print that he repeated that number*/

        public int NumberOfNumber(int evaluate_the_number, int[] array)//method receives as parameter an array and an integer
        {
            int answer = 0;//Variable empty
            for (int accountant = 0; accountant < array.Length; accountant++)//Runs through the settlement.
                if (array[accountant] == evaluate_the_number)//Entering condition if the number is repeated
                {
                    answer++;//Is storing the number of times that that number
                }
            Console.WriteLine("La cantidad de veces que aparece el numero es: {0}", answer);//Print the message

            return answer;//Retort this variable
        }
    }

    class Program//Class
    {

        static void Main(string[] args)//Main
        {
            NumberExistsInAnArray Repeated = new NumberExistsInAnArray();//intancia class
            int evaluate_the_number = 1;//Variable that stores the number to evaluate
            int[] test = { 8, 1, 6, 6, 11, 1, 6, 6, 1, 6 };//int receiving method
            int val = Repeated.NumberOfNumber(evaluate_the_number, test);//Call the method and the class to pass the chain defined above
            Console.Read();// It keeps the program running until a key is pressed
        }
    }
}



