﻿namespace JustRipe_Farm
{
	partial class Storage
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
			this.button2 = new System.Windows.Forms.Button();
			this.dgvStorage = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Update = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(588, 404);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Homepage";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(691, 404);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(97, 34);
			this.button2.TabIndex = 27;
			this.button2.Text = "Log Out";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// dgvStorage
			// 
			this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStorage.Location = new System.Drawing.Point(12, 88);
			this.dgvStorage.Name = "dgvStorage";
			this.dgvStorage.Size = new System.Drawing.Size(776, 310);
			this.dgvStorage.TabIndex = 28;
			this.dgvStorage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorage_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(230, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(397, 61);
			this.label1.TabIndex = 29;
			this.label1.Text = "Just Ripe Farm";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox1.Location = new System.Drawing.Point(1, -23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(799, 103);
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// Update
			// 
			this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update.Location = new System.Drawing.Point(82, 406);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(97, 32);
			this.Update.TabIndex = 31;
			this.Update.Text = "Add Storage";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::JustRipe_Farm.Properties.Resources.Untitled_2;
			this.pictureBox2.Location = new System.Drawing.Point(12, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(76, 76);
			this.pictureBox2.TabIndex = 32;
			this.pictureBox2.TabStop = false;
			// 
			// Storage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dgvStorage);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Storage";
			this.Text = "Storage";
			((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}