namespace Grap
{
    partial class Gr
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
            this.Pole = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pole
            // 
            this.Pole.Location = new System.Drawing.Point(11, 11);
            this.Pole.Margin = new System.Windows.Forms.Padding(2);
            this.Pole.Name = "Pole";
            this.Pole.Size = new System.Drawing.Size(596, 301);
            this.Pole.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(212, 317);
            this.result.Margin = new System.Windows.Forms.Padding(2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(179, 31);
            this.result.TabIndex = 2;
            this.result.Text = "Построить график";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Gr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 359);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Pole);
            this.Name = "Gr";
            this.Text = "Gr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pole;
        private System.Windows.Forms.Button result;
    }
}

