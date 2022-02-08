using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CalcularPromedio
{
    public partial class Form1 : Form
    {

        //Variables para las calificaciones y el promedio cuatrimestral
        private float creditoTotal;
        private float totalNotas;

        private float total;

        private float credito;
        private float nota;

        private float promedio;

        //Variables para calcular el promedio total de todos los cuatrimestres
        private float sumaPromedios;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            totalNotas = 0;

            try
            {
                credito = float.Parse(txtCredito.Text);
                nota = float.Parse(txtNota.Text);

                txtCredito.Text = string.Empty;
                txtNota.Text = string.Empty;
                
                if (nota > 89 && nota < 101)
                {
                    nota = 4;
                }
                else if (nota > 79 && nota < 90)
                {
                    nota = 3;
                }
                else if (nota > 69 && nota < 80)
                {
                    nota = 2;
                }
                else if (nota > 59 && nota < 70)
                {
                    nota = 1;
                }
                else
                {
                    nota = 0;
                }

                creditoTotal += credito;

                total = credito * nota;

                lbCalificaciones.Items.Add(total);

                foreach (var item in lbCalificaciones.Items)
                {
                    totalNotas += float.Parse(item.ToString());
                }

                promedio = totalNotas / creditoTotal;

                txtPromedioTotal.Text = "";
                txtPromedioTotal.Text = promedio.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Oops! hubo un problema!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lbCalificaciones.Items.Clear();
                lbPromedios.Items.Clear();

                creditoTotal = 0;
                totalNotas = 0;

                total = 0;

                credito = 0;
                nota = 0;

                promedio = 0;

                txtCredito.Text = string.Empty;
                txtNota.Text = string.Empty;

                txtPromedioTotal.Text = string.Empty;
                txtCalculoPromedios.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Oops! Hubo un problema al intentar eliminar!");
            }
            
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                float nuevoPromedio = float.Parse(txtPromedioTotal.Text);

                lbPromedios.Items.Add(nuevoPromedio);


                lbCalificaciones.Items.Clear();

                creditoTotal = 0;
                totalNotas = 0;

                total = 0;

                credito = 0;
                nota = 0;

                promedio = 0;

                txtCredito.Text = string.Empty;
                txtNota.Text = string.Empty;

                txtPromedioTotal.Text = string.Empty;

                sumaPromedios = 0;

                foreach (var item in lbPromedios.Items)
                {
                    sumaPromedios += float.Parse(item.ToString());
                }

                txtCalculoPromedios.Text = (sumaPromedios / float.Parse(lbPromedios.Items.Count.ToString())).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops! Hubo un Problema");
            }
            
        }

        private void btnCIzquierda_Click(object sender, EventArgs e)
        {
            lbCalificaciones.Items.Clear();

            creditoTotal = 0;
            totalNotas = 0;

            total = 0;

            credito = 0;
            nota = 0;

            promedio = 0;

            txtCredito.Text = string.Empty;
            txtNota.Text = string.Empty;

            txtPromedioTotal.Text = string.Empty;
        }

        private void btnCDerecho_Click(object sender, EventArgs e)
        {
            lbPromedios.Items.Clear();

            txtCredito.Text = string.Empty;
            txtNota.Text = string.Empty;

            txtCalculoPromedios.Text = string.Empty;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por: Gabriel Vargas - Estudiante de Ingenieria de Software\n" +
                "Alias: Odraga\n" +
                "Fecha de Creacion: 02/01/2022\n" +
                "Tiempo de desarrollo: 3 Horas\n" +
                "\n\n" +
                "Esta Aplicación te permite calcular tu promedio cuatrimestral y total." +
                "\nPor supuesto, esto solo va a servir para calcular el promedio en formato de la Universidad Federico Henríquez y Carvajal(UFHEC).");

            String URL = "https://www.youtube.com/channel/UCK_NUEUQ-oSM4iQy4nP6S8A";
            OpenUrl(URL);
        }
    private void OpenUrl(string url)
    {
        try
        {
            Process.Start(url);
        }
        catch
        {
            // hack because of this: https://github.com/dotnet/corefx/issues/10361
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
            else
            {
                throw;
            }
        }
    }
}
}
