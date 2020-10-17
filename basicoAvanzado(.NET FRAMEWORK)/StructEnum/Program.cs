using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado(5000000,500000);
            //emp1.CambiarSalario(emp1, 100000);

            Console.WriteLine(emp1);
            Console.ReadLine();
        }
    }

    public struct Empleado
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario y comision del empleado({0},{1})", this.salarioBase, this.comision);
        }

        public void CambiarSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }
    }
}
