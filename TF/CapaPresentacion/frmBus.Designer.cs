using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmBus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDniChofer = new System.Windows.Forms.ComboBox();
            this.btnVerChoferes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarBus = new System.Windows.Forms.Button();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbPuntoSalida = new System.Windows.Forms.ComboBox();
            this.cbTipoBus = new System.Windows.Forms.ComboBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrarBus = new System.Windows.Forms.Button();
            this.btnCancelarBus = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalBuses = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudCantidadAsientos = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudCantidadAsientos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbDniChofer);
            this.panel1.Controls.Add(this.btnVerChoferes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminarBus);
            this.panel1.Controls.Add(this.dtpFechaLlegada);
            this.panel1.Controls.Add(this.dtpFechaSalida);
            this.panel1.Controls.Add(this.cbDestino);
            this.panel1.Controls.Add(this.cbPuntoSalida);
            this.panel1.Controls.Add(this.cbTipoBus);
            this.panel1.Controls.Add(this.nudPrecio);
            this.panel1.Controls.Add(this.btnRegistrarBus);
            this.panel1.Controls.Add(this.btnCancelarBus);
            this.panel1.Controls.Add(this.txtMatricula);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(835, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 590);
            this.panel1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(79, 409);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Importante elegir el dni del chofer*";
            // 
            // cbDniChofer
            // 
            this.cbDniChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDniChofer.FormattingEnabled = true;
            this.cbDniChofer.Items.AddRange(new object[] {
            "Economico",
            "Vip",
            "Primera Clase",
            "Negocio"});
            this.cbDniChofer.Location = new System.Drawing.Point(115, 365);
            this.cbDniChofer.Margin = new System.Windows.Forms.Padding(2);
            this.cbDniChofer.Name = "cbDniChofer";
            this.cbDniChofer.Size = new System.Drawing.Size(133, 21);
            this.cbDniChofer.TabIndex = 22;
            // 
            // btnVerChoferes
            // 
            this.btnVerChoferes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnVerChoferes.FlatAppearance.BorderSize = 0;
            this.btnVerChoferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerChoferes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerChoferes.ForeColor = System.Drawing.Color.White;
            this.btnVerChoferes.Location = new System.Drawing.Point(252, 360);
            this.btnVerChoferes.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerChoferes.Name = "btnVerChoferes";
            this.btnVerChoferes.Size = new System.Drawing.Size(79, 28);
            this.btnVerChoferes.TabIndex = 21;
            this.btnVerChoferes.Text = "Ver Choferes";
            this.btnVerChoferes.UseVisualStyleBackColor = false;
            this.btnVerChoferes.Click += new System.EventHandler(this.btnVerChoferes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(20, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dni del Chofer";
            // 
            // btnEliminarBus
            // 
            this.btnEliminarBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(113)))), ((int)(((byte)(137)))));
            this.btnEliminarBus.FlatAppearance.BorderSize = 0;
            this.btnEliminarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarBus.ForeColor = System.Drawing.Color.White;
            this.btnEliminarBus.Location = new System.Drawing.Point(100, 538);
            this.btnEliminarBus.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarBus.Name = "btnEliminarBus";
            this.btnEliminarBus.Size = new System.Drawing.Size(150, 30);
            this.btnEliminarBus.TabIndex = 20;
            this.btnEliminarBus.Text = "Eliminar bus";
            this.btnEliminarBus.UseVisualStyleBackColor = false;
            this.btnEliminarBus.Click += new System.EventHandler(this.btnEliminarBus_Click);
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(116, 287);
            this.dtpFechaLlegada.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaLlegada.MinDate = new System.DateTime(2023, 11, 18, 12, 13, 29, 221);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(189, 20);
            this.dtpFechaLlegada.TabIndex = 9;
            this.dtpFechaLlegada.Value = new System.DateTime(2023, 11, 18, 12, 13, 29, 221);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSalida.Location = new System.Drawing.Point(116, 173);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaSalida.MinDate = new System.DateTime(2023, 11, 18, 12, 13, 29, 223);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(189, 20);
            this.dtpFechaSalida.TabIndex = 9;
            this.dtpFechaSalida.Value = new System.DateTime(2023, 11, 18, 12, 13, 29, 223);
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
            this.cbDestino.Location = new System.Drawing.Point(115, 249);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(189, 21);
            this.cbDestino.TabIndex = 8;
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
            this.cbPuntoSalida.Location = new System.Drawing.Point(115, 211);
            this.cbPuntoSalida.Margin = new System.Windows.Forms.Padding(2);
            this.cbPuntoSalida.Name = "cbPuntoSalida";
            this.cbPuntoSalida.Size = new System.Drawing.Size(189, 21);
            this.cbPuntoSalida.TabIndex = 8;
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
            this.cbTipoBus.Location = new System.Drawing.Point(115, 133);
            this.cbTipoBus.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoBus.Name = "cbTipoBus";
            this.cbTipoBus.Size = new System.Drawing.Size(189, 21);
            this.cbTipoBus.TabIndex = 8;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(116, 322);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecio.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(73, 20);
            this.nudPrecio.TabIndex = 7;
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrecio.Value = new decimal(new int[] {
            2250,
            0,
            0,
            131072});
            // 
            // btnRegistrarBus
            // 
            this.btnRegistrarBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnRegistrarBus.FlatAppearance.BorderSize = 0;
            this.btnRegistrarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarBus.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarBus.Location = new System.Drawing.Point(100, 492);
            this.btnRegistrarBus.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarBus.Name = "btnRegistrarBus";
            this.btnRegistrarBus.Size = new System.Drawing.Size(150, 30);
            this.btnRegistrarBus.TabIndex = 4;
            this.btnRegistrarBus.Text = "Registrar bus";
            this.btnRegistrarBus.UseVisualStyleBackColor = false;
            this.btnRegistrarBus.Click += new System.EventHandler(this.btnRegistrarBus_Click);
            // 
            // btnCancelarBus
            // 
            this.btnCancelarBus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelarBus.FlatAppearance.BorderSize = 0;
            this.btnCancelarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarBus.ForeColor = System.Drawing.Color.White;
            this.btnCancelarBus.Location = new System.Drawing.Point(100, 448);
            this.btnCancelarBus.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarBus.Name = "btnCancelarBus";
            this.btnCancelarBus.Size = new System.Drawing.Size(148, 30);
            this.btnCancelarBus.TabIndex = 4;
            this.btnCancelarBus.Text = "Cancelar bus";
            this.btnCancelarBus.UseVisualStyleBackColor = false;
            this.btnCancelarBus.Click += new System.EventHandler(this.btnCancelarBus_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(116, 54);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(189, 20);
            this.txtMatricula.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(-2, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "    Fecha de llegada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(4, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "    Fecha de salida\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(38, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo de bus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(66, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(37, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad de\r\n      Asientos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(58, 251);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(22, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(49, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(20, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detalles del bus:";
            // 
            // lblTotalBuses
            // 
            this.lblTotalBuses.AutoSize = true;
            this.lblTotalBuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalBuses.Location = new System.Drawing.Point(662, 15);
            this.lblTotalBuses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBuses.Name = "lblTotalBuses";
            this.lblTotalBuses.Size = new System.Drawing.Size(14, 15);
            this.lblTotalBuses.TabIndex = 15;
            this.lblTotalBuses.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.Location = new System.Drawing.Point(555, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Total de buses: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(11, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Lista de buses: ";
            // 
            // dgBuses
            // 
            this.dgBuses.AllowUserToAddRows = false;
            this.dgBuses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgBuses.Location = new System.Drawing.Point(1, 75);
            this.dgBuses.MultiSelect = false;
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBuses.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBuses.RowTemplate.Height = 28;
            this.dgBuses.Size = new System.Drawing.Size(830, 562);
            this.dgBuses.TabIndex = 22;
            this.dgBuses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBuses_CellContentClick);
            this.dgBuses.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgBuses_CellPainting);
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
            this.CantidadAsiento.Width = 60;
            // 
            // AsientosDisponibles
            // 
            this.AsientosDisponibles.HeaderText = "Asientos Disponibles";
            this.AsientosDisponibles.Name = "AsientosDisponibles";
            this.AsientosDisponibles.ReadOnly = true;
            this.AsientosDisponibles.Width = 75;
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
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(343, 44);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(193, 20);
            this.txtBusqueda.TabIndex = 27;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(558, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 24);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(643, 43);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 24);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBusqueda.DisplayMember = "0";
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Location = new System.Drawing.Point(162, 42);
            this.cbBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(158, 21);
            this.cbBusqueda.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label11.Location = new System.Drawing.Point(72, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Buscar por:";
            // 
            // nudCantidadAsientos
            // 
            this.nudCantidadAsientos.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudCantidadAsientos.Location = new System.Drawing.Point(116, 93);
            this.nudCantidadAsientos.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudCantidadAsientos.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudCantidadAsientos.Name = "nudCantidadAsientos";
            this.nudCantidadAsientos.Size = new System.Drawing.Size(46, 20);
            this.nudCantidadAsientos.TabIndex = 24;
            this.nudCantidadAsientos.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // frmBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 649);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgBuses);
            this.Controls.Add(this.lblTotalBuses);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBus";
            this.Text = "frmBus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnRegistrarBus;
        private Button btnCancelarBus;
        private TextBox txtMatricula;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbTipoBus;
        private Label label2;
        private ComboBox cbDestino;
        private ComboBox cbPuntoSalida;
        private NumericUpDown nudPrecio;
        private Label label7;
        private Label label8;
        private Label label12;
        private Label lblTotalBuses;
        private Label label14;
        private Label label15;
        private Button btnEliminarBus;
        private DateTimePicker dtpFechaLlegada;
        private DateTimePicker dtpFechaSalida;
        private DataGridView dgBuses;
        private ComboBox cbDniChofer;
        private Button btnVerChoferes;
        private Label label1;
        private Label label10;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private Button btnLimpiar;
        private ComboBox cbBusqueda;
        private Label label11;
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
        private NumericUpDown nudCantidadAsientos;
    }
}