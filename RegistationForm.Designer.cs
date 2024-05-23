namespace CursovaySonin2024
{
    partial class Registration
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
            buttonRegistation = new Button();
            helloLabel = new Label();
            registrationLabel = new Label();
            labelPhoneNumber = new Label();
            labelPassword = new Label();
            linkLabel1 = new LinkLabel();
            maskedTextBoxPhoneNumber = new MaskedTextBox();
            maskedTextBoxPassword = new MaskedTextBox();
            SuspendLayout();
            // 
            // buttonRegistation
            // 
            buttonRegistation.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistation.Location = new Point(184, 231);
            buttonRegistation.Name = "buttonRegistation";
            buttonRegistation.Size = new Size(173, 33);
            buttonRegistation.TabIndex = 2;
            buttonRegistation.Text = "Зарегистрироваться";
            buttonRegistation.UseVisualStyleBackColor = true;
            buttonRegistation.Click += buttonRegistation_Click;
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            helloLabel.Location = new Point(12, 9);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(257, 44);
            helloLabel.TabIndex = 3;
            helloLabel.Text = "Приветствую вас \r\nв приложении \"Мир морей\"\r\n";
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registrationLabel.Location = new Point(106, 70);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(144, 19);
            registrationLabel.TabIndex = 4;
            registrationLabel.Text = "Зарегистрироваться";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhoneNumber.Location = new Point(12, 101);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(93, 15);
            labelPhoneNumber.TabIndex = 5;
            labelPhoneNumber.Text = "Номер телефона:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(12, 162);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "Пароль:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(41, 292);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(257, 19);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Если у вас есть аккаунт, то кликайте!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // maskedTextBoxPhoneNumber
            // 
            maskedTextBoxPhoneNumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPhoneNumber.Location = new Point(12, 119);
            maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            maskedTextBoxPhoneNumber.Size = new Size(345, 26);
            maskedTextBoxPhoneNumber.TabIndex = 1;
            // 
            // maskedTextBoxPassword
            // 
            maskedTextBoxPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPassword.Location = new Point(12, 180);
            maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Size = new Size(345, 26);
            maskedTextBoxPassword.TabIndex = 8;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 339);
            Controls.Add(maskedTextBoxPassword);
            Controls.Add(maskedTextBoxPhoneNumber);
            Controls.Add(linkLabel1);
            Controls.Add(labelPassword);
            Controls.Add(labelPhoneNumber);
            Controls.Add(registrationLabel);
            Controls.Add(helloLabel);
            Controls.Add(buttonRegistation);
            Name = "Registration";
            Text = "Ресторан \"Мир морей\" - окно регистрации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonRegistation;
        private Label helloLabel;
        private Label registrationLabel;
        private Label labelPhoneNumber;
        private Label labelPassword;
        private LinkLabel linkLabel1;
        private MaskedTextBox maskedTextBoxPhoneNumber;
        private MaskedTextBox maskedTextBoxPassword;
    }
}