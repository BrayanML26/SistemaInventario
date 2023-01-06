namespace inventario
{
    partial class FormBase
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
            this.panelbutones = new utilidades.panel(this.components);
            this.cmdcerrar = new utilidades.boton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbutones
            // 
            this.panelbutones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelbutones.Controls.Add(this.cmdcerrar);
            this.panelbutones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelbutones.Location = new System.Drawing.Point(468, 0);
            this.panelbutones.Margin = new System.Windows.Forms.Padding(2);
            this.panelbutones.Name = "panelbutones";
            this.panelbutones.Size = new System.Drawing.Size(76, 396);
            this.panelbutones.TabIndex = 4;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdcerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcerrar.Location = new System.Drawing.Point(0, 347);
            this.cmdcerrar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(76, 49);
            this.cmdcerrar.TabIndex = 0;
            this.cmdcerrar.Text = "Cerrar";
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdcerrar;
            this.ClientSize = new System.Drawing.Size(544, 396);
            this.Controls.Add(this.panelbutones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private utilidades.boton cmdcerrar;
        public utilidades.panel panelbutones;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}