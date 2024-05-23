namespace CursovaySonin2024
{
    partial class DishItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            dishNameLabel = new Label();
            dishPriceLabel = new Label();
            addToCartButton = new Button();
            dishDescriptionLabel = new RichTextBox();
            SuspendLayout();
            // 
            // dishNameLabel
            // 
            dishNameLabel.AutoSize = true;
            dishNameLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dishNameLabel.Location = new Point(13, 16);
            dishNameLabel.Name = "dishNameLabel";
            dishNameLabel.Size = new Size(114, 19);
            dishNameLabel.TabIndex = 0;
            dishNameLabel.Text = "dishNameLabel";
            // 
            // dishPriceLabel
            // 
            dishPriceLabel.AutoSize = true;
            dishPriceLabel.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dishPriceLabel.Location = new Point(13, 146);
            dishPriceLabel.Name = "dishPriceLabel";
            dishPriceLabel.Size = new Size(105, 19);
            dishPriceLabel.TabIndex = 2;
            dishPriceLabel.Text = "dishPriceLabel";
            // 
            // addToCartButton
            // 
            addToCartButton.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addToCartButton.Location = new Point(157, 142);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(142, 23);
            addToCartButton.TabIndex = 3;
            addToCartButton.Text = "Добавить в корзину";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // dishDescriptionLabel
            // 
            dishDescriptionLabel.Enabled = false;
            dishDescriptionLabel.Location = new Point(13, 38);
            dishDescriptionLabel.Name = "dishDescriptionLabel";
            dishDescriptionLabel.Size = new Size(286, 96);
            dishDescriptionLabel.TabIndex = 4;
            dishDescriptionLabel.Text = "";
            // 
            // DishItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(dishDescriptionLabel);
            Controls.Add(addToCartButton);
            Controls.Add(dishPriceLabel);
            Controls.Add(dishNameLabel);
            Name = "DishItem";
            Size = new Size(311, 180);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dishNameLabel;
        private Label dishPriceLabel;
        private Button addToCartButton;
        private RichTextBox dishDescriptionLabel;
    }
}
