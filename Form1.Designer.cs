
namespace Method_of_calculation_1
{
    partial class LR1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LR1));
            this.dtGV = new System.Windows.Forms.DataGridView();
            this.start_btn = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGV
            // 
            this.dtGV.AllowUserToAddRows = false;
            this.dtGV.AllowUserToDeleteRows = false;
            this.dtGV.AllowUserToResizeColumns = false;
            this.dtGV.AllowUserToResizeRows = false;
            this.dtGV.BackgroundColor = System.Drawing.Color.Bisque;
            this.dtGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y,
            this.fxy,
            this.dx,
            this.dy,
            this.alpha});
            this.dtGV.GridColor = System.Drawing.Color.Peru;
            this.dtGV.Location = new System.Drawing.Point(13, 13);
            this.dtGV.Name = "dtGV";
            this.dtGV.ReadOnly = true;
            this.dtGV.RowHeadersWidth = 90;
            this.dtGV.RowTemplate.Height = 24;
            this.dtGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGV.ShowEditingIcon = false;
            this.dtGV.Size = new System.Drawing.Size(1218, 371);
            this.dtGV.TabIndex = 0;
            this.dtGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtGV_RowsAdded);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.start_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_btn.ForeColor = System.Drawing.Color.Peru;
            this.start_btn.Location = new System.Drawing.Point(13, 390);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(119, 48);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Начать";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.ReadOnly = true;
            this.x.Width = 200;
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.ReadOnly = true;
            this.y.Width = 200;
            // 
            // fxy
            // 
            this.fxy.HeaderText = "f(x,y)";
            this.fxy.MinimumWidth = 6;
            this.fxy.Name = "fxy";
            this.fxy.ReadOnly = true;
            this.fxy.Width = 200;
            // 
            // dx
            // 
            this.dx.HeaderText = "df(dx)";
            this.dx.MinimumWidth = 6;
            this.dx.Name = "dx";
            this.dx.ReadOnly = true;
            this.dx.Width = 200;
            // 
            // dy
            // 
            this.dy.HeaderText = "df(dy)";
            this.dy.MinimumWidth = 6;
            this.dy.Name = "dy";
            this.dy.ReadOnly = true;
            this.dy.Width = 200;
            // 
            // alpha
            // 
            this.alpha.HeaderText = "alpha";
            this.alpha.MinimumWidth = 6;
            this.alpha.Name = "alpha";
            this.alpha.ReadOnly = true;
            this.alpha.Width = 125;
            // 
            // Info_btn
            // 
            this.Info_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.Info_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_btn.ForeColor = System.Drawing.Color.Peru;
            this.Info_btn.Location = new System.Drawing.Point(1088, 390);
            this.Info_btn.Name = "Info_btn";
            this.Info_btn.Size = new System.Drawing.Size(144, 48);
            this.Info_btn.TabIndex = 2;
            this.Info_btn.Text = "Информация";
            this.Info_btn.UseVisualStyleBackColor = false;
            this.Info_btn.Click += new System.EventHandler(this.Info_btn_Click);
            // 
            // LR1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.Info_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.dtGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1262, 497);
            this.MinimumSize = new System.Drawing.Size(1262, 497);
            this.Name = "LR1";
            this.Text = "Лабораторная работа №1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGV;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dy;
        private System.Windows.Forms.DataGridViewTextBoxColumn alpha;
        private System.Windows.Forms.Button Info_btn;
    }
}

