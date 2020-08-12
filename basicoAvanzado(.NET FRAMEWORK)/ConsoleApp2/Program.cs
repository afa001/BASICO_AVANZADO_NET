//IMPORTACIONES, Clases predefinidas y clases creadas por nosotros
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //METODOS main
        static void Main(string[] args)
        {
            //SWITCH
            //Todo lo que puedo hacer con los switch lo puiedo hacer con los if
            //No todo lo que puedo hacer con los if lo puedo hacer con los switch


            ////SINTAXIS BASICA
            ////VARIABLE
            ////declarar variable es crear/ contruir 
            ////Espacio en la memoria ram del ordenador donde se almacenara un valor que podra cambiar durante la ejecucion del programa
            ////No comenzar el nombre de la variable con un guion bajo _edad
            ////No crear mas de una varbiable que se diferencien solo por una letra -> Edad, edad. EDAD
            ////Si el nombre de la variable esta compuesta por mas de una palabra comenzar la segunda con mayuscula -> edadAlumno, edadPersona   
            ////al crear una variable se hace asi tipodato/nombreVaribale -> int edad;Persona persona;
            //int edad = 23;

            //Console.WriteLine("Tu edad es: " + edad + "años"); //concatenacion

            ////OPERADORES ARITMETICOS
            //Console.WriteLine("_______________OPERADORES ARITMETICOS_____________");
            //Console.WriteLine(5 + 7);
            //Console.WriteLine("operadores aritmeticos / division " + 5.0 / 2.0);
            //Console.WriteLine("Bienvenido al curso de c#"); //escrbe o imprime un texto en la consola

            //edad += 7;    //incremento +7
            ////edad++;//incremento
            ////edad--;//decremento
            //Console.WriteLine("Tienes una edad de " + edad);


            //Console.WriteLine("_______________CONVERSIONES EXPLICITAS E IMPLICITAS - CASTING_____________");

            ////CONVERSIONES EXPLICITAS E IMPLICITAS - CASTING 

            ////conversion explcita 
            ////puedo convertir distintos tipos de datos
            //double temperatura = 34.5;
            //int temperaturaMadrid;

            //temperaturaMadrid = (int)temperatura;

            ////conversion implicita
            ////puedo convertir tipos compatibles pero de diferente alcanze
            //int habitantesCiudad = 10000000;
            //long habitantesCiudad2020 = habitantesCiudad;

            //Console.WriteLine(habitantesCiudad2020);

            //float pesoMaterial = 5.78F;
            //double pesoMaterialPrec = pesoMaterial;
            //Console.WriteLine(pesoMaterialPrec);

            ////conversiones de tipo TypeConversion - conversiones no compatibles
            ////conversiones de texto a numero, de texto a primitivo

            //Console.WriteLine("Introduce el primer numero");
            //int num1 = int.Parse(Console.ReadLine()); //la app se queda a la espera de que el usuario introduzca datos
            //Console.WriteLine("Ingrese el segundo numero");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("El resultado de los digitos que introduciste es "+(num1 + num2));

            ////CONSTANTES
            ///*Espacio en la memoria del ordenador donde se almacenara un valor que no podrà cambiar durante la ejecucion del programa
            // las constantes deben iniciar en la misma linea
            // recomendacion de usar las constantes en mayusculas*/

            //const int VALOR = 5; //No puedo cambiar su valor, siempre sera 5;
            //const int VALOR2 = 7;
            //Console.WriteLine("_______________CONSTANTES_____________");
            //Console.WriteLine("El valor de la constante es: {0}",VALOR);//puedo usar el console.writeline si lo hago con argumentos sin necesidad de concatenar, uso {0} para reflejar
            //Console.WriteLine("El valor de la constante es: {1}",VALOR,VALOR2);//con el uso de {1} hagop referencia  a que parametro mostrar en pantalla
            //Console.WriteLine("Impriendo el valor de la constante en concatenacion: "+VALOR2);//Imprimo de manera habitual

            ////METODOS
            ///*Grupo de sentencias(Instrucciones) a las que se les da un nombre identificativo que realizan una tarea o una accion en concreto
            //se realiza en un momento determinado, si un metodo no es llamado jamas se ejecutara, solo se ejecuta cuando este metodo es llamado*/

            ////sintaxis - identificado tipoDato nombre(//parametros,parametrosopciones){cuerpodelmetodo}
            ////Declaracion y llamada de metodos
            ////paso de pàrametros

            ////Existen metodos estaticos, quiere decir que no necesito crear un objeto de la clase para llamarlo a la ejecucion
            //MensajePantalla(); //metodo sin paso de parametros
            //SumaNumeros(1,3);//metodo paso de parametros
            //Console.WriteLine(ReturnSumaNumeros(1,3));//metodo devuelve valor
            //Console.ReadLine();

            //SOBRECARGA
            /* se refiere a la posibilidad de tener dos o más funciones con el mismo nombre pero funcionalidad diferente. 
            Es decir, dos o más funciones con el mismo nombre realizan acciones diferentes. 
            El compilador usará una u otra dependiendo de los parámetros usados.
            A esto se llama también sobrecarga de funciones */

            //Console.WriteLine(Multiplicacion(2, 2)); //return 4
            //Console.WriteLine(Multiplicacion(2, 2.4)); //return  4.8
            //Console.WriteLine(Multiplicacion(2, 2, 2)); //return 8

            //PARAMETROS OPCIONALES
            //int valor1 = 7;
            //double valor2 = 5.2;
            //double valor3 = 8.3;

            //METODOS PARAMETROS OPCIONALES
            ///*c# nos permite hacer uso de parametros opcionales en nuetros metodos y
            //la regla para pasara parametros opcionales es primero los requeridos y en ultimas los opcionales*/
            //Console.WriteLine(SumaParametroOpcional(valor1, valor2));
            //Console.Read();

            //////ESTRUCTURAS DE CONTROL DE FLUJO
            //////Gracias a las estrucutras de control de flujo nuestras aplicaciones toman sus propias decisiones
            //////Evaluan constantemente expresiones booleanas o es true,cierto o es false,falso
            ////bool haceFrio; //variable que admite dos valores true, o false
            ////haceFrio = true;

            ////Console.WriteLine(!haceFrio); //! valor aritmetico que invierte el valor de bool 
            ////Console.Read();

            ////>=
            ////==
            ////&&
            ////or

            //int edad = 23;
            //bool carnet = false;

            //Console.WriteLine("Ya tenemos tus datos son los siguientes, edad: "+edad+" carnet:"+carnet);
            //Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");


            //if (edad>=18 && carnet==true)
            //{
            //    Console.WriteLine("Puedes conducir un vehiculo, vamos a pedir tus datos basicos:");

            //    Console.WriteLine("Ingrese, Nombres completos:");
            //    string nombresCompletos = Console.ReadLine();

            //    Console.WriteLine("Ingrese, Correo Electronico:");
            //    string correoElectronico = Console.ReadLine();

            //    if (nombresCompletos!=null && correoElectronico!=null)
            //    {
            //        Console.WriteLine("Perfecto un gusto saludarte, "+nombresCompletos);
            //        Console.Read();
            //    }                 
            //}
            //else
            //{
            //    Console.WriteLine("Lo siento pero no puedes conducir vehiculos");
            //    Console.Read();
            //}

        }

        //METODOS
        static void MensajePantalla()
        {
            Console.WriteLine("_______________METODOS_____________");
            Console.WriteLine("Metodo MensajePantalla() { Esto es un mensaje desde el metodo MensajePantalla }");
        }

        static void SumaNumeros(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Metodo SumaNumeros() { La suma de los numeros por parametros es: "+sum+" }");
        }

        static int ReturnSumaNumeros(int num1, int num2)
        {
            return num1 + num2; 
        }

        //AMBITO
        int numero1 = 5; //ambito de clase
        int numero2 = 5; //ambito de clase

        void PrimerMetodo()
        {
            int numero1 = 5; //ambito local
            int numero2 = 7; //ambito local

            Console.WriteLine(numero1+numero2);
        }

        void SegundoMetodo()
        {
            //Console.WriteLine(numero1); No es posible porque la variable numero1 no esta en el ambito de ser usada aqui   
        }

        //SOBRECARGA
        //mtd multiplica dos numeros int
        static int Multiplicacion(int operador1, int operador2) 
        {
            return operador1 * operador2;
        }

        //mtd que multiplica un int y un double
        static double Multiplicacion(int numero1, double numero2) 
        {
            return numero1 * numero2;
        }

        //mtd que multplica dos int y un doouble
        static double Multiplicacion(int numero1, double numero2 , int numero3) 
        {
            return numero1 * numero2 * numero3;
        }

        //METODOS PARAMETROS OPCIONALES
        //double num3 toma el valor por defecto y sabe que es parametro opcional 
        private static double SumaParametroOpcional(int num1,double num2, double num3=0)
        {
            return num1 + num2 + num3;
        }
    }
}

//Existen Clases propias, Clases predefinidas de c#

////no se pueden tener dos clases con el mismo nombre en el mismo namespace (espacio de nombres)
////la unica manera es crear dos namespaces distintos
//namespace OtrosEspacioNombres
//{
//    class Program
//    {

//    }
//}

//Output, se nos informa de todos los errores o abvertencias que puede tener nuestra aplicacion

//operadores aritmeticos
/*
se usan con valores numericos
incremetos ++
decrementos -- 
 */
