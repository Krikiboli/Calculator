
namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_znak = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_float = new System.Windows.Forms.Button();
            this.button_res = new System.Windows.Forms.Button();
            this.button_addition = new System.Windows.Forms.Button();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.button_multip = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_sqr = new System.Windows.Forms.Button();
            this.button_deg = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_mr = new System.Windows.Forms.Button();
            this.button_mc = new System.Windows.Forms.Button();
            this.button_MS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(30, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 158);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_znak
            // 
            this.button_znak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_znak.Location = new System.Drawing.Point(30, 648);
            this.button_znak.Name = "button_znak";
            this.button_znak.Size = new System.Drawing.Size(101, 77);
            this.button_znak.TabIndex = 1;
            this.button_znak.Text = "+/-";
            this.button_znak.UseVisualStyleBackColor = true;
            this.button_znak.Click += new System.EventHandler(this.button_znak_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_0.Location = new System.Drawing.Point(137, 648);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(101, 77);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_float
            // 
            this.button_float.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.button_float.Location = new System.Drawing.Point(244, 648);
            this.button_float.Name = "button_float";
            this.button_float.Size = new System.Drawing.Size(101, 77);
            this.button_float.TabIndex = 3;
            this.button_float.Text = ",";
            this.button_float.UseVisualStyleBackColor = true;
            this.button_float.Click += new System.EventHandler(this.button_float_Click);
            // 
            // button_res
            // 
            this.button_res.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_res.Location = new System.Drawing.Point(351, 648);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(101, 77);
            this.button_res.TabIndex = 4;
            this.button_res.Text = "=";
            this.button_res.UseVisualStyleBackColor = false;
            this.button_res.Click += new System.EventHandler(this.button_res_Click);
            // 
            // button_addition
            // 
            this.button_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addition.Location = new System.Drawing.Point(351, 565);
            this.button_addition.Name = "button_addition";
            this.button_addition.Size = new System.Drawing.Size(101, 77);
            this.button_addition.TabIndex = 5;
            this.button_addition.Text = "+";
            this.button_addition.UseVisualStyleBackColor = true;
            this.button_addition.Click += new System.EventHandler(this.button_act);
            // 
            // button_subtraction
            // 
            this.button_subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_subtraction.Location = new System.Drawing.Point(351, 482);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(101, 77);
            this.button_subtraction.TabIndex = 6;
            this.button_subtraction.Text = "-";
            this.button_subtraction.UseVisualStyleBackColor = true;
            this.button_subtraction.Click += new System.EventHandler(this.button_act);
            // 
            // button_multip
            // 
            this.button_multip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multip.Location = new System.Drawing.Point(351, 399);
            this.button_multip.Name = "button_multip";
            this.button_multip.Size = new System.Drawing.Size(101, 77);
            this.button_multip.TabIndex = 7;
            this.button_multip.Text = "X";
            this.button_multip.UseVisualStyleBackColor = true;
            this.button_multip.Click += new System.EventHandler(this.button_act);
            // 
            // button_division
            // 
            this.button_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_division.Location = new System.Drawing.Point(351, 316);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(101, 77);
            this.button_division.TabIndex = 8;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_act);
            // 
            // button_C
            // 
            this.button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_C.Location = new System.Drawing.Point(244, 233);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(101, 77);
            this.button_C.TabIndex = 10;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_sqr
            // 
            this.button_sqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sqr.Location = new System.Drawing.Point(244, 316);
            this.button_sqr.Name = "button_sqr";
            this.button_sqr.Size = new System.Drawing.Size(101, 77);
            this.button_sqr.TabIndex = 12;
            this.button_sqr.Text = "y√(x)";
            this.button_sqr.UseVisualStyleBackColor = true;
            this.button_sqr.Click += new System.EventHandler(this.button_sqr_Click);
            // 
            // button_deg
            // 
            this.button_deg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deg.Location = new System.Drawing.Point(137, 316);
            this.button_deg.Name = "button_deg";
            this.button_deg.Size = new System.Drawing.Size(101, 77);
            this.button_deg.TabIndex = 13;
            this.button_deg.Text = "x^(y)";
            this.button_deg.UseVisualStyleBackColor = true;
            this.button_deg.Click += new System.EventHandler(this.button_deg_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_2.Location = new System.Drawing.Point(137, 565);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(101, 77);
            this.button_2.TabIndex = 14;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_3.Location = new System.Drawing.Point(244, 565);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(101, 77);
            this.button_3.TabIndex = 15;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_6.Location = new System.Drawing.Point(244, 482);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(101, 77);
            this.button_6.TabIndex = 16;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_9.Location = new System.Drawing.Point(244, 399);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(101, 77);
            this.button_9.TabIndex = 17;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5.Location = new System.Drawing.Point(137, 482);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(101, 77);
            this.button_5.TabIndex = 18;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_8.Location = new System.Drawing.Point(137, 399);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(101, 77);
            this.button_8.TabIndex = 19;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_7.Location = new System.Drawing.Point(30, 399);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(101, 77);
            this.button_7.TabIndex = 20;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_4.Location = new System.Drawing.Point(30, 482);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(101, 77);
            this.button_4.TabIndex = 21;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_1.Location = new System.Drawing.Point(30, 565);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(101, 77);
            this.button_1.TabIndex = 22;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.SystemColors.Control;
            this.button_del.BackgroundImage = global::Calculator.Properties.Resources.kisspng_computer_icons_symbol_clip_art_delete_button_5ad65cc81cbec0_3633946415239978961177;
            this.button_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_del.Location = new System.Drawing.Point(351, 233);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(101, 77);
            this.button_del.TabIndex = 9;
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_CE
            // 
            this.button_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CE.Location = new System.Drawing.Point(137, 233);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(101, 77);
            this.button_CE.TabIndex = 23;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_mr
            // 
            this.button_mr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_mr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mr.Location = new System.Drawing.Point(85, 316);
            this.button_mr.Name = "button_mr";
            this.button_mr.Size = new System.Drawing.Size(46, 77);
            this.button_mr.TabIndex = 24;
            this.button_mr.Text = "MR";
            this.button_mr.UseVisualStyleBackColor = true;
            this.button_mr.Click += new System.EventHandler(this.button_mr_Click);
            // 
            // button_mc
            // 
            this.button_mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mc.Location = new System.Drawing.Point(30, 316);
            this.button_mc.Name = "button_mc";
            this.button_mc.Size = new System.Drawing.Size(49, 77);
            this.button_mc.TabIndex = 25;
            this.button_mc.Text = "MC";
            this.button_mc.UseVisualStyleBackColor = true;
            this.button_mc.Click += new System.EventHandler(this.button_mc_Click);
            // 
            // button_MS
            // 
            this.button_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MS.Location = new System.Drawing.Point(30, 233);
            this.button_MS.Name = "button_MS";
            this.button_MS.Size = new System.Drawing.Size(101, 77);
            this.button_MS.TabIndex = 26;
            this.button_MS.Text = "MS";
            this.button_MS.UseVisualStyleBackColor = true;
            this.button_MS.Click += new System.EventHandler(this.button_MS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 752);
            this.Controls.Add(this.button_MS);
            this.Controls.Add(this.button_mc);
            this.Controls.Add(this.button_mr);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_deg);
            this.Controls.Add(this.button_sqr);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multip);
            this.Controls.Add(this.button_subtraction);
            this.Controls.Add(this.button_addition);
            this.Controls.Add(this.button_res);
            this.Controls.Add(this.button_float);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_znak);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(494, 799);
            this.MinimumSize = new System.Drawing.Size(494, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_znak;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_float;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.Button button_addition;
        private System.Windows.Forms.Button button_subtraction;
        private System.Windows.Forms.Button button_multip;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_sqr;
        private System.Windows.Forms.Button button_deg;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_mr;
        private System.Windows.Forms.Button button_mc;
        private System.Windows.Forms.Button button_MS;
    }
}

