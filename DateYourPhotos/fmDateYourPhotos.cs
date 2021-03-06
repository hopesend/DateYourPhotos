﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Shell32;
using System.Globalization;

namespace DateYourPhotos
{
    public partial class fmDateYourPhotos : Form
    {
        private const string IMAGEEXTENSION = "*.jpg,*.gif,*.png,*.bmp,*.jpe,*.jpeg,*.tif,*.tiff";
        private const string VIDEOEXTENSION = "*.avi,*.mp4,*.mpg,*.mpeg";
        public fmDateYourPhotos()
        {
            InitializeComponent();
        }

        private void abrirDirectorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fbdDirectorio.ShowDialog() == DialogResult.OK)
            {
                lbDirectorio.Text = fbdDirectorio.SelectedPath;
                lvLog.Items.Clear();
                string extensiones = IMAGEEXTENSION + "," + VIDEOEXTENSION;
                foreach (string archivo in Directory.GetFiles(fbdDirectorio.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s => extensiones.Contains(Path.GetExtension(s).ToLower())))
                {
                    ListViewItem nuevoItem = new ListViewItem();
                    nuevoItem.Text = Path.GetFileName(archivo);
                    nuevoItem.Tag = archivo;
                    lvLog.Items.Add(nuevoItem);
                }
            }
        }

        private void btComenzar_Click(object sender, EventArgs e)
        {
            //lvLog.Items.Clear();
            Renombrar_Imagenes(lbDirectorio.Text);
        }

        private void Renombrar_Imagenes(string pathImagenes)
        {
            foreach (ListViewItem item in lvLog.Items)
            {
                string extension = Path.GetExtension(item.Tag.ToString());
                string fechaCaptura = new ShellFileInfo().GetFileDetails(Path.GetDirectoryName(item.Tag.ToString()), Path.GetFileName(item.Tag.ToString()), ShellFileInfo.infoFile.Fecha_de_captura);
                if(fechaCaptura.Equals(string.Empty))
                    fechaCaptura = new ShellFileInfo().GetFileDetails(Path.GetDirectoryName(item.Tag.ToString()), Path.GetFileName(item.Tag.ToString()), ShellFileInfo.infoFile.Fecha_de_modificacion);
                string nuevaFecha = Reformatear_Fecha(Obtener_Fecha(fechaCaptura)) + extension;

                if (Path.GetFileNameWithoutExtension(nuevaFecha).Equals(string.Empty))
                    nuevaFecha = Path.GetFileNameWithoutExtension(item.Tag.ToString()) + "(NoShotDate)" + extension;
                else
                {
                    if (File.Exists(Path.Combine(Path.GetDirectoryName(item.Tag.ToString()), nuevaFecha)))
                        nuevaFecha = Devolver_Nuevo_Nombre(Path.Combine(Path.GetDirectoryName(item.Tag.ToString()), nuevaFecha));
                }

                item.Text = item.Text + " >> " + nuevaFecha;
                string nuevoPath = Path.Combine(Path.GetDirectoryName(item.Tag.ToString()), nuevaFecha);
                File.Move(item.Tag.ToString(), nuevoPath);
                item.Tag = nuevoPath;
                
                lvLog.Items[lvLog.Items.Count - 1].EnsureVisible();
            }
        }

        private string Reformatear_Fecha(DateTime fecha)
        {
            if (!fecha.Equals(DateTime.MinValue))
            {
                if (rbDDMMYY.Checked)
                    return string.Format("{0}-{1}-{2}[{3}_{4}]", fecha.Day.ToString(), fecha.Month.ToString(), fecha.Year.ToString(), fecha.Hour.ToString(), fecha.Minute.ToString());

                if (rbMMDDYY.Checked)
                    return string.Format("{0}-{1}-{2}[{3}_{4}]", fecha.Month.ToString(), fecha.Day.ToString(), fecha.Year.ToString(), fecha.Hour.ToString(), fecha.Minute.ToString());

                if (rbMMYY.Checked)
                    return string.Format("{0}-{1}[{3}_{4}]", fecha.Month.ToString(), fecha.Year.ToString(), fecha.Hour.ToString(), fecha.Minute.ToString());

                if (rbYY.Checked)
                    return string.Format("{0}[{3}_{4}]", fecha.Year.ToString(), fecha.Hour.ToString(), fecha.Minute.ToString());

                if (rbYYMM.Checked)
                    return string.Format("{0}-{1}[{3}_{4}]", fecha.Year.ToString(), fecha.Month.ToString(), fecha.Hour.ToString(), fecha.Minute.ToString());

                if (rbYYMMDD.Checked)
                    return string.Format("{0}-{1}-{2}[{3}_{4}]", fecha.Year.ToString(), fecha.Month.ToString(), fecha.Day.ToString(), fecha.Hour.ToString(), fecha.Minute.ToString());
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
                    if(nombreArchivo.Contains("]_"))
                    {
                        nombreArchivo = nombreArchivo.Remove(nombreArchivo.IndexOf("]_"));
                        nombreArchivo = nombreArchivo + "]_" + cont;
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
            if (IsImage(lvLog.SelectedItems[0].Tag.ToString()))
            {
                pbImagenCargada.Visible = true;
                axWindowsMediaPlayer1.Visible = false;
                pbImagenCargada.Image = Image.FromFile(lvLog.SelectedItems[0].Tag.ToString());
            }
            else
            {
                pbImagenCargada.Visible = false;
                axWindowsMediaPlayer1.Visible = true;
                axWindowsMediaPlayer1.URL = lvLog.SelectedItems[0].Tag.ToString();
            }
        }

        public bool IsImage(string pathArchivo)
        {
            return IMAGEEXTENSION.Contains(Path.GetExtension(pathArchivo));
        }

        public DateTime Obtener_Fecha(string fecha)
        {
            return DateTime.Parse(Encoding.UTF8.GetString(Encoding.ASCII.GetBytes(fecha)).Replace("?", ""));
        }
    }
}
