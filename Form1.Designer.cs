namespace Latih8_WinformEvent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1117, 331);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 363);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(203, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 31);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Validated += textBox2_Validated;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(264, 434);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 31);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(264, 495);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 33);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(488, 363);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(274, 102);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.Validated += richTextBox1_Validated;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(488, 495);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(274, 33);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1017, 363);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 585);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox2;
        private Button button1;
    }
}
