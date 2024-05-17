using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmHistorialEncomienda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTotalEncomiendas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFechaPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgHistorialEncomiendas = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntoSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorialEncomiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(830, 63);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(96, 24);
            this.btnFiltrar.TabIndex = 27;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(937, 63);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 24);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTotalEncomiendas
            // 
            this.lblTotalEncomiendas.AutoSize = true;
            this.lblTotalEncomiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalEncomiendas.Location = new System.Drawing.Point(1014, 28);
            this.lblTotalEncomiendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalEncomiendas.Name = "lblTotalEncomiendas";
            this.lblTotalEncomiendas.Size = new System.Drawing.Size(15, 17);
            this.lblTotalEncomiendas.TabIndex = 22;
            this.lblTotalEncomiendas.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(873, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total de encomiendas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(84, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Buscar por destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Historial de mis encomiendas:";
            // 
            // cbFechaPedido
            // 
            this.cbFechaPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechaPedido.FormattingEnabled = true;
            this.cbFechaPedido.Items.AddRange(new object[] {
            "Más recientes",
            "Más antiguos"});
            this.cbFechaPedido.Location = new System.Drawing.Point(565, 64);
            this.cbFechaPedido.Margin = new System.Windows.Forms.Padding(2);
            this.cbFechaPedido.Name = "cbFechaPedido";
            this.cbFechaPedido.Size = new System.Drawing.Size(180, 21);
            this.cbFechaPedido.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(441, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha de pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(445, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ordenar por:";
            // 
            // dgHistorialEncomiendas
            // 
            this.dgHistorialEncomiendas.AllowUserToAddRows = false;
            this.dgHistorialEncomiendas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHistorialEncomiendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgHistorialEncomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorialEncomiendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Id,
            this.UsuarioId,
            this.Destino,
            this.PuntoSalida,
            this.FechaEnvio,
            this.FechaLlegada,
            this.TipoProducto,
            this.Peso,
            this.Largo,
            this.Alto,
            this.Ancho,
            this.Precio,
            this.FechaPedido});
            this.dgHistorialEncomiendas.Location = new System.Drawing.Point(12, 105);
            this.dgHistorialEncomiendas.MultiSelect = false;
            this.dgHistorialEncomiendas.Name = "dgHistorialEncomiendas";
            this.dgHistorialEncomiendas.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgHistorialEncomiendas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgHistorialEncomiendas.RowTemplate.Height = 28;
            this.dgHistorialEncomiendas.Size = new System.Drawing.Size(1159, 532);
            this.dgHistorialEncomiendas.TabIndex = 33;
            this.dgHistorialEncomiendas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgHistorialEncomiendas_CellPainting);
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
            this.Id.HeaderText = "N° de orden";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // UsuarioId
            // 
            this.UsuarioId.HeaderText = "UsuarioId";
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.ReadOnly = true;
            this.UsuarioId.Visible = false;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 75;
            // 
            // PuntoSalida
            // 
            this.PuntoSalida.HeaderText = "Punto de Salida";
            this.PuntoSalida.Name = "PuntoSalida";
            this.PuntoSalida.ReadOnly = true;
            this.PuntoSalida.Width = 90;
            // 
            // FechaEnvio
            // 
            this.FechaEnvio.HeaderText = "Fecha de envio";
            this.FechaEnvio.Name = "FechaEnvio";
            this.FechaEnvio.ReadOnly = true;
            this.FechaEnvio.Width = 130;
            // 
            // FechaLlegada
            // 
            this.FechaLlegada.HeaderText = "Fecha de Llegada";
            this.FechaLlegada.Name = "FechaLlegada";
            this.FechaLlegada.ReadOnly = true;
            this.FechaLlegada.Width = 130;
            // 
            // TipoProducto
            // 
            this.TipoProducto.HeaderText = "Tipo de producto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            this.TipoProducto.Width = 80;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso en kg";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 70;
            // 
            // Largo
            // 
            this.Largo.HeaderText = "Largo en cm";
            this.Largo.Name = "Largo";
            this.Largo.ReadOnly = true;
            this.Largo.Width = 70;
            // 
            // Alto
            // 
            this.Alto.HeaderText = "Alto en cm";
            this.Alto.Name = "Alto";
            this.Alto.ReadOnly = true;
            this.Alto.Width = 70;
            // 
            // Ancho
            // 
            this.Ancho.HeaderText = "Ancho en cm";
            this.Ancho.Name = "Ancho";
            this.Ancho.ReadOnly = true;
            this.Ancho.Width = 70;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio estimado";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 90;
            // 
            // FechaPedido
            // 
            this.FechaPedido.HeaderText = "Fecha de Pedido";
            this.FechaPedido.Name = "FechaPedido";
            this.FechaPedido.ReadOnly = true;
            this.FechaPedido.Width = 130;
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
            this.cbDestino.Location = new System.Drawing.Point(222, 63);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(189, 21);
            this.cbDestino.TabIndex = 34;
            // 
            // frmHistorialEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 649);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.dgHistorialEncomiendas);
            this.Controls.Add(this.cbFechaPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotalEncomiendas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHistorialEncomienda";
            this.Text = "frmHistorialEncomienda";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorialEncomiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnFiltrar;
        private Button btnLimpiar;
        private Label lblTotalEncomiendas;
        private Label label10;
        private Label label2;
        private Label label1;
        private ComboBox cbFechaPedido;
        private Label label3;
        private Label label4;
        private DataGridView dgHistorialEncomiendas;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UsuarioId;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn PuntoSalida;
        private DataGridViewTextBoxColumn FechaEnvio;
        private DataGridViewTextBoxColumn FechaLlegada;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Largo;
        private DataGridViewTextBoxColumn Alto;
        private DataGridViewTextBoxColumn Ancho;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn FechaPedido;
        private ComboBox cbDestino;
    }
}