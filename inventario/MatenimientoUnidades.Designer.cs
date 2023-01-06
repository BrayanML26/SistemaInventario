namespace inventario
{
    partial class MatenimientoUnidades
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
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 185);
            this.boton1.Size = new System.Drawing.Size(97, 41);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 100);
            this.boton3.Size = new System.Drawing.Size(97, 42);
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 142);
            this.boton2.Size = new System.Drawing.Size(97, 43);
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // panelbutones
            // 
            this.panelbutones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelbutones.Location = new System.Drawing.Point(374, 0);
            this.panelbutones.Size = new System.Drawing.Size(97, 275);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(138, 81);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(76, 20);
            this.txtcodigo.Solonumero = false;
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Validar = false;
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.textbox1_Validating);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(138, 121);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(194, 20);
            this.txtnombre.Solonumero = false;
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckestado.Location = new System.Drawing.Point(255, 25);
            this.ckestado.Margin = new System.Windows.Forms.Padding(2);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(76, 20);
            this.ckestado.TabIndex = 5;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            this.ckestado.CheckedChanged += new System.EventHandler(this.ckestado_CheckedChanged);
            // 
            // matenimientounidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 275);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Name = "matenimientounidades";
            this.Text = "Registro Unidades";
            this.Load += new System.EventHandler(this.matenimientounidades_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.ckestado, 0);
            this.Controls.SetChildIndex(this.panelbutones, 0);
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
    }
}