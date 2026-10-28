/*
 * Creado por SharpDevelop.
 * Usuario: yesia
 * Fecha: 27/10/2026
 * Hora: 09:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_Basica
{
	/// <summary>
	/// Description of X1_y_X2.
	/// </summary>
	public partial class X1_y_X2 : Form
	{
		public X1_y_X2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm j = new MainForm();
			j.Show();
			this.Close();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double raiz, x1, x2;
			double a = Convert.ToDouble(txtA.Text);
			double b = Convert.ToDouble(txtB.Text);
			double c = Convert.ToDouble(txtC.Text);
			raiz = Math.Sqrt(b*b-4*a*c);
			x1 = (-b+raiz)/(2*a);
			x2 = (-b-raiz)/(2*a);
			lblRespuesta.Text="X1 : "+x1+"\n"+"X2 : "+x2;
		}
		
		void LblRespuestaClick(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void X1_y_X2Load(object sender, EventArgs e)
		{
			
		}
	}
}
