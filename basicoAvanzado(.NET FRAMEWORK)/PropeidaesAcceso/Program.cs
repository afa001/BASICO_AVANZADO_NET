using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropeidaesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear empleado
            Empleado emp1 = new Empleado("Anderson");

            //SIN USO DE PROPERTIES

            //emp1.SetSalario(5500000);    //Establecer salario
            //double salarioIncrementado = emp1.GetSalario() + 1000000;    //Incrementar salario  //CORRECTO
            //Console.WriteLine("El Salario de " + emp1.GetNombre() + " es: " + emp1.GetSalario());    //Imprimos texto

            //CON USO DE PROPERTIES

            //Establecer salario
            emp1.SALARIO = 5500000;  //PROPERTIES SET
            //emp1.SALARIO = -100000; //validacionSalario PROPERTIE SET

            //Incrementar salario
            emp1.SALARIO += 1000000; //PROPERTIES SET

            //Imprimimos texto 
            Console.WriteLine("El salario del empleado es: "+emp1.SALARIO); //PROPERTIES GET
            Console.ReadLine();
        }
    }

    class Empleado
    {
        private string nombre;
        private double salario;
        public Empleado(string _nombre)
        {
            this.nombre = _nombre;
        }

        private double ValidarSalario(double _salario)
        {
            if (_salario < 0)
            {
                return 0;
            }
            else
            {
                this.salario = _salario;
                return salario;
            }
        }

        //CREACION PROPERTIE
        //sintaxis - modificadorAcceso+Tipo+NombrePropiedad
        public double SALARIO
        {
            get { return this.salario; }                     //lectura
            set { this.salario = ValidarSalario(value); }    //escritura
        }

        /*
        //Expression Bodie en PROPERTIES, otra nomenclatura haciendo uso de expresiones lamdba
        public double SALARIO
        {
            get => this.salario;
            set => this.salario = ValidarSalario(value);
        }*/

        /*public void SetSalario(double _salario)
        {
            if (_salario<0)
            {
                Console.WriteLine("El Salario no puede ser negativo");
                this.salario = 0;
            }
            else
            {
                this.salario = _salario;
            }
        }

        public double GetSalario()
        {
            return this.salario;
        }

        public string GetNombre()
        {
            return this.nombre;
        }*/
    }
}
