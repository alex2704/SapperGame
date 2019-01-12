namespace SaperGame
{
    partial class SapperForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SapperForm));
            this.gameFieldDataGridView = new System.Windows.Forms.DataGridView();
            this.newGameButton = new System.Windows.Forms.Button();
            this.Width_box = new System.Windows.Forms.NumericUpDown();
            this.Mine_box = new System.Windows.Forms.NumericUpDown();
            this.Height_box = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.Background_box = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer_lbl = new System.Windows.Forms.Label();
            this.timeWord_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameFieldDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mine_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background_box)).BeginInit();
            this.SuspendLayout();
            // 
            // gameFieldDataGridView
            // 
            this.gameFieldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameFieldDataGridView.Location = new System.Drawing.Point(12, 132);
            this.gameFieldDataGridView.Name = "gameFieldDataGridView";
            this.gameFieldDataGridView.RowTemplate.Height = 24;
            this.gameFieldDataGridView.Size = new System.Drawing.Size(464, 306);
            this.gameFieldDataGridView.TabIndex = 0;
            this.gameFieldDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gameFieldDataGridView_CellMouseClick);
            this.gameFieldDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gameFieldDataGridView_CellPainting);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(809, 22);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(173, 43);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Width_box
            // 
            this.Width_box.Location = new System.Drawing.Point(118, 33);
            this.Width_box.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Width_box.Name = "Width_box";
            this.Width_box.Size = new System.Drawing.Size(60, 22);
            this.Width_box.TabIndex = 2;
            this.Width_box.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Mine_box
            // 
            this.Mine_box.Location = new System.Drawing.Point(612, 33);
            this.Mine_box.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Mine_box.Name = "Mine_box";
            this.Mine_box.Size = new System.Drawing.Size(60, 22);
            this.Mine_box.TabIndex = 3;
            this.Mine_box.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // Height_box
            // 
            this.Height_box.Location = new System.Drawing.Point(371, 31);
            this.Height_box.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Height_box.Name = "Height_box";
            this.Height_box.Size = new System.Drawing.Size(60, 22);
            this.Height_box.TabIndex = 4;
            this.Height_box.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ширина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(288, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Высота:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(498, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во мин:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(296, 80);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(283, 32);
            this.label.TabIndex = 8;
            this.label.Text = "Добро пожаловать";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_lbl.Location = new System.Drawing.Point(737, 80);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(0, 32);
            this.score_lbl.TabIndex = 9;
            // 
            // Background_box
            // 
            this.Background_box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Background_box.BackgroundImage")));
            this.Background_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background_box.Location = new System.Drawing.Point(0, 0);
            this.Background_box.Name = "Background_box";
            this.Background_box.Size = new System.Drawing.Size(1006, 646);
            this.Background_box.TabIndex = 10;
            this.Background_box.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer_lbl.Location = new System.Drawing.Point(127, 80);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(0, 32);
            this.timer_lbl.TabIndex = 11;
            // 
            // timeWord_lbl
            // 
            this.timeWord_lbl.AutoSize = true;
            this.timeWord_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeWord_lbl.Location = new System.Drawing.Point(12, 80);
            this.timeWord_lbl.Name = "timeWord_lbl";
            this.timeWord_lbl.Size = new System.Drawing.Size(115, 32);
            this.timeWord_lbl.TabIndex = 12;
            this.timeWord_lbl.Text = "Время:";
            // 
            // SapperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 646);
            this.Controls.Add(this.timeWord_lbl);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Height_box);
            this.Controls.Add(this.Mine_box);
            this.Controls.Add(this.Width_box);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.gameFieldDataGridView);
            this.Controls.Add(this.Background_box);
            this.Name = "SapperForm";
            this.Text = "САПЕР";
            this.Load += new System.EventHandler(this.SapperForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameFieldDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mine_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gameFieldDataGridView;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.NumericUpDown Width_box;
        private System.Windows.Forms.NumericUpDown Mine_box;
        private System.Windows.Forms.NumericUpDown Height_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox Background_box;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.Label timeWord_lbl;
    }
}

