using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_4
{
    public class Tarea
    {
       public DateTime fecha { get; set; }
       public string hora { get; set; }
       public string actividad { get; set; }
       public string estado { get; set; }

        public Tarea(DateTime fecha, string hora, string activ, string estadoT)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.actividad = activ;
            this.estado = estadoT;
        }
    }
}
