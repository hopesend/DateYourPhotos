namespace DateYourPhotos
{
    partial class fmDateYourPhotos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDateYourPhotos));
            this.fbdDirectorio = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btComenzar = new System.Windows.Forms.Button();
            this.btFolder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAbrirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImagenCargada = new System.Windows.Forms.PictureBox();
            this.lvLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbYY = new System.Windows.Forms.RadioButton();
            this.rbYYMM = new System.Windows.Forms.RadioButton();
            this.rbMMYY = new System.Windows.Forms.RadioButton();
            this.rbYYMMDD = new System.Windows.Forms.RadioButton();
            this.rbMMDDYY = new System.Windows.Forms.RadioButton();
            this.rbDDMMYY = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDirectorio = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCargada)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btComenzar
            // 
            this.btComenzar.Image = ((System.Drawing.Image)(resources.GetObject("btComenzar.Image")));
            this.btComenzar.Location = new System.Drawing.Point(589, 50);
            this.btComenzar.Name = "btComenzar";
            this.btComenzar.Size = new System.Drawing.Size(71, 71);
            this.btComenzar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btComenzar, "Start Rename Files");
            this.btComenzar.UseVisualStyleBackColor = true;
            this.btComenzar.Click += new System.EventHandler(this.btComenzar_Click);
            // 
            // btFolder
            // 
            this.btFolder.Image = ((System.Drawing.Image)(resources.GetObject("btFolder.Image")));
            this.btFolder.Location = new System.Drawing.Point(12, 23);
            this.btFolder.Name = "btFolder";
            this.btFolder.Size = new System.Drawing.Size(25, 25);
            this.btFolder.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btFolder, "Select Folder");
            this.btFolder.UseVisualStyleBackColor = true;
            this.btFolder.Click += new System.EventHandler(this.abrirDirectorioToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAbrirMenu,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.archivoToolStripMenuItem.Text = "File";
            // 
            // btAbrirMenu
            // 
            this.btAbrirMenu.Name = "btAbrirMenu";
            this.btAbrirMenu.Size = new System.Drawing.Size(141, 22);
            this.btAbrirMenu.Text = "Select Folder";
            this.btAbrirMenu.ToolTipText = "Abrir Directorio Contenedor de Imagenes";
            this.btAbrirMenu.Click += new System.EventHandler(this.abrirDirectorioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.salirToolStripMenuItem.Text = "Exit";
            // 
            // pbImagenCargada
            // 
            this.pbImagenCargada.Location = new System.Drawing.Point(12, 127);
            this.pbImagenCargada.Name = "pbImagenCargada";
            this.pbImagenCargada.Size = new System.Drawing.Size(250, 250);
            this.pbImagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenCargada.TabIndex = 4;
            this.pbImagenCargada.TabStop = false;
            // 
            // lvLog
            // 
            this.lvLog.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvLog.Location = new System.Drawing.Point(268, 127);
            this.lvLog.MultiSelect = false;
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(392, 250);
            this.lvLog.TabIndex = 5;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            this.lvLog.ItemActivate += new System.EventHandler(this.lvLog_ItemActivate);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbYY);
            this.groupBox1.Controls.Add(this.rbYYMM);
            this.groupBox1.Controls.Add(this.rbMMYY);
            this.groupBox1.Controls.Add(this.rbYYMMDD);
            this.groupBox1.Controls.Add(this.rbMMDDYY);
            this.groupBox1.Controls.Add(this.rbDDMMYY);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rename Format";
            // 
            // rbYY
            // 
            this.rbYY.AutoSize = true;
            this.rbYY.Location = new System.Drawing.Point(256, 42);
            this.rbYY.Name = "rbYY";
            this.rbYY.Size = new System.Drawing.Size(82, 17);
            this.rbYY.TabIndex = 5;
            this.rbYY.TabStop = true;
            this.rbYY.Text = "YY[HH:MM]";
            this.rbYY.UseVisualStyleBackColor = true;
            // 
            // rbYYMM
            // 
            this.rbYYMM.AutoSize = true;
            this.rbYYMM.Location = new System.Drawing.Point(256, 19);
            this.rbYYMM.Name = "rbYYMM";
            this.rbYYMM.Size = new System.Drawing.Size(103, 17);
            this.rbYYMM.TabIndex = 4;
            this.rbYYMM.TabStop = true;
            this.rbYYMM.Text = "YY-MM[HH:MM]";
            this.rbYYMM.UseVisualStyleBackColor = true;
            // 
            // rbMMYY
            // 
            this.rbMMYY.AutoSize = true;
            this.rbMMYY.Location = new System.Drawing.Point(129, 42);
            this.rbMMYY.Name = "rbMMYY";
            this.rbMMYY.Size = new System.Drawing.Size(103, 17);
            this.rbMMYY.TabIndex = 3;
            this.rbMMYY.TabStop = true;
            this.rbMMYY.Text = "MM-YY[HH:MM]";
            this.rbMMYY.UseVisualStyleBackColor = true;
            // 
            // rbYYMMDD
            // 
            this.rbYYMMDD.AutoSize = true;
            this.rbYYMMDD.Location = new System.Drawing.Point(129, 19);
            this.rbYYMMDD.Name = "rbYYMMDD";
            this.rbYYMMDD.Size = new System.Drawing.Size(122, 17);
            this.rbYYMMDD.TabIndex = 2;
            this.rbYYMMDD.TabStop = true;
            this.rbYYMMDD.Text = "YY-MM-DD[HH:MM]";
            this.rbYYMMDD.UseVisualStyleBackColor = true;
            // 
            // rbMMDDYY
            // 
            this.rbMMDDYY.AutoSize = true;
            this.rbMMDDYY.Location = new System.Drawing.Point(6, 42);
            this.rbMMDDYY.Name = "rbMMDDYY";
            this.rbMMDDYY.Size = new System.Drawing.Size(122, 17);
            this.rbMMDDYY.TabIndex = 1;
            this.rbMMDDYY.TabStop = true;
            this.rbMMDDYY.Text = "MM-DD-YY[HH:MM]";
            this.rbMMDDYY.UseVisualStyleBackColor = true;
            // 
            // rbDDMMYY
            // 
            this.rbDDMMYY.AutoSize = true;
            this.rbDDMMYY.Location = new System.Drawing.Point(6, 19);
            this.rbDDMMYY.Name = "rbDDMMYY";
            this.rbDDMMYY.Size = new System.Drawing.Size(122, 17);
            this.rbDDMMYY.TabIndex = 0;
            this.rbDDMMYY.TabStop = true;
            this.rbDDMMYY.Text = "DD-MM-YY[HH:MM]";
            this.rbDDMMYY.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Folder:";
            // 
            // lbDirectorio
            // 
            this.lbDirectorio.AutoSize = true;
            this.lbDirectorio.Location = new System.Drawing.Point(103, 28);
            this.lbDirectorio.Name = "lbDirectorio";
            this.lbDirectorio.Size = new System.Drawing.Size(16, 13);
            this.lbDirectorio.TabIndex = 9;
            this.lbDirectorio.Text = "...";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 127);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(250, 250);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // fmDateYourPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 389);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btFolder);
            this.Controls.Add(this.lbDirectorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btComenzar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvLog);
            this.Controls.Add(this.pbImagenCargada);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDateYourPhotos";
            this.Text = "Date Your Photos & Videos";
            this.Load += new System.EventHandler(this.fmDateYourPhotos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCargada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdDirectorio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btAbrirMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbImagenCargada;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbYY;
        private System.Windows.Forms.RadioButton rbYYMM;
        private System.Windows.Forms.RadioButton rbMMYY;
        private System.Windows.Forms.RadioButton rbYYMMDD;
        private System.Windows.Forms.RadioButton rbMMDDYY;
        private System.Windows.Forms.RadioButton rbDDMMYY;
        private System.Windows.Forms.Button btComenzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDirectorio;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btFolder;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

