namespace PRIMETA_APP
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
            this.btnsaludar = new System.Windows.Forms.Button();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnPreguntar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsaludar
            // 
            this.btnsaludar.AccessibleDescription = "";
            this.btnsaludar.Location = new System.Drawing.Point(295, 139);
            this.btnsaludar.Name = "btnsaludar";
            this.btnsaludar.Size = new System.Drawing.Size(107, 26);
            this.btnsaludar.TabIndex = 0;
            this.btnsaludar.Text = "saludar";
            this.btnsaludar.UseVisualStyleBackColor = true;
            this.btnsaludar.Click += new System.EventHandler(this.btnsaludar_Click);
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(163, 85);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(361, 20);
            this.txtTextBox.TabIndex = 1;
            this.txtTextBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(326, 224);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(35, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "label1";
            // 
            // btnPreguntar
            // 
            this.btnPreguntar.Location = new System.Drawing.Point(470, 143);
            this.btnPreguntar.Name = "btnPreguntar";
            this.btnPreguntar.Size = new System.Drawing.Size(133, 21);
            this.btnPreguntar.TabIndex = 3;
            this.btnPreguntar.Text = "Salir";
            this.btnPreguntar.UseVisualStyleBackColor = true;
            this.btnPreguntar.Click += new System.EventHandler(this.btnPreguntar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPreguntar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.btnsaludar);
            this.Name = "Form1";
            this.Text = "primera aplicacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaludar;
        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnPreguntar;
    }
}

