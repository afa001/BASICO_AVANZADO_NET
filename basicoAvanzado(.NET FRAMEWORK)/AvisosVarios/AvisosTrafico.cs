using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    class AvisosTrafico : IAvisos
    {
        private string remitente;
        private string mensaje;
        private string fecha;

        public AvisosTrafico() {
            remitente = "DGT";
            mensaje = "Sancion cometida. Pague antes de 3 dias y se beneficiará de una reduccion en la sancion";
            fecha = "";
        } 

        public AvisosTrafico(string _remitente, string _mensaje, string _fecha)
        {
            remitente = _remitente;
            mensaje = _mensaje;
            fecha = _fecha;
        }

        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine(mensaje);
            Console.ReadLine();
        }
    }
}
