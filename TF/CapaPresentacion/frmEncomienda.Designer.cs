using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmEncomienda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTipoEncomienda = new System.Windows.Forms.ComboBox();
            this.dtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbPuntoSalida = new System.Windows.Forms.ComboBox();
            this.lblPrecioCalculado = new System.Windows.Forms.Label();
            this.nudAlto = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudLargo = new System.Windows.Forms.NumericUpDown();
            this.nudAncho = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkbAutorizacion1 = new System.Windows.Forms.CheckBox();
            this.checkbAutorizacion2 = new System.Windows.Forms.CheckBox();
            this.btnConfirmarEncomienda = new System.Windows.Forms.Button();
            this.btnCancelarEncomienda = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbTipoEncomienda);
            this.panel1.Controls.Add(this.dtpFechaEnvio);
            this.panel1.Controls.Add(this.cbDestino);
            this.panel1.Controls.Add(this.cbPuntoSalida);
            this.panel1.Controls.Add(this.lblPrecioCalculado);
            this.panel1.Controls.Add(this.nudAlto);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.nudLargo);
            this.panel1.Controls.Add(this.nudAncho);
            this.panel1.Controls.Add(this.nudPeso);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(75, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 391);
            this.panel1.TabIndex = 15;
            // 
            // cbTipoEncomienda
            // 
            this.cbTipoEncomienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEncomienda.FormattingEnabled = true;
            this.cbTipoEncomienda.Items.AddRange(new object[] {
            "Fragil",
            "No Fragil",
            "Ropa",
            "Muebles"});
            this.cbTipoEncomienda.Location = new System.Drawing.Point(151, 171);
            this.cbTipoEncomienda.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoEncomienda.Name = "cbTipoEncomienda";
            this.cbTipoEncomienda.Size = new System.Drawing.Size(189, 21);
            this.cbTipoEncomienda.TabIndex = 17;
            this.cbTipoEncomienda.SelectedIndexChanged += new System.EventHandler(this.cbTipoEncomienda_SelectedIndexChanged);
            // 
            // dtpFechaEnvio
            // 
            this.dtpFechaEnvio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEnvio.Location = new System.Drawing.Point(151, 130);
            this.dtpFechaEnvio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaEnvio.MinDate = new System.DateTime(2023, 11, 18, 12, 13, 29, 223);
            this.dtpFechaEnvio.Name = "dtpFechaEnvio";
            this.dtpFechaEnvio.Size = new System.Drawing.Size(189, 20);
            this.dtpFechaEnvio.TabIndex = 16;
            this.dtpFechaEnvio.Value = new System.DateTime(2023, 11, 18, 12, 13, 29, 223);
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
            this.cbDestino.Location = new System.Drawing.Point(151, 91);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(189, 21);
            this.cbDestino.TabIndex = 15;
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
            this.cbPuntoSalida.Location = new System.Drawing.Point(151, 54);
            this.cbPuntoSalida.Margin = new System.Windows.Forms.Padding(2);
            this.cbPuntoSalida.Name = "cbPuntoSalida";
            this.cbPuntoSalida.Size = new System.Drawing.Size(189, 21);
            this.cbPuntoSalida.TabIndex = 14;
            // 
            // lblPrecioCalculado
            // 
            this.lblPrecioCalculado.AutoSize = true;
            this.lblPrecioCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecioCalculado.Location = new System.Drawing.Point(191, 355);
            this.lblPrecioCalculado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioCalculado.Name = "lblPrecioCalculado";
            this.lblPrecioCalculado.Size = new System.Drawing.Size(56, 15);
            this.lblPrecioCalculado.TabIndex = 13;
            this.lblPrecioCalculado.Text = "S/. 0.00";
            // 
            // nudAlto
            // 
            this.nudAlto.Location = new System.Drawing.Point(151, 277);
            this.nudAlto.Margin = new System.Windows.Forms.Padding(2);
            this.nudAlto.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudAlto.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAlto.Name = "nudAlto";
            this.nudAlto.Size = new System.Drawing.Size(73, 20);
            this.nudAlto.TabIndex = 12;
            this.nudAlto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAlto.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(58, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Alto en cm";
            // 
            // nudLargo
            // 
            this.nudLargo.Location = new System.Drawing.Point(151, 244);
            this.nudLargo.Margin = new System.Windows.Forms.Padding(2);
            this.nudLargo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLargo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLargo.Name = "nudLargo";
            this.nudLargo.Size = new System.Drawing.Size(73, 20);
            this.nudLargo.TabIndex = 10;
            this.nudLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLargo.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nudAncho
            // 
            this.nudAncho.Location = new System.Drawing.Point(151, 308);
            this.nudAncho.Margin = new System.Windows.Forms.Padding(2);
            this.nudAncho.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudAncho.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAncho.Name = "nudAncho";
            this.nudAncho.Size = new System.Drawing.Size(73, 20);
            this.nudAncho.TabIndex = 10;
            this.nudAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAncho.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(152, 207);
            this.nudPeso.Margin = new System.Windows.Forms.Padding(2);
            this.nudPeso.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudPeso.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(73, 20);
            this.nudPeso.TabIndex = 10;
            this.nudPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPeso.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPeso.ValueChanged += new System.EventHandler(this.nudPeso_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(89, 355);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Precio estimado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(48, 244);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Largo en cm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(47, 313);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ancho en cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(58, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Peso en kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(11, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detalles de la encomienda:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de salida";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(73, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(21, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "    Fecha de envío";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(22, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo de producto";
            // 
            // checkbAutorizacion1
            // 
            this.checkbAutorizacion1.AutoSize = true;
            this.checkbAutorizacion1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkbAutorizacion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbAutorizacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.checkbAutorizacion1.Location = new System.Drawing.Point(75, 468);
            this.checkbAutorizacion1.Margin = new System.Windows.Forms.Padding(2);
            this.checkbAutorizacion1.Name = "checkbAutorizacion1";
            this.checkbAutorizacion1.Size = new System.Drawing.Size(341, 30);
            this.checkbAutorizacion1.TabIndex = 16;
            this.checkbAutorizacion1.Text = "Autorizo el material de mediciones de la plataforma para especificar \r\nlas dimens" +
    "iones de mi encomienda";
            this.checkbAutorizacion1.UseVisualStyleBackColor = true;
            // 
            // checkbAutorizacion2
            // 
            this.checkbAutorizacion2.AutoSize = true;
            this.checkbAutorizacion2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkbAutorizacion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbAutorizacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.checkbAutorizacion2.Location = new System.Drawing.Point(75, 510);
            this.checkbAutorizacion2.Margin = new System.Windows.Forms.Padding(2);
            this.checkbAutorizacion2.Name = "checkbAutorizacion2";
            this.checkbAutorizacion2.Size = new System.Drawing.Size(331, 43);
            this.checkbAutorizacion2.TabIndex = 16;
            this.checkbAutorizacion2.Text = "Autorizo el cambio de tarifas según los datos brindados cuando la\r\nencomienda lle" +
    "gue a las instalaciones para acordar el precio\r\nrespectivo.";
            this.checkbAutorizacion2.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEncomienda
            // 
            this.btnConfirmarEncomienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnConfirmarEncomienda.FlatAppearance.BorderSize = 0;
            this.btnConfirmarEncomienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarEncomienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarEncomienda.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarEncomienda.Location = new System.Drawing.Point(299, 590);
            this.btnConfirmarEncomienda.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarEncomienda.Name = "btnConfirmarEncomienda";
            this.btnConfirmarEncomienda.Size = new System.Drawing.Size(163, 30);
            this.btnConfirmarEncomienda.TabIndex = 17;
            this.btnConfirmarEncomienda.Text = "Confirmar encomienda";
            this.btnConfirmarEncomienda.UseVisualStyleBackColor = false;
            this.btnConfirmarEncomienda.Click += new System.EventHandler(this.btnConfirmarEncomienda_Click);
            // 
            // btnCancelarEncomienda
            // 
            this.btnCancelarEncomienda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelarEncomienda.FlatAppearance.BorderSize = 0;
            this.btnCancelarEncomienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEncomienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarEncomienda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarEncomienda.Location = new System.Drawing.Point(75, 590);
            this.btnCancelarEncomienda.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarEncomienda.Name = "btnCancelarEncomienda";
            this.btnCancelarEncomienda.Size = new System.Drawing.Size(166, 30);
            this.btnCancelarEncomienda.TabIndex = 18;
            this.btnCancelarEncomienda.Text = "Cancelar encomienda";
            this.btnCancelarEncomienda.UseVisualStyleBackColor = false;
            this.btnCancelarEncomienda.Click += new System.EventHandler(this.btnCancelarEncomienda_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(31, 561);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(443, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Todas las encomiendas se entregarán con un plazo de 7 días a partir de la fecha d" +
    "e envío.*";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackgroundImage = global::CapaPresentacion.Properties.Resources.logo_perla_del_altomayo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(708, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label14.Location = new System.Drawing.Point(642, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(357, 48);
            this.label14.TabIndex = 21;
            this.label14.Text = "¡Confíe en nuestra plataforma para enviar \r\nencomiendas!";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.encomienda_fondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(544, 248);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 350);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnConfirmarEncomienda);
            this.Controls.Add(this.btnCancelarEncomienda);
            this.Controls.Add(this.checkbAutorizacion2);
            this.Controls.Add(this.checkbAutorizacion1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEncomienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEncomienda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private NumericUpDown nudPeso;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label12;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label lblPrecioCalculado;
        private NumericUpDown nudAlto;
        private Label label11;
        private NumericUpDown nudLargo;
        private NumericUpDown nudAncho;
        private Label label10;
        private Label label1;
        private CheckBox checkbAutorizacion1;
        private CheckBox checkbAutorizacion2;
        private Button btnConfirmarEncomienda;
        private Button btnCancelarEncomienda;
        private Label label8;
        private PictureBox pictureBox2;
        private Label label14;
        private PictureBox pictureBox1;
        private ComboBox cbPuntoSalida;
        private ComboBox cbDestino;
        private DateTimePicker dtpFechaEnvio;
        private ComboBox cbTipoEncomienda;
    }
}