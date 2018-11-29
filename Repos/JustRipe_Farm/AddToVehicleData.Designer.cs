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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateVehicleData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpdateVehicleData
            // 
            this.dgvUpdateVehicleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateVehicleData.Location = new System.Drawing.Point(42, 24);
            this.dgvUpdateVehicleData.Name = "dgvUpdateVehicleData";
            this.dgvUpdateVehicleData.Size = new System.Drawing.Size(710, 139);
            this.dgvUpdateVehicleData.TabIndex = 0;
            this.dgvUpdateVehicleData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddToVehicleData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUpdateVehicleData);
            this.Name = "AddToVehicleData";
            this.Text = "AddToVehicleData";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateVehicleData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpdateVehicleData;
    }
}