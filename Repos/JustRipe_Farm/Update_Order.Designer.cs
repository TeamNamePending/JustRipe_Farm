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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Order_ID
            // 
            this.Order_ID.AutoSize = true;
            this.Order_ID.Location = new System.Drawing.Point(56, 230);
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.Size = new System.Drawing.Size(50, 13);
            this.Order_ID.TabIndex = 11;
            this.Order_ID.Text = "Order_ID";
            this.Order_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(56, 284);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(37, 13);
            this.s.TabIndex = 12;
            this.s.Text = "Status";
            // 
            // Order_ID_Txt
            // 
            this.Order_ID_Txt.Location = new System.Drawing.Point(150, 222);
            this.Order_ID_Txt.Name = "Order_ID_Txt";
            this.Order_ID_Txt.Size = new System.Drawing.Size(100, 20);
            this.Order_ID_Txt.TabIndex = 13;
            // 
            // Order_Status_Txt
            // 
            this.Order_Status_Txt.Location = new System.Drawing.Point(150, 276);
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
            // Update_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.Order_Status_Txt);
            this.Controls.Add(this.Order_ID_Txt);
            this.Controls.Add(this.s);
            this.Controls.Add(this.Order_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Update_Order";
            this.Text = "Update_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}