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
			this.button1 = new System.Windows.Forms.Button();
			this.ViewCultivatingCropsButton = new System.Windows.Forms.Button();
			this.ViewStorageButton = new System.Windows.Forms.Button();
			this.VehicleButton = new System.Windows.Forms.Button();
			this.ViewOrdersButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(669, 404);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 34);
			this.button1.TabIndex = 9;
			this.button1.Text = "Log Out";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ViewCultivatingCropsButton
			// 
			this.ViewCultivatingCropsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewCultivatingCropsButton.Location = new System.Drawing.Point(116, 163);
			this.ViewCultivatingCropsButton.Name = "ViewCultivatingCropsButton";
			this.ViewCultivatingCropsButton.Size = new System.Drawing.Size(228, 64);
			this.ViewCultivatingCropsButton.TabIndex = 10;
			this.ViewCultivatingCropsButton.Text = "Cultivating Crops";
			this.ViewCultivatingCropsButton.UseVisualStyleBackColor = true;
			this.ViewCultivatingCropsButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// ViewStorageButton
			// 
			this.ViewStorageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewStorageButton.Location = new System.Drawing.Point(116, 272);
			this.ViewStorageButton.Name = "ViewStorageButton";
			this.ViewStorageButton.Size = new System.Drawing.Size(228, 64);
			this.ViewStorageButton.TabIndex = 11;
			this.ViewStorageButton.Text = "Storage";
			this.ViewStorageButton.UseVisualStyleBackColor = true;
			this.ViewStorageButton.Click += new System.EventHandler(this.button3_Click);
			// 
			// VehicleButton
			// 
			this.VehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VehicleButton.Location = new System.Drawing.Point(421, 272);
			this.VehicleButton.Name = "VehicleButton";
			this.VehicleButton.Size = new System.Drawing.Size(228, 64);
			this.VehicleButton.TabIndex = 12;
			this.VehicleButton.Text = "Vehicle";
			this.VehicleButton.UseVisualStyleBackColor = true;
			this.VehicleButton.Click += new System.EventHandler(this.button4_Click);
			// 
			// ViewOrdersButton
			// 
			this.ViewOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewOrdersButton.Location = new System.Drawing.Point(421, 163);
			this.ViewOrdersButton.Name = "ViewOrdersButton";
			this.ViewOrdersButton.Size = new System.Drawing.Size(228, 64);
			this.ViewOrdersButton.TabIndex = 13;
			this.ViewOrdersButton.Text = "Orders";
			this.ViewOrdersButton.UseVisualStyleBackColor = true;
			this.ViewOrdersButton.Click += new System.EventHandler(this.button5_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(325, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Main menu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(297, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 18);
			this.label2.TabIndex = 15;
			this.label2.Text = "Please select an option";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(201, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(392, 63);
			this.label3.TabIndex = 16;
			this.label3.Text = "Just Ripe Farm";
			// 
			// Homepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ViewOrdersButton);
			this.Controls.Add(this.VehicleButton);
			this.Controls.Add(this.ViewStorageButton);
			this.Controls.Add(this.ViewCultivatingCropsButton);
			this.Controls.Add(this.button1);
			this.Name = "Homepage";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button ViewCultivatingCropsButton;
		private System.Windows.Forms.Button ViewStorageButton;
		private System.Windows.Forms.Button VehicleButton;
		private System.Windows.Forms.Button ViewOrdersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}