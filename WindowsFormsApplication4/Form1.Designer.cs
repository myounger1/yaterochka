namespace WindowsFormsApplication4
{
    partial class Ya_Terochka
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Magazin = new System.Windows.Forms.Button();
            this.Тёрочка = new System.Windows.Forms.Button();
            this.Мой_кабинет = new System.Windows.Forms.Button();
            this.Скины = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Magazin
            // 
            this.Magazin.Location = new System.Drawing.Point(-1, 49);
            this.Magazin.Name = "Magazin";
            this.Magazin.Size = new System.Drawing.Size(145, 23);
            this.Magazin.TabIndex = 0;
            this.Magazin.Text = "Магазин";
            this.Magazin.UseVisualStyleBackColor = true;
            this.Magazin.Click += new System.EventHandler(this.Магазин_Click);
            // 
            // Тёрочка
            // 
            this.Тёрочка.Location = new System.Drawing.Point(142, 49);
            this.Тёрочка.Name = "Тёрочка";
            this.Тёрочка.Size = new System.Drawing.Size(145, 23);
            this.Тёрочка.TabIndex = 1;
            this.Тёрочка.Text = "Тёрочка";
            this.Тёрочка.UseVisualStyleBackColor = true;
            this.Тёрочка.Click += new System.EventHandler(this.Тёрочка_Click);
            // 
            // Мой_кабинет
            // 
            this.Мой_кабинет.Location = new System.Drawing.Point(285, 49);
            this.Мой_кабинет.Name = "Мой_кабинет";
            this.Мой_кабинет.Size = new System.Drawing.Size(145, 23);
            this.Мой_кабинет.TabIndex = 2;
            this.Мой_кабинет.Text = "Мой кабинет";
            this.Мой_кабинет.UseVisualStyleBackColor = true;
            this.Мой_кабинет.Click += new System.EventHandler(this.Мой_кабинет_Click);
            // 
            // Скины
            // 
            this.Скины.Location = new System.Drawing.Point(428, 49);
            this.Скины.Name = "Скины";
            this.Скины.Size = new System.Drawing.Size(145, 23);
            this.Скины.TabIndex = 4;
            this.Скины.Text = "Скины";
            this.Скины.UseVisualStyleBackColor = true;
            this.Скины.Click += new System.EventHandler(this.Скины_Click);
            // 
            // Ya_Terochka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.ytrk_mini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(572, 342);
            this.Controls.Add(this.Скины);
            this.Controls.Add(this.Мой_кабинет);
            this.Controls.Add(this.Тёрочка);
            this.Controls.Add(this.Magazin);
            this.Name = "Ya_Terochka";
            this.Text = "Ya_Terochka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Magazin;
        private System.Windows.Forms.Button Тёрочка;
        private System.Windows.Forms.Button Мой_кабинет;
        private System.Windows.Forms.Button Скины;
    }
}

