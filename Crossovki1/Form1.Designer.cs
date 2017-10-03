namespace Crossovki1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGTable = new System.Windows.Forms.DataGridView();
            this.BRefresh = new System.Windows.Forms.Button();
            this.LabelMain = new System.Windows.Forms.Label();
            this.LAbelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DGTable
            // 
            this.DGTable.AllowUserToOrderColumns = true;
            this.DGTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTable.Location = new System.Drawing.Point(12, 38);
            this.DGTable.Name = "DGTable";
            this.DGTable.Size = new System.Drawing.Size(1125, 574);
            this.DGTable.TabIndex = 0;
            // 
            // BRefresh
            // 
            this.BRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BRefresh.Location = new System.Drawing.Point(1143, 38);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(141, 41);
            this.BRefresh.TabIndex = 1;
            this.BRefresh.Text = "Обновить";
            this.BRefresh.UseVisualStyleBackColor = true;
            this.BRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMain.Location = new System.Drawing.Point(12, 9);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(245, 20);
            this.LabelMain.TabIndex = 2;
            this.LabelMain.Text = "Необходимо получить таблицу";
            // 
            // LAbelCount
            // 
            this.LAbelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LAbelCount.AutoSize = true;
            this.LAbelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAbelCount.Location = new System.Drawing.Point(1139, 592);
            this.LAbelCount.Name = "LAbelCount";
            this.LAbelCount.Size = new System.Drawing.Size(58, 20);
            this.LAbelCount.TabIndex = 3;
            this.LAbelCount.Text = "Итого:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 624);
            this.Controls.Add(this.LAbelCount);
            this.Controls.Add(this.LabelMain);
            this.Controls.Add(this.BRefresh);
            this.Controls.Add(this.DGTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGTable;
        private System.Windows.Forms.Button BRefresh;
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.Label LAbelCount;
    }
}

