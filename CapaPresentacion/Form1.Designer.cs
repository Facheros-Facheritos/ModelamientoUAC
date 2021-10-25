
namespace CapaPresentacion
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
            this.textNombres = new System.Windows.Forms.TextBox();
            this.textCelular = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textSemestreInicio = new System.Windows.Forms.TextBox();
            this.textEscuelaProfesional = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnMetodo1 = new System.Windows.Forms.Button();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.btnMetodo3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnRendirExamen = new System.Windows.Forms.Button();
            this.btnTrabajarEquipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(149, 192);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(175, 20);
            this.textNombres.TabIndex = 0;
            // 
            // textCelular
            // 
            this.textCelular.Location = new System.Drawing.Point(149, 218);
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(175, 20);
            this.textCelular.TabIndex = 1;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(149, 245);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(175, 20);
            this.textCodigo.TabIndex = 2;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(149, 271);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(175, 20);
            this.textCorreo.TabIndex = 3;
            // 
            // textSemestreInicio
            // 
            this.textSemestreInicio.Location = new System.Drawing.Point(149, 298);
            this.textSemestreInicio.Name = "textSemestreInicio";
            this.textSemestreInicio.Size = new System.Drawing.Size(175, 20);
            this.textSemestreInicio.TabIndex = 4;
            // 
            // textEscuelaProfesional
            // 
            this.textEscuelaProfesional.Location = new System.Drawing.Point(149, 325);
            this.textEscuelaProfesional.Name = "textEscuelaProfesional";
            this.textEscuelaProfesional.Size = new System.Drawing.Size(175, 20);
            this.textEscuelaProfesional.TabIndex = 5;
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(149, 166);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(175, 20);
            this.textApellidos.TabIndex = 6;
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEscribir.Location = new System.Drawing.Point(330, 167);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 7;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLeer.Location = new System.Drawing.Point(438, 166);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 8;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMetodo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMetodo1.Location = new System.Drawing.Point(197, 364);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo1.TabIndex = 9;
            this.btnMetodo1.Text = "Matricular ( )";
            this.btnMetodo1.UseVisualStyleBackColor = false;
            this.btnMetodo1.Click += new System.EventHandler(this.btnMetodo1_Click);
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMetodo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMetodo2.Location = new System.Drawing.Point(305, 364);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo2.TabIndex = 10;
            this.btnMetodo2.Text = "Estudiar ( )";
            this.btnMetodo2.UseVisualStyleBackColor = false;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // btnMetodo3
            // 
            this.btnMetodo3.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMetodo3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMetodo3.Location = new System.Drawing.Point(413, 364);
            this.btnMetodo3.Name = "btnMetodo3";
            this.btnMetodo3.Size = new System.Drawing.Size(75, 23);
            this.btnMetodo3.TabIndex = 11;
            this.btnMetodo3.Text = "Aprobar ( )";
            this.btnMetodo3.UseVisualStyleBackColor = false;
            this.btnMetodo3.Click += new System.EventHandler(this.btnMetodo3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Apellidos:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 325);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Escuela Profesional:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 300);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Semestre Inicio:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 274);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Correo:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(38, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(105, 20);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Código:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(38, 222);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(105, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "Celular:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(38, 196);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(105, 20);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "Nombres:";
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDesaprobar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesaprobar.Location = new System.Drawing.Point(190, 394);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(88, 23);
            this.btnDesaprobar.TabIndex = 21;
            this.btnDesaprobar.Text = "Desaprobar ( )";
            this.btnDesaprobar.UseVisualStyleBackColor = false;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAtender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtender.Location = new System.Drawing.Point(305, 394);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(75, 23);
            this.btnAtender.TabIndex = 22;
            this.btnAtender.Text = "Atender ( )";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnRendirExamen
            // 
            this.btnRendirExamen.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRendirExamen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRendirExamen.Location = new System.Drawing.Point(402, 394);
            this.btnRendirExamen.Name = "btnRendirExamen";
            this.btnRendirExamen.Size = new System.Drawing.Size(100, 23);
            this.btnRendirExamen.TabIndex = 23;
            this.btnRendirExamen.Text = "RendirExamen ( )";
            this.btnRendirExamen.UseVisualStyleBackColor = false;
            this.btnRendirExamen.Click += new System.EventHandler(this.btnRendirExamen_Click);
            // 
            // btnTrabajarEquipo
            // 
            this.btnTrabajarEquipo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTrabajarEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrabajarEquipo.Location = new System.Drawing.Point(289, 423);
            this.btnTrabajarEquipo.Name = "btnTrabajarEquipo";
            this.btnTrabajarEquipo.Size = new System.Drawing.Size(100, 23);
            this.btnTrabajarEquipo.TabIndex = 24;
            this.btnTrabajarEquipo.Text = "TrabajarEquipo( )";
            this.btnTrabajarEquipo.UseVisualStyleBackColor = false;
            this.btnTrabajarEquipo.Click += new System.EventHandler(this.btnTrabajarEquipo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(547, 495);
            this.Controls.Add(this.btnTrabajarEquipo);
            this.Controls.Add(this.btnRendirExamen);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnDesaprobar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMetodo3);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo1);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textEscuelaProfesional);
            this.Controls.Add(this.textSemestreInicio);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textCelular);
            this.Controls.Add(this.textNombres);
            this.Name = "Form1";
            this.Text = "SistemaAdministativoUAC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.TextBox textCelular;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textSemestreInicio;
        private System.Windows.Forms.TextBox textEscuelaProfesional;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnMetodo1;
        private System.Windows.Forms.Button btnMetodo2;
        private System.Windows.Forms.Button btnMetodo3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnDesaprobar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnRendirExamen;
        private System.Windows.Forms.Button btnTrabajarEquipo;
    }
}

