namespace LibraryManager
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAuithorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takenBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takenMoreThanThreeMonthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takenAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBooksQualityByYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakenSince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.editToolStripMenuItem,
            this.RefToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1314, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libraryToolStripMenuItem
            // 
            this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            this.libraryToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.libraryToolStripMenuItem.Text = "Библиотека";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.newToolStripMenuItem.Text = "Создать";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byAuithorToolStripMenuItem,
            this.byPublisherToolStripMenuItem,
            this.byYearToolStripMenuItem,
            this.byQualityToolStripMenuItem,
            this.byPriceToolStripMenuItem,
            this.takenBooksToolStripMenuItem,
            this.availableBooksToolStripMenuItem,
            this.allBooksToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.searchToolStripMenuItem.Text = "Фильтры";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.byNameToolStripMenuItem.Text = "По названию";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // byAuithorToolStripMenuItem
            // 
            this.byAuithorToolStripMenuItem.Name = "byAuithorToolStripMenuItem";
            this.byAuithorToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.byAuithorToolStripMenuItem.Text = "По автору";
            this.byAuithorToolStripMenuItem.Click += new System.EventHandler(this.byAuthorToolStripMenuItem_Click);
            // 
            // byPublisherToolStripMenuItem
            // 
            this.byPublisherToolStripMenuItem.Name = "byPublisherToolStripMenuItem";
            this.byPublisherToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.byPublisherToolStripMenuItem.Text = "По издателю";
            this.byPublisherToolStripMenuItem.Click += new System.EventHandler(this.byPublisherToolStripMenuItem_Click);
            // 
            // byYearToolStripMenuItem
            // 
            this.byYearToolStripMenuItem.Name = "byYearToolStripMenuItem";
            this.byYearToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.byYearToolStripMenuItem.Text = "По году";
            this.byYearToolStripMenuItem.Click += new System.EventHandler(this.byYearToolStripMenuItem_Click);
            // 
            // byQualityToolStripMenuItem
            // 
            this.byQualityToolStripMenuItem.Name = "byQualityToolStripMenuItem";
            this.byQualityToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.byQualityToolStripMenuItem.Text = "По состоянию";
            this.byQualityToolStripMenuItem.Click += new System.EventHandler(this.byQualityToolStripMenuItem_Click);
            // 
            // byPriceToolStripMenuItem
            // 
            this.byPriceToolStripMenuItem.Name = "byPriceToolStripMenuItem";
            this.byPriceToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.byPriceToolStripMenuItem.Text = "По цене";
            this.byPriceToolStripMenuItem.Click += new System.EventHandler(this.byPriceToolStripMenuItem_Click);
            // 
            // takenBooksToolStripMenuItem
            // 
            this.takenBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takenMoreThanThreeMonthsToolStripMenuItem,
            this.takenAllToolStripMenuItem});
            this.takenBooksToolStripMenuItem.Name = "takenBooksToolStripMenuItem";
            this.takenBooksToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.takenBooksToolStripMenuItem.Text = "Книги на руках";
            // 
            // takenMoreThanThreeMonthsToolStripMenuItem
            // 
            this.takenMoreThanThreeMonthsToolStripMenuItem.Name = "takenMoreThanThreeMonthsToolStripMenuItem";
            this.takenMoreThanThreeMonthsToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.takenMoreThanThreeMonthsToolStripMenuItem.Text = "больше 3 месяцев";
            this.takenMoreThanThreeMonthsToolStripMenuItem.Click += new System.EventHandler(this.takenMoreThanThreeMonthsAgoToolStripMenuItem_Click);
            // 
            // takenAllToolStripMenuItem
            // 
            this.takenAllToolStripMenuItem.Name = "takenAllToolStripMenuItem";
            this.takenAllToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.takenAllToolStripMenuItem.Text = "все";
            this.takenAllToolStripMenuItem.Click += new System.EventHandler(this.takenAllToolStripMenuItem_Click);
            // 
            // availableBooksToolStripMenuItem
            // 
            this.availableBooksToolStripMenuItem.Name = "availableBooksToolStripMenuItem";
            this.availableBooksToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.availableBooksToolStripMenuItem.Text = "Доступные книги";
            this.availableBooksToolStripMenuItem.Click += new System.EventHandler(this.availableBooksToolStripMenuItem_Click);
            // 
            // allBooksToolStripMenuItem
            // 
            this.allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            this.allBooksToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.allBooksToolStripMenuItem.Text = "Все книги";
            this.allBooksToolStripMenuItem.Click += new System.EventHandler(this.allBooksToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateQualityToolStripMenuItem,
            this.addBookToolStripMenuItem,
            this.generateBooksToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.editToolStripMenuItem.Text = "Редактирование";
            // 
            // updateQualityToolStripMenuItem
            // 
            this.updateQualityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateBooksQualityByYearToolStripMenuItem});
            this.updateQualityToolStripMenuItem.Name = "updateQualityToolStripMenuItem";
            this.updateQualityToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.updateQualityToolStripMenuItem.Text = "Обновить состояние книг";
            // 
            // updateBooksQualityByYearToolStripMenuItem
            // 
            this.updateBooksQualityByYearToolStripMenuItem.Name = "updateBooksQualityByYearToolStripMenuItem";
            this.updateBooksQualityByYearToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.updateBooksQualityByYearToolStripMenuItem.Text = "По возрасту";
            this.updateBooksQualityByYearToolStripMenuItem.Click += new System.EventHandler(this.updateBooksQualityByYearToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.addBookToolStripMenuItem.Text = "Добавить книгу";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // generateBooksToolStripMenuItem
            // 
            this.generateBooksToolStripMenuItem.Name = "generateBooksToolStripMenuItem";
            this.generateBooksToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.generateBooksToolStripMenuItem.Text = "Сгенерировать книги";
            this.generateBooksToolStripMenuItem.Click += new System.EventHandler(this.generateBooksToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Author,
            this.Publisher,
            this.Year,
            this.Quality,
            this.Price,
            this.TakenSince,
            this.Action});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 387);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // Title
            // 
            this.Title.Frozen = true;
            this.Title.HeaderText = "Название";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.Width = 150;
            // 
            // Author
            // 
            this.Author.Frozen = true;
            this.Author.HeaderText = "Автор";
            this.Author.MinimumWidth = 8;
            this.Author.Name = "Author";
            this.Author.Width = 150;
            // 
            // Publisher
            // 
            this.Publisher.Frozen = true;
            this.Publisher.HeaderText = "Издатель";
            this.Publisher.MinimumWidth = 8;
            this.Publisher.Name = "Publisher";
            this.Publisher.Width = 150;
            // 
            // Year
            // 
            this.Year.Frozen = true;
            this.Year.HeaderText = "Год";
            this.Year.MinimumWidth = 8;
            this.Year.Name = "Year";
            this.Year.Width = 50;
            // 
            // Quality
            // 
            this.Quality.Frozen = true;
            this.Quality.HeaderText = "Состояние";
            this.Quality.MinimumWidth = 8;
            this.Quality.Name = "Quality";
            this.Quality.Width = 150;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Цена";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // TakenSince
            // 
            this.TakenSince.Frozen = true;
            this.TakenSince.HeaderText = "На руках с";
            this.TakenSince.MinimumWidth = 8;
            this.TakenSince.Name = "TakenSince";
            this.TakenSince.ReadOnly = true;
            this.TakenSince.Width = 150;
            // 
            // Action
            // 
            this.Action.Frozen = true;
            this.Action.HeaderText = "Действие";
            this.Action.MinimumWidth = 8;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 150;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RefToolStripMenuItem
            // 
            this.RefToolStripMenuItem.Name = "RefToolStripMenuItem";
            this.RefToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.RefToolStripMenuItem.Text = "Справка";
            this.RefToolStripMenuItem.Click += new System.EventHandler(this.RefToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 415);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотечный Менеджер";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byAuithorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPublisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takenBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allBooksToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem takenMoreThanThreeMonthsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takenAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBooksQualityByYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakenSince;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.ToolStripMenuItem generateBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefToolStripMenuItem;
    }
}

