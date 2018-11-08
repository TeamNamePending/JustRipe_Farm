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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Homepage
            // 
            this.Homepage.Location = new System.Drawing.Point(332, 342);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(75, 23);
            this.Homepage.TabIndex = 0;
            this.Homepage.Text = "Homepage";
            this.Homepage.UseVisualStyleBackColor = true;
            this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(691, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fertilisier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Homepage);
            this.Name = "Fertilisier";
            this.Text = "Fertilisier";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Homepage;
        private System.Windows.Forms.Button button1;
    }
}