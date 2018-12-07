namespace EcoFarm_EF
{
    partial class Form1
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
            this.dt = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.ProductsCB = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(3, 129);
            this.dt.Name = "dt";
            this.dt.RowTemplate.Height = 24;
            this.dt.Size = new System.Drawing.Size(967, 415);
            this.dt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get info by period LINQ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 13);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 22);
            this.start.TabIndex = 2;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(12, 50);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(200, 22);
            this.end.TabIndex = 3;
            // 
            // ProductsCB
            // 
            this.ProductsCB.FormattingEnabled = true;
            this.ProductsCB.Location = new System.Drawing.Point(420, 12);
            this.ProductsCB.Name = "ProductsCB";
            this.ProductsCB.Size = new System.Drawing.Size(121, 24);
            this.ProductsCB.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Get Product info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProductsCB);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt);
            this.Name = "Form1";
            this.Text = "Database first";
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.ComboBox ProductsCB;
        private System.Windows.Forms.Button button2;
    }
}

