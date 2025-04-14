using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8_Hilos
{
    public partial class Form_Inicio : Form
    {
        private List<string> actividades = new List<string>();
        private Thread hiloNotificaciones;
        public Form_Inicio()
        {
            InitializeComponent();
            // Iniciar hilo de verificación de actividades
            hiloNotificaciones = new Thread(VerificarActividades);
            hiloNotificaciones.IsBackground = true;
            hiloNotificaciones.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Aquí va la lógica que quieres al hacer clic en el label1
            MessageBox.Show("Hiciste clic en el label de NOTAS.");
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string actividad = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una nueva actividad:", "Agregar Actividad");

            if (!string.IsNullOrWhiteSpace(actividad))
            {
                actividades.Add(actividad);
                MessageBox.Show("¡Actividad agregada!");
            }

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string actividad = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una nueva actividad:", "Agregar Actividad");

            if (!string.IsNullOrWhiteSpace(actividad))
            {
                actividades.Add(actividad);
                MessageBox.Show("¡Actividad agregada!");
            }

        }

        private void VerificarActividades()
        {
            while (true)
            {
                Thread.Sleep(2000); // Cada 2 segundos

                if (label3.InvokeRequired)
                {
                    label3.Invoke(new Action(() =>
                    {
                        if (actividades.Count > 0)
                        {
                            label3.Text = "🔔 Tienes actividades pendientes";
                        }
                        else
                        {
                            label3.Text = "✅ No hay actividades pendientes";
                        }
                    }));
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (hiloNotificaciones != null && hiloNotificaciones.IsAlive)
                hiloNotificaciones.Abort(); // Detiene el hilo cuando se cierra el formulario
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
