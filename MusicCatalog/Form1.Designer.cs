namespace MusicCatalog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SingerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongbookCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Название",
            "Жанр",
            "Год"});
            this.comboBox2.Location = new System.Drawing.Point(609, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Песни",
            "Артисты",
            "Альбомы",
            "Сборники"});
            this.comboBox1.Location = new System.Drawing.Point(447, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerCol,
            this.AlbumCol,
            this.YearCol,
            this.SongCol,
            this.GenreCol,
            this.SongbookCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // SingerCol
            // 
            this.SingerCol.HeaderText = "Артист";
            this.SingerCol.Name = "SingerCol";
            this.SingerCol.ReadOnly = true;
            this.SingerCol.Width = 150;
            // 
            // AlbumCol
            // 
            this.AlbumCol.HeaderText = "Альбом";
            this.AlbumCol.Name = "AlbumCol";
            this.AlbumCol.ReadOnly = true;
            this.AlbumCol.Width = 200;
            // 
            // YearCol
            // 
            this.YearCol.HeaderText = "Год";
            this.YearCol.Name = "YearCol";
            this.YearCol.ReadOnly = true;
            this.YearCol.Width = 70;
            // 
            // SongCol
            // 
            this.SongCol.HeaderText = "Песня";
            this.SongCol.Name = "SongCol";
            this.SongCol.ReadOnly = true;
            this.SongCol.Width = 250;
            // 
            // GenreCol
            // 
            this.GenreCol.HeaderText = "Жанр";
            this.GenreCol.Name = "GenreCol";
            this.GenreCol.ReadOnly = true;
            // 
            // SongbookCol
            // 
            this.SongbookCol.HeaderText = "Сборник";
            this.SongbookCol.Name = "SongbookCol";
            this.SongbookCol.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Каталог музыки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongbookCol;
    }
}

