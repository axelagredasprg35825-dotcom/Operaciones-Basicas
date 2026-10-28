/*
 * Creado por SharpDevelop.
 * Usuario: yesia
 * Fecha: 27/10/2026
 * Hora: 09:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Operaciones_Basica
{
	partial class X1_y_X2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(X1_y_X2));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.label1.Location = new System.Drawing.Point(26, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor de A:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
			this.label2.Location = new System.Drawing.Point(26, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor de B:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
			this.label3.Location = new System.Drawing.Point(26, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Valor de C:";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(112, 37);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(139, 22);
			this.txtA.TabIndex = 3;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(112, 115);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(139, 22);
			this.txtC.TabIndex = 4;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(112, 75);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(139, 22);
			this.txtB.TabIndex = 5;
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(26, 155);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(225, 42);
			this.lblRespuesta.TabIndex = 6;
			this.lblRespuesta.Click += new System.EventHandler(this.LblRespuestaClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(26, 199);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(85, 39);
			this.btnRegresar.TabIndex = 7;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(176, 199);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(78, 39);
			this.btnCalcular.TabIndex = 8;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// X1_y_X2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "X1_y_X2";
			this.Text = "X1_y_X2";
			this.Load += new System.EventHandler(this.X1_y_X2Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
