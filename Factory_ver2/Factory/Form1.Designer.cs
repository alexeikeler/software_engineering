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
            this.label1 = new System.Windows.Forms.Label();
            this.integrate_button = new System.Windows.Forms.Button();
            this.EvalIntegralAtPoint_a = new System.Windows.Forms.Label();
            this.EvalIntegralAtPoint_b = new System.Windows.Forms.Label();
            this.a_value_box = new System.Windows.Forms.RichTextBox();
            this.b_value_box = new System.Windows.Forms.RichTextBox();
            this.textBoxForIntegralRes = new System.Windows.Forms.RichTextBox();
            this.integrationResultLabel = new System.Windows.Forms.Label();
            this.graph_bound_a = new System.Windows.Forms.RichTextBox();
            this.graph_bound_b = new System.Windows.Forms.RichTextBox();
            this.rectangle_method = new System.Windows.Forms.Button();
            this.trapezoidal_method = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_plot
            // 
            this.main_plot.BackColor = System.Drawing.Color.Transparent;
            this.main_plot.Location = new System.Drawing.Point(-27, -7);
            this.main_plot.Name = "main_plot";
            this.main_plot.Size = new System.Drawing.Size(481, 508);
            this.main_plot.TabIndex = 0;
            this.main_plot.Load += new System.EventHandler(this.main_plot_Load);
            // 
            // user_input_rtb
            // 
            this.user_input_rtb.Location = new System.Drawing.Point(460, 42);
            this.user_input_rtb.Name = "user_input_rtb";
            this.user_input_rtb.Size = new System.Drawing.Size(292, 37);
            this.user_input_rtb.TabIndex = 2;
            this.user_input_rtb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите функцию";
            // 
            // integrate_button
            // 
            this.integrate_button.Location = new System.Drawing.Point(460, 210);
            this.integrate_button.Name = "integrate_button";
            this.integrate_button.Size = new System.Drawing.Size(228, 23);
            this.integrate_button.TabIndex = 6;
            this.integrate_button.Text = "Точное интегрирование";
            this.integrate_button.UseVisualStyleBackColor = true;
            this.integrate_button.Click += new System.EventHandler(this.integrate_button_Click);
            // 
            // EvalIntegralAtPoint_a
            // 
            this.EvalIntegralAtPoint_a.AutoSize = true;
            this.EvalIntegralAtPoint_a.Location = new System.Drawing.Point(456, 185);
            this.EvalIntegralAtPoint_a.Name = "EvalIntegralAtPoint_a";
            this.EvalIntegralAtPoint_a.Size = new System.Drawing.Size(13, 13);
            this.EvalIntegralAtPoint_a.TabIndex = 7;
            this.EvalIntegralAtPoint_a.Text = "a";
            // 
            // EvalIntegralAtPoint_b
            // 
            this.EvalIntegralAtPoint_b.AutoSize = true;
            this.EvalIntegralAtPoint_b.Location = new System.Drawing.Point(512, 185);
            this.EvalIntegralAtPoint_b.Name = "EvalIntegralAtPoint_b";
            this.EvalIntegralAtPoint_b.Size = new System.Drawing.Size(13, 13);
            this.EvalIntegralAtPoint_b.TabIndex = 8;
            this.EvalIntegralAtPoint_b.Text = "b";
            // 
            // a_value_box
            // 
            this.a_value_box.Location = new System.Drawing.Point(470, 180);
            this.a_value_box.Name = "a_value_box";
            this.a_value_box.Size = new System.Drawing.Size(30, 24);
            this.a_value_box.TabIndex = 10;
            this.a_value_box.Text = "";
            // 
            // b_value_box
            // 
            this.b_value_box.Location = new System.Drawing.Point(529, 180);
            this.b_value_box.Name = "b_value_box";
            this.b_value_box.Size = new System.Drawing.Size(30, 24);
            this.b_value_box.TabIndex = 12;
            this.b_value_box.Text = "";
            // 
            // textBoxForIntegralRes
            // 
            this.textBoxForIntegralRes.Location = new System.Drawing.Point(460, 400);
            this.textBoxForIntegralRes.Name = "textBoxForIntegralRes";
            this.textBoxForIntegralRes.Size = new System.Drawing.Size(304, 46);
            this.textBoxForIntegralRes.TabIndex = 13;
            this.textBoxForIntegralRes.Text = "";
            // 
            // integrationResultLabel
            // 
            this.integrationResultLabel.AutoSize = true;
            this.integrationResultLabel.Location = new System.Drawing.Point(596, 384);
            this.integrationResultLabel.Name = "integrationResultLabel";
            this.integrationResultLabel.Size = new System.Drawing.Size(37, 13);
            this.integrationResultLabel.TabIndex = 15;
            this.integrationResultLabel.Text = "Result";
            this.integrationResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // graph_bound_a
            // 
            this.graph_bound_a.Location = new System.Drawing.Point(470, 118);
            this.graph_bound_a.Name = "graph_bound_a";
            this.graph_bound_a.Size = new System.Drawing.Size(30, 24);
            this.graph_bound_a.TabIndex = 23;
            this.graph_bound_a.Text = "";
            // 
            // graph_bound_b
            // 
            this.graph_bound_b.Location = new System.Drawing.Point(529, 118);
            this.graph_bound_b.Name = "graph_bound_b";
            this.graph_bound_b.Size = new System.Drawing.Size(30, 24);
            this.graph_bound_b.TabIndex = 24;
            this.graph_bound_b.Text = "";
            // 
            // rectangle_method
            // 
            this.rectangle_method.Location = new System.Drawing.Point(461, 240);
            this.rectangle_method.Name = "rectangle_method";
            this.rectangle_method.Size = new System.Drawing.Size(227, 23);
            this.rectangle_method.TabIndex = 25;
            this.rectangle_method.Text = "Метод прямоугольников";
            this.rectangle_method.UseVisualStyleBackColor = true;
            this.rectangle_method.Click += new System.EventHandler(this.rectangle_method_Click);
            // 
            // trapezoidal_method
            // 
            this.trapezoidal_method.Location = new System.Drawing.Point(461, 270);
            this.trapezoidal_method.Name = "trapezoidal_method";
            this.trapezoidal_method.Size = new System.Drawing.Size(227, 23);
            this.trapezoidal_method.TabIndex = 26;
            this.trapezoidal_method.Text = "Метод трапеций";
            this.trapezoidal_method.UseVisualStyleBackColor = true;
            this.trapezoidal_method.Click += new System.EventHandler(this.trapezoidal_method_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Пределы интегрирования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Пределы графика";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trapezoidal_method);
            this.Controls.Add(this.rectangle_method);
            this.Controls.Add(this.graph_bound_b);
            this.Controls.Add(this.graph_bound_a);
            this.Controls.Add(this.integrationResultLabel);
            this.Controls.Add(this.textBoxForIntegralRes);
            this.Controls.Add(this.b_value_box);
            this.Controls.Add(this.a_value_box);
            this.Controls.Add(this.EvalIntegralAtPoint_b);
            this.Controls.Add(this.EvalIntegralAtPoint_a);
            this.Controls.Add(this.integrate_button);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button integrate_button;
        private System.Windows.Forms.Label EvalIntegralAtPoint_a;
        private System.Windows.Forms.Label EvalIntegralAtPoint_b;
        private System.Windows.Forms.RichTextBox a_value_box;
        private System.Windows.Forms.RichTextBox b_value_box;
        private System.Windows.Forms.RichTextBox textBoxForIntegralRes;
        private System.Windows.Forms.Label integrationResultLabel;
        private System.Windows.Forms.RichTextBox graph_bound_a;
        private System.Windows.Forms.RichTextBox graph_bound_b;
        private System.Windows.Forms.Button rectangle_method;
        private System.Windows.Forms.Button trapezoidal_method;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

