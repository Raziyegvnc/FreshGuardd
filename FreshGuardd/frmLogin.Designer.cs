namespace FreshGuardd
{
	partial class frmLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(12, 69);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(413, 316);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(462, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 46);
			this.label1.TabIndex = 1;
			this.label1.Text = "WELCOME";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label2.Location = new System.Drawing.Point(467, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "User Name";
			// 
			// txtUser
			// 
			this.txtUser.AutoRoundedCorners = true;
			this.txtUser.BorderRadius = 23;
			this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUser.DefaultText = "";
			this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUser.Location = new System.Drawing.Point(471, 134);
			this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtUser.Name = "txtUser";
			this.txtUser.PasswordChar = '\0';
			this.txtUser.PlaceholderText = "";
			this.txtUser.SelectedText = "";
			this.txtUser.Size = new System.Drawing.Size(229, 48);
			this.txtUser.TabIndex = 3;
			this.txtUser.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
			// 
			// btnLogin
			// 
			this.btnLogin.AutoRoundedCorners = true;
			this.btnLogin.BorderRadius = 21;
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(520, 340);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(180, 45);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "LOGIN";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label3.Location = new System.Drawing.Point(467, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			// 
			// txtPass
			// 
			this.txtPass.AutoRoundedCorners = true;
			this.txtPass.BorderRadius = 23;
			this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPass.DefaultText = "";
			this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPass.Location = new System.Drawing.Point(470, 238);
			this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '\0';
			this.txtPass.PlaceholderText = "";
			this.txtPass.SelectedText = "";
			this.txtPass.Size = new System.Drawing.Size(229, 48);
			this.txtPass.TabIndex = 6;
			// 
			// guna2CirclePictureBox1
			// 
			this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
			this.guna2CirclePictureBox1.ImageRotate = 0F;
			this.guna2CirclePictureBox1.Location = new System.Drawing.Point(705, 30);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
			this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox1.TabIndex = 7;
			this.guna2CirclePictureBox1.TabStop = false;
			// 
			// guna2VSeparator1
			// 
			this.guna2VSeparator1.Location = new System.Drawing.Point(421, 30);
			this.guna2VSeparator1.Name = "guna2VSeparator1";
			this.guna2VSeparator1.Size = new System.Drawing.Size(26, 359);
			this.guna2VSeparator1.TabIndex = 8;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.guna2VSeparator1);
			this.Controls.Add(this.guna2CirclePictureBox1);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txtUser;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtPass;
		private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
		private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
	}
}