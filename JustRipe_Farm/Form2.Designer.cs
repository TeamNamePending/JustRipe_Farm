namespace JustRipe_Farm
{
	partial class Form2
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
            this.Box1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.FormattingEnabled = true;
            this.Box1.Location = new System.Drawing.Point(52, 31);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(107, 43);
            this.Box1.TabIndex = 0;
            this.Box1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(52, 92);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(107, 43);
            this.listBox2.TabIndex = 3;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Box1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox Box1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
    }
}