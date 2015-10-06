namespace CountExcel
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.excelPath = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.path = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // excelPath
            // 
            this.excelPath.Location = new System.Drawing.Point(73, 28);
            this.excelPath.Name = "excelPath";
            this.excelPath.Size = new System.Drawing.Size(330, 19);
            this.excelPath.TabIndex = 0;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(110, 64);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(219, 23);
            this.count.TabIndex = 1;
            this.count.Text = "行数カウント";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(410, 185);
            this.dataGridView1.TabIndex = 2;
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(33, 31);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(24, 12);
            this.path.TabIndex = 3;
            this.path.Text = "パス";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.excelPath);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox excelPath;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Label label1;
    }
}

