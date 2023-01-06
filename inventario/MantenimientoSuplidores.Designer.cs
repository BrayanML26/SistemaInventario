namespace inventario
{
    partial class MantenimientoSuplidores
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new utilidades.label(this.components);
            this.txtcodigo = new utilidades.textbox(this.components);
            this.txtnombre = new utilidades.textbox(this.components);
            this.label2 = new utilidades.label(this.components);
            this.ckestado = new System.Windows.Forms.CheckBox();
            this.txtemail = new utilidades.textbox(this.components);
            this.label3 = new utilidades.label(this.components);
            this.txtdireccion = new utilidades.textbox(this.components);
            this.label4 = new utilidades.label(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 246);
            this.boton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton1.Size = new System.Drawing.Size(142, 53);
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 144);
            this.boton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton3.Size = new System.Drawing.Size(142, 52);
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 196);
            this.boton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boton2.Size = new System.Drawing.Size(142, 50);
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // panelbutones
            // 
            this.panelbutones.Location = new System.Drawing.Point(471, 0);
            this.panelbutones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelbutones.Size = new System.Drawing.Size(142, 348);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(146, 83);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(112, 22);
            this.txtcodigo.Solonumero = false;
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Validar = false;
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.textbox1_Validating);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(146, 132);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(261, 22);
            this.txtnombre.Solonumero = false;
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Validar = true;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckestado.Location = new System.Drawing.Point(331, 23);
            this.ckestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(76, 20);
            this.ckestado.TabIndex = 5;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            this.ckestado.CheckedChanged += new System.EventHandler(this.ckestado_CheckedChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(146, 178);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(261, 22);
            this.txtemail.Solonumero = false;
            this.txtemail.TabIndex = 7;
            this.txtemail.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(146, 221);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(261, 22);
            this.txtdireccion.Solonumero = false;
            this.txtdireccion.TabIndex = 9;
            this.txtdireccion.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direccion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mantesuplidpores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 348);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mantesuplidpores";
            this.Text = "Registro Suplidores";
            this.Load += new System.EventHandler(this.mantesuplidpores_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.ckestado, 0);
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtemail, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtdireccion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utilidades.label label1;
        private utilidades.textbox txtcodigo;
        private utilidades.textbox txtnombre;
        private utilidades.label label2;
        private System.Windows.Forms.CheckBox ckestado;
        private utilidades.textbox txtemail;
        private utilidades.label label3;
        private utilidades.textbox txtdireccion;
        private utilidades.label label4;
    }
}