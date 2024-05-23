namespace CursovaySonin2024
{
    partial class RestuarantMenu
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
            flowLayoutPanelRestuarantMenu = new FlowLayoutPanel();
            cartOpen = new Button();
            windowLabel = new Label();
            CountLabel = new Label();
            cartCountLabel = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanelRestuarantMenu
            // 
            flowLayoutPanelRestuarantMenu.AutoScroll = true;
            flowLayoutPanelRestuarantMenu.Location = new Point(12, 36);
            flowLayoutPanelRestuarantMenu.Name = "flowLayoutPanelRestuarantMenu";
            flowLayoutPanelRestuarantMenu.Size = new Size(683, 402);
            flowLayoutPanelRestuarantMenu.TabIndex = 0;
            // 
            // cartOpen
            // 
            cartOpen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cartOpen.Location = new Point(712, 404);
            cartOpen.Name = "cartOpen";
            cartOpen.Size = new Size(76, 34);
            cartOpen.TabIndex = 1;
            cartOpen.Text = "Корзина";
            cartOpen.UseVisualStyleBackColor = true;
            cartOpen.Click += cartOpen_Click;
            // 
            // windowLabel
            // 
            windowLabel.AutoSize = true;
            windowLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            windowLabel.Location = new Point(12, 9);
            windowLabel.Name = "windowLabel";
            windowLabel.Size = new Size(156, 22);
            windowLabel.TabIndex = 2;
            windowLabel.Text = "Меню ресторана";
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CountLabel.Location = new Point(701, 36);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(88, 54);
            CountLabel.TabIndex = 3;
            CountLabel.Text = "Количество\r\nпозиций в\r\nкорзине:";
            // 
            // cartCountLabel
            // 
            cartCountLabel.AutoSize = true;
            cartCountLabel.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cartCountLabel.Location = new Point(765, 75);
            cartCountLabel.Name = "cartCountLabel";
            cartCountLabel.Size = new Size(13, 15);
            cartCountLabel.TabIndex = 4;
            cartCountLabel.Text = "0";
            // 
            // RestuarantMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cartCountLabel);
            Controls.Add(CountLabel);
            Controls.Add(windowLabel);
            Controls.Add(cartOpen);
            Controls.Add(flowLayoutPanelRestuarantMenu);
            Name = "RestuarantMenu";
            Text = "Ресторан \"Мир морей\" - Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelRestuarantMenu;
        private Button cartOpen;
        private Label windowLabel;
        private Label CountLabel;
        private Label cartCountLabel;
    }
}