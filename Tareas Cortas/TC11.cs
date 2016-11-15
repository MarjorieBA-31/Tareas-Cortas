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
	Tarea Corta 11
	Estudiante: [Marjorie Yosibel Blandon Aguilar]
	
	Enunciado:
	Sub arreglo de suma minima:
	Si se recibe un arreglo con N enteros positivos, y se recibe un numero K, retornar el subarreglo mas corto de numeros cuya sumatoria es mayor o igual al numero K.
	Ejemplo
	[2,3,1,2,4,3], 7 -> [4,3] tiene el largo minimo de numeros que sumados son iguales o mayores a 7.
*/

//Your code starts here



    public class Arreglo_mas_pequeño//Class
    {
        /*This was how I came up first was to make for that through me the 
        arrangement and if I found a number equal to the passed parameter 
        I imprint it and leave the program if it does not happen I made another 
        two for that roam me the settlement and ordered me high to low after the
        hiba adding this pole to be equal or exceed the number received as parameter 
        and if it were so it would print out and arrangement*/

        public int[] Arreglo_Menor(int[] quantity, int entry_number)//method receives an integer and an array as a parameter
        {
            int auxiliary_variable = 0;//Variable empty
            int stored_numbers = 0;//Variable empty
            int accountant = 0;//Variable empty
            int accountant1 = 0;//Variable empty
            int number = 0;//Variable empty
            //print if there is an equal number in the array, this arrangement is messy
            for (accountant = 0; accountant < quantity.Length; accountant++)//runs through the arrangement
            {
                if (quantity[accountant] == entry_number)//if you find a number in the array equal to the last number by entering the condition parameter
                {
                    number = quantity[accountant];//stores the number
                    Console.WriteLine("\nArrangement become smaller:\n" + number);//prints the message and the response
                    break;//It exits as soon as the areglo is greater than integer introduced
                }
            }

            //Order the numbers from highest to lowest
            for (accountant = 0; accountant < quantity.Length; accountant++)//comensando for entering the counter from the zero position
            {
                for (accountant1 = accountant + 1; accountant1 < quantity.Length; accountant1++)//comensando for entering the counter from the one position
                {
                    if (quantity[accountant] < quantity[accountant1])//enters the condition depending on whether the first is less
                    {
                         auxiliary_variable = quantity[accountant];//store the number in that position
                        quantity[accountant] = quantity[accountant1];//stores the number in the other position
                        quantity[accountant1] = auxiliary_variable;//at the end you are left with the correct number
                    }


                }

            }

            if (number == 0)//at the end you are left with the correct number
            {
                //me imprime los numeros que sumado dan al ingresado por el usuario
                Console.WriteLine("\nArrangement become smaller:\n");//prints the message 

                //va imprimiendo los numeros de mayor a menor y los va sumando asta llegar a la cantidad del entero
                for (accountant = 0; accountant < quantity.Length; accountant++)
                {
                    Console.Write(quantity[accountant] + " ");//prints the response
                    stored_numbers = stored_numbers + quantity[accountant];//sum
                    if (stored_numbers >= entry_number)// It exits if this variable is already higher
                    {
                        break;//It exits as soon as the areglo is greater than integer introduced
                    }
                }

            }
            return quantity;//You will return this variable to the specified value
        }

    }
    public class Program//class
    {

        static void Main(string[] args)//Main
        {
            //Busca apartir de un arreglo convertirlo en otro mas pequeño
            Arreglo_mas_pequeño instance = new Arreglo_mas_pequeño();//creates an instance of the class
            int[] test= { 1,5,6,3,2};//vector containing the values
            int user_number = 11;//Number I want you to return me or greater
            int[] val = instance.Arreglo_Menor(test, user_number);// values ​​obtained
            Console.Read();//Stops the console
        }

    }

}