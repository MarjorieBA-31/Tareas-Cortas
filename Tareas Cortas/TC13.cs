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
	Formar el numero mas grande:
	Al recibir un arreglo de enteros, debe ordenarlos para formar el numero mas grande posible.
	Ejemplo:
	[3, 30, 34, 5, 9] -> 9534330
	Notese que el numero formado puede ser muy grande, entonces debe retornar un string en vez de un entero.
*/

//Your code starts here


 public class LargestNumber
    {
        public string largestNumber(int[] quantity)//toma numero del arreglo de enteros y lo convierte en uno solo a strnig
        {
            int auxiliary_variable = 0;//Variable empty
            int accountantt = 0;//Variable empty
            string answer = "";//Variable empty

            //Order the numbers from highest to lowest
            for (int accountant = 0; accountant < quantity.Length; accountant++)//comensando for entering the counter from the zero position
            {
                for (int accountant1 = accountant + 1; accountant1 < quantity.Length; accountant1++)//comensando for entering the counter from the one position
                {
                    if (quantity[accountant] < quantity[accountant1])//enters the condition depending on whether the first is less
                    {
                        auxiliary_variable = quantity[accountant];//store the number in that position
                        quantity[accountant] = quantity[accountant1];//stores the number in the other position
                        quantity[accountant1] = auxiliary_variable;//at the end you are left with the correct number
                    }
                }
            }
            Console.Write("Numero Entero:  ");//prints mensage
            //Printing the numbers goes high to low and adds up until you reach the quantity of the whole
            for (accountantt = 0; accountantt < quantity.Length; accountantt++)//runs the arrangement
            {
                answer = Convert.ToString(quantity[accountantt]);//converts the number to string
                Console.Write(answer);//prints the response
            }
            return answer;
        }

    }
    public class Program//class
    {
        static void Main(string[] args)//Main
        {
            //Busca apartir de un arreglo convertirlo en otro mas pequeño
            LargestNumber instance = new LargestNumber();//creates an instance of the class
            int[] cantidad = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//vector containing the values
            string val = instance.largestNumber(cantidad);// values ​​obtained
            Console.Read();//Stops the console
        }

    }

}
