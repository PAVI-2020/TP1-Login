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

		// Comentario para generar un conflicto
		private string correctUsername = "admin";
		private string correctCarrera = "Sistemas";
		private string correctPassword = "1234";

		public frmMain() {
			InitializeComponent();
			
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			if (txtUsername.Text == correctUsername && txtPass.Text == correctPassword && cmbCarrera.Text == correctCarrera) {
				frmRedes redes = new frmRedes();
				Hide();
				if (redes.ShowDialog() == DialogResult.Cancel)
					Close();
			} else {
				string advertencia = "";

				if (txtUsername.Text != correctUsername)
					advertencia = "Nombre de usuario invalido";
				else if (cmbCarrera.Text != correctCarrera)
					advertencia = "Carrera invalida";
				else if (txtPass.Text != correctPassword)
					advertencia = "Contraseña invalida";

				MessageBox.Show(advertencia, "Detalles de inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void btnCancel_Click(object sender, EventArgs e) {
			Close();
		}

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
