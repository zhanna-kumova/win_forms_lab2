namespace win_forms_lab2
{
    partial class SolutionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AcomboBox = new System.Windows.Forms.ComboBox();
            this.BcomboBox = new System.Windows.Forms.ComboBox();
            this.Alabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.a_calculation = new System.Windows.Forms.Button();
            this.b_calculation = new System.Windows.Forms.Button();
            this.c_calculation = new System.Windows.Forms.Button();
            this.a_task = new System.Windows.Forms.Label();
            this.b_task = new System.Windows.Forms.Label();
            this.c_task = new System.Windows.Forms.Label();
            this.a_result = new System.Windows.Forms.Label();
            this.b_result = new System.Windows.Forms.Label();
            this.c_result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picture2calc = new System.Windows.Forms.PictureBox();
            this.picture1calc = new System.Windows.Forms.PictureBox();
            this.button1calc = new System.Windows.Forms.Button();
            this.button2calc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result_1 = new System.Windows.Forms.Label();
            this.result_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture2calc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1calc)).BeginInit();
            this.SuspendLayout();
            // 
            // AcomboBox
            // 
            this.AcomboBox.FormattingEnabled = true;
            this.AcomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.AcomboBox.Location = new System.Drawing.Point(143, 16);
            this.AcomboBox.Name = "AcomboBox";
            this.AcomboBox.Size = new System.Drawing.Size(133, 24);
            this.AcomboBox.TabIndex = 0;
            this.AcomboBox.Text = "choose boolean";
            // 
            // BcomboBox
            // 
            this.BcomboBox.FormattingEnabled = true;
            this.BcomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.BcomboBox.Location = new System.Drawing.Point(143, 60);
            this.BcomboBox.Name = "BcomboBox";
            this.BcomboBox.Size = new System.Drawing.Size(133, 24);
            this.BcomboBox.TabIndex = 1;
            this.BcomboBox.Text = "choose boolean";
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Location = new System.Drawing.Point(58, 19);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(17, 17);
            this.Alabel.TabIndex = 2;
            this.Alabel.Text = "A";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Location = new System.Drawing.Point(58, 63);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(17, 17);
            this.Blabel.TabIndex = 3;
            this.Blabel.Text = "B";
            // 
            // a_calculation
            // 
            this.a_calculation.Location = new System.Drawing.Point(191, 114);
            this.a_calculation.Name = "a_calculation";
            this.a_calculation.Size = new System.Drawing.Size(85, 23);
            this.a_calculation.TabIndex = 4;
            this.a_calculation.Text = "calculate";
            this.a_calculation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.a_calculation.UseVisualStyleBackColor = true;
            this.a_calculation.Click += new System.EventHandler(this.A_calculation_Click);
            // 
            // b_calculation
            // 
            this.b_calculation.Location = new System.Drawing.Point(191, 191);
            this.b_calculation.Name = "b_calculation";
            this.b_calculation.Size = new System.Drawing.Size(85, 23);
            this.b_calculation.TabIndex = 5;
            this.b_calculation.Text = "calculate";
            this.b_calculation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_calculation.UseVisualStyleBackColor = true;
            this.b_calculation.Click += new System.EventHandler(this.B_calculation_Click);
            // 
            // c_calculation
            // 
            this.c_calculation.Location = new System.Drawing.Point(191, 259);
            this.c_calculation.Name = "c_calculation";
            this.c_calculation.Size = new System.Drawing.Size(85, 23);
            this.c_calculation.TabIndex = 6;
            this.c_calculation.Text = "calculate";
            this.c_calculation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_calculation.UseVisualStyleBackColor = true;
            this.c_calculation.Click += new System.EventHandler(this.C_calculation_Click);
            // 
            // a_task
            // 
            this.a_task.AutoSize = true;
            this.a_task.Location = new System.Drawing.Point(12, 117);
            this.a_task.Name = "a_task";
            this.a_task.Size = new System.Drawing.Size(153, 17);
            this.a_task.TabIndex = 7;
            this.a_task.Text = "a) not A and not B or A";
            // 
            // b_task
            // 
            this.b_task.AutoSize = true;
            this.b_task.Location = new System.Drawing.Point(12, 194);
            this.b_task.Name = "b_task";
            this.b_task.Size = new System.Drawing.Size(156, 17);
            this.b_task.TabIndex = 8;
            this.b_task.Text = "b) B or not A and not B\'";
            // 
            // c_task
            // 
            this.c_task.AutoSize = true;
            this.c_task.Location = new System.Drawing.Point(12, 265);
            this.c_task.Name = "c_task";
            this.c_task.Size = new System.Drawing.Size(173, 17);
            this.c_task.TabIndex = 9;
            this.c_task.Text = "c) B and not (A and not B)";
            // 
            // a_result
            // 
            this.a_result.AutoSize = true;
            this.a_result.Location = new System.Drawing.Point(58, 156);
            this.a_result.Name = "a_result";
            this.a_result.Size = new System.Drawing.Size(46, 17);
            this.a_result.TabIndex = 10;
            this.a_result.Text = "label1";
            this.a_result.Visible = false;
            // 
            // b_result
            // 
            this.b_result.AutoSize = true;
            this.b_result.Location = new System.Drawing.Point(58, 229);
            this.b_result.Name = "b_result";
            this.b_result.Size = new System.Drawing.Size(46, 17);
            this.b_result.TabIndex = 11;
            this.b_result.Text = "label2";
            this.b_result.Visible = false;
            // 
            // c_result
            // 
            this.c_result.AutoSize = true;
            this.c_result.Location = new System.Drawing.Point(58, 300);
            this.c_result.Name = "c_result";
            this.c_result.Size = new System.Drawing.Size(46, 17);
            this.c_result.TabIndex = 12;
            this.c_result.Text = "label3";
            this.c_result.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "2)";
            // 
            // picture2calc
            // 
            this.picture2calc.Image = global::win_forms_lab2.Properties.Resources.Снимок1;
            this.picture2calc.Location = new System.Drawing.Point(319, 194);
            this.picture2calc.Name = "picture2calc";
            this.picture2calc.Size = new System.Drawing.Size(459, 32);
            this.picture2calc.TabIndex = 16;
            this.picture2calc.TabStop = false;
            // 
            // picture1calc
            // 
            this.picture1calc.Image = global::win_forms_lab2.Properties.Resources.Снимок;
            this.picture1calc.Location = new System.Drawing.Point(417, 60);
            this.picture1calc.Name = "picture1calc";
            this.picture1calc.Size = new System.Drawing.Size(361, 69);
            this.picture1calc.TabIndex = 13;
            this.picture1calc.TabStop = false;
            // 
            // button1calc
            // 
            this.button1calc.Location = new System.Drawing.Point(481, 10);
            this.button1calc.Name = "button1calc";
            this.button1calc.Size = new System.Drawing.Size(83, 23);
            this.button1calc.TabIndex = 17;
            this.button1calc.Text = "calculate";
            this.button1calc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1calc.UseVisualStyleBackColor = true;
            this.button1calc.Click += new System.EventHandler(this.Button1calc_Click);
            // 
            // button2calc
            // 
            this.button2calc.Location = new System.Drawing.Point(481, 153);
            this.button2calc.Name = "button2calc";
            this.button2calc.Size = new System.Drawing.Size(83, 23);
            this.button2calc.TabIndex = 18;
            this.button2calc.Text = "calculate";
            this.button2calc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2calc.UseVisualStyleBackColor = true;
            this.button2calc.Click += new System.EventHandler(this.Button2calc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 51);
            this.label3.TabIndex = 19;
            this.label3.Text = "*  A = true; \r\n    B = true;\r\n    C = false";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 34);
            this.label4.TabIndex = 20;
            this.label4.Text = "X = 1.5;\r\nY = 2.5";
            // 
            // result_1
            // 
            this.result_1.AutoSize = true;
            this.result_1.Location = new System.Drawing.Point(630, 16);
            this.result_1.Name = "result_1";
            this.result_1.Size = new System.Drawing.Size(46, 17);
            this.result_1.TabIndex = 21;
            this.result_1.Text = "label5";
            this.result_1.Visible = false;
            // 
            // result_2
            // 
            this.result_2.AutoSize = true;
            this.result_2.Location = new System.Drawing.Point(630, 159);
            this.result_2.Name = "result_2";
            this.result_2.Size = new System.Drawing.Size(46, 17);
            this.result_2.TabIndex = 22;
            this.result_2.Text = "label6";
            this.result_2.Visible = false;
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_2);
            this.Controls.Add(this.result_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2calc);
            this.Controls.Add(this.button1calc);
            this.Controls.Add(this.picture2calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture1calc);
            this.Controls.Add(this.c_result);
            this.Controls.Add(this.b_result);
            this.Controls.Add(this.a_result);
            this.Controls.Add(this.c_task);
            this.Controls.Add(this.b_task);
            this.Controls.Add(this.a_task);
            this.Controls.Add(this.c_calculation);
            this.Controls.Add(this.b_calculation);
            this.Controls.Add(this.a_calculation);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.Alabel);
            this.Controls.Add(this.BcomboBox);
            this.Controls.Add(this.AcomboBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "SolutionForm";
            this.Text = "Solution form";
            ((System.ComponentModel.ISupportInitialize)(this.picture2calc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1calc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AcomboBox;
        private System.Windows.Forms.ComboBox BcomboBox;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.Button a_calculation;
        private System.Windows.Forms.Button b_calculation;
        private System.Windows.Forms.Button c_calculation;
        private System.Windows.Forms.Label a_task;
        private System.Windows.Forms.Label b_task;
        private System.Windows.Forms.Label c_task;
        private System.Windows.Forms.Label a_result;
        private System.Windows.Forms.Label b_result;
        private System.Windows.Forms.Label c_result;
        private System.Windows.Forms.PictureBox picture1calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picture2calc;
        private System.Windows.Forms.Button button1calc;
        private System.Windows.Forms.Button button2calc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result_1;
        private System.Windows.Forms.Label result_2;
    }
}

