/*
 * Creado por SharpDevelop.
 * Usuario: yesia
 * Fecha: 27/10/2026
 * Hora: 08:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_Basica
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
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtN1.Text);
			double n2 = Convert.ToDouble(txtN2.Text);
			if(n2!=0)
			{
				lblRespuesta.Text="Respuesta: "+n1+" % "+n2+" = "+(n1%n2);
			}
		}
		
		void BtnSumarClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtN1.Text);
			double n2 = Convert.ToDouble(txtN2.Text);
			lblRespuesta.Text="Respuesta: "+n1+" + "+n2+" = "+(n1+n2);
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtN1.Text);
			double n2 = Convert.ToDouble(txtN2.Text);
			lblRespuesta.Text="Respuesta: "+n1+" - "+n2+" = "+(n1-n2);			
		}
		
		void BtnDivisionClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtN1.Text);
			double n2 = Convert.ToDouble(txtN2.Text);
			if(n2!=0)
			{
			lblRespuesta.Text="Respuesta: "+n1+" / "+n2+" = "+(n1/n2);			
			}	
			else
			{
				MessageBox.Show("Error: El numero debe ser mayor a Cero");
			}
		}
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double n1 = Convert.ToDouble(txtN1.Text);
			double n2 = Convert.ToDouble(txtN2.Text);
			lblRespuesta.Text="Respuesta: "+n1+" x "+n2+" = "+(n1*n2);			
		}			
		
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			X1_y_X2 f = new X1_y_X2();
			f.Show();
			this.Hide();
		}
	}
}
