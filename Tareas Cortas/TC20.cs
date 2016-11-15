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
	Identificador de numeros primos, escriba una funcion que indique si un numero recibido es primo o no, tome en cuenta que el numero recibido estará en un rago de 
	1 a 5000.
*/

//Your code starts here


public class PrimeNumbers//class
    {
        /*I chose this way to solve the problem that I found it simple
                Primiro did an if you enter only if the number was less than 5000 
                once inside was created a for where you have a condition that if the 
                number was divisible between the counter and the resudio was wax increase
                by singer but it count was equal to two I will return true if not a fake*/

        public bool primeNumbers(int array)//method that receives or integer as a parameter
        {
            bool answer = false;//variable false value
            int accountant = 0;//variable empaty
            if (array >= 1 && array <= 5000)//enters this condition if the number is between 1 and 5000
            {
                for (int accountant1 = 1; accountant1 <= array; accountant1++)//runs an arrangement
                {
                    if (array % accountant1 == 0)//number is divisible against two and reciduo is cer
                    {
                        accountant++;//Variable is increased
                    }
                }
                if (accountant == 2)//comes if the counter is equal to two
                {
                    answer = true;// variable true value
                    Console.WriteLine(answer);//prints true
                }
                else
                {
                    answer = false;// variable false value
                    Console.WriteLine(answer);//prints false
                }
            }
            else
            {
                Console.WriteLine("Enter a number between 1 and 5000");//prints the message
            }
            //Console.WriteLine(answer);
            Console.ReadKey();//Stops the console
            return answer;//You will return this variable to the specified value
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers instance = new PrimeNumbers();//creates an instance of the class
            int test =5;//Number I want you to return me or greater
            bool val = instance.primeNumbers(test);// values ​​obtained
            Console.ReadKey();//Stops the console
        }
    }
}



