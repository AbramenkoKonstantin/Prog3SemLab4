
namespace Prog3SemLab4
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
            this.sortChoose = new System.Windows.Forms.CheckedListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.startBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSheetsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortChoose
            // 
            this.sortChoose.FormattingEnabled = true;
            this.sortChoose.Items.AddRange(new object[] {
            "Bubble sort",
            "Insertion sort",
            "Shaker sort",
            "Quick sort",
            "Bogo sort"});
            this.sortChoose.Location = new System.Drawing.Point(12, 119);
            this.sortChoose.Name = "sortChoose";
            this.sortChoose.Size = new System.Drawing.Size(120, 79);
            this.sortChoose.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 63);
            this.dataGridView.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startBtn,
            this.импортToolStripMenuItem,
            this.closeBtn});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // startBtn
            // 
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(57, 20);
            this.startBtn.Text = "Запуск";
            this.startBtn.Click += new System.EventHandler(this.StartBtnClick);
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleSheetsItem,
            this.excel});
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // googleSheetsItem
            // 
            this.googleSheetsItem.Name = "googleSheetsItem";
            this.googleSheetsItem.Size = new System.Drawing.Size(180, 22);
            this.googleSheetsItem.Text = "Google sheets";
            this.googleSheetsItem.Click += new System.EventHandler(this.GoogleSheetsItemClick);
            // 
            // excel
            // 
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(180, 22);
            this.excel.Text = "Excel";
            this.excel.Click += new System.EventHandler(this.ExcelClick);
            // 
            // closeBtn
            // 
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(54, 20);
            this.closeBtn.Text = "Выход";
            this.closeBtn.Click += new System.EventHandler(this.CloseBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.sortChoose);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox sortChoose;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem startBtn;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleSheetsItem;
        private System.Windows.Forms.ToolStripMenuItem excel;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
    }
}

