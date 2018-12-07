namespace JustRipe_Farm
{
    partial class Update_Order
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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Order_ID = new System.Windows.Forms.Label();
			this.s = new System.Windows.Forms.Label();
			this.Order_ID_Txt = new System.Windows.Forms.TextBox();
			this.Order_Status_Txt = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(227, 399);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 34);
			this.button1.TabIndex = 9;
			this.button1.Text = "Complete";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(139, 115);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Order_ID
			// 
			this.Order_ID.AutoSize = true;
			this.Order_ID.Location = new System.Drawing.Point(133, 320);
			this.Order_ID.Name = "Order_ID";
			this.Order_ID.Size = new System.Drawing.Size(50, 13);
			this.Order_ID.TabIndex = 11;
			this.Order_ID.Text = "Order_ID";
			this.Order_ID.Click += new System.EventHandler(this.label1_Click);
			// 
			// s
			// 
			this.s.AutoSize = true;
			this.s.Location = new System.Drawing.Point(133, 356);
			this.s.Name = "s";
			this.s.Size = new System.Drawing.Size(37, 13);
			this.s.TabIndex = 12;
			this.s.Text = "Status";
			// 
			// Order_ID_Txt
			// 
			this.Order_ID_Txt.Location = new System.Drawing.Point(227, 312);
			this.Order_ID_Txt.Name = "Order_ID_Txt";
			this.Order_ID_Txt.Size = new System.Drawing.Size(100, 20);
			this.Order_ID_Txt.TabIndex = 13;
			// 
			// Order_Status_Txt
			// 
			this.Order_Status_Txt.Location = new System.Drawing.Point(227, 348);
			this.Order_Status_Txt.Name = "Order_Status_Txt";
			this.Order_Status_Txt.Size = new System.Drawing.Size(100, 20);
			this.Order_Status_Txt.TabIndex = 14;
			this.Order_Status_Txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox1.Location = new System.Drawing.Point(1, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(536, 81);
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(90, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(397, 61);
			this.label1.TabIndex = 34;
			this.label1.Text = "Just Ripe Farm";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::JustRipe_Farm.Properties.Resources.Untitled_2;
			this.pictureBox2.Location = new System.Drawing.Point(12, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(76, 76);
			this.pictureBox2.TabIndex = 35;
			this.pictureBox2.TabStop = false;
			// 
			// Update_Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 450);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Order_Status_Txt);
			this.Controls.Add(this.Order_ID_Txt);
			this.Controls.Add(this.s);
			this.Controls.Add(this.Order_ID);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Name = "Update_Order";
			this.Text = "Update_Order";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Order_ID;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TextBox Order_ID_Txt;
        private System.Windows.Forms.TextBox Order_Status_Txt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}