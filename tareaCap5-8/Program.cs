using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace tareaCap5_8
{
    class Program
    {   
        //funcion TITULOS DEL MENU INICIAL
        static void TitulosGenerales(){
            Console.WriteLine("EJERCICIOS PRACTICOS || CAPITULO 1-5");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("1- Capitulo 5");
            Console.WriteLine("2- Capitulo 6");
            Console.WriteLine("3- Capitulo 7");
            Console.WriteLine("4- Capitulo 8");
            Console.WriteLine("0- Salir");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Elegir una opcion -> ");
        }
        //FUNCIONES DE LOS PROBLEMAS DEL CAPITULO 5
        //funcion que retorna el factorial de un numero
        static int Factoral(int numero){
            int f = 1;
            for(int i = 1; i <= numero; i++){
                f *= i;
            }
            Console.Write("El factorial de {0} es --> {1}",numero, f);
            return f;
        }
        //funcion que retorna el nombre el numero escrito
        static void Main(string[] args)
        {
            //variables generales
            string entrada = "";
            int nav;
            int navCap5;
            int navCap6;
            int navCap7;
            int navCap8;
            //variable para opciones capitulo 5
            
            //ejercicio 5.1
                 int numeroFactorial;
            // ejercicio 5.2
                int digitarNumero;
            //variable para opciones capitulo 6
            //ejercicio 6.1
            // Variables necesarias
				int cantidad=0; // Cantidad de alumnos 
                int salones=0; // Cantidad de salones
				int n=0; // Variable de control de ciclo salones
				int m=0; // Variable de control del ciclo alumnos 
            //variable para opciones capitulo 7
            //variable para opciones capitulo 8
            
            do{
                TitulosGenerales();  
                entrada = Console.ReadLine();
                nav = Convert.ToInt32(entrada);

                switch(nav){
                //CAPITULO 5
                    case 1:
                        System.Console.Clear();
                        Console.WriteLine("1- Hacer una función que calcule el factorial de un número.");
                        Console.WriteLine("2- Hacer una función que dado un número nos regrese una cadena donde se encuentre escrito en palabras.");
                        Console.WriteLine("0- Atras");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.Write("Elegir una opcion ->");
                        entrada = Console.ReadLine();
                        navCap5 = Convert.ToInt32(entrada);
                        switch(navCap5){
                            case 1:
                                System.Console.Clear();
                                Console.Write("escribir un numero ->");
                                entrada = Console.ReadLine();
                                numeroFactorial = Convert.ToInt32(entrada);
                                Factoral(numeroFactorial);
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                            break;
                            case 2:
                                System.Console.Clear();
                                Console.Write("Escribir un numero 0 - 10 --> ");
                                do{
                                    entrada = Console.ReadLine();
                                    digitarNumero = Convert.ToInt32(entrada);
                                }while(digitarNumero < 0 && digitarNumero > 10);
                                switch(digitarNumero){
                                    case 0:
                                        Console.WriteLine("CERO");
                                    break;
                                    case 1:
                                        Console.WriteLine("UNO");
                                    break;
                                    case 2:
                                        Console.WriteLine("DOS");
                                    break;
                                    case 3:
                                        Console.WriteLine("TRES");
                                    break;
                                    case 4:
                                        Console.WriteLine("CUATRO");
                                    break;
                                    case 5:
                                        Console.WriteLine("CINCO");
                                    break;
                                    case 6:
                                        Console.WriteLine("SEIS");
                                    break;
                                    case 7:
                                        Console.WriteLine("SIETE");
                                    break;
                                    case 8:
                                        Console.WriteLine("OCHO");
                                    break;
                                    case 9:
                                        Console.WriteLine("NUEVE");
                                    break;
                                    case 10:
                                        Console.WriteLine("DIEZ");
                                    break;
                                    default:
                                        System.Console.Clear();
                                    break;

                                }
                            break;
                            default:
                                System.Console.Clear();
                            break;
                    }
                    break;
                //CAPITULO 6
                    case 2:
                        System.Console.Clear();
                        Console.WriteLine("1- Agregar el cálculo del promedio para el programa con arreglo jagged.");
                        Console.WriteLine("2- Agregar el cálculo de la menor calificación para el programa con arreglo jagged.");
                        Console.WriteLine("3- Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.");
                        Console.WriteLine("4- Modificar el programa de la escuela para que utilice funciones.");
                        Console.WriteLine("5- Crear un programa que pase un arreglo jagged como parámetro a una función.");
                        Console.WriteLine("0- Atras");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.Write("Elegir uan opcion -->");
                        entrada = Console.ReadLine();
                        navCap6 = Convert.ToInt32(entrada);
                        switch(navCap6){
                            case 1:
                                System.Console.Clear();
                                // Pedimos la cantidad de salones 
                                Console.WriteLine("Dame la cantidad de salones"); 
                                entrada=Console.ReadLine(); 
                                salones=Convert.ToInt32(entrada);

                                // Creamos el arreglo
				                float[][] calif= new float [salones][];

                                // Pedimos los alumnos por salon
                                for(n=0;n<salones;n++) // Ciclo salones 
                                {
                                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}",n); 
                                entrada=Console.ReadLine(); 
                                cantidad=Convert.ToInt32(entrada);
                                
                                // Instanciamos el arreglo 
                                calif[n]=new float[cantidad];
                                }
                                
                                // Capturamos la información 
                                for(n=0;n<salones;n++) // Ciclo salones 
                                {
                                    Console.WriteLine("Salon {0}",n); 
                                    for(m=0;m<calif[n].GetLength(0);m++) //Ciclo alumnos
                                    {
                                        Console.Write("Dame la calificación");
                                        entrada=Console.ReadLine(); 
                                        calif[n][m]=Convert.ToSingle(entrada);
                                    } 			
                                }

                                // Desplegamos la información 
                                Console.WriteLine("—— Información ——");
                                for (n = 0; n < salones; n++) // Ciclo salones 
                                {
                                    Console.WriteLine("Salon {0}", n);
                                    for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos 
                                    {
                                        Console.WriteLine("El alumno {0} tiene {1} ", m, calif[n][m]);
                                        Console.WriteLine("\tEl promedio de calificaciones de este salon es: {0}", calcularPromedio(calif, n));
                                    }
                                }
                                
                                //funcion que calcula el promedio de las calificaciones de los alumnos
                                static float calcularPromedio(float[][] array, int n)
                                {
                                    int m;
                                    float suma = 0;
                                    int cantidad = array[n].GetLength(0);

                                    for (m = 0; m< array[n].GetLength(0); m++)
                                    {
                                        suma += array[n][m];
                                    }

                                    return (suma / cantidad);
                                }
                               

                            break;
                            case 2:
                            System.Console.Clear();
                                // Pedimos la cantidad de salones 
                                Console.WriteLine("Dame la cantidad de salones"); 
                                entrada=Console.ReadLine(); 
                                salones=Convert.ToInt32(entrada);

                                // Creamos el arreglo
				                float[][] calif1= new float [salones][];

                                // Pedimos los alumnos por salon
                                for(n=0;n<salones;n++) // Ciclo salones 
                                {
                                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}",n); 
                                entrada=Console.ReadLine(); 
                                cantidad=Convert.ToInt32(entrada);
                                
                                // Instanciamos el arreglo 
                                calif1[n]=new float[cantidad];
                                }

                                // Capturamos la información 
                                for(n=0;n<salones;n++) // Ciclo salones 
                                {
                                    Console.WriteLine("Salon {0}",n); 
                                    for(m=0;m<calif1[n].GetLength(0);m++) //Ciclo alumnos
                                    {
                                        Console.Write("Dame la calificación");
                                        entrada=Console.ReadLine(); 
                                        calif1[n][m]=Convert.ToSingle(entrada);
                                    } 				
                                }

                                // Desplegamos la información 
                                Console.WriteLine("—— Información ——");
                                for (n = 0; n < salones; n++) // Ciclo salones 
                                {
                                    Console.WriteLine("Salon {0}", n);
                                    for (m = 0; m < calif1[n].GetLength(0); m++) // Ciclo alumnos 
                                    {
                                        Console.WriteLine("El alumno {0} tiene {1} ", m, calif1[n][m]);
                                        Console.WriteLine("\tLa calificacion menor de este salon es: {0}", calcularMenor(calif1, n));
                                    }
                                }
                                //funcion que me devuelve la calificacion menor 
                                static float calcularMenor(float[][] array, int n)
                                {
                                    int m;
                                    float menor = array[n][0];

                                    for (m = 1; m < array[n].GetLength(0); m++)
                                    {
                                        if(array[n][m] < menor)
                                        {
                                            menor = array[n][m];
                                        }
                                    }

                                    return menor;
                                }
                            break; 
                            case 3:
                            System.Console.Clear();
                                // Pedimos la cantidad de salones 
                                Console.WriteLine("Dame la cantidad de salones"); 
                                entrada=Console.ReadLine(); 
                                salones=Convert.ToInt32(entrada);

                                // Creamos el arreglo
				                float[][] calif2= new float [salones][];

                                // Pedimos los alumnos por salon
                                for(n=0;n<salones;n++) // Ciclo salones 
                                {
                                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}",n); 
                                entrada=Console.ReadLine(); 
                                cantidad=Convert.ToInt32(entrada);
                                
                                // Instanciamos el arreglo 
                                calif2[n]=new float[cantidad];
                                }

                                // Capturamos la información 
                                for(n=0;n<salones;n++) // Ciclo salones 
                                {
                                    Console.WriteLine("Salon {0}",n); 
                                    for(m=0;m<calif2[n].GetLength(0);m++) //Ciclo alumnos
                                    {
                                        Console.Write("Dame la calificación");
                                        entrada=Console.ReadLine(); 
                                        calif2[n][m]=Convert.ToSingle(entrada);
                                    } 				
                                }

                                // Desplegamos la información 
                                Console.WriteLine("—— Información ——");
                                for (n = 0; n < salones; n++) // Ciclo salones 
                                {
                                    Console.WriteLine("Salon {0}", n);
                                    for (m = 0; m < calif2[n].GetLength(0); m++) // Ciclo alumnos 
                                    {
                                        Console.WriteLine("El alumno {0} tiene {1} ", m, calif2[n][m]);
                                        Console.WriteLine("\tLa calificacion mayor de este salon es: {0}", calcularMayor(calif2, n));
                                    }
                                }
                                //funcion que me devuelve la calidicacion mayor
                                static float calcularMayor(float[][] array, int n)
                                {
                                    int m;
                                    float mayor = array[n][0];

                                    for (m = 1; m < array[n].GetLength(0); m++)
                                    {
                                        if (array[n][m] > mayor)
                                        {
                                            mayor = array[n][m];
                                        }
                                    }

                                    return mayor;
                                }

                            break;
                            case 4:
                            System.Console.Clear();
                                // Pedimos la cantidad de salones 
                                Console.WriteLine("Dame la cantidad de salones"); 
                                entrada=Console.ReadLine(); 
                                salones=Convert.ToInt32(entrada);

                                // Creamos el arreglo
				                float[][] calif3= new float [salones][];

                                // Pedimos los alumnos por salon
                                for(n=0;n<salones;n++) // Ciclo salones 
                                {
                                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}",n); 
                                entrada=Console.ReadLine(); 
                                cantidad=Convert.ToInt32(entrada);
                                
                                // Instanciamos el arreglo 
                                calif3[n]=new float[cantidad];
                                }

                                // Capturamos la información 
                                for(n=0;n<salones;n++) // Ciclo salones 
                                {
                                    Console.WriteLine("Salon {0}",n); 
                                    for(m=0;m<calif3[n].GetLength(0);m++) //Ciclo alumnos
                                    {
                                        Console.Write("Dame la calificación");
                                        entrada=Console.ReadLine(); 
                                        calif3[n][m]=Convert.ToSingle(entrada);
                                    } 				
                                }

                                // Desplegamos la información 
                                Console.WriteLine("—— Información ——");
                                for (n = 0; n < salones; n++) // Ciclo salones 
                                {
                                    Console.WriteLine("Salon {0}", n);
                                    for (m = 0; m < calif3[n].GetLength(0); m++) // Ciclo alumnos 
                                    {
                                        Console.WriteLine("El alumno {0} tiene {1} ", m, calif3[n][m]);
                                        Console.WriteLine("\tEl promedio de calificaciones de este salon es: {0}", calcularPromedio(calif3, n));
                                        Console.WriteLine("\tLa calificacion menor de este salon es: {0}", calcularMenor(calif3, n));
                                        Console.WriteLine("\tLa calificacion mayor de este salon es: {0}", calcularMayor(calif3, n));
                                    }
                                }
                                //Esta version del programa de la escuela utiliza funciones 
                            break;
                            case 5:
                            System.Console.Clear();
                                int[][] arregloJagged = new int[][] {
                                    new int[] {8,6,7,4,5,2},
                                    new int[] {7,2},
                                    new int[] {2,3,4}
                                };

                                static void mostrar(int[][] arregloJagged, int n)
                                {
                                    int m;
                                    for (m = 0; m < arregloJagged[n].GetLength(0); m++)
                                    {
                                        Console.WriteLine("\n{0}", arregloJagged[n][m]);
                                    }
                                }
                                mostrar(arregloJagged,0);
                                mostrar(arregloJagged, 1);
                                mostrar(arregloJagged, 2);
                            break;
                            default:
                            System.Console.Clear();
                            break;

                        }
                    break;
                //CAPITULO 7
                    case 3:
                        System.Console.Clear();
                        Console.WriteLine("1- Hacer el programa que calcula el promedio, calificación máxima y mínima de un salón de clases usando el ArrayList.");
                        Console.WriteLine("2- Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable.");
                        Console.WriteLine("3- Hacer un programa que funcione como una agenda telefónica y que guarde el nombre de la persona y su número telefónico.");
                        Console.WriteLine("0- Atras");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.Write("Elegir una opcion --> ");
                        entrada = Console.ReadLine();
                        navCap7 = Convert.ToInt32(entrada);
                        switch(navCap7){
                            case 1:
                            System.Console.Clear();
                            float calificacion = 0;
                            float sumatoria = 0.0f;
                            float promedio = 0.0f;
                            float maxima = 0.0f;
                            float minima = 0.0f;
                            int cantidadL = 0;
                            int i;
                            
                           

                            ArrayList alumnos = new ArrayList();

                            Console.WriteLine("Digite la cantidad de estudiantes: ");
                            cantidadL = Convert.ToInt32(Console.ReadLine());

                            for(i = 0; i < cantidadL; i++)
                            {
                                Console.WriteLine("Digite la calificacion: ");
                                calificacion = Convert.ToSingle(Console.ReadLine());
                                alumnos.Add(calificacion);
                            }

                            maxima = 0;
                            minima = calificacion;

                            foreach (float no in alumnos)
                            {
                                if (no > maxima)
                                    maxima = n;

                                if (no < minima)
                                    minima = n;

                                sumatoria += n;
                            }

                            promedio = sumatoria / cantidad;



                            Console.WriteLine("\n\nEl promedio es:{0}", promedio);
                            Console.WriteLine("La calificacion maxima es: {0}", maxima);
                            Console.WriteLine("La calificacion minima es: {0}", minima);
                            break;
                            case 2:
                            System.Console.Clear();

                            

                            static void diccionarioHash()
                            {
                                int contador = 0;
                                int opcion = 0;
                                string palabra = "";
                                string definicion = "";
                                Hashtable diccionario = new Hashtable();
                                do
                                {
                                    Console.WriteLine("1- Agregar definiciones");
                                    Console.WriteLine("2- Mostrar palabras");
                                    Console.WriteLine("3- Salir: ");
                                    Console.WriteLine("\nDigite la opcion deseada: ");
                                    opcion = Convert.ToInt32(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            {
                                                contador = 1;
                                                Console.WriteLine("Digite la palabra: ");
                                                palabra = Console.ReadLine();

                                                Console.WriteLine("Digite la definicion: ");
                                                definicion = Console.ReadLine();

                                                diccionario.Add(palabra, definicion);
                                                Console.ReadKey();
                                                break;
                                            }

                                        case 2:
                                            {
                                                if(contador != 0)
                                                {
                                                    Console.WriteLine("**--Las palabras guardadas--***");
                                                    foreach (DictionaryEntry aux in diccionario)
                                                        Console.WriteLine(aux.Key + " : " + aux.Value);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe de agregar una palabra con su definicion antes de buscar");
                                                }
                                                Console.ReadKey();
                                                break;
                                            }
                                        case 3:
                                            {
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Opcion mal");
                                                break;
                                            }
                                    }

                                } while (opcion != 3);
                            }
                            diccionarioHash();
                            break;
                            case 3:
                            System.Console.Clear();

                            static void metodoAgenda()
                            {
                                int opcion = 0;
                                string nombre = "";
                                string numero = "";
                                int contador = 0;
                                Hashtable agenda = new Hashtable();
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("1- Agregar Contacto");
                                    Console.WriteLine("2- Mostrar Contactos");
                                    Console.WriteLine("3- Salir: ");
                                    Console.WriteLine("\nDigite la opcion deseada: ");
                                    opcion = Convert.ToInt32(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            {
                                                Console.Clear();
                                                contador = 1;
                                                Console.WriteLine("***---Añadir contacto---***");
                                                Console.WriteLine("Digite el nombre: ");
                                                nombre = Console.ReadLine();

                                                Console.WriteLine("Digite el numero: ");
                                                numero = Console.ReadLine();

                                                agenda.Add(nombre, numero);
                                                Console.ReadKey();
                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.Clear();
                                                if (contador != 0)
                                                {
                                                    Console.WriteLine("***--Contactos guardados--***");
                                                    Console.WriteLine("Nombre : Numero\n");
                                                    foreach (DictionaryEntry contacto in agenda)
                                                        Console.WriteLine(contacto.Key + " : " + contacto.Value);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Debe de agregar una palabra con su definicion antes de buscar");
                                                }
                                                Console.ReadKey();
                                                break;
                                            }
                                        case 3:
                                            {
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Opcion mal");
                                                break;
                                            }
                                    }

                                } while (opcion != 3);
                            }
                            metodoAgenda();   

                            break;
                            default:
                            System.Console.Clear();
                            break;
                        }
                    break;
                //CAPITULO 8
                    case 4:
                        System.Console.Clear();
                        Console.WriteLine("1- Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.");
                        Console.WriteLine("2- Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.");
                        Console.WriteLine("0- Atras");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.Write("Elegir una opcion --> ");
                        entrada = Console.ReadLine();
                        navCap8 = Convert.ToInt32(entrada);
                        switch(navCap8){
                            case 1:
                            System.Console.Clear();

                            static void AmFm(){
                                string hora;

                                hora = string.Format("Fecha Actual es: {0: h: m tt yyy / d / m}", DateTime.Now);
                                Console.WriteLine(hora);
                            }

                            AmFm();

                            break;
                            case 2:
                            System.Console.Clear();

                            static void metodoCadena(){
                                string cadena1, cadena2;
                                int comparar;

                                Console.WriteLine("Digite la cadena 1 : ");
                                cadena1 = Console.ReadLine();
                                Console.WriteLine("Digite la cadena 2: ");
                                cadena2 = Console.ReadLine();

                                comparar = string.Compare(cadena2, cadena2);

                                if(comparar > 0)
                                {
                                    Console.WriteLine("\t {0} \n\t {1}", cadena2, cadena1);
                                }
                                else
                                {
                                    Console.WriteLine("\t {0} \n\t {1}", cadena1, cadena2);
                                }
                            }

                            metodoCadena();
                            break;
                            default:
                            System.Console.Clear();
                            break;
                        }
                    break;
                //CASO SALIR
                    default:
                        System.Console.Clear();
                        Console.WriteLine("GRACIAS POR UTILIZAR EL PROGRAMA :) ");
                    break;

            }

            }while(nav != 0);
        }
    }
}
