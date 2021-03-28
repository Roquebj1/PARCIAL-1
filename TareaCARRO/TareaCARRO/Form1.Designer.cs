
namespace TareaCARRO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonInicio_Click = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonChevrolet = new System.Windows.Forms.Button();
            this.buttonAltoTotal = new System.Windows.Forms.Button();
            this.labelPalanca = new System.Windows.Forms.Label();
            this.buttonPalanca = new System.Windows.Forms.Button();
            this.ReproducirAudio = new System.Windows.Forms.Label();
            this.buttonReproducir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInicio_Click
            // 
            this.buttonInicio_Click.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInicio_Click.BackColor = System.Drawing.Color.SlateGray;
            this.buttonInicio_Click.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonInicio_Click.FlatAppearance.BorderSize = 9;
            this.buttonInicio_Click.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInicio_Click.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonInicio_Click.Location = new System.Drawing.Point(12, 12);
            this.buttonInicio_Click.Name = "buttonInicio_Click";
            this.buttonInicio_Click.Size = new System.Drawing.Size(762, 122);
            this.buttonInicio_Click.TabIndex = 0;
            this.buttonInicio_Click.Text = "Crear Carro";
            this.buttonInicio_Click.UseVisualStyleBackColor = false;
            this.buttonInicio_Click.Click += new System.EventHandler(this.buttonInicio_Click_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.Lime;
            this.buttonEncender.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEncender.ForeColor = System.Drawing.Color.Blue;
            this.buttonEncender.Location = new System.Drawing.Point(12, 142);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(324, 96);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender el Carro";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(342, 182);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(59, 25);
            this.labelEstado.TabIndex = 2;
            this.labelEstado.Text = "label1";
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.Yellow;
            this.buttonAcelerar.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAcelerar.ForeColor = System.Drawing.Color.Blue;
            this.buttonAcelerar.Location = new System.Drawing.Point(12, 244);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(254, 84);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(272, 278);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(59, 25);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "label1";
            // 
            // buttonChevrolet
            // 
            this.buttonChevrolet.BackColor = System.Drawing.Color.OldLace;
            this.buttonChevrolet.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChevrolet.ForeColor = System.Drawing.Color.DimGray;
            this.buttonChevrolet.Location = new System.Drawing.Point(787, 12);
            this.buttonChevrolet.Name = "buttonChevrolet";
            this.buttonChevrolet.Size = new System.Drawing.Size(241, 62);
            this.buttonChevrolet.TabIndex = 5;
            this.buttonChevrolet.Text = "CHEVROLET";
            this.buttonChevrolet.UseVisualStyleBackColor = false;
            this.buttonChevrolet.Click += new System.EventHandler(this.buttonChevrolet_Click);
            // 
            // buttonAltoTotal
            // 
            this.buttonAltoTotal.BackColor = System.Drawing.Color.Red;
            this.buttonAltoTotal.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAltoTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAltoTotal.Location = new System.Drawing.Point(787, 569);
            this.buttonAltoTotal.Name = "buttonAltoTotal";
            this.buttonAltoTotal.Size = new System.Drawing.Size(234, 105);
            this.buttonAltoTotal.TabIndex = 6;
            this.buttonAltoTotal.Text = "Alto Total";
            this.buttonAltoTotal.UseVisualStyleBackColor = false;
            this.buttonAltoTotal.Click += new System.EventHandler(this.buttonAltoTotal_Click);
            // 
            // labelPalanca
            // 
            this.labelPalanca.AutoSize = true;
            this.labelPalanca.Location = new System.Drawing.Point(456, 411);
            this.labelPalanca.Name = "labelPalanca";
            this.labelPalanca.Size = new System.Drawing.Size(59, 25);
            this.labelPalanca.TabIndex = 7;
            this.labelPalanca.Text = "label1";
            this.labelPalanca.Click += new System.EventHandler(this.labelPalanca_Click);
            // 
            // buttonPalanca
            // 
            this.buttonPalanca.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonPalanca.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPalanca.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonPalanca.Location = new System.Drawing.Point(263, 369);
            this.buttonPalanca.Name = "buttonPalanca";
            this.buttonPalanca.Size = new System.Drawing.Size(187, 104);
            this.buttonPalanca.TabIndex = 8;
            this.buttonPalanca.Text = "PALANCA DE CAMBIOS";
            this.buttonPalanca.UseVisualStyleBackColor = false;
            this.buttonPalanca.Click += new System.EventHandler(this.buttonPalanca_Click);
            // 
            // ReproducirAudio
            // 
            this.ReproducirAudio.AutoSize = true;
            this.ReproducirAudio.Location = new System.Drawing.Point(12, 579);
            this.ReproducirAudio.Name = "ReproducirAudio";
            this.ReproducirAudio.Size = new System.Drawing.Size(339, 25);
            this.ReproducirAudio.TabIndex = 9;
            this.ReproducirAudio.Text = "Reproducir HEAVEN BRYAN ADAMS.WAV";
            this.ReproducirAudio.Click += new System.EventHandler(this.ReproducirAudio_Click);
            // 
            // buttonReproducir
            // 
            this.buttonReproducir.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonReproducir.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReproducir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReproducir.Location = new System.Drawing.Point(87, 623);
            this.buttonReproducir.Name = "buttonReproducir";
            this.buttonReproducir.Size = new System.Drawing.Size(142, 51);
            this.buttonReproducir.TabIndex = 10;
            this.buttonReproducir.Text = "Play";
            this.buttonReproducir.UseVisualStyleBackColor = false;
            this.buttonReproducir.Click += new System.EventHandler(this.buttonReproducir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 686);
            this.Controls.Add(this.buttonReproducir);
            this.Controls.Add(this.ReproducirAudio);
            this.Controls.Add(this.buttonPalanca);
            this.Controls.Add(this.labelPalanca);
            this.Controls.Add(this.buttonAltoTotal);
            this.Controls.Add(this.buttonChevrolet);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttonInicio_Click);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicio_Click;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonChevrolet;
        private System.Windows.Forms.Button buttonAltoTotal;
        private System.Windows.Forms.Label labelPalanca;
        private System.Windows.Forms.Button buttonPalanca;
        private System.Windows.Forms.Label ReproducirAudio;
        private System.Windows.Forms.Button buttonReproducir;
    }
}

