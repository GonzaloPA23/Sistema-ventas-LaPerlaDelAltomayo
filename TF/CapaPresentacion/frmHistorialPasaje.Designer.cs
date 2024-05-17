using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmHistorialPasaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalPasajes = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBusqueda = new System.Windows.Forms.ComboBox();
            this.dgPasajes = new System.Windows.Forms.DataGridView();
            this.dgBuses = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPasajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(736, 85);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 24);
            this.button4.TabIndex = 16;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(853, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 24);
            this.button2.TabIndex = 17;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label16.Location = new System.Drawing.Point(902, 549);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 7;
            // 
            // lblTotalPasajes
            // 
            this.lblTotalPasajes.AutoSize = true;
            this.lblTotalPasajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalPasajes.Location = new System.Drawing.Point(866, 40);
            this.lblTotalPasajes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPasajes.Name = "lblTotalPasajes";
            this.lblTotalPasajes.Size = new System.Drawing.Size(14, 15);
            this.lblTotalPasajes.TabIndex = 8;
            this.lblTotalPasajes.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(762, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total de pasajes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(181, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Historial de mis pasajes:";
            // 
            // cbBusqueda
            // 
            this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusqueda.FormattingEnabled = true;
            this.cbBusqueda.Location = new System.Drawing.Point(294, 87);
            this.cbBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.cbBusqueda.Name = "cbBusqueda";
            this.cbBusqueda.Size = new System.Drawing.Size(188, 21);
            this.cbBusqueda.TabIndex = 21;
            // 
            // dgPasajes
            // 
            this.dgPasajes.AllowUserToAddRows = false;
            this.dgPasajes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPasajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgPasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPasajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UsuarioId,
            this.BusId,
            this.Asiento,
            this.Piso,
            this.FechaCompra});
            this.dgPasajes.Location = new System.Drawing.Point(12, 140);
            this.dgPasajes.MultiSelect = false;
            this.dgPasajes.Name = "dgPasajes";
            this.dgPasajes.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPasajes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgPasajes.RowTemplate.Height = 28;
            this.dgPasajes.Size = new System.Drawing.Size(470, 474);
            this.dgPasajes.TabIndex = 23;
            // 
            // dgBuses
            // 
            this.dgBuses.AllowUserToAddRows = false;
            this.dgBuses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.dataGridViewTextBoxColumn1,
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
            this.dgBuses.Location = new System.Drawing.Point(502, 191);
            this.dgBuses.MultiSelect = false;
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.ReadOnly = true;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBuses.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgBuses.RowTemplate.Height = 28;
            this.dgBuses.Size = new System.Drawing.Size(669, 424);
            this.dgBuses.TabIndex = 24;
            // 
            // Id
            // 
            this.Id.HeaderText = "N° de orden";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // UsuarioId
            // 
            this.UsuarioId.HeaderText = "UsuarioId";
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.ReadOnly = true;
            this.UsuarioId.Visible = false;
            this.UsuarioId.Width = 80;
            // 
            // BusId
            // 
            this.BusId.HeaderText = "BusId";
            this.BusId.Name = "BusId";
            this.BusId.ReadOnly = true;
            this.BusId.Width = 80;
            // 
            // Asiento
            // 
            this.Asiento.HeaderText = "Asiento";
            this.Asiento.Name = "Asiento";
            this.Asiento.ReadOnly = true;
            this.Asiento.Width = 80;
            // 
            // Piso
            // 
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            this.Piso.Width = 80;
            // 
            // FechaCompra
            // 
            this.FechaCompra.HeaderText = "FechaCompra";
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
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
            this.CantidadAsiento.Visible = false;
            this.CantidadAsiento.Width = 60;
            // 
            // AsientosDisponibles
            // 
            this.AsientosDisponibles.HeaderText = "Asientos Disponibles";
            this.AsientosDisponibles.Name = "AsientosDisponibles";
            this.AsientosDisponibles.ReadOnly = true;
            this.AsientosDisponibles.Visible = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(505, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Buses";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(509, 85);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(197, 20);
            this.tbBusqueda.TabIndex = 25;
            // 
            // frmHistorialPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 649);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.dgBuses);
            this.Controls.Add(this.dgPasajes);
            this.Controls.Add(this.cbBusqueda);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTotalPasajes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHistorialPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorialPasaje";
            this.Load += new System.EventHandler(this.frmHistorialPasaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPasajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button4;
        private Button button2;
        private Label label16;
        private Label lblTotalPasajes;
        private Label label10;
        private Label label2;
        private Label label1;
        private ComboBox cbBusqueda;
        private DataGridView dgPasajes;
        private DataGridView dgBuses;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UsuarioId;
        private DataGridViewTextBoxColumn BusId;
        private DataGridViewTextBoxColumn Asiento;
        private DataGridViewTextBoxColumn Piso;
        private DataGridViewTextBoxColumn FechaCompra;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private Label label3;
        private TextBox tbBusqueda;
    }
}