namespace ClaseFinal
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonProbar = new System.Windows.Forms.Button();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.comboBoxCompania = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConsola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGeneracion = new System.Windows.Forms.TextBox();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.buttonDatos = new System.Windows.Forms.Button();
            this.buttonSiguente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keven Ryan Lopez Pineda   0905-23-4114";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 209);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonProbar
            // 
            this.buttonProbar.Location = new System.Drawing.Point(35, 159);
            this.buttonProbar.Name = "buttonProbar";
            this.buttonProbar.Size = new System.Drawing.Size(153, 46);
            this.buttonProbar.TabIndex = 2;
            this.buttonProbar.Text = "Probar Conexion";
            this.buttonProbar.UseVisualStyleBackColor = true;
            this.buttonProbar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(214, 159);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(153, 46);
            this.buttonCargar.TabIndex = 3;
            this.buttonCargar.Text = "Cargar Tabla";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // comboBoxCompania
            // 
            this.comboBoxCompania.FormattingEnabled = true;
            this.comboBoxCompania.Location = new System.Drawing.Point(231, 108);
            this.comboBoxCompania.Name = "comboBoxCompania";
            this.comboBoxCompania.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCompania.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de Consola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Compania:";
            // 
            // textBoxConsola
            // 
            this.textBoxConsola.Location = new System.Drawing.Point(231, 63);
            this.textBoxConsola.Name = "textBoxConsola";
            this.textBoxConsola.Size = new System.Drawing.Size(121, 22);
            this.textBoxConsola.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID: ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(231, 27);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 22);
            this.textBoxID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Anio Lanzamiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Generacion: ";
            // 
            // textBoxGeneracion
            // 
            this.textBoxGeneracion.Location = new System.Drawing.Point(594, 63);
            this.textBoxGeneracion.Name = "textBoxGeneracion";
            this.textBoxGeneracion.Size = new System.Drawing.Size(100, 22);
            this.textBoxGeneracion.TabIndex = 12;
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(594, 27);
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(100, 22);
            this.textBoxAnio.TabIndex = 13;
            // 
            // buttonDatos
            // 
            this.buttonDatos.Location = new System.Drawing.Point(402, 159);
            this.buttonDatos.Name = "buttonDatos";
            this.buttonDatos.Size = new System.Drawing.Size(153, 46);
            this.buttonDatos.TabIndex = 14;
            this.buttonDatos.Text = "Cargar Datos";
            this.buttonDatos.UseVisualStyleBackColor = true;
            this.buttonDatos.Click += new System.EventHandler(this.buttonDatos_Click);
            // 
            // buttonSiguente
            // 
            this.buttonSiguente.Location = new System.Drawing.Point(582, 159);
            this.buttonSiguente.Name = "buttonSiguente";
            this.buttonSiguente.Size = new System.Drawing.Size(153, 46);
            this.buttonSiguente.TabIndex = 15;
            this.buttonSiguente.Text = "Siguente Registro";
            this.buttonSiguente.UseVisualStyleBackColor = true;
            this.buttonSiguente.Click += new System.EventHandler(this.buttonSiguente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(443, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fredy Bartolo Castillo Ardon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 39);
            this.label8.TabIndex = 17;
            this.label8.Text = "0905-17-3888";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 581);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSiguente);
            this.Controls.Add(this.buttonDatos);
            this.Controls.Add(this.textBoxAnio);
            this.Controls.Add(this.textBoxGeneracion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxConsola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCompania);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.buttonProbar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonProbar;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.ComboBox comboBoxCompania;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConsola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGeneracion;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.Button buttonDatos;
        private System.Windows.Forms.Button buttonSiguente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

