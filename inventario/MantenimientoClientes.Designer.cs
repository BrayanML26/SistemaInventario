namespace inventario
{
    partial class MantenimientoClientes
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
            this.txtdireccion = new utilidades.textbox(this.components);
            this.label4 = new utilidades.label(this.components);
            this.txtemail = new utilidades.textbox(this.components);
            this.label3 = new utilidades.label(this.components);
            this.ckestado = new System.Windows.Forms.CheckBox();
            this.txtnombre = new utilidades.textbox(this.components);
            this.label2 = new utilidades.label(this.components);
            this.txtcodigo = new utilidades.textbox(this.components);
            this.label1 = new utilidades.label(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 269);
            this.boton1.Size = new System.Drawing.Size(105, 48);
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 175);
            this.boton3.Size = new System.Drawing.Size(105, 48);
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 223);
            this.boton2.Size = new System.Drawing.Size(105, 46);
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // panelbutones
            // 
            this.panelbutones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelbutones.Location = new System.Drawing.Point(462, 0);
            this.panelbutones.Size = new System.Drawing.Size(105, 366);
            this.panelbutones.TabIndex = 8;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(146, 204);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(254, 20);
            this.txtdireccion.Solonumero = false;
            this.txtdireccion.TabIndex = 7;
            this.txtdireccion.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(146, 161);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(254, 20);
            this.txtemail.Solonumero = false;
            this.txtemail.TabIndex = 5;
            this.txtemail.Validar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckestado.Location = new System.Drawing.Point(324, 24);
            this.ckestado.Margin = new System.Windows.Forms.Padding(2);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(76, 20);
            this.ckestado.TabIndex = 9;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(146, 123);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(254, 20);
            this.txtnombre.Solonumero = false;
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(146, 84);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(76, 20);
            this.txtcodigo.Solonumero = false;
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Validar = false;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodigo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // mantenimientoclietnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 366);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Name = "mantenimientoclietnes";
            this.Text = "Registro Clientes";
            this.Load += new System.EventHandler(this.mantenimientoclietnes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mantenimientoclietnes_KeyPress);
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.ckestado, 0);
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

        private utilidades.textbox txtdireccion;
        private utilidades.label label4;
        private utilidades.textbox txtemail;
        private utilidades.label label3;
        private System.Windows.Forms.CheckBox ckestado;
        private utilidades.textbox txtnombre;
        private utilidades.label label2;
        private utilidades.textbox txtcodigo;
        private utilidades.label label1;
    }
}