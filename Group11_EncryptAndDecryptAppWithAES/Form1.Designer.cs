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
            btnSave2 = new Button();
            chooseFileBtn2 = new Button();
            btnDecrypt = new Button();
            richTextBoxFourth = new RichTextBox();
            richTextBoxThird = new RichTextBox();
            label3 = new Label();
            labelFourth = new Label();
            laberThird = new Label();
            label2 = new Label();
            btnEncrypt = new Button();
            btnChangeMode = new Button();
            chooseFileBtn = new Button();
            btnSave = new Button();
            richTextBoxSecond = new RichTextBox();
            richTextBoxFirst = new RichTextBox();
            labelSecond = new Label();
            labelFirst = new Label();
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
            panel1.Size = new Size(1118, 506);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave2);
            panel3.Controls.Add(chooseFileBtn2);
            panel3.Controls.Add(btnDecrypt);
            panel3.Controls.Add(richTextBoxFourth);
            panel3.Controls.Add(richTextBoxThird);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(labelFourth);
            panel3.Controls.Add(laberThird);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnEncrypt);
            panel3.Controls.Add(btnChangeMode);
            panel3.Controls.Add(chooseFileBtn);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(richTextBoxSecond);
            panel3.Controls.Add(richTextBoxFirst);
            panel3.Controls.Add(labelSecond);
            panel3.Controls.Add(labelFirst);
            panel3.Location = new Point(13, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(1094, 434);
            panel3.TabIndex = 1;
            // 
            // btnSave2
            // 
            btnSave2.Location = new Point(982, 302);
            btnSave2.Name = "btnSave2";
            btnSave2.Size = new Size(101, 53);
            btnSave2.TabIndex = 19;
            btnSave2.Text = "Lưu";
            btnSave2.UseVisualStyleBackColor = true;
            btnSave2.Click += btnSave2_Click;
            // 
            // chooseFileBtn2
            // 
            chooseFileBtn2.Location = new Point(982, 65);
            chooseFileBtn2.Name = "chooseFileBtn2";
            chooseFileBtn2.Size = new Size(101, 50);
            chooseFileBtn2.TabIndex = 18;
            chooseFileBtn2.Text = "File";
            chooseFileBtn2.UseVisualStyleBackColor = true;
            chooseFileBtn2.Click += chooseFileBtn2_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(813, 217);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(112, 53);
            btnDecrypt.TabIndex = 17;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // richTextBoxFourth
            // 
            richTextBoxFourth.Location = new Point(662, 303);
            richTextBoxFourth.Name = "richTextBoxFourth";
            richTextBoxFourth.Size = new Size(310, 118);
            richTextBoxFourth.TabIndex = 16;
            richTextBoxFourth.Text = "";
            // 
            // richTextBoxThird
            // 
            richTextBoxThird.Location = new Point(662, 65);
            richTextBoxThird.Name = "richTextBoxThird";
            richTextBoxThird.Size = new Size(310, 120);
            richTextBoxThird.TabIndex = 15;
            richTextBoxThird.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(815, 19);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 14;
            label3.Text = "GIẢI MÃ";
            // 
            // labelFourth
            // 
            labelFourth.AutoSize = true;
            labelFourth.Location = new Point(577, 304);
            labelFourth.Name = "labelFourth";
            labelFourth.Size = new Size(63, 25);
            labelFourth.TabIndex = 13;
            labelFourth.Text = "Bản rõ";
            // 
            // laberThird
            // 
            laberThird.AutoSize = true;
            laberThird.Location = new Point(577, 66);
            laberThird.Name = "laberThird";
            laberThird.Size = new Size(71, 25);
            laberThird.TabIndex = 12;
            laberThird.Text = "Bản mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(171, 19);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 11;
            label2.Text = "MÃ HÓA";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(286, 217);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(112, 53);
            btnEncrypt.TabIndex = 10;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnChangeMode
            // 
            btnChangeMode.Location = new Point(413, 303);
            btnChangeMode.Name = "btnChangeMode";
            btnChangeMode.Size = new Size(112, 53);
            btnChangeMode.TabIndex = 9;
            btnChangeMode.Text = "Chuyển";
            btnChangeMode.UseVisualStyleBackColor = true;
            btnChangeMode.Click += btnChangeMode_Click;
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Location = new Point(413, 69);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(112, 50);
            chooseFileBtn.TabIndex = 8;
            chooseFileBtn.Text = "File";
            chooseFileBtn.UseVisualStyleBackColor = true;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(413, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 52);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // richTextBoxSecond
            // 
            richTextBoxSecond.Location = new Point(80, 304);
            richTextBoxSecond.Name = "richTextBoxSecond";
            richTextBoxSecond.ReadOnly = true;
            richTextBoxSecond.Size = new Size(318, 118);
            richTextBoxSecond.TabIndex = 6;
            richTextBoxSecond.Text = "";
            // 
            // richTextBoxFirst
            // 
            richTextBoxFirst.Location = new Point(80, 69);
            richTextBoxFirst.Name = "richTextBoxFirst";
            richTextBoxFirst.Size = new Size(318, 117);
            richTextBoxFirst.TabIndex = 5;
            richTextBoxFirst.Text = "";
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Location = new Point(3, 309);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(71, 25);
            labelSecond.TabIndex = 2;
            labelSecond.Text = "Bản mã";
            // 
            // labelFirst
            // 
            labelFirst.AutoSize = true;
            labelFirst.Location = new Point(3, 69);
            labelFirst.Name = "labelFirst";
            labelFirst.Size = new Size(63, 25);
            labelFirst.TabIndex = 1;
            labelFirst.Text = "Bản rõ";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(13, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1094, 41);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(386, 6);
            label1.Name = "label1";
            label1.Size = new Size(321, 32);
            label1.TabIndex = 0;
            label1.Text = "Encrypt And Decrypt - AES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 505);
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
        private RichTextBox richTextBoxFirst;
        private RichTextBox richTextBoxSecond;
        private Button btnEncrypt;
        private Button btnChangeMode;
        private Button chooseFileBtn;
        private Button btnSave;
        private Label label2;
        private Label laberThird;
        private Label labelFourth;
        private Label label3;
        private RichTextBox richTextBoxThird;
        private Button btnDecrypt;
        private RichTextBox richTextBoxFourth;
        private Button btnSave2;
        private Button chooseFileBtn2;
    }
}
