namespace inventario
{
    partial class Reportes
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
            this.boton1 = new utilidades.boton();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbutones
            // 
            this.panelbutones.Controls.Add(this.boton1);
            this.panelbutones.Location = new System.Drawing.Point(505, 0);
            this.panelbutones.Size = new System.Drawing.Size(95, 366);
            this.panelbutones.Controls.SetChildIndex(this.boton1, 0);
            // 
            // boton1
            // 
            this.boton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(0, 276);
            this.boton1.Margin = new System.Windows.Forms.Padding(2);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(95, 41);
            this.boton1.TabIndex = 1;
            this.boton1.Text = "Imprimir";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Name = "Reportes";
            this.PuedeConsultar = true;
            this.PuedeImprimir = true;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private utilidades.boton boton1;
    }
}