namespace Main9
{
    partial class Calculator
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
            First_num = new TextBox();
            Second_num = new TextBox();
            sign = new Label();
            Value = new TextBox();
            Plus = new Button();
            Minus = new Button();
            multiply = new Button();
            decide = new Button();
            equal = new Button();
            Btn_conv = new Button();
            SuspendLayout();
            // 
            // First_num
            // 
            First_num.Location = new Point(27, 88);
            First_num.Name = "First_num";
            First_num.Size = new Size(100, 23);
            First_num.TabIndex = 0;
            First_num.TextChanged += First_num_TextChanged;
            // 
            // Second_num
            // 
            Second_num.Location = new Point(27, 132);
            Second_num.Name = "Second_num";
            Second_num.Size = new Size(100, 23);
            Second_num.TabIndex = 1;
            Second_num.TextChanged += textBox2_TextChanged;
            // 
            // sign
            // 
            sign.AutoSize = true;
            sign.Location = new Point(72, 114);
            sign.Name = "sign";
            sign.Size = new Size(12, 15);
            sign.TabIndex = 2;
            sign.Text = "_";
            // 
            // Value
            // 
            Value.Location = new Point(130, 346);
            Value.Name = "Value";
            Value.Size = new Size(100, 23);
            Value.TabIndex = 4;
            // 
            // Plus
            // 
            Plus.Location = new Point(27, 161);
            Plus.Name = "Plus";
            Plus.Size = new Size(69, 68);
            Plus.TabIndex = 5;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(130, 161);
            Minus.Name = "Minus";
            Minus.Size = new Size(69, 68);
            Minus.TabIndex = 6;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(27, 244);
            multiply.Name = "multiply";
            multiply.Size = new Size(69, 68);
            multiply.TabIndex = 7;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // decide
            // 
            decide.Location = new Point(130, 244);
            decide.Name = "decide";
            decide.Size = new Size(69, 68);
            decide.TabIndex = 8;
            decide.Text = "/";
            decide.UseVisualStyleBackColor = true;
            decide.Click += decide_Click;
            // 
            // equal
            // 
            equal.Location = new Point(21, 346);
            equal.Name = "equal";
            equal.Size = new Size(75, 23);
            equal.TabIndex = 9;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // Btn_conv
            // 
            Btn_conv.Location = new Point(72, 408);
            Btn_conv.Name = "Btn_conv";
            Btn_conv.Size = new Size(86, 30);
            Btn_conv.TabIndex = 10;
            Btn_conv.Text = "Конвертер";
            Btn_conv.UseVisualStyleBackColor = true;
            Btn_conv.Click += Btn_conv_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_conv);
            Controls.Add(equal);
            Controls.Add(decide);
            Controls.Add(multiply);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(Value);
            Controls.Add(sign);
            Controls.Add(Second_num);
            Controls.Add(First_num);
            Name = "Calculator";
            Text = "Калькулятор";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox First_num;
        private TextBox Second_num;
        private Label sign;
        private TextBox Value;
        private Button Plus;
        private Button Minus;
        private Button multiply;
        private Button decide;
        private Button equal;
        private Button Btn_conv;
    }
}
