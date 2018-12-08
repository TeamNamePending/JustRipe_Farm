namespace JustRipe_Farm
{
    partial class New_Order
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
			this.Cust_ID_Txt = new System.Windows.Forms.TextBox();
			this.Order_Info_Txt = new System.Windows.Forms.TextBox();
			this.Total_Cost_Txt = new System.Windows.Forms.TextBox();
			this.Item_Count_Txt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// Cust_ID_Txt
			// 
			this.Cust_ID_Txt.AccessibleName = "Cust_ID_Txt";
			this.Cust_ID_Txt.Location = new System.Drawing.Point(214, 267);
			this.Cust_ID_Txt.Name = "Cust_ID_Txt";
			this.Cust_ID_Txt.Size = new System.Drawing.Size(156, 20);
			this.Cust_ID_Txt.TabIndex = 0;
			// 
			// Order_Info_Txt
			// 
			this.Order_Info_Txt.AccessibleName = "Order_Info_Txt";
			this.Order_Info_Txt.Location = new System.Drawing.Point(214, 315);
			this.Order_Info_Txt.Name = "Order_Info_Txt";
			this.Order_Info_Txt.Size = new System.Drawing.Size(156, 20);
			this.Order_Info_Txt.TabIndex = 1;
			// 
			// Total_Cost_Txt
			// 
			this.Total_Cost_Txt.AccessibleName = "Total_Cost_Txt";
			this.Total_Cost_Txt.Location = new System.Drawing.Point(214, 359);
			this.Total_Cost_Txt.Name = "Total_Cost_Txt";
			this.Total_Cost_Txt.Size = new System.Drawing.Size(156, 20);
			this.Total_Cost_Txt.TabIndex = 2;
			this.Total_Cost_Txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// Item_Count_Txt
			// 
			this.Item_Count_Txt.AccessibleName = "Item_Count_Txt";
			this.Item_Count_Txt.Location = new System.Drawing.Point(214, 401);
			this.Item_Count_Txt.Name = "Item_Count_Txt";
			this.Item_Count_Txt.Size = new System.Drawing.Size(156, 20);
			this.Item_Count_Txt.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(234, 453);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 34);
			this.button1.TabIndex = 8;
			this.button1.Text = "Complete";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(120, 270);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Customer ID";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(121, 318);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Order Info";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(120, 362);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Total Cost";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(121, 404);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Amount of Items";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(123, 98);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(246, 150);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox1.Location = new System.Drawing.Point(1, -23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(799, 103);
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(91, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(397, 61);
			this.label5.TabIndex = 28;
			this.label5.Text = "Just Ripe Farm";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::JustRipe_Farm.Properties.Resources.Untitled_2;
			this.pictureBox2.Location = new System.Drawing.Point(12, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(76, 76);
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			// 
			// New_Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 499);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Item_Count_Txt);
			this.Controls.Add(this.Total_Cost_Txt);
			this.Controls.Add(this.Order_Info_Txt);
			this.Controls.Add(this.Cust_ID_Txt);
			this.Name = "New_Order";
			this.Text = "New_Order";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cust_ID_Txt;
        private System.Windows.Forms.TextBox Order_Info_Txt;
        private System.Windows.Forms.TextBox Total_Cost_Txt;
        private System.Windows.Forms.TextBox Item_Count_Txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}