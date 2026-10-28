/*
 * Creado por SharpDevelop.
 * Usuario: yesia
 * Fecha: 27/10/2026
 * Hora: 08:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Operaciones_Basica
{
	partial class MainForm
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
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDivision = new System.Windows.Forms.Button();
			this.btnModulo = new System.Windows.Forms.Button();
			this.txtN1 = new System.Windows.Forms.TextBox();
			this.txtN2 = new System.Windows.Forms.TextBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(185, 99);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(85, 28);
			this.btnSumar.TabIndex = 0;
			this.btnSumar.Text = "Suma";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(12, 99);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(85, 28);
			this.btnResta.TabIndex = 1;
			this.btnResta.Text = "Resta";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(12, 134);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(85, 28);
			this.btnMultiplicar.TabIndex = 2;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnDivision
			// 
			this.btnDivision.Location = new System.Drawing.Point(185, 134);
			this.btnDivision.Name = "btnDivision";
			this.btnDivision.Size = new System.Drawing.Size(85, 28);
			this.btnDivision.TabIndex = 3;
			this.btnDivision.Text = "Division";
			this.btnDivision.UseVisualStyleBackColor = true;
			this.btnDivision.Click += new System.EventHandler(this.BtnDivisionClick);
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(98, 99);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(85, 28);
			this.btnModulo.TabIndex = 4;
			this.btnModulo.Text = "Modulo";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// txtN1
			// 
			this.txtN1.Location = new System.Drawing.Point(12, 71);
			this.txtN1.Name = "txtN1";
			this.txtN1.Size = new System.Drawing.Size(100, 22);
			this.txtN1.TabIndex = 5;
			// 
			// txtN2
			// 
			this.txtN2.Location = new System.Drawing.Point(170, 71);
			this.txtN2.Name = "txtN2";
			this.txtN2.Size = new System.Drawing.Size(100, 22);
			this.txtN2.TabIndex = 6;
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(17, 15);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(247, 34);
			this.lblRespuesta.TabIndex = 7;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(16, 168);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(255, 27);
			this.btnCalcular.TabIndex = 8;
			this.btnCalcular.Text = "Calcular X1 y X2";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 200);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.txtN2);
			this.Controls.Add(this.txtN1);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.btnDivision);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSumar);
			this.Name = "MainForm";
			this.Text = "Operaciones Basica";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.TextBox txtN2;
		private System.Windows.Forms.TextBox txtN1;
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Button btnDivision;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnSumar;
	}
}
