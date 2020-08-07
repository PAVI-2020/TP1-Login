namespace TP1_Login {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblCarrera = new System.Windows.Forms.Label();
			this.cmbCarrera = new System.Windows.Forms.ComboBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancel.Location = new System.Drawing.Point(20, 125);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(101, 37);
			this.btnCancel.TabIndex = 17;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLogin.Location = new System.Drawing.Point(304, 125);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(101, 37);
			this.btnLogin.TabIndex = 16;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPass
			// 
			this.txtPass.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtPass.Location = new System.Drawing.Point(120, 71);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(285, 20);
			this.txtPass.TabIndex = 15;
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtUsername.Location = new System.Drawing.Point(120, 21);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(285, 20);
			this.txtUsername.TabIndex = 14;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblPassword.Location = new System.Drawing.Point(17, 74);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 13;
			this.lblPassword.Text = "Password:";
			// 
			// lblCarrera
			// 
			this.lblCarrera.AutoSize = true;
			this.lblCarrera.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCarrera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblCarrera.Location = new System.Drawing.Point(17, 48);
			this.lblCarrera.Name = "lblCarrera";
			this.lblCarrera.Size = new System.Drawing.Size(44, 13);
			this.lblCarrera.TabIndex = 12;
			this.lblCarrera.Text = "Carrera:";
			// 
			// cmbCarrera
			// 
			this.cmbCarrera.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.cmbCarrera.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.cmbCarrera.FormattingEnabled = true;
			this.cmbCarrera.Items.AddRange(new object[] {
            "Sistemas",
            "Electronica",
            "Industrial"});
			this.cmbCarrera.Location = new System.Drawing.Point(120, 45);
			this.cmbCarrera.Name = "cmbCarrera";
			this.cmbCarrera.Size = new System.Drawing.Size(285, 21);
			this.cmbCarrera.TabIndex = 11;
			this.cmbCarrera.Text = "Seleccione...";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblUsername.Location = new System.Drawing.Point(17, 21);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(58, 13);
			this.lblUsername.TabIndex = 10;
			this.lblUsername.Text = "Username:";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(423, 182);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblCarrera);
			this.Controls.Add(this.cmbCarrera);
			this.Controls.Add(this.lblUsername);
			this.Name = "frmMain";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblCarrera;
		private System.Windows.Forms.ComboBox cmbCarrera;
		private System.Windows.Forms.Label lblUsername;
	}
}

