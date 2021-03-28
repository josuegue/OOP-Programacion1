
using System;

namespace EjercicioPOO1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BotonInicio = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelDatos = new System.Windows.Forms.Label();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.labelCrear = new System.Windows.Forms.Label();
            this.buttonDisminuir = new System.Windows.Forms.Button();
            this.labelApagar = new System.Windows.Forms.Label();
            this.buttonSegunda = new System.Windows.Forms.Button();
            this.buttonTercera = new System.Windows.Forms.Button();
            this.buttonCuarta = new System.Windows.Forms.Button();
            this.buttonQuinta = new System.Windows.Forms.Button();
            this.buttonSexta = new System.Windows.Forms.Button();
            this.buttonPrimera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonInicio
            // 
            this.BotonInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonInicio.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.BotonInicio.FlatAppearance.BorderSize = 2;
            this.BotonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonInicio.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInicio.ForeColor = System.Drawing.Color.Aqua;
            this.BotonInicio.Location = new System.Drawing.Point(212, 12);
            this.BotonInicio.Name = "BotonInicio";
            this.BotonInicio.Size = new System.Drawing.Size(113, 28);
            this.BotonInicio.TabIndex = 0;
            this.BotonInicio.Text = "Crear Carro";
            this.BotonInicio.UseVisualStyleBackColor = false;
            this.BotonInicio.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEncender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEncender.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonEncender.FlatAppearance.BorderSize = 3;
            this.buttonEncender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncender.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.ForeColor = System.Drawing.Color.Aqua;
            this.buttonEncender.Image = ((System.Drawing.Image)(resources.GetObject("buttonEncender.Image")));
            this.buttonEncender.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonEncender.Location = new System.Drawing.Point(88, 51);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(163, 42);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender Carro";
            this.buttonEncender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAcelerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcelerar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonAcelerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcelerar.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcelerar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonAcelerar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAcelerar.Image")));
            this.buttonAcelerar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonAcelerar.Location = new System.Drawing.Point(104, 110);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(135, 38);
            this.buttonAcelerar.TabIndex = 2;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.BackColor = System.Drawing.Color.White;
            this.buttonFrenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFrenar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonFrenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFrenar.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFrenar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonFrenar.Location = new System.Drawing.Point(262, 118);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(108, 30);
            this.buttonFrenar.TabIndex = 3;
            this.buttonFrenar.Text = "Frenar";
            this.buttonFrenar.UseVisualStyleBackColor = false;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.White;
            this.buttonApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApagar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonApagar.FlatAppearance.BorderSize = 3;
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagar.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApagar.ForeColor = System.Drawing.Color.Aqua;
            this.buttonApagar.Location = new System.Drawing.Point(288, 51);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(132, 42);
            this.buttonApagar.TabIndex = 4;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.BackColor = System.Drawing.Color.Navy;
            this.labelDatos.ForeColor = System.Drawing.Color.White;
            this.labelDatos.Location = new System.Drawing.Point(394, 124);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(58, 13);
            this.labelDatos.TabIndex = 5;
            this.labelDatos.Text = "Encendido";
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.BackColor = System.Drawing.Color.Navy;
            this.labelVelocidad.ForeColor = System.Drawing.Color.White;
            this.labelVelocidad.Location = new System.Drawing.Point(496, 153);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(63, 13);
            this.labelVelocidad.TabIndex = 6;
            this.labelVelocidad.Text = "Aceleracion";
            // 
            // labelCrear
            // 
            this.labelCrear.AutoSize = true;
            this.labelCrear.BackColor = System.Drawing.Color.Navy;
            this.labelCrear.ForeColor = System.Drawing.Color.White;
            this.labelCrear.Location = new System.Drawing.Point(498, 80);
            this.labelCrear.Name = "labelCrear";
            this.labelCrear.Size = new System.Drawing.Size(62, 13);
            this.labelCrear.TabIndex = 7;
            this.labelCrear.Text = "Datos carro";
            // 
            // buttonDisminuir
            // 
            this.buttonDisminuir.BackColor = System.Drawing.Color.White;
            this.buttonDisminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisminuir.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisminuir.ForeColor = System.Drawing.Color.Aqua;
            this.buttonDisminuir.Location = new System.Drawing.Point(262, 168);
            this.buttonDisminuir.Name = "buttonDisminuir";
            this.buttonDisminuir.Size = new System.Drawing.Size(106, 25);
            this.buttonDisminuir.TabIndex = 8;
            this.buttonDisminuir.Text = "Disminuir";
            this.buttonDisminuir.UseVisualStyleBackColor = false;
            this.buttonDisminuir.Click += new System.EventHandler(this.buttonDisminuir_Click);
            // 
            // labelApagar
            // 
            this.labelApagar.AutoSize = true;
            this.labelApagar.BackColor = System.Drawing.Color.Navy;
            this.labelApagar.ForeColor = System.Drawing.Color.White;
            this.labelApagar.Location = new System.Drawing.Point(604, 124);
            this.labelApagar.Name = "labelApagar";
            this.labelApagar.Size = new System.Drawing.Size(50, 13);
            this.labelApagar.TabIndex = 10;
            this.labelApagar.Text = "Apagado";
            // 
            // buttonSegunda
            // 
            this.buttonSegunda.BackColor = System.Drawing.Color.Aqua;
            this.buttonSegunda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSegunda.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSegunda.ForeColor = System.Drawing.Color.Black;
            this.buttonSegunda.Location = new System.Drawing.Point(136, 199);
            this.buttonSegunda.Name = "buttonSegunda";
            this.buttonSegunda.Size = new System.Drawing.Size(75, 23);
            this.buttonSegunda.TabIndex = 12;
            this.buttonSegunda.Text = "Segunda";
            this.buttonSegunda.UseVisualStyleBackColor = false;
            this.buttonSegunda.Click += new System.EventHandler(this.buttonSegunda_Click);
            // 
            // buttonTercera
            // 
            this.buttonTercera.BackColor = System.Drawing.Color.Aqua;
            this.buttonTercera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTercera.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonTercera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTercera.ForeColor = System.Drawing.Color.Black;
            this.buttonTercera.Location = new System.Drawing.Point(136, 228);
            this.buttonTercera.Name = "buttonTercera";
            this.buttonTercera.Size = new System.Drawing.Size(75, 23);
            this.buttonTercera.TabIndex = 13;
            this.buttonTercera.Text = "Tercera";
            this.buttonTercera.UseVisualStyleBackColor = false;
            this.buttonTercera.Click += new System.EventHandler(this.buttonTercera_Click);
            // 
            // buttonCuarta
            // 
            this.buttonCuarta.BackColor = System.Drawing.Color.Aqua;
            this.buttonCuarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCuarta.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonCuarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCuarta.Location = new System.Drawing.Point(136, 257);
            this.buttonCuarta.Name = "buttonCuarta";
            this.buttonCuarta.Size = new System.Drawing.Size(75, 23);
            this.buttonCuarta.TabIndex = 14;
            this.buttonCuarta.Text = "Cuarta";
            this.buttonCuarta.UseVisualStyleBackColor = false;
            this.buttonCuarta.Click += new System.EventHandler(this.buttonCuarta_Click);
            // 
            // buttonQuinta
            // 
            this.buttonQuinta.BackColor = System.Drawing.Color.Aqua;
            this.buttonQuinta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuinta.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonQuinta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuinta.Location = new System.Drawing.Point(136, 286);
            this.buttonQuinta.Name = "buttonQuinta";
            this.buttonQuinta.Size = new System.Drawing.Size(75, 23);
            this.buttonQuinta.TabIndex = 15;
            this.buttonQuinta.Text = "Quinta";
            this.buttonQuinta.UseVisualStyleBackColor = false;
            this.buttonQuinta.Click += new System.EventHandler(this.buttonQuinta_Click);
            // 
            // buttonSexta
            // 
            this.buttonSexta.BackColor = System.Drawing.Color.Aqua;
            this.buttonSexta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSexta.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonSexta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSexta.Location = new System.Drawing.Point(136, 315);
            this.buttonSexta.Name = "buttonSexta";
            this.buttonSexta.Size = new System.Drawing.Size(75, 23);
            this.buttonSexta.TabIndex = 16;
            this.buttonSexta.Text = "Sexta";
            this.buttonSexta.UseVisualStyleBackColor = false;
            this.buttonSexta.Click += new System.EventHandler(this.buttonSexta_Click);
            // 
            // buttonPrimera
            // 
            this.buttonPrimera.BackColor = System.Drawing.Color.Aqua;
            this.buttonPrimera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrimera.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonPrimera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimera.ForeColor = System.Drawing.Color.Black;
            this.buttonPrimera.Location = new System.Drawing.Point(136, 170);
            this.buttonPrimera.Name = "buttonPrimera";
            this.buttonPrimera.Size = new System.Drawing.Size(75, 23);
            this.buttonPrimera.TabIndex = 17;
            this.buttonPrimera.Text = "Primera";
            this.buttonPrimera.UseVisualStyleBackColor = false;
            this.buttonPrimera.Click += new System.EventHandler(this.buttonPrimera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPrimera);
            this.Controls.Add(this.buttonSexta);
            this.Controls.Add(this.buttonQuinta);
            this.Controls.Add(this.buttonCuarta);
            this.Controls.Add(this.buttonTercera);
            this.Controls.Add(this.buttonSegunda);
            this.Controls.Add(this.labelApagar);
            this.Controls.Add(this.buttonDisminuir);
            this.Controls.Add(this.labelCrear);
            this.Controls.Add(this.labelVelocidad);
            this.Controls.Add(this.labelDatos);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.BotonInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label labelDatos;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Label labelCrear;
        private System.Windows.Forms.Button buttonDisminuir;
        private System.Windows.Forms.Label labelApagar;
        private System.Windows.Forms.Button buttonSegunda;
        private System.Windows.Forms.Button buttonTercera;
        private System.Windows.Forms.Button buttonCuarta;
        private System.Windows.Forms.Button buttonQuinta;
        private System.Windows.Forms.Button buttonSexta;
        private System.Windows.Forms.Button buttonPrimera;
    }
}

