using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Practico_4
{
    public partial class MODIFICACION_Tarea : Form
    {
        Form1 Principal;
        string fechaAModificar;
        string horaAModificar;
        string actividadAModificar;
        string estadoAModificar;
        Tarea tareaAModificar;
        public MODIFICACION_Tarea(Form1 Padre, string fechaAModif, string horaAModif, string actividadAModif, string estadoAModif)
        {

            Principal = Padre;
            fechaAModificar = fechaAModif;
            horaAModificar = horaAModif;
            actividadAModificar = actividadAModif;
            estadoAModificar = estadoAModif;
            tareaAModificar = new Tarea(DateTime.Parse(fechaAModificar), horaAModificar,actividadAModificar, estadoAModificar);
            InitializeComponent();
            dtpFechaTarea.Value = DateTime.Parse(fechaAModificar);
            tbHora.Text = horaAModificar;
            tbActividad.Text = actividadAModificar;
            var estadosPosibles = new[] { Principal.ESTADO_TAREA_NO_REALIZADA, Principal.ESTADO_TAREA_REALIZADA, Principal.ESTADO_TAREA_SUSPENDIDA };
            cbEstado.DataSource = estadosPosibles;
            
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            string fechaModificada = dtpFechaTarea.Value.ToShortDateString();
            string horaModificada = tbHora.Text;
            string actividadModificada = tbActividad.Text;
            string estadoModificado = cbEstado.Text;
            actualizarLista(tareaAModificar,fechaModificada, horaModificada, actividadModificada,estadoModificado);
            Principal.actualizarGVTareas();
            this.Close();
        }
        public void modificarTarea()
        {
            var documento = XDocument.Load(Principal.RUTA_XML);

            var nuevaTarea = new XElement("tarea",

                new XElement("fecha", dtpFechaTarea.Value.ToShortDateString()),
                new XElement("hora", tbHora.Text),
                new XElement("actividad", tbActividad.Text),
                new XElement("estado", cbEstado.Text));

            documento.Element("agenda").Add(nuevaTarea);
            documento.Save(Principal.RUTA_XML);
            return;
        }

        private void actualizarLista(Tarea tareaAModificar ,string fechaActualizada, string horaActualizada, string actividadActualizada, string estadoActualizado)
        {
            Tarea tareaActualizada = new Tarea(DateTime.Parse(fechaActualizada), horaActualizada, actividadActualizada, estadoActualizado);
             int cantidadTareasEnRegistro = Principal.tarea.Count();
            if (cantidadTareasEnRegistro > 0)
            {
                for (int t = 0; t < cantidadTareasEnRegistro; t++)
                {
                    if (Principal.tarea[t].fecha.ToShortDateString() == DateTime.Parse(fechaAModificar).ToShortDateString() && Principal.tarea[t].hora == horaAModificar && Principal.tarea[t].actividad == actividadAModificar && Principal.tarea[t].estado == estadoAModificar)
                    {
                        Principal.tarea.Remove(Principal.tarea[t]);
                        Principal.tarea.Add(tareaActualizada);
                    }
                }
            }
            Principal.modificarTareaDeXML(tareaAModificar, DateTime.Parse(fechaActualizada), horaActualizada, actividadActualizada, estadoActualizado);

        }
    }
}

