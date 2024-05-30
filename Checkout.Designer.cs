namespace CursovaySonin2024
{
    partial class Checkout
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
            checkoutMainLabel = new Label();
            adressLabel = new Label();
            textBoxAdress = new TextBox();
            label1 = new Label();
            textBoxTableNumber = new TextBox();
            checkBoxSamovivoz = new CheckBox();
            totalPriceLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkoutMainLabel
            // 
            checkoutMainLabel.AutoSize = true;
            checkoutMainLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkoutMainLabel.Location = new Point(12, 9);
            checkoutMainLabel.Name = "checkoutMainLabel";
            checkoutMainLabel.Size = new Size(184, 22);
            checkoutMainLabel.TabIndex = 0;
            checkoutMainLabel.Text = "Оформление заказа";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            adressLabel.Location = new Point(12, 45);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(46, 16);
            adressLabel.TabIndex = 1;
            adressLabel.Text = "Адрес:";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdress.Location = new Point(12, 64);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.PlaceholderText = "Введите адрес доставки";
            textBoxAdress.Size = new Size(341, 26);
            textBoxAdress.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(98, 16);
            label1.TabIndex = 3;
            label1.Text = "Номер столика:";
            // 
            // textBoxTableNumber
            // 
            textBoxTableNumber.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTableNumber.Location = new Point(12, 124);
            textBoxTableNumber.Name = "textBoxTableNumber";
            textBoxTableNumber.PlaceholderText = "Введите номер столика";
            textBoxTableNumber.Size = new Size(341, 26);
            textBoxTableNumber.TabIndex = 4;
            // 
            // checkBoxSamovivoz
            // 
            checkBoxSamovivoz.AutoSize = true;
            checkBoxSamovivoz.Location = new Point(12, 166);
            checkBoxSamovivoz.Name = "checkBoxSamovivoz";
            checkBoxSamovivoz.Size = new Size(89, 19);
            checkBoxSamovivoz.TabIndex = 5;
            checkBoxSamovivoz.Text = "Самовывоз";
            checkBoxSamovivoz.UseVisualStyleBackColor = true;
            checkBoxSamovivoz.CheckedChanged += checkBoxSamovivoz_CheckedChanged;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(13, 218);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(48, 19);
            totalPriceLabel.TabIndex = 6;
            totalPriceLabel.Text = "label2";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(258, 210);
            button1.Name = "button1";
            button1.Size = new Size(95, 31);
            button1.TabIndex = 7;
            button1.Text = "Оплатить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 261);
            Controls.Add(button1);
            Controls.Add(totalPriceLabel);
            Controls.Add(checkBoxSamovivoz);
            Controls.Add(textBoxTableNumber);
            Controls.Add(label1);
            Controls.Add(textBoxAdress);
            Controls.Add(adressLabel);
            Controls.Add(checkoutMainLabel);
            Name = "Checkout";
            Text = "Оформление заказа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label checkoutMainLabel;
        private Label adressLabel;
        private TextBox textBoxAdress;
        private Label label1;
        private TextBox textBoxTableNumber;
        private CheckBox checkBoxSamovivoz;
        private Label totalPriceLabel;
        private Button button1;
    }
}