/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC23
 * Fecha: 27/10/2026
 * Hora: 12:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_Basicas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtN1.Text);
			double n2 = double.Parse(txtN2.Text);
			lblRespuesta.Text = "Resultado: "+n1+" + "+n2+" = "+(n1 + n2);

		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtN1.Text);
			double n2 = double.Parse(txtN2.Text);
			lblRespuesta.Text = "Resultado: "+n1+" - "+n2+" = "+(n1 - n2);
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtN1.Text);
			double n2 = double.Parse(txtN2.Text);
			lblRespuesta.Text = "Resultado: "+n1+" % "+n2+" = "+(n1 % n2);
		}
		
		void BtnDivisionClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtN1.Text);
			double n2 = double.Parse(txtN2.Text);
			if(n2!=0)
			{
				lblRespuesta.Text = "Resultado: "+n1+" / "+n2+" = "+(n1 / n2);	
			}
			else
			{
				MessageBox.Show("Error: El numero debe Ser mayor a Cero" );
			}
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double n1 = double.Parse(txtN1.Text);
			double n2 = double.Parse(txtN2.Text);
			lblRespuesta.Text = "Resultado: "+n1+" x "+n2+" = "+(n1 * n2);				
		}
	}
}
