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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cust_ID_Txt
            // 
            this.Cust_ID_Txt.AccessibleName = "Cust_ID_Txt";
            this.Cust_ID_Txt.Location = new System.Drawing.Point(130, 231);
            this.Cust_ID_Txt.Name = "Cust_ID_Txt";
            this.Cust_ID_Txt.Size = new System.Drawing.Size(156, 20);
            this.Cust_ID_Txt.TabIndex = 0;
            // 
            // Order_Info_Txt
            // 
            this.Order_Info_Txt.AccessibleName = "Order_Info_Txt";
            this.Order_Info_Txt.Location = new System.Drawing.Point(130, 279);
            this.Order_Info_Txt.Name = "Order_Info_Txt";
            this.Order_Info_Txt.Size = new System.Drawing.Size(156, 20);
            this.Order_Info_Txt.TabIndex = 1;
            // 
            // Total_Cost_Txt
            // 
            this.Total_Cost_Txt.AccessibleName = "Total_Cost_Txt";
            this.Total_Cost_Txt.Location = new System.Drawing.Point(130, 323);
            this.Total_Cost_Txt.Name = "Total_Cost_Txt";
            this.Total_Cost_Txt.Size = new System.Drawing.Size(156, 20);
            this.Total_Cost_Txt.TabIndex = 2;
            this.Total_Cost_Txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Item_Count_Txt
            // 
            this.Item_Count_Txt.AccessibleName = "Item_Count_Txt";
            this.Item_Count_Txt.Location = new System.Drawing.Point(130, 365);
            this.Item_Count_Txt.Name = "Item_Count_Txt";
            this.Item_Count_Txt.Size = new System.Drawing.Size(156, 20);
            this.Item_Count_Txt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Order Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Cost";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount of Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // New_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 443);
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
    }
}