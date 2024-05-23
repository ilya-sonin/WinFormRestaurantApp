namespace CursovaySonin2024
{
    partial class LoginForm
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
            MainLabel = new Label();
            maskedTextBoxPhoneNumber = new MaskedTextBox();
            labelPhoneNumber = new Label();
            labelPassword = new Label();
            maskedTextBoxPassword = new MaskedTextBox();
            button1 = new Button();
            backToReg = new Button();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabel.Location = new Point(128, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(98, 19);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "Авторизация";
            // 
            // maskedTextBoxPhoneNumber
            // 
            maskedTextBoxPhoneNumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPhoneNumber.Location = new Point(7, 53);
            maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            maskedTextBoxPhoneNumber.Size = new Size(350, 26);
            maskedTextBoxPhoneNumber.TabIndex = 1;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhoneNumber.Location = new Point(7, 34);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(105, 16);
            labelPhoneNumber.TabIndex = 2;
            labelPhoneNumber.Text = "Номер телефона:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(7, 96);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 16);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Пароль";
            // 
            // maskedTextBoxPassword
            // 
            maskedTextBoxPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPassword.Location = new Point(7, 115);
            maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Size = new Size(350, 26);
            maskedTextBoxPassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(277, 159);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // backToReg
            // 
            backToReg.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backToReg.Location = new Point(12, 304);
            backToReg.Name = "backToReg";
            backToReg.Size = new Size(159, 23);
            backToReg.TabIndex = 6;
            backToReg.Text = "Вернуться к регистрации";
            backToReg.UseVisualStyleBackColor = true;
            backToReg.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 339);
            Controls.Add(backToReg);
            Controls.Add(button1);
            Controls.Add(maskedTextBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelPhoneNumber);
            Controls.Add(maskedTextBoxPhoneNumber);
            Controls.Add(MainLabel);
            Name = "LoginForm";
            Text = "Ресторан \"Мир морей\" - окно авторизации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainLabel;
        private MaskedTextBox maskedTextBoxPhoneNumber;
        private Label labelPhoneNumber;
        private Label labelPassword;
        private MaskedTextBox maskedTextBoxPassword;
        private Button button1;
        private Button backToReg;
    }
}