using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico avisosTrafico = new AvisosTrafico();

            avisosTrafico.MostrarAviso();

            AvisosTrafico avisosTrafico2 = new AvisosTrafico("Jefatura Provinicial","Sancion de velocidad: USD300","02-03-2020");
            
            Console.WriteLine(avisosTrafico2.GetFecha());
            avisosTrafico2.MostrarAviso();
        }
    }
}
