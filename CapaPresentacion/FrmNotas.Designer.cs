
namespace CapaPresentacion
{
    partial class FrmNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotas));
            this.textCursoEvaluado = new System.Windows.Forms.TextBox();
            this.textMaximaCalificacion = new System.Windows.Forms.TextBox();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.textAprobado = new System.Windows.Forms.TextBox();
            this.textDesaprobado = new System.Windows.Forms.TextBox();
            this.btnMetodo1 = new System.Windows.Forms.Button();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.btnMetodo3 = new System.Windows.Forms.Button();
            this.btnMetodo4 = new System.Windows.Forms.Button();
            this.btnMetodo5 = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textCursoEvaluado
            // 
            this.textCursoEvaluado.Location = new System.Drawing.Point(112, 137);
            this.textCursoEvaluado.Name = "textCursoEvaluado";
            this.textCursoEvaluado.Size = new System.Drawing.Size(229, 20);
            this.textCursoEvaluado.TabIndex = 0;
            // 
            // textMaximaCalificacion
            // 
            this.textMaximaCalificacion.Location = new System.Drawing.Point(112, 163);
            this.textMaximaCalificacion.Name = "textMaximaCalificacion";
            this.textMaximaCalificacion.Size = new System.Drawing.Size(229, 20);
            this.textMaximaCalificacion.TabIndex = 1;
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(112, 189);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(229, 20);
            this.textTipo.TabIndex = 2;
            // 
            // textAprobado
            // 
            this.textAprobado.Location = new System.Drawing.Point(112, 215);
            this.textAprobado.Name = "textAprobado";
            this.textAprobado.Size = new System.Drawing.Size(229, 20);
            this.textAprobado.TabIndex = 3;
            // 
            // textDesaprobado
            // 
            this.textDesaprobado.Location = new System.Drawing.Point(112, 241);
            this.textDesaprobado.Name = "textDesaprobado";
            this.textDesaprobado.Size = new System.Drawing.Size(229, 20);
            this.textDesaprobado.TabIndex = 4;
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.BackColor = System.Drawing.Color.LightGreen;
            this.btnMetodo1.Location = new System.Drawing.Point(205, 273);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(136, 25);
            this.btnMetodo1.TabIndex = 5;
            this.btnMetodo1.Text = "DescribirProgreso ( )";
            this.btnMetodo1.UseVisualStyleBackColor = false;
            this.btnMetodo1.Click += new System.EventHandler(this.btnMetodo1_Click);
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.BackColor = System.Drawing.Color.LightGreen;
            this.btnMetodo2.Location = new System.Drawing.Point(205, 302);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(136, 25);
            this.btnMetodo2.TabIndex = 6;
            this.btnMetodo2.Text = "Motivar ( )";
            this.btnMetodo2.UseVisualStyleBackColor = false;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // btnMetodo3
            // 
            this.btnMetodo3.BackColor = System.Drawing.Color.LightGreen;
            this.btnMetodo3.Location = new System.Drawing.Point(205, 331);
            this.btnMetodo3.Name = "btnMetodo3";
            this.btnMetodo3.Size = new System.Drawing.Size(136, 25);
            this.btnMetodo3.TabIndex = 7;
            this.btnMetodo3.Text = "Desmotivar ( )";
            this.btnMetodo3.UseVisualStyleBackColor = false;
            this.btnMetodo3.Click += new System.EventHandler(this.btnMetodo3_Click);
            // 
            // btnMetodo4
            // 
            this.btnMetodo4.BackColor = System.Drawing.Color.LightGreen;
            this.btnMetodo4.Location = new System.Drawing.Point(205, 360);
            this.btnMetodo4.Name = "btnMetodo4";
            this.btnMetodo4.Size = new System.Drawing.Size(136, 25);
            this.btnMetodo4.TabIndex = 8;
            this.btnMetodo4.Text = "InformarDocentes ( )";
            this.btnMetodo4.UseVisualStyleBackColor = false;
            this.btnMetodo4.Click += new System.EventHandler(this.btnMetodo4_Click);
            // 
            // btnMetodo5
            // 
            this.btnMetodo5.BackColor = System.Drawing.Color.LightGreen;
            this.btnMetodo5.Location = new System.Drawing.Point(205, 389);
            this.btnMetodo5.Name = "btnMetodo5";
            this.btnMetodo5.Size = new System.Drawing.Size(136, 25);
            this.btnMetodo5.TabIndex = 9;
            this.btnMetodo5.Text = "DeterminarAprobacion ( )";
            this.btnMetodo5.UseVisualStyleBackColor = false;
            this.btnMetodo5.Click += new System.EventHandler(this.btnMetodo5_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEscribir.Location = new System.Drawing.Point(112, 306);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 10;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLeer.Location = new System.Drawing.Point(112, 346);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 11;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Curso Evaluado:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Desprabado";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Aprobado:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Tipo :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Maxima Calificación:";
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnMetodo5);
            this.Controls.Add(this.btnMetodo4);
            this.Controls.Add(this.btnMetodo3);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo1);
            this.Controls.Add(this.textDesaprobado);
            this.Controls.Add(this.textAprobado);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.textMaximaCalificacion);
            this.Controls.Add(this.textCursoEvaluado);
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCursoEvaluado;
        private System.Windows.Forms.TextBox textMaximaCalificacion;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.TextBox textAprobado;
        private System.Windows.Forms.TextBox textDesaprobado;
        private System.Windows.Forms.Button btnMetodo1;
        private System.Windows.Forms.Button btnMetodo2;
        private System.Windows.Forms.Button btnMetodo3;
        private System.Windows.Forms.Button btnMetodo4;
        private System.Windows.Forms.Button btnMetodo5;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}