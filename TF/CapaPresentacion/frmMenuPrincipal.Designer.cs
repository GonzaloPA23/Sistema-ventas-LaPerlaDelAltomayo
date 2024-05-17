using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmMenuPrincipal
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesionMP = new System.Windows.Forms.Button();
            this.btnRegistrarseMP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(209, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chiclayo - Lima y Viceversa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(252, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "SALIDAS DIARIAS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 110);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bienvenido a La Perla \r\ndel Altomayo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.bus_menu;
            this.pictureBox2.Location = new System.Drawing.Point(128, 325);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(423, 268);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo_perla_del_altomayo;
            this.pictureBox1.Location = new System.Drawing.Point(246, -28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnIniciarSesionMP
            // 
            this.btnIniciarSesionMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSesionMP.AutoEllipsis = true;
            this.btnIniciarSesionMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.btnIniciarSesionMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesionMP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIniciarSesionMP.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesionMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(113)))), ((int)(((byte)(142)))));
            this.btnIniciarSesionMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesionMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesionMP.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesionMP.Location = new System.Drawing.Point(164, 630);
            this.btnIniciarSesionMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarSesionMP.Name = "btnIniciarSesionMP";
            this.btnIniciarSesionMP.Size = new System.Drawing.Size(355, 60);
            this.btnIniciarSesionMP.TabIndex = 16;
            this.btnIniciarSesionMP.Text = "Iniciar sesión";
            this.btnIniciarSesionMP.UseVisualStyleBackColor = false;
            this.btnIniciarSesionMP.Click += new System.EventHandler(this.btnIniciarSesionMP_Click);
            // 
            // btnRegistrarseMP
            // 
            this.btnRegistrarseMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarseMP.AutoEllipsis = true;
            this.btnRegistrarseMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(113)))), ((int)(((byte)(137)))));
            this.btnRegistrarseMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarseMP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrarseMP.FlatAppearance.BorderSize = 0;
            this.btnRegistrarseMP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.btnRegistrarseMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarseMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarseMP.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarseMP.Location = new System.Drawing.Point(164, 709);
            this.btnRegistrarseMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarseMP.Name = "btnRegistrarseMP";
            this.btnRegistrarseMP.Size = new System.Drawing.Size(355, 60);
            this.btnRegistrarseMP.TabIndex = 15;
            this.btnRegistrarseMP.Text = "Registrarse";
            this.btnRegistrarseMP.UseVisualStyleBackColor = false;
            this.btnRegistrarseMP.Click += new System.EventHandler(this.btnRegistrarseMP_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(709, 836);
            this.Controls.Add(this.btnRegistrarseMP);
            this.Controls.Add(this.btnIniciarSesionMP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnIniciarSesionMP;
        private Button btnRegistrarseMP;
    }
}