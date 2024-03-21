namespace SimpleLoginSystem
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.lblUsername = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(32, 90);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(61, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username :";
			this.button1.Location = new global::System.Drawing.Point(99, 142);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.Location = new global::System.Drawing.Point(99, 90);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(298, 20);
			this.textBox1.TabIndex = 2;
			this.textBox2.Location = new global::System.Drawing.Point(99, 116);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(298, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.UseSystemPasswordChar = true;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(32, 120);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(59, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password :";
			this.button2.Location = new global::System.Drawing.Point(353, 12);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Logout";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new global::System.Drawing.Point(208, 17);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new global::System.Drawing.Size(61, 13);
			this.lblUsername.TabIndex = 5;
			this.lblUsername.Text = "Username :";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(440, 259);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.lblUsername);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label1);
			base.Name = "Ravan";
			this.Text = "Ravan";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(true);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label lblUsername;
	}
}
