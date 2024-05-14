namespace Group11_EncryptAndDecryptAppWithAES
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
            panel1 = new Panel();
            panel3 = new Panel();
            btnCalculate = new Button();
            btnChangeMode = new Button();
            chooseFileBtn = new Button();
            btnSave = new Button();
            richTextBoxSecond = new RichTextBox();
            richTextBoxFirst = new RichTextBox();
            taoKhoaBtn = new Button();
            txtGenerateKey = new TextBox();
            labelSecond = new Label();
            labelFirst = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 506);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCalculate);
            panel3.Controls.Add(btnChangeMode);
            panel3.Controls.Add(chooseFileBtn);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(richTextBoxSecond);
            panel3.Controls.Add(richTextBoxFirst);
            panel3.Controls.Add(taoKhoaBtn);
            panel3.Controls.Add(txtGenerateKey);
            panel3.Controls.Add(labelSecond);
            panel3.Controls.Add(labelFirst);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(13, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(823, 434);
            panel3.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(451, 239);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Ma hoa";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnChangeMode
            // 
            btnChangeMode.Location = new Point(290, 239);
            btnChangeMode.Name = "btnChangeMode";
            btnChangeMode.Size = new Size(112, 34);
            btnChangeMode.TabIndex = 9;
            btnChangeMode.Text = "Chuyen";
            btnChangeMode.UseVisualStyleBackColor = true;
            btnChangeMode.Click += btnChangeMode_Click;
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Location = new Point(116, 239);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(112, 34);
            chooseFileBtn.TabIndex = 8;
            chooseFileBtn.Text = "Chon file";
            chooseFileBtn.UseVisualStyleBackColor = true;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(636, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Luu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // richTextBoxSecond
            // 
            richTextBoxSecond.Location = new Point(99, 304);
            richTextBoxSecond.Name = "richTextBoxSecond";
            richTextBoxSecond.Size = new Size(498, 118);
            richTextBoxSecond.TabIndex = 6;
            richTextBoxSecond.Text = "";
            // 
            // richTextBoxFirst
            // 
            richTextBoxFirst.Location = new Point(99, 93);
            richTextBoxFirst.Name = "richTextBoxFirst";
            richTextBoxFirst.Size = new Size(498, 117);
            richTextBoxFirst.TabIndex = 5;
            richTextBoxFirst.Text = "";
            // 
            // taoKhoaBtn
            // 
            taoKhoaBtn.Location = new Point(636, 10);
            taoKhoaBtn.Name = "taoKhoaBtn";
            taoKhoaBtn.Size = new Size(112, 34);
            taoKhoaBtn.TabIndex = 4;
            taoKhoaBtn.Text = "Tao khoa";
            taoKhoaBtn.UseVisualStyleBackColor = true;
            taoKhoaBtn.Click += taoKhoaBtn_Click;
            // 
            // txtGenerateKey
            // 
            txtGenerateKey.Location = new Point(99, 10);
            txtGenerateKey.Name = "txtGenerateKey";
            txtGenerateKey.ReadOnly = true;
            txtGenerateKey.Size = new Size(498, 31);
            txtGenerateKey.TabIndex = 3;
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Location = new Point(3, 309);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(71, 25);
            labelSecond.TabIndex = 2;
            labelSecond.Text = "Ban ma";
            // 
            // labelFirst
            // 
            labelFirst.AutoSize = true;
            labelFirst.Location = new Point(3, 99);
            labelFirst.Name = "labelFirst";
            labelFirst.Size = new Size(63, 25);
            labelFirst.TabIndex = 1;
            labelFirst.Text = "Ban ro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 0;
            label2.Text = "Sinh khoa";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(13, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(823, 41);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 6);
            label1.Name = "label1";
            label1.Size = new Size(321, 32);
            label1.TabIndex = 0;
            label1.Text = "Encrypt And Decrypt - AES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 505);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "AESApp";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label labelSecond;
        private Label labelFirst;
        private Label label2;
        private Button taoKhoaBtn;
        private TextBox txtGenerateKey;
        private RichTextBox richTextBoxFirst;
        private RichTextBox richTextBoxSecond;
        private Button btnCalculate;
        private Button btnChangeMode;
        private Button chooseFileBtn;
        private Button btnSave;
    }
}
