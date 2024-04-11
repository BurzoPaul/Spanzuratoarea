namespace Spanzuratoarea
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
            cuvantLabel = new Label();
            textLabel = new Label();
            desenPictureBox = new PictureBox();
            literaTextBox = new TextBox();
            charLabel = new Label();
            verificareLButton = new Button();
            CuvLabel = new Label();
            CuvTextBox = new TextBox();
            verificareCButton = new Button();
            ((System.ComponentModel.ISupportInitialize)desenPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cuvantLabel
            // 
            cuvantLabel.AutoSize = true;
            cuvantLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuvantLabel.Location = new Point(230, 36);
            cuvantLabel.Name = "cuvantLabel";
            cuvantLabel.Size = new Size(128, 50);
            cuvantLabel.TabIndex = 0;
            cuvantLabel.Text = "label1";
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textLabel.Location = new Point(12, 36);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(195, 50);
            textLabel.TabIndex = 1;
            textLabel.Text = "Cuvantul: ";
            // 
            // desenPictureBox
            // 
            desenPictureBox.Location = new Point(775, 36);
            desenPictureBox.Name = "desenPictureBox";
            desenPictureBox.Size = new Size(373, 402);
            desenPictureBox.TabIndex = 2;
            desenPictureBox.TabStop = false;
            // 
            // literaTextBox
            // 
            literaTextBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            literaTextBox.Location = new Point(230, 149);
            literaTextBox.Name = "literaTextBox";
            literaTextBox.Size = new Size(125, 57);
            literaTextBox.TabIndex = 3;
            // 
            // charLabel
            // 
            charLabel.AutoSize = true;
            charLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            charLabel.Location = new Point(12, 156);
            charLabel.Name = "charLabel";
            charLabel.Size = new Size(161, 50);
            charLabel.TabIndex = 4;
            charLabel.Text = "O litera:";
            // 
            // verificareLButton
            // 
            verificareLButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verificareLButton.Location = new Point(397, 149);
            verificareLButton.Name = "verificareLButton";
            verificareLButton.Size = new Size(108, 57);
            verificareLButton.TabIndex = 5;
            verificareLButton.Text = "Verificare";
            verificareLButton.UseVisualStyleBackColor = true;
            verificareLButton.Click += verificareLButton_Click;
            // 
            // CuvLabel
            // 
            CuvLabel.AutoSize = true;
            CuvLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CuvLabel.Location = new Point(12, 254);
            CuvLabel.Name = "CuvLabel";
            CuvLabel.Size = new Size(152, 50);
            CuvLabel.TabIndex = 6;
            CuvLabel.Text = "Cuvant:";
            // 
            // CuvTextBox
            // 
            CuvTextBox.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CuvTextBox.Location = new Point(230, 247);
            CuvTextBox.Name = "CuvTextBox";
            CuvTextBox.Size = new Size(236, 57);
            CuvTextBox.TabIndex = 7;
            // 
            // verificareCButton
            // 
            verificareCButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verificareCButton.Location = new Point(513, 247);
            verificareCButton.Name = "verificareCButton";
            verificareCButton.Size = new Size(101, 57);
            verificareCButton.TabIndex = 8;
            verificareCButton.Text = "Verificare";
            verificareCButton.UseVisualStyleBackColor = true;
            verificareCButton.Click += verificareCButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 537);
            Controls.Add(verificareCButton);
            Controls.Add(CuvTextBox);
            Controls.Add(CuvLabel);
            Controls.Add(verificareLButton);
            Controls.Add(charLabel);
            Controls.Add(literaTextBox);
            Controls.Add(desenPictureBox);
            Controls.Add(textLabel);
            Controls.Add(cuvantLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)desenPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cuvantLabel;
        private Label textLabel;
        private PictureBox desenPictureBox;
        private TextBox literaTextBox;
        private Label charLabel;
        private Button verificareLButton;
        private Label CuvLabel;
        private TextBox CuvTextBox;
        private Button verificareCButton;
    }
}
