using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmPasaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmarViaje = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbColumnaAsiento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFilaAsiento = new System.Windows.Forms.ComboBox();
            this.lblPrecioPasaje = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgBuses = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChoferId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsientosDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntoSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbAsientos = new System.Windows.Forms.PictureBox();
            this.cbPuntoSalida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTipoBus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(16, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Elija su bus:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label17.Location = new System.Drawing.Point(316, 26);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Elija la matricula y confirme su viaje *";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.dtpFechaSalida);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbTipoBus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbDestino);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbPuntoSalida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(801, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 213);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detalles del pasaje:\r\n";
            // 
            // btnConfirmarViaje
            // 
            this.btnConfirmarViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnConfirmarViaje.FlatAppearance.BorderSize = 0;
            this.btnConfirmarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarViaje.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarViaje.Location = new System.Drawing.Point(1014, 590);
            this.btnConfirmarViaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarViaje.Name = "btnConfirmarViaje";
            this.btnConfirmarViaje.Size = new System.Drawing.Size(150, 30);
            this.btnConfirmarViaje.TabIndex = 4;
            this.btnConfirmarViaje.Text = "Confirmar viaje";
            this.btnConfirmarViaje.UseVisualStyleBackColor = false;
            this.btnConfirmarViaje.Click += new System.EventHandler(this.btnConfirmarViaje_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(801, 590);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar viaje";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbColumnaAsiento);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pbAsientos);
            this.panel2.Controls.Add(this.cbFilaAsiento);
            this.panel2.Controls.Add(this.lblPrecioPasaje);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nudPiso);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(801, 243);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 328);
            this.panel2.TabIndex = 24;
            // 
            // cbColumnaAsiento
            // 
            this.cbColumnaAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumnaAsiento.FormattingEnabled = true;
            this.cbColumnaAsiento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbColumnaAsiento.Location = new System.Drawing.Point(295, 35);
            this.cbColumnaAsiento.Margin = new System.Windows.Forms.Padding(2);
            this.cbColumnaAsiento.Name = "cbColumnaAsiento";
            this.cbColumnaAsiento.Size = new System.Drawing.Size(52, 21);
            this.cbColumnaAsiento.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(231, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Columna:";
            // 
            // cbFilaAsiento
            // 
            this.cbFilaAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilaAsiento.FormattingEnabled = true;
            this.cbFilaAsiento.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbFilaAsiento.Location = new System.Drawing.Point(155, 36);
            this.cbFilaAsiento.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilaAsiento.Name = "cbFilaAsiento";
            this.cbFilaAsiento.Size = new System.Drawing.Size(52, 21);
            this.cbFilaAsiento.TabIndex = 15;
            // 
            // lblPrecioPasaje
            // 
            this.lblPrecioPasaje.AutoSize = true;
            this.lblPrecioPasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecioPasaje.Location = new System.Drawing.Point(264, 301);
            this.lblPrecioPasaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioPasaje.Name = "lblPrecioPasaje";
            this.lblPrecioPasaje.Size = new System.Drawing.Size(64, 15);
            this.lblPrecioPasaje.TabIndex = 16;
            this.lblPrecioPasaje.Text = "S/. 00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(209, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio:";
            // 
            // nudPiso
            // 
            this.nudPiso.Location = new System.Drawing.Point(47, 37);
            this.nudPiso.Margin = new System.Windows.Forms.Padding(2);
            this.nudPiso.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPiso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(53, 20);
            this.nudPiso.TabIndex = 12;
            this.nudPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPiso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(121, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fila:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(14, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Piso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(10, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Elige tus asientos:";
            // 
            // dgBuses
            // 
            this.dgBuses.AllowUserToAddRows = false;
            this.dgBuses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Id,
            this.ChoferId,
            this.Matricula,
            this.Tipo,
            this.CantidadAsiento,
            this.AsientosDisponibles,
            this.PuntoSalida,
            this.Destino,
            this.FechaSalida,
            this.FechaLlegada,
            this.PrecioAsiento});
            this.dgBuses.Location = new System.Drawing.Point(9, 57);
            this.dgBuses.MultiSelect = false;
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.ReadOnly = true;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBuses.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgBuses.RowTemplate.Height = 28;
            this.dgBuses.Size = new System.Drawing.Size(784, 562);
            this.dgBuses.TabIndex = 25;
            this.dgBuses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBuses_CellContentClick_1);
            this.dgBuses.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgBuses_CellPainting_1);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ChoferId
            // 
            this.ChoferId.HeaderText = "ChoferId";
            this.ChoferId.Name = "ChoferId";
            this.ChoferId.ReadOnly = true;
            this.ChoferId.Visible = false;
            this.ChoferId.Width = 60;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 70;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de Bus";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 75;
            // 
            // CantidadAsiento
            // 
            this.CantidadAsiento.HeaderText = "Cantidad de Asientos";
            this.CantidadAsiento.Name = "CantidadAsiento";
            this.CantidadAsiento.ReadOnly = true;
            this.CantidadAsiento.Width = 65;
            // 
            // AsientosDisponibles
            // 
            this.AsientosDisponibles.HeaderText = "Asientos Disponibles";
            this.AsientosDisponibles.Name = "AsientosDisponibles";
            this.AsientosDisponibles.ReadOnly = true;
            this.AsientosDisponibles.Width = 80;
            // 
            // PuntoSalida
            // 
            this.PuntoSalida.HeaderText = "Punto de Salida";
            this.PuntoSalida.Name = "PuntoSalida";
            this.PuntoSalida.ReadOnly = true;
            this.PuntoSalida.Width = 80;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 75;
            // 
            // FechaSalida
            // 
            this.FechaSalida.HeaderText = "Fecha de Salida";
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            this.FechaSalida.Width = 95;
            // 
            // FechaLlegada
            // 
            this.FechaLlegada.HeaderText = "Fecha de Llegada";
            this.FechaLlegada.Name = "FechaLlegada";
            this.FechaLlegada.ReadOnly = true;
            this.FechaLlegada.Width = 95;
            // 
            // PrecioAsiento
            // 
            this.PrecioAsiento.HeaderText = "Precio";
            this.PrecioAsiento.Name = "PrecioAsiento";
            this.PrecioAsiento.ReadOnly = true;
            this.PrecioAsiento.Width = 70;
            // 
            // pbAsientos
            // 
            this.pbAsientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAsientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAsientos.Location = new System.Drawing.Point(9, 63);
            this.pbAsientos.Name = "pbAsientos";
            this.pbAsientos.Size = new System.Drawing.Size(345, 230);
            this.pbAsientos.TabIndex = 17;
            this.pbAsientos.TabStop = false;
            // 
            // cbPuntoSalida
            // 
            this.cbPuntoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuntoSalida.FormattingEnabled = true;
            this.cbPuntoSalida.Items.AddRange(new object[] {
            "Ica",
            "Arequipa",
            "Moquegua",
            "Tacna",
            "Chimbote",
            "Huaraz",
            "Trujillo",
            "Chiclayo",
            "Piura",
            "Tumbes",
            "Lima"});
            this.cbPuntoSalida.Location = new System.Drawing.Point(146, 35);
            this.cbPuntoSalida.Margin = new System.Windows.Forms.Padding(2);
            this.cbPuntoSalida.Name = "cbPuntoSalida";
            this.cbPuntoSalida.Size = new System.Drawing.Size(189, 21);
            this.cbPuntoSalida.TabIndex = 18;
            this.cbPuntoSalida.SelectedIndexChanged += new System.EventHandler(this.cbPuntoSalida_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(42, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Punto de salida";
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Items.AddRange(new object[] {
            "Ica",
            "Arequipa",
            "Moquegua",
            "Tacna",
            "Chimbote",
            "Huaraz",
            "Trujillo",
            "Chiclayo",
            "Piura",
            "Tumbes",
            "Lima"});
            this.cbDestino.Location = new System.Drawing.Point(146, 71);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(189, 21);
            this.cbDestino.TabIndex = 20;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(72, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Destino";
            // 
            // cbTipoBus
            // 
            this.cbTipoBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBus.FormattingEnabled = true;
            this.cbTipoBus.Items.AddRange(new object[] {
            "Economico",
            "Vip",
            "Primera Clase",
            "Negocio"});
            this.cbTipoBus.Location = new System.Drawing.Point(146, 110);
            this.cbTipoBus.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoBus.Name = "cbTipoBus";
            this.cbTipoBus.Size = new System.Drawing.Size(189, 21);
            this.cbTipoBus.TabIndex = 22;
            this.cbTipoBus.SelectedIndexChanged += new System.EventHandler(this.cbTipoBus_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(50, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tipo de bus";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSalida.Location = new System.Drawing.Point(146, 148);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaSalida.MinDate = new System.DateTime(2023, 11, 18, 12, 13, 29, 223);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(189, 20);
            this.dtpFechaSalida.TabIndex = 24;
            this.dtpFechaSalida.Value = new System.DateTime(2023, 11, 18, 12, 13, 29, 223);
            this.dtpFechaSalida.ValueChanged += new System.EventHandler(this.dtpFechaSalida_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(24, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "    Fecha de salida\r\n";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(111, 180);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(167, 24);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 649);
            this.Controls.Add(this.dgBuses);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirmarViaje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPasaje";
            this.Text = "frmPasaje";
            this.Load += new System.EventHandler(this.frmPasaje_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label15;
        private Label label17;
        private Panel panel1;
        private Button btnConfirmarViaje;
        private Button button1;
        private Label label3;
        private Panel panel2;
        private Label label8;
        private NumericUpDown nudPiso;
        private Label label5;
        private Label lblPrecioPasaje;
        private Label label7;
        private PictureBox pbAsientos;
        private DataGridView dgBuses;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ChoferId;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn CantidadAsiento;
        private DataGridViewTextBoxColumn AsientosDisponibles;
        private DataGridViewTextBoxColumn PuntoSalida;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn FechaSalida;
        private DataGridViewTextBoxColumn FechaLlegada;
        private DataGridViewTextBoxColumn PrecioAsiento;
        private ComboBox cbColumnaAsiento;
        private Label label10;
        private ComboBox cbFilaAsiento;
        private Label label1;
        private ComboBox cbPuntoSalida;
        private Label label2;
        private ComboBox cbDestino;
        private Label label12;
        private ComboBox cbTipoBus;
        private Label label6;
        private DateTimePicker dtpFechaSalida;
        private Label label9;
        private Button btnLimpiar;
    }
}