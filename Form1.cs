using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleLoginSystem
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2
		private void button1_Click(object sender, EventArgs e)
		{
			string userN = "haugaland";
			string pass = "itfag";
			if (this.textBox1.Text == userN && this.textBox2.Text == pass)
			{
				MessageBox.Show("Du er logget inn");
				this.lblUsername.Visible = true;
				this.button2.Visible = true;
				this.lblUsername.Text = "Hei, " + userN;
				this.label1.Visible = false;
				this.label2.Visible = false;
				this.textBox1.Visible = false;
				this.textBox2.Visible = false;
				this.button1.Visible = false;
				return;
			}
			MessageBox.Show("Kontoen eksisterer ikke.");
		}

		// Token: 0x06000003 RID: 3
		private void button2_Click(object sender, EventArgs e)
		{
			this.label1.Visible = true;
			this.label2.Visible = true;
			this.textBox1.Visible = true;
			this.textBox2.Visible = true;
			this.button1.Visible = true;
			this.lblUsername.Visible = true;
			this.button2.Visible = true;
			this.textBox1.Text = "";
			this.textBox2.Text = "";
			this.textBox1.Focus();
		}

		// Token: 0x06000004 RID: 4
		private void Form1_Load(object sender, EventArgs e)
		{
			this.lblUsername.Visible = true;
			this.button2.Visible = true;
		}
	}
}
