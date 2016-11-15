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
        Escriba una funcion que retorne el elemento mas grande de una lista no ordenada	
    */

    //Your code starts here

    public class MajorNumberOfAnArrangement//Class
    {
        /* I chose this option to solve this problem for any reason the code is smaller
        and why the user can enter through an arrangement the amount of numbers you want to evaluate,
        and then the way to compare each number is the easier and faster because each input cycle can
        compare once which is the highest number.*/

        public int MajorElement(int[] quantity)// Function to find the largest element in a list
        {
            int accountant = 0;//Variable empty
            int stored_numbers = 0;  //Variable empty         

            for (accountant = 0; accountant < quantity.Length; accountant++)//if counter is less than amount enters this cycle
            {//open for

                if (quantity[accountant] > stored_numbers)//if number is less than amount enters the true condition
                {//open if
                    stored_numbers = quantity[accountant];//this variable holds the largest number
                }//if closing
                else
                {//open else
                }//else closing
            }//for closing
            Console.WriteLine(string.Format("El elemento mas grande es: {0}", stored_numbers));//prints the message and the response
            return stored_numbers;//Retort this variable
        }
    }
    public class Program//Class
    {

        static void Main(string[] args)//Main 
        {
            MajorNumberOfAnArrangement bigger_number = new MajorNumberOfAnArrangement();//intancia class
            int[] test = { 7, 1, 6, 11, 7, 4, 2, 5, 3, 7, 66, 45, 77, 2, 4, 6, 126, 56, 3, 2, 5 };//int receiving method
            int val = bigger_number.MajorElement(test);//Call the method and the class to pass the chain defined above  
            Console.Read();// It keeps the program running until a key is pressed

        }

    }

}
