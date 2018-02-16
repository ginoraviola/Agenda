using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace Practico_4
{
    public partial class Form1 : Form
    {
        public List<Tarea> tarea = new List<Tarea>();
        public string RUTA_XML = "Registro.xml";
        public string ESTADO_TAREA_REALIZADA = "Realizada";
        public string ESTADO_TAREA_NO_REALIZADA = "No Realizada";
        public string ESTADO_TAREA_SUSPENDIDA = "Suspendida";
        public string MSJ_FECHA_INVALIDA = "La fecha ingresada es invalida, intentelo nuevamente";
        public string MSJ_HORA_INVALIDA = "La hora ingresada no es correcta, por favor intentelo nuevamente";
        public Form1()
        {
            InitializeComponent();
            if (existeRegistroXML())
            {
                leerRegistroXML();
                actualizarGVTareas();
            }
            else
            {
                crearRegistroXML();
                leerRegistroXML();
                actualizarGVTareas();
            }

        }
        //Esta rutina crea el registro XML y inicializa la agenda
        public void crearRegistroXML()
        {

            XDocument registroXML = new XDocument(
                new XDeclaration("1.0", "utf - 16", "true"),

                      new XElement("agenda"));


            registroXML.Save(RUTA_XML);

        }
        //Funcion para verificar si existe el registro .XML
        public bool existeRegistroXML()
        {
            bool existe = false;
            if (File.Exists(RUTA_XML))
            {
                existe = true;
            }
            else
            {
                existe = false;
            }
            return existe;
        }
        //Lee el registro XML e inserta en una lista las actividades encontradas
        public void leerRegistroXML()
        {
            XmlDocument registroAgenda = new XmlDocument();

            registroAgenda.Load(RUTA_XML);

            XmlNodeList personas = registroAgenda.GetElementsByTagName("agenda");

            XmlNodeList lista =
                ((XmlElement)personas[0]).GetElementsByTagName("tarea");

            foreach (XmlElement nodo in lista)

            {

                int i = 0;

                XmlNodeList fechaTarea =
                nodo.GetElementsByTagName("fecha");

                XmlNodeList horaTarea =
                nodo.GetElementsByTagName("hora");

                XmlNodeList actividadTarea =
                nodo.GetElementsByTagName("actividad");

                XmlNodeList estadoTarea =
                nodo.GetElementsByTagName("estado");

                Tarea regTareas = new Tarea(DateTime.Parse(fechaTarea[i].InnerText), horaTarea[i].InnerText, actividadTarea[i].InnerText, estadoTarea[i++].InnerText);
                tarea.Add(regTareas);
            }

        }

        private void btAgregarTarea_Click(object sender, EventArgs e)
        {
            ALTA_Tarea alta = new ALTA_Tarea(this);

            if (existeRegistroXML())
            {
                alta.Show();
            }
            else
            {
                crearRegistroXML();
                alta.Show();
            }
            actualizarGVTareas();
        }
        //Esta funcion genera una nueva lista con las actividades de cierta fecha seleccionada
        // y muestra en grilla dichas actividades
        public void mostrarTareasPorFecha()
        {
            List<Tarea> tareasPorFecha = new List<Tarea>();
            string fechaSeleccionada = monthCalendar1.SelectionEnd.ToShortDateString();
            int cantidadTareasEnRegistro = tarea.Count();
            if (cantidadTareasEnRegistro > 0)
            {
                for (int t = 0; t < cantidadTareasEnRegistro; t++)
                {
                    if (tarea[t].fecha.ToShortDateString() == fechaSeleccionada)
                    {
                        tareasPorFecha.Add(tarea[t]);
                    }
                }
            }
            dgvTareas.DataSource = null;
            dgvTareas.Columns.Clear();
            dgvTareas.DataSource = tareasPorFecha;
            dgvTareas.Refresh();
        }


        private void btTareasPorFecha_Click(object sender, EventArgs e)
        {
            mostrarTareasPorFecha();
        }
        //Rutina para actualizar Grilla con todas las tareas en la lista
        public void actualizarGVTareas()
        {
            dgvTareas.DataSource = null;
            dgvTareas.Columns.Clear();
            dgvTareas.DataSource = tarea;
            dgvTareas.Refresh();
    


        }
        
        private void btTodasLasTareas_Click(object sender, EventArgs e)
        {
            actualizarGVTareas();
        }

        //Rutina que obtiene los datos de la tarea seleccionada para luego modificarlos
        private void btEditarTarea_Click(object sender, EventArgs e)
        {
            string fechaAModificar = dgvTareas.CurrentRow.Cells[0].Value.ToString();
            string horaAModificar = dgvTareas.CurrentRow.Cells[1].Value.ToString();
            string actividadAModificar = dgvTareas.CurrentRow.Cells[2].Value.ToString();
            string estadoAModificar = dgvTareas.CurrentRow.Cells[3].Value.ToString();
            MODIFICACION_Tarea nModif = new MODIFICACION_Tarea(this, fechaAModificar, horaAModificar, actividadAModificar,estadoAModificar);
            nModif.Show();
            actualizarGVTareas();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarTarea();
        }

        //Rutina que obtiene los datos de la tarea seleccionada para luego eliminarlos
        private void eliminarTarea()
        {
            DateTime fechaAEliminar = DateTime.Parse(dgvTareas.CurrentRow.Cells[0].Value.ToString());
            string horaAEliminar = dgvTareas.CurrentRow.Cells[1].Value.ToString();
            string actividadAEliminar = dgvTareas.CurrentRow.Cells[2].Value.ToString();
            string estadoAEliminar = dgvTareas.CurrentRow.Cells[3].Value.ToString();

            Tarea tareaAEliminar = new Tarea(fechaAEliminar, horaAEliminar, actividadAEliminar,estadoAEliminar);
            eliminarTareaDeXML(tareaAEliminar);

            int indiceDeFilaABorrar = dgvTareas.CurrentRow.Index;
            tarea.Remove(tarea[indiceDeFilaABorrar]);
            actualizarGVTareas();

        }
        //Rutina para eliminar cierta tarea del registro XML
        public static void eliminarTareaDeXML(Tarea actividad)
        {

            XmlDocument agenda = new XmlDocument();
            agenda.Load("Registro.xml");
            XmlNode tareaAEliminar = null;

            XmlElement tareas = agenda.DocumentElement;

            //Obtiene las actividades de la agenda.
            XmlNodeList listaDeTareas = agenda.GetElementsByTagName("tarea");


            foreach (XmlNode tarea in listaDeTareas)
            {
                DateTime fechaDeTarea = Convert.ToDateTime(tarea.FirstChild.InnerText);
                if (Convert.ToString(fechaDeTarea.ToShortDateString()) == Convert.ToString(actividad.fecha.ToShortDateString()))
                {
                    tareaAEliminar = tarea;
                }

            }


            tareas.RemoveChild(tareaAEliminar);
            agenda.Save("Registro.xml");
        }
        //Rutina para modificar cierta tarea del registro XML
        public  void modificarTareaDeXML(Tarea tareaAModificar, DateTime nuevaFecha, string nuevaHora, string nuevaActividad, string nuevoEstado)
        {

            XmlDocument agenda = new XmlDocument();
            agenda.Load("Registro.xml");

            XmlElement tareas = agenda.DocumentElement;

            //Obtiene las actividades de la agenda.
            XmlNodeList listaDeTareas = agenda.GetElementsByTagName("agenda");
            //Obtiene las actividades de la agenda.
            XmlNodeList listaDeActividades = agenda.GetElementsByTagName("actividad");

            foreach (XmlNode tar in listaDeTareas)
            {
                foreach (XmlNode actividad in listaDeActividades)
                {
                    DateTime fechaDeTarea = Convert.ToDateTime(tar.FirstChild.ChildNodes[0].InnerText);
                    if (Convert.ToString(fechaDeTarea.ToShortDateString()) == Convert.ToString(tareaAModificar.fecha.ToShortDateString()) && actividad.InnerText == tareaAModificar.actividad)
                    {
                        tar.FirstChild.InnerText = Convert.ToString(nuevaFecha);
                        tar.ChildNodes[0].InnerText = nuevaFecha.ToShortDateString();
                        tar.ChildNodes[1].InnerText = nuevaHora;
                        tar.ChildNodes[2].InnerText = nuevaActividad;
                        tar.ChildNodes[3].InnerText = nuevoEstado;
                        actividad.InnerText = nuevaActividad;
                        break;
                    }

                }
            }

            agenda.Save("Registro.xml");

        }


    }
}
