namespace JustRipe_Farm
{
	partial class Homepage
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
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.listBox6 = new System.Windows.Forms.ListBox();
			this.listBox7 = new System.Windows.Forms.ListBox();
			this.listBox8 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.Location = new System.Drawing.Point(52, 162);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(107, 43);
			this.listBox4.TabIndex = 4;
			// 
			// listBox6
			// 
			this.listBox6.FormattingEnabled = true;
			this.listBox6.Location = new System.Drawing.Point(52, 358);
			this.listBox6.Name = "listBox6";
			this.listBox6.Size = new System.Drawing.Size(107, 43);
			this.listBox6.TabIndex = 6;
			// 
			// listBox7
			// 
			this.listBox7.FormattingEnabled = true;
			this.listBox7.Location = new System.Drawing.Point(52, 298);
			this.listBox7.Name = "listBox7";
			this.listBox7.Size = new System.Drawing.Size(107, 43);
			this.listBox7.TabIndex = 7;
			// 
			// listBox8
			// 
			this.listBox8.FormattingEnabled = true;
			this.listBox8.Location = new System.Drawing.Point(52, 229);
			this.listBox8.Name = "listBox8";
			this.listBox8.Size = new System.Drawing.Size(107, 43);
			this.listBox8.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(691, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Log Out";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(52, 36);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Crops";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(52, 85);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Storage";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox8);
			this.Controls.Add(this.listBox7);
			this.Controls.Add(this.listBox6);
			this.Controls.Add(this.listBox4);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}