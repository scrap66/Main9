namespace Main9
{
    partial class Form2
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
            rub = new Label();
            Dollar = new Button();
            Euro = new Button();
            Tenge = new Button();
            Uani = new Button();
            En = new Button();
            value = new TextBox();
            num = new TextBox();
            curText = new Label();
            Current = new Label();
            res = new Button();
            SuspendLayout();
            // 
            // rub
            // 
            rub.AutoSize = true;
            rub.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rub.Location = new Point(373, 9);
            rub.Name = "rub";
            rub.Size = new Size(160, 42);
            rub.TabIndex = 1;
            rub.Text = "RUBLES";
            rub.Click += label1_Click;
            // 
            // Dollar
            // 
            Dollar.Location = new Point(109, 92);
            Dollar.Name = "Dollar";
            Dollar.Size = new Size(148, 73);
            Dollar.TabIndex = 2;
            Dollar.Text = "Dollar";
            Dollar.UseVisualStyleBackColor = true;
            Dollar.Click += Dollar_Click;
            // 
            // Euro
            // 
            Euro.Location = new Point(330, 92);
            Euro.Name = "Euro";
            Euro.Size = new Size(148, 73);
            Euro.TabIndex = 3;
            Euro.Text = "Euro";
            Euro.UseVisualStyleBackColor = true;
            Euro.Click += Euro_Click;
            // 
            // Tenge
            // 
            Tenge.Location = new Point(554, 92);
            Tenge.Name = "Tenge";
            Tenge.Size = new Size(148, 73);
            Tenge.TabIndex = 4;
            Tenge.Text = "Tenge";
            Tenge.UseVisualStyleBackColor = true;
            Tenge.Click += Tenge_Click;
            // 
            // Uani
            // 
            Uani.Location = new Point(222, 205);
            Uani.Name = "Uani";
            Uani.Size = new Size(148, 73);
            Uani.TabIndex = 5;
            Uani.Text = "Uani";
            Uani.UseVisualStyleBackColor = true;
            Uani.Click += Uani_Click;
            // 
            // En
            // 
            En.Location = new Point(448, 205);
            En.Name = "En";
            En.Size = new Size(148, 73);
            En.TabIndex = 6;
            En.Text = "En";
            En.UseVisualStyleBackColor = true;
            En.Click += En_Click;
            // 
            // value
            // 
            value.Location = new Point(360, 405);
            value.Name = "value";
            value.Size = new Size(100, 23);
            value.TabIndex = 7;
            // 
            // num
            // 
            num.Location = new Point(267, 20);
            num.Name = "num";
            num.Size = new Size(100, 23);
            num.TabIndex = 8;
            // 
            // curText
            // 
            curText.AutoSize = true;
            curText.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            curText.Location = new Point(12, 383);
            curText.Name = "curText";
            curText.Size = new Size(80, 23);
            curText.TabIndex = 9;
            curText.Text = "Current:";
            // 
            // Current
            // 
            Current.AutoSize = true;
            Current.Location = new Point(93, 388);
            Current.Name = "Current";
            Current.Size = new Size(22, 15);
            Current.TabIndex = 10;
            Current.Text = "---";
            // 
            // res
            // 
            res.Location = new Point(373, 326);
            res.Name = "res";
            res.Size = new Size(75, 23);
            res.TabIndex = 11;
            res.Text = "Result";
            res.UseVisualStyleBackColor = true;
            res.Click += res_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(res);
            Controls.Add(Current);
            Controls.Add(curText);
            Controls.Add(num);
            Controls.Add(value);
            Controls.Add(En);
            Controls.Add(Uani);
            Controls.Add(Tenge);
            Controls.Add(Euro);
            Controls.Add(Dollar);
            Controls.Add(rub);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label rub;
        private Button Dollar;
        private Button Euro;
        private Button Tenge;
        private Button Uani;
        private Button En;
        private TextBox value;
        private TextBox num;
        private Label curText;
        private Label Current;
        private Button res;
    }
}