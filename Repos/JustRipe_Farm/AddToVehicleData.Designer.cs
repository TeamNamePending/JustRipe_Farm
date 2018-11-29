namespace JustRipe_Farm
{
    partial class AddToVehicleData
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
            this.dgvUpdateVehicleData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UpdateVehicleID = new System.Windows.Forms.Label();
            this.UpdateVehicleSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateVehicleMaxSpace = new System.Windows.Forms.Label();
            this.UpdateVehicleCurrentSpace = new System.Windows.Forms.Label();
            this.UpdateVehicleType = new System.Windows.Forms.Label();
            this.UpdateVehicleAvailability = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateVehicleData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdateVehicleData
            // 
            this.dgvUpdateVehicleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateVehicleData.Location = new System.Drawing.Point(42, 24);
            this.dgvUpdateVehicleData.Name = "dgvUpdateVehicleData";
            this.dgvUpdateVehicleData.Size = new System.Drawing.Size(692, 23);
            this.dgvUpdateVehicleData.TabIndex = 0;
            this.dgvUpdateVehicleData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Homepage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 28;
            // 
            // UpdateVehicleID
            // 
            this.UpdateVehicleID.AutoSize = true;
            this.UpdateVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpdateVehicleID.Location = new System.Drawing.Point(37, 152);
            this.UpdateVehicleID.Name = "UpdateVehicleID";
            this.UpdateVehicleID.Size = new System.Drawing.Size(135, 26);
            this.UpdateVehicleID.TabIndex = 29;
            this.UpdateVehicleID.Text = "Vehicles ID :";
            this.UpdateVehicleID.Click += new System.EventHandler(this.Username_Click);
            // 
            // UpdateVehicleSaveButton
            // 
            this.UpdateVehicleSaveButton.Location = new System.Drawing.Point(364, 375);
            this.UpdateVehicleSaveButton.Name = "UpdateVehicleSaveButton";
            this.UpdateVehicleSaveButton.Size = new System.Drawing.Size(109, 46);
            this.UpdateVehicleSaveButton.TabIndex = 30;
            this.UpdateVehicleSaveButton.Text = "Save";
            this.UpdateVehicleSaveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Please enter the new :";
            // 
            // UpdateVehicleMaxSpace
            // 
            this.UpdateVehicleMaxSpace.AutoSize = true;
            this.UpdateVehicleMaxSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpdateVehicleMaxSpace.Location = new System.Drawing.Point(37, 195);
            this.UpdateVehicleMaxSpace.Name = "UpdateVehicleMaxSpace";
            this.UpdateVehicleMaxSpace.Size = new System.Drawing.Size(133, 26);
            this.UpdateVehicleMaxSpace.TabIndex = 32;
            this.UpdateVehicleMaxSpace.Text = "Max Space :";
            // 
            // UpdateVehicleCurrentSpace
            // 
            this.UpdateVehicleCurrentSpace.AutoSize = true;
            this.UpdateVehicleCurrentSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpdateVehicleCurrentSpace.Location = new System.Drawing.Point(37, 242);
            this.UpdateVehicleCurrentSpace.Name = "UpdateVehicleCurrentSpace";
            this.UpdateVehicleCurrentSpace.Size = new System.Drawing.Size(164, 26);
            this.UpdateVehicleCurrentSpace.TabIndex = 33;
            this.UpdateVehicleCurrentSpace.Text = "Current Space :";
            // 
            // UpdateVehicleType
            // 
            this.UpdateVehicleType.AutoSize = true;
            this.UpdateVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpdateVehicleType.Location = new System.Drawing.Point(37, 285);
            this.UpdateVehicleType.Name = "UpdateVehicleType";
            this.UpdateVehicleType.Size = new System.Drawing.Size(143, 26);
            this.UpdateVehicleType.TabIndex = 34;
            this.UpdateVehicleType.Text = "VehicleType :";
            // 
            // UpdateVehicleAvailability
            // 
            this.UpdateVehicleAvailability.AutoSize = true;
            this.UpdateVehicleAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UpdateVehicleAvailability.Location = new System.Drawing.Point(37, 327);
            this.UpdateVehicleAvailability.Name = "UpdateVehicleAvailability";
            this.UpdateVehicleAvailability.Size = new System.Drawing.Size(113, 26);
            this.UpdateVehicleAvailability.TabIndex = 35;
            this.UpdateVehicleAvailability.Text = "Available :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 20);
            this.textBox3.TabIndex = 37;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 291);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 20);
            this.textBox4.TabIndex = 38;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(207, 333);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(211, 20);
            this.textBox5.TabIndex = 39;
            // 
            // AddToVehicleData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UpdateVehicleAvailability);
            this.Controls.Add(this.UpdateVehicleType);
            this.Controls.Add(this.UpdateVehicleCurrentSpace);
            this.Controls.Add(this.UpdateVehicleMaxSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateVehicleSaveButton);
            this.Controls.Add(this.UpdateVehicleID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvUpdateVehicleData);
            this.Name = "AddToVehicleData";
            this.Text = "AddToVehicleData";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateVehicleData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateVehicleData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label UpdateVehicleID;
        private System.Windows.Forms.Button UpdateVehicleSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpdateVehicleMaxSpace;
        private System.Windows.Forms.Label UpdateVehicleCurrentSpace;
        private System.Windows.Forms.Label UpdateVehicleType;
        private System.Windows.Forms.Label UpdateVehicleAvailability;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}