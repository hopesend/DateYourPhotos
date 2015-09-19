using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace DateYourPhotos
{
    public partial class fmDateYourPhotos : Form
    {
        public fmDateYourPhotos()
        {
            InitializeComponent();
        }

        private void abrirDirectorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fbdDirectorio.ShowDialog() == DialogResult.OK)
            {
                lbDirectorio.Text = fbdDirectorio.SelectedPath;
            }
        }

        private void btComenzar_Click(object sender, EventArgs e)
        {
            lvLog.Items.Clear();
            Renombrar_Imagenes(lbDirectorio.Text);
        }

        private void Renombrar_Imagenes(string pathImagenes)
        {
            foreach(string archivo in Directory.GetFiles(pathImagenes))
            {
                ListViewItem nuevoItem = new ListViewItem();
                string extension = Path.GetExtension(archivo);
                string nuevaFecha = Reformatear_Fecha(Obtener_Fecha(archivo)) + extension;

                if (Path.GetFileNameWithoutExtension(nuevaFecha) == string.Empty)
                    nuevaFecha = Path.GetFileNameWithoutExtension(archivo) + "(SinFechaQueMostrar)" + extension;
                else
                {
                    if (File.Exists(Path.Combine(Path.GetDirectoryName(archivo), nuevaFecha)))
                        nuevaFecha = Devolver_Nuevo_Nombre(Path.Combine(Path.GetDirectoryName(archivo), nuevaFecha));
                }

                nuevoItem.Text = Path.GetFileName(archivo) + " >> " + nuevaFecha;
                nuevoItem.Tag = Path.Combine(Path.GetDirectoryName(archivo), nuevaFecha);
                File.Move(archivo, nuevoItem.Tag.ToString());

                lvLog.Items.Add(nuevoItem);
                lvLog.Refresh();
                lvLog.Items[lvLog.Items.Count - 1].EnsureVisible();
            }
        }

        private DateTime Obtener_Fecha(string pathImagen)
        {
            Regex r = new Regex(":");
            Image imagenAux = null;
         
            try
            {
                imagenAux = Image.FromFile(pathImagen);
                PropertyItem propiedadFechaCaptura = imagenAux.GetPropertyItem(36867);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propiedadFechaCaptura.Value), "-", 2);
                imagenAux.Dispose();
                return DateTime.Parse(dateTaken);
            }
            catch
            {
                if(imagenAux != null)
                    imagenAux.Dispose();
                return DateTime.MinValue;
            }
        }

        private string Reformatear_Fecha(DateTime fecha)
        {
            if (!fecha.Equals(DateTime.MinValue))
            {
                if (rbDDMMYY.Checked)
                    return string.Format("{0}-{1}-{2}", fecha.Day.ToString(), fecha.Month.ToString(), fecha.Year.ToString());

                if (rbMMDDYY.Checked)
                    return string.Format("{0}-{1}-{2}", fecha.Month.ToString(), fecha.Day.ToString(), fecha.Year.ToString());

                if (rbMMYY.Checked)
                    return string.Format("{0}-{1}", fecha.Month.ToString(), fecha.Year.ToString());

                if (rbYY.Checked)
                    return string.Format("{0}", fecha.Year.ToString());

                if (rbYYMM.Checked)
                    return string.Format("{0}-{1}", fecha.Year.ToString(), fecha.Month.ToString());

                if (rbYYMMDD.Checked)
                    return string.Format("{0}-{1}-{2}", fecha.Year.ToString(), fecha.Month.ToString(), fecha.Day.ToString());
            }

            return null;
        }

        private string Devolver_Nuevo_Nombre(string path)
        {
            string nuevoNombre = string.Empty;
            string aux;
            string nombreArchivo;
            string extension;
            string ruta;

            byte cont = 0;
            aux = path;

            do
            {
                nombreArchivo = Path.GetFileNameWithoutExtension(aux);
                extension = Path.GetExtension(aux);
                ruta = Path.GetDirectoryName(aux);

                if(File.Exists(aux))
                {
                    cont++;
                    if(nombreArchivo.Contains('_'))
                    {
                        nombreArchivo = nombreArchivo.Remove(nombreArchivo.IndexOf('_'));
                        nombreArchivo = nombreArchivo + "_" + cont;
                        aux = Path.Combine(ruta, nombreArchivo + extension);
                    }
                    else
                        aux = Path.Combine(ruta, nombreArchivo + "_" + cont + extension);
                }
                else
                    nuevoNombre = nombreArchivo + extension;

            }
            while (nuevoNombre.Equals(string.Empty));

            return nuevoNombre;
        }

        private void fmDateYourPhotos_Load(object sender, EventArgs e)
        {
            lvLog.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            rbDDMMYY.Checked = true;
        }

        private void lvLog_ItemActivate(object sender, EventArgs e)
        {
            pbImagenCargada.Image = Image.FromFile(lvLog.SelectedItems[0].Tag.ToString());
        }


    }
}
