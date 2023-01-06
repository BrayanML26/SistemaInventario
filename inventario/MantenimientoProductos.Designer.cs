
namespace inventario
{
    partial class MantenimientoProductos
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
            this.ckestado = new System.Windows.Forms.CheckBox();
            this.label2 = new utilidades.label(this.components);
            this.label1 = new utilidades.label(this.components);
            this.label7 = new utilidades.label(this.components);
            this.label6 = new utilidades.label(this.components);
            this.label5 = new utilidades.label(this.components);
            this.label4 = new utilidades.label(this.components);
            this.label3 = new utilidades.label(this.components);
            this.txtpreven = new System.Windows.Forms.TextBox();
            this.txtprecom = new System.Windows.Forms.TextBox();
            this.txtexipro = new System.Windows.Forms.TextBox();
            this.txtnompro = new System.Windows.Forms.TextBox();
            this.txtcoddep = new System.Windows.Forms.TextBox();
            this.txtpunreo = new System.Windows.Forms.TextBox();
            this.txtcodpro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 273);
            this.boton1.Size = new System.Drawing.Size(111, 47);
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 179);
            this.boton3.Size = new System.Drawing.Size(111, 47);
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 226);
            this.boton2.Size = new System.Drawing.Size(111, 47);
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // panelbutones
            // 
            this.panelbutones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelbutones.Location = new System.Drawing.Point(415, 0);
            this.panelbutones.Size = new System.Drawing.Size(111, 369);
            this.panelbutones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbutones_Paint);
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckestado.Location = new System.Drawing.Point(264, 47);
            this.ckestado.Margin = new System.Windows.Forms.Padding(2);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(76, 20);
            this.ckestado.TabIndex = 18;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            this.ckestado.CheckedChanged += new System.EventHandler(this.ckestado_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cod-dep";
            this.label7.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pun-reo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Exi-pro";
            this.label5.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pre-com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pre-ven";
            this.label3.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtpreven
            // 
            this.txtpreven.Location = new System.Drawing.Point(152, 164);
            this.txtpreven.Name = "txtpreven";
            this.txtpreven.Size = new System.Drawing.Size(100, 20);
            this.txtpreven.TabIndex = 30;
            this.txtpreven.TextChanged += new System.EventHandler(this.txtpreven_TextChanged_1);
            // 
            // txtprecom
            // 
            this.txtprecom.Location = new System.Drawing.Point(152, 207);
            this.txtprecom.Name = "txtprecom";
            this.txtprecom.Size = new System.Drawing.Size(100, 20);
            this.txtprecom.TabIndex = 31;
            this.txtprecom.TextChanged += new System.EventHandler(this.txtprecom_TextChanged_1);
            // 
            // txtexipro
            // 
            this.txtexipro.Location = new System.Drawing.Point(152, 246);
            this.txtexipro.Name = "txtexipro";
            this.txtexipro.Size = new System.Drawing.Size(100, 20);
            this.txtexipro.TabIndex = 32;
            this.txtexipro.TextChanged += new System.EventHandler(this.txtexipro_TextChanged_1);
            // 
            // txtnompro
            // 
            this.txtnompro.Location = new System.Drawing.Point(152, 127);
            this.txtnompro.Name = "txtnompro";
            this.txtnompro.Size = new System.Drawing.Size(188, 20);
            this.txtnompro.TabIndex = 33;
            this.txtnompro.TextChanged += new System.EventHandler(this.txtnompro_TextChanged);
            // 
            // txtcoddep
            // 
            this.txtcoddep.Location = new System.Drawing.Point(152, 322);
            this.txtcoddep.Name = "txtcoddep";
            this.txtcoddep.Size = new System.Drawing.Size(100, 20);
            this.txtcoddep.TabIndex = 35;
            this.txtcoddep.TextChanged += new System.EventHandler(this.txtcoddep_TextChanged_1);
            // 
            // txtpunreo
            // 
            this.txtpunreo.Location = new System.Drawing.Point(152, 281);
            this.txtpunreo.Name = "txtpunreo";
            this.txtpunreo.Size = new System.Drawing.Size(100, 20);
            this.txtpunreo.TabIndex = 36;
            this.txtpunreo.TextChanged += new System.EventHandler(this.txtpunreo_TextChanged_1);
            // 
            // txtcodpro
            // 
            this.txtcodpro.Location = new System.Drawing.Point(152, 94);
            this.txtcodpro.Name = "txtcodpro";
            this.txtcodpro.Size = new System.Drawing.Size(100, 20);
            this.txtcodpro.TabIndex = 37;
            this.txtcodpro.TextChanged += new System.EventHandler(this.txtcodpro_TextChanged_1);
            this.txtcodpro.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodpro_Validating);
            // 
            // mantenimientoproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.txtcodpro);
            this.Controls.Add(this.txtpunreo);
            this.Controls.Add(this.txtcoddep);
            this.Controls.Add(this.txtnompro);
            this.Controls.Add(this.txtexipro);
            this.Controls.Add(this.txtprecom);
            this.Controls.Add(this.txtpreven);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mantenimientoproducto";
            this.Text = "Registro Productos";
            this.Load += new System.EventHandler(this.mantenimientoproducto_Load);
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ckestado, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtpreven, 0);
            this.Controls.SetChildIndex(this.txtprecom, 0);
            this.Controls.SetChildIndex(this.txtexipro, 0);
            this.Controls.SetChildIndex(this.txtnompro, 0);
            this.Controls.SetChildIndex(this.txtcoddep, 0);
            this.Controls.SetChildIndex(this.txtpunreo, 0);
            this.Controls.SetChildIndex(this.txtcodpro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckestado;
        private utilidades.label label2;
        private utilidades.label label1;
        private utilidades.label label7;
        private utilidades.label label6;
        private utilidades.label label5;
        private utilidades.label label4;
        private utilidades.label label3;
        private System.Windows.Forms.TextBox txtpreven;
        private System.Windows.Forms.TextBox txtprecom;
        private System.Windows.Forms.TextBox txtexipro;
        private System.Windows.Forms.TextBox txtnompro;
        private System.Windows.Forms.TextBox txtcoddep;
        private System.Windows.Forms.TextBox txtpunreo;
        private System.Windows.Forms.TextBox txtcodpro;
    }
}