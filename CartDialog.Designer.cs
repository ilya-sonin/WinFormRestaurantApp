namespace CursovaySonin2024
{
    partial class CartDialog
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
            totalPriceLabel = new Label();
            cartDataGridView = new DataGridView();
            checkout = new Button();
            ((System.ComponentModel.ISupportInitialize)cartDataGridView).BeginInit();
            SuspendLayout();
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(12, 422);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(45, 19);
            totalPriceLabel.TabIndex = 1;
            totalPriceLabel.Text = "label1";
            // 
            // cartDataGridView
            // 
            cartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartDataGridView.Location = new Point(12, 12);
            cartDataGridView.Name = "cartDataGridView";
            cartDataGridView.RowTemplate.Height = 25;
            cartDataGridView.Size = new Size(453, 388);
            cartDataGridView.TabIndex = 2;
            cartDataGridView.CellContentClick += cartDataGridView_CellContentClick;
            // 
            // checkout
            // 
            checkout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkout.Location = new Point(366, 406);
            checkout.Name = "checkout";
            checkout.Size = new Size(99, 39);
            checkout.TabIndex = 3;
            checkout.Text = "Оформить";
            checkout.UseVisualStyleBackColor = true;
            checkout.Click += checkout_Click;
            // 
            // CartDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(checkout);
            Controls.Add(cartDataGridView);
            Controls.Add(totalPriceLabel);
            Name = "CartDialog";
            Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)cartDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label totalPriceLabel;
        private DataGridView cartDataGridView;
        private Button checkout;
    }
}