using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Practico_4
{
    public partial class ALTA_Tarea : Form
    {
        Form1 Principal;

        string MSJ_TAREAEXITO = "Tarea agregada exitosamente a la agenda!";
        string MSJ_TAREAFRACASO = "No se ha podido agregar la tarea a la agenda";
        string MSJ_FECHA_Y_HORA_INVALIDA = "Ya existe una tarea en esta fecha y hora, por favor ingrese una nueva fecha u hora";
        //string MSJ_REGISTROEXITO = "Se ha creado un nuevo registro XML con exito";
        //string MSJ_REGISTROFRACASO = "No se ha podido crear el registro XML";  

        public ALTA_Tarea(Form1 Padre)
        {
            Principal = Padre;
            InitializeComponent();
        }


        private void btAgregarTarea_Click(object sender, EventArgs e)
        {
            if (camposCorrectos())
            {
                if (Principal.existeRegistroXML())
                {

                    if (fechaYHoraValidas())
                    {

                        crearNuevaTarea();
                        almacenarDatosEnLista();
                        MessageBox.Show(MSJ_TAREAEXITO);
                        Principal.actualizarGVTareas();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(MSJ_FECHA_Y_HORA_INVALIDA);
                    }
                }
                else
                {
                    try
                    {
                        Principal.crearRegistroXML();
                        crearNuevaTarea();
                        almacenarDatosEnLista();
                        MessageBox.Show(MSJ_TAREAEXITO);
                        Principal.actualizarGVTareas();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(MSJ_TAREAFRACASO);
                    }
                }
            }
            
        }

        //Agrega tarea a la agenda
        public void crearNuevaTarea()
        {
            var documento = XDocument.Load(Principal.RUTA_XML);
            var nuevaTarea = new XElement("tarea",

                new XElement("fecha", dtpFechaTarea.Value.ToShortDateString()),
                new XElement("hora", tbHora.Text),
                new XElement("actividad", tbActividad.Text),
                new XElement("estado", Principal.ESTADO_TAREA_NO_REALIZADA));

            documento.Element("agenda").Add(nuevaTarea);
            documento.Save(Principal.RUTA_XML);
            return;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void almacenarDatosEnLista()
        {
            Tarea nTarea= new Tarea(Convert.ToDateTime(dtpFechaTarea.Value.ToShortDateString()), tbHora.Text, tbActividad.Text, Principal.ESTADO_TAREA_NO_REALIZADA);
            Principal.tarea.Add(nTarea);
        }

        //Esta funcion verifica si ya hay asignada una tarea en la fecha y hora.
        private bool fechaYHoraValidas()
        {
            bool fechaYHoraValidas = false;

            int cantidadTareasEnRegistro = Principal.tarea.Count();
            if (cantidadTareasEnRegistro > 0)
            {
                for (int t = 0; t < cantidadTareasEnRegistro; t++)
                {
                    if (dtpFechaTarea.Value.ToShortDateString() == Principal.tarea[t].fecha.ToShortDateString() && tbHora.Text == Principal.tarea[t].hora)
                    {
                        fechaYHoraValidas = false;
                        break;
                    }
                    else
                    {
                        fechaYHoraValidas = true;
                    }
                }
            }else
            {
                fechaYHoraValidas = true;
            }
            return fechaYHoraValidas;
        }
                    
        private bool camposCorrectos()
        {
            bool verificacionCorrecta = false;
            string errorEnCampo = "";
            DateTime fechaActual = DateTime.Today;
            if (dtpFechaTarea.Value < fechaActual || string.IsNullOrWhiteSpace(tbHora.Text) || tbHora.Text == "  :")
            {
                if (dtpFechaTarea.Value < fechaActual)
                {
                    errorEnCampo = Principal.MSJ_FECHA_INVALIDA;
                    MessageBox.Show(errorEnCampo);
                    verificacionCorrecta = false;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(tbHora.Text) || tbHora.Text == "  :")
                    {
                        errorEnCampo = Principal.MSJ_HORA_INVALIDA;
                        MessageBox.Show(errorEnCampo);
                        verificacionCorrecta = false;
                    }
                }
            }
            else
            {
                verificacionCorrecta = true;
            }
            return verificacionCorrecta;
        }
    }
}

