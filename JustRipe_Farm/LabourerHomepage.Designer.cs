namespace JustRipe_Farm
{
	partial class LabourerHomepage
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Order = new System.Windows.Forms.Button();
			this.Vehicle = new System.Windows.Forms.Button();
			this.Storage = new System.Windows.Forms.Button();
			this.Crop = new System.Windows.Forms.Button();
			this.Fertiliser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(184, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(392, 63);
			this.label3.TabIndex = 17;
			this.label3.Text = "Just Ripe Farm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(297, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 18);
			this.label2.TabIndex = 19;
			this.label2.Text = "Please select an option";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(325, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 25);
			this.label1.TabIndex = 18;
			this.label1.Text = "Main menu";
			// 
			// Order
			// 
			this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.Order.Location = new System.Drawing.Point(421, 163);
			this.Order.Name = "Order";
			this.Order.Size = new System.Drawing.Size(228, 64);
			this.Order.TabIndex = 20;
			this.Order.Text = "Orders";
			this.Order.UseVisualStyleBackColor = true;
			this.Order.Click += new System.EventHandler(this.button1_Click);
			// 
			// Vehicle
			// 
			this.Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.Vehicle.Location = new System.Drawing.Point(421, 272);
			this.Vehicle.Name = "Vehicle";
			this.Vehicle.Size = new System.Drawing.Size(228, 64);
			this.Vehicle.TabIndex = 21;
			this.Vehicle.Text = "Vehicle";
			this.Vehicle.UseVisualStyleBackColor = true;
			this.Vehicle.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Storage
			// 
			this.Storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.Storage.Location = new System.Drawing.Point(116, 272);
			this.Storage.Name = "Storage";
			this.Storage.Size = new System.Drawing.Size(228, 64);
			this.Storage.TabIndex = 22;
			this.Storage.Text = "Storage";
			this.Storage.UseVisualStyleBackColor = true;
			this.Storage.Click += new System.EventHandler(this.Storage_Click);
			// 
			// Crop
			// 
			this.Crop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.Crop.Location = new System.Drawing.Point(116, 163);
			this.Crop.Name = "Crop";
			this.Crop.Size = new System.Drawing.Size(228, 64);
			this.Crop.TabIndex = 23;
			this.Crop.Text = "Crops";
			this.Crop.UseVisualStyleBackColor = true;
			this.Crop.Click += new System.EventHandler(this.button1_Click_2);
			// 
			// Fertiliser
			// 
			this.Fertiliser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.Fertiliser.Location = new System.Drawing.Point(273, 374);
			this.Fertiliser.Name = "Fertiliser";
			this.Fertiliser.Size = new System.Drawing.Size(228, 64);
			this.Fertiliser.TabIndex = 24;
			this.Fertiliser.Text = "Fertiliser";
			this.Fertiliser.UseVisualStyleBackColor = true;
			this.Fertiliser.Click += new System.EventHandler(this.Fertiliser_Click);
			// 
			// LabourerHomepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Fertiliser);
			this.Controls.Add(this.Crop);
			this.Controls.Add(this.Storage);
			this.Controls.Add(this.Vehicle);
			this.Controls.Add(this.Order);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Name = "LabourerHomepage";
			this.Text = "LabourerHomepage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Order;
		private System.Windows.Forms.Button Vehicle;
		private System.Windows.Forms.Button Storage;
		private System.Windows.Forms.Button Crop;
		private System.Windows.Forms.Button Fertiliser;
	}
}