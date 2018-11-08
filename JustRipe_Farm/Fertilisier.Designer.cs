namespace JustRipe_Farm
{
	partial class Fertilisier
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
			this.Homepage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Homepage
			// 
			this.Homepage.Location = new System.Drawing.Point(417, 353);
			this.Homepage.Name = "Homepage";
			this.Homepage.Size = new System.Drawing.Size(75, 23);
			this.Homepage.TabIndex = 0;
			this.Homepage.Text = "Homepage";
			this.Homepage.UseVisualStyleBackColor = true;
			this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
			// 
			// Fertilisier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Homepage);
			this.Name = "Fertilisier";
			this.Text = "Fertilisier";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Homepage;
	}
}