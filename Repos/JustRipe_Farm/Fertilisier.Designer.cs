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
            this.dgvFertilisers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilisers)).BeginInit();
            this.SuspendLayout();
            // 
            // Homepage
            // 
            this.Homepage.Location = new System.Drawing.Point(579, 415);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(106, 33);
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
            // dgvFertilisers
            // 
            this.dgvFertilisers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFertilisers.Location = new System.Drawing.Point(48, 103);
            this.dgvFertilisers.Name = "dgvFertilisers";
            this.dgvFertilisers.Size = new System.Drawing.Size(670, 234);
            this.dgvFertilisers.TabIndex = 11;
            this.dgvFertilisers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 63);
            this.label3.TabIndex = 17;
            this.label3.Text = "Just Ripe Farm";
            // 
            // Fertilisier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFertilisers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Homepage);
            this.Name = "Fertilisier";
            this.Text = "Fertilisier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilisers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Homepage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvFertilisers;
        private System.Windows.Forms.Label label3;
    }
}