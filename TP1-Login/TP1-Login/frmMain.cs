using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Login {
	public partial class frmMain : Form {
		private string correctUsername = "admin";
		private string correctCarrera = "Sistemas";
		private string correctPassword = "1234";

		public frmMain() {
			InitializeComponent();
			
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			string advertencia = "";
			if (txtUsername.Text == correctUsername)
				if (txtPass.Text == correctPassword)
					if (cmbCarrera.Text == correctCarrera)
					{
						frmRedes redes = new frmRedes();
						redes.Show();

					}
					else
					{
						advertencia = "Carrera incorrecta";
						MessageBox.Show(advertencia, "Detalles de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				else
				{
					advertencia = "Contraseña incorrecta";
					MessageBox.Show(advertencia, "Detalles de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			else
			{
				advertencia = "No se ha encontrado el usuario";
				MessageBox.Show(advertencia, "Detalles de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		// Simple comentario con lo de arriba, creo que seria mas simple hacer un solo if con && y que el mensaje sea simplemente verifique sus datos (como hacen la mayoria de programas)
		private void btnCancel_Click(object sender, EventArgs e) {

		}

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
			
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
