namespace Cotizadora
{
    partial class Cotizadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizadora));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txTiempo = new System.Windows.Forms.TextBox();
            this.txPeso = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbMen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txExtra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo:";
            // 
            // txTiempo
            // 
            this.txTiempo.Location = new System.Drawing.Point(63, 123);
            this.txTiempo.Name = "txTiempo";
            this.txTiempo.Size = new System.Drawing.Size(100, 20);
            this.txTiempo.TabIndex = 2;
            // 
            // txPeso
            // 
            this.txPeso.Location = new System.Drawing.Point(63, 87);
            this.txPeso.Name = "txPeso";
            this.txPeso.Size = new System.Drawing.Size(100, 20);
            this.txPeso.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cotizadora SAM3D";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(300, 198);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(187, 198);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 5;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(63, 198);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 4;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbMen
            // 
            this.lbMen.AutoSize = true;
            this.lbMen.Location = new System.Drawing.Point(25, 61);
            this.lbMen.Name = "lbMen";
            this.lbMen.Size = new System.Drawing.Size(0, 13);
            this.lbMen.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Extra:";
            // 
            // txExtra
            // 
            this.txExtra.Location = new System.Drawing.Point(63, 158);
            this.txExtra.Name = "txExtra";
            this.txExtra.Size = new System.Drawing.Size(100, 20);
            this.txExtra.TabIndex = 3;
            // 
            // Cotizadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 239);
            this.Controls.Add(this.txExtra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMen);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txPeso);
            this.Controls.Add(this.txTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cotizadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizadora SAM3D";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txTiempo;
        private System.Windows.Forms.TextBox txPeso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbMen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txExtra;
    }
}

