namespace Dotskin_lab_3
{
    partial class Form3
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            radioSec1 = new RadioButton();
            radioSec2 = new RadioButton();
            textBox1 = new TextBox();
            buttonAdd = new Button();
            buttonCansel = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioSec2);
            groupBox1.Controls.Add(radioSec1);
            groupBox1.Location = new Point(72, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить в";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioSec1
            // 
            radioSec1.AutoSize = true;
            radioSec1.Location = new Point(6, 22);
            radioSec1.Name = "radioSec1";
            radioSec1.Size = new Size(71, 19);
            radioSec1.TabIndex = 1;
            radioSec1.TabStop = true;
            radioSec1.Text = "Раздел 1";
            radioSec1.UseVisualStyleBackColor = true;
            // 
            // radioSec2
            // 
            radioSec2.AutoSize = true;
            radioSec2.Location = new Point(6, 47);
            radioSec2.Name = "radioSec2";
            radioSec2.Size = new Size(71, 19);
            radioSec2.TabIndex = 2;
            radioSec2.TabStop = true;
            radioSec2.Text = "Раздел 2";
            radioSec2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(72, 132);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(97, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCansel
            // 
            buttonCansel.Location = new Point(175, 132);
            buttonCansel.Name = "buttonCansel";
            buttonCansel.Size = new Size(97, 23);
            buttonCansel.TabIndex = 3;
            buttonCansel.Text = "Отмена";
            buttonCansel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 89);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Введите текст:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 165);
            Controls.Add(label1);
            Controls.Add(buttonCansel);
            Controls.Add(buttonAdd);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private RadioButton radioSec2;
        private RadioButton radioSec1;
        private TextBox textBox1;
        private Button buttonAdd;
        private Button buttonCansel;
        private Label label1;
    }
}