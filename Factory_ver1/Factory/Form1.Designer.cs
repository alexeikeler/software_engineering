namespace Factory
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
            this.main_plot = new ScottPlot.FormsPlot();
            this.user_input_rtb = new System.Windows.Forms.RichTextBox();
            this.differentiate_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.integrate_button = new System.Windows.Forms.Button();
            this.EvalIntegralAtPoint_a = new System.Windows.Forms.Label();
            this.EvalIntegralAtPoint_b = new System.Windows.Forms.Label();
            this.EvalDerivativeAtPoint_a = new System.Windows.Forms.Label();
            this.a_value_box = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.b_value_box = new System.Windows.Forms.RichTextBox();
            this.textBoxForIntegralRes = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.integrationResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_plot
            // 
            this.main_plot.BackColor = System.Drawing.Color.Transparent;
            this.main_plot.Location = new System.Drawing.Point(-27, -7);
            this.main_plot.Name = "main_plot";
            this.main_plot.Size = new System.Drawing.Size(496, 508);
            this.main_plot.TabIndex = 0;
            this.main_plot.Load += new System.EventHandler(this.main_plot_Load);
            // 
            // user_input_rtb
            // 
            this.user_input_rtb.Location = new System.Drawing.Point(475, 41);
            this.user_input_rtb.Name = "user_input_rtb";
            this.user_input_rtb.Size = new System.Drawing.Size(266, 37);
            this.user_input_rtb.TabIndex = 2;
            this.user_input_rtb.Text = "";
            // 
            // differentiate_button
            // 
            this.differentiate_button.Location = new System.Drawing.Point(475, 217);
            this.differentiate_button.Name = "differentiate_button";
            this.differentiate_button.Size = new System.Drawing.Size(131, 23);
            this.differentiate_button.TabIndex = 3;
            this.differentiate_button.Text = "Дифференцирование";
            this.differentiate_button.UseVisualStyleBackColor = true;
            this.differentiate_button.Click += new System.EventHandler(this.differentiate_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите функцию";
            // 
            // integrate_button
            // 
            this.integrate_button.Location = new System.Drawing.Point(486, 126);
            this.integrate_button.Name = "integrate_button";
            this.integrate_button.Size = new System.Drawing.Size(109, 23);
            this.integrate_button.TabIndex = 6;
            this.integrate_button.Text = "Интегрирование";
            this.integrate_button.UseVisualStyleBackColor = true;
            this.integrate_button.Click += new System.EventHandler(this.integrate_button_Click);
            // 
            // EvalIntegralAtPoint_a
            // 
            this.EvalIntegralAtPoint_a.AutoSize = true;
            this.EvalIntegralAtPoint_a.Location = new System.Drawing.Point(485, 166);
            this.EvalIntegralAtPoint_a.Name = "EvalIntegralAtPoint_a";
            this.EvalIntegralAtPoint_a.Size = new System.Drawing.Size(13, 13);
            this.EvalIntegralAtPoint_a.TabIndex = 7;
            this.EvalIntegralAtPoint_a.Text = "a";
            // 
            // EvalIntegralAtPoint_b
            // 
            this.EvalIntegralAtPoint_b.AutoSize = true;
            this.EvalIntegralAtPoint_b.Location = new System.Drawing.Point(544, 166);
            this.EvalIntegralAtPoint_b.Name = "EvalIntegralAtPoint_b";
            this.EvalIntegralAtPoint_b.Size = new System.Drawing.Size(13, 13);
            this.EvalIntegralAtPoint_b.TabIndex = 8;
            this.EvalIntegralAtPoint_b.Text = "b";
            // 
            // EvalDerivativeAtPoint_a
            // 
            this.EvalDerivativeAtPoint_a.AutoSize = true;
            this.EvalDerivativeAtPoint_a.Location = new System.Drawing.Point(460, 243);
            this.EvalDerivativeAtPoint_a.Name = "EvalDerivativeAtPoint_a";
            this.EvalDerivativeAtPoint_a.Size = new System.Drawing.Size(164, 13);
            this.EvalDerivativeAtPoint_a.TabIndex = 9;
            this.EvalDerivativeAtPoint_a.Text = "Значение производной в точке";
            this.EvalDerivativeAtPoint_a.Click += new System.EventHandler(this.EvalDerivativeAtPoint_a_Click);
            // 
            // a_value_box
            // 
            this.a_value_box.Location = new System.Drawing.Point(504, 163);
            this.a_value_box.Name = "a_value_box";
            this.a_value_box.Size = new System.Drawing.Size(30, 24);
            this.a_value_box.TabIndex = 10;
            this.a_value_box.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(522, 260);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(47, 26);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // b_value_box
            // 
            this.b_value_box.Location = new System.Drawing.Point(563, 163);
            this.b_value_box.Name = "b_value_box";
            this.b_value_box.Size = new System.Drawing.Size(30, 24);
            this.b_value_box.TabIndex = 12;
            this.b_value_box.Text = "";
            // 
            // textBoxForIntegralRes
            // 
            this.textBoxForIntegralRes.Location = new System.Drawing.Point(641, 142);
            this.textBoxForIntegralRes.Name = "textBoxForIntegralRes";
            this.textBoxForIntegralRes.Size = new System.Drawing.Size(100, 37);
            this.textBoxForIntegralRes.TabIndex = 13;
            this.textBoxForIntegralRes.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(641, 240);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(100, 38);
            this.richTextBox5.TabIndex = 14;
            this.richTextBox5.Text = "";
            // 
            // integrationResultLabel
            // 
            this.integrationResultLabel.AutoSize = true;
            this.integrationResultLabel.Location = new System.Drawing.Point(660, 126);
            this.integrationResultLabel.Name = "integrationResultLabel";
            this.integrationResultLabel.Size = new System.Drawing.Size(59, 13);
            this.integrationResultLabel.TabIndex = 15;
            this.integrationResultLabel.Text = "Результат";
            this.integrationResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.integrationResultLabel);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.textBoxForIntegralRes);
            this.Controls.Add(this.b_value_box);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.a_value_box);
            this.Controls.Add(this.EvalDerivativeAtPoint_a);
            this.Controls.Add(this.EvalIntegralAtPoint_b);
            this.Controls.Add(this.EvalIntegralAtPoint_a);
            this.Controls.Add(this.integrate_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.differentiate_button);
            this.Controls.Add(this.user_input_rtb);
            this.Controls.Add(this.main_plot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot main_plot;
        private System.Windows.Forms.RichTextBox user_input_rtb;
        private System.Windows.Forms.Button differentiate_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button integrate_button;
        private System.Windows.Forms.Label EvalIntegralAtPoint_a;
        private System.Windows.Forms.Label EvalIntegralAtPoint_b;
        private System.Windows.Forms.Label EvalDerivativeAtPoint_a;
        private System.Windows.Forms.RichTextBox a_value_box;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox b_value_box;
        private System.Windows.Forms.RichTextBox textBoxForIntegralRes;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label integrationResultLabel;
        private System.Windows.Forms.Label label3;
    }
}

