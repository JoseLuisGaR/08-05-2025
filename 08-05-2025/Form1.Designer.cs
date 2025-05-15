namespace _08_05_2025
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
            this.lstRuta = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLectura = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstRuta
            // 
            this.lstRuta.HideSelection = false;
            this.lstRuta.Location = new System.Drawing.Point(49, 85);
            this.lstRuta.Name = "lstRuta";
            this.lstRuta.Size = new System.Drawing.Size(162, 178);
            this.lstRuta.TabIndex = 1;
            this.lstRuta.UseCompatibleStateImageBehavior = false;
            this.lstRuta.DoubleClick += new System.EventHandler(this.lstRuta_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MODIFICAR";
            // 
            // txtLectura
            // 
            this.txtLectura.Enabled = false;
            this.txtLectura.Location = new System.Drawing.Point(244, 85);
            this.txtLectura.Multiline = true;
            this.txtLectura.Name = "txtLectura";
            this.txtLectura.Size = new System.Drawing.Size(162, 178);
            this.txtLectura.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(289, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(323, 48);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(41, 17);
            this.rbtnNo.TabIndex = 8;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "NO";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Location = new System.Drawing.Point(254, 48);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(35, 17);
            this.rbtnSi.TabIndex = 9;
            this.rbtnSi.TabStop = true;
            this.rbtnSi.Text = "SI";
            this.rbtnSi.UseVisualStyleBackColor = true;
            this.rbtnSi.CheckedChanged += new System.EventHandler(this.rbtnSi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 408);
            this.Controls.Add(this.rbtnSi);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtLectura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRuta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLectura;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnSi;
    }
}

