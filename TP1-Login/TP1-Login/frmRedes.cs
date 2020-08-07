using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Login {
	public partial class frmRedes : Form {
		public frmRedes() {
			InitializeComponent();
		}

		private void btnFB_Click(object sender, EventArgs e) {
			Process.Start("https://www.facebook.com/Valquiria-Fighting-Games-103143004647952");
		}

		private void btnTwitch_Click(object sender, EventArgs e) {
			Process.Start("https://www.twitch.tv/valquiriafightinggames");
		}

		private void btnTwitter_Click(object sender, EventArgs e) {
			Process.Start("https://twitter.com/ValquiriaGames");
		}

		private void btnIG_Click(object sender, EventArgs e) {
			Process.Start("https://www.instagram.com/valquiriafightinggames/");
		}

		private void btnYT_Click(object sender, EventArgs e) {
			Process.Start("https://www.youtube.com/channel/UCz0saQWvlXneqX0oime4IYQ");
		}

		private void btnWP_Click(object sender, EventArgs e) {
			Process.Start("https://chat.whatsapp.com/Emkac6ECdv9Ec42XcQujni");
		}
	}
}
