namespace demo19
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            category = new Label();
            label2 = new Label();
            opis = new Label();
            prois = new Label();
            post = new Label();
            price = new Label();
            unit = new Label();
            count = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 159);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(216, 23);
            category.Name = "category";
            category.Size = new Size(38, 15);
            category.TabIndex = 1;
            category.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 23);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // opis
            // 
            opis.AutoSize = true;
            opis.Location = new Point(216, 49);
            opis.Name = "opis";
            opis.Size = new Size(38, 15);
            opis.TabIndex = 3;
            opis.Text = "label3";
            // 
            // prois
            // 
            prois.AutoSize = true;
            prois.Location = new Point(216, 73);
            prois.Name = "prois";
            prois.Size = new Size(38, 15);
            prois.TabIndex = 4;
            prois.Text = "label4";
            // 
            // post
            // 
            post.AutoSize = true;
            post.Location = new Point(216, 97);
            post.Name = "post";
            post.Size = new Size(38, 15);
            post.TabIndex = 5;
            post.Text = "label5";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(216, 121);
            price.Name = "price";
            price.Size = new Size(38, 15);
            price.TabIndex = 6;
            price.Text = "label6";
            // 
            // unit
            // 
            unit.AutoSize = true;
            unit.Location = new Point(216, 145);
            unit.Name = "unit";
            unit.Size = new Size(38, 15);
            unit.TabIndex = 7;
            unit.Text = "label7";
            // 
            // count
            // 
            count.AutoSize = true;
            count.Location = new Point(216, 167);
            count.Name = "count";
            count.Size = new Size(38, 15);
            count.TabIndex = 8;
            count.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(543, 97);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 9;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(543, 49);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 10;
            label10.Text = "скидка";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(count);
            Controls.Add(unit);
            Controls.Add(price);
            Controls.Add(post);
            Controls.Add(prois);
            Controls.Add(opis);
            Controls.Add(label2);
            Controls.Add(category);
            Controls.Add(pictureBox1);
            Name = "UserControl1";
            Size = new Size(623, 215);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label category;
        private Label label2;
        private Label opis;
        private Label prois;
        private Label post;
        private Label price;
        private Label unit;
        private Label count;
        private Label label9;
        private Label label10;
    }
}
