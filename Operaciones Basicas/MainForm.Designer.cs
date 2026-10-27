/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC23
 * Fecha: 27/10/2026
 * Hora: 12:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Operaciones_Basicas
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
			this.txtN2 = new System.Windows.Forms.TextBox();
			this.txtN1 = new System.Windows.Forms.TextBox();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnDivision = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnModulo = new System.Windows.Forms.Button();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtN2
			// 
			this.txtN2.Location = new System.Drawing.Point(155, 23);
			this.txtN2.Name = "txtN2";
			this.txtN2.Size = new System.Drawing.Size(100, 20);
			this.txtN2.TabIndex = 1;
			// 
			// txtN1
			// 
			this.txtN1.Location = new System.Drawing.Point(26, 23);
			this.txtN1.Name = "txtN1";
			this.txtN1.Size = new System.Drawing.Size(100, 20);
			this.txtN1.TabIndex = 2;
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(26, 60);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(75, 23);
			this.btnSuma.TabIndex = 3;
			this.btnSuma.Text = "Suma";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnDivision
			// 
			this.btnDivision.Location = new System.Drawing.Point(183, 60);
			this.btnDivision.Name = "btnDivision";
			this.btnDivision.Size = new System.Drawing.Size(75, 23);
			this.btnDivision.TabIndex = 4;
			this.btnDivision.Text = "Dividir";
			this.btnDivision.UseVisualStyleBackColor = true;
			this.btnDivision.Click += new System.EventHandler(this.BtnDivisionClick);
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(26, 89);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(75, 23);
			this.btnResta.TabIndex = 5;
			this.btnResta.Text = "Resta";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(185, 89);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
			this.btnMultiplicar.TabIndex = 6;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(104, 60);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(75, 23);
			this.btnModulo.TabIndex = 7;
			this.btnModulo.Text = "Modulo";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(30, 119);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(230, 26);
			this.lblRespuesta.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 158);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnDivision);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.txtN1);
			this.Controls.Add(this.txtN2);
			this.Name = "MainForm";
			this.Text = "Operaciones Basicas";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnDivision;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.TextBox txtN1;
		private System.Windows.Forms.TextBox txtN2;
	}
}
