namespace SendRequest
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.contentTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bodyBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.responseText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qtdNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.qtdNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // methodComboBox
            // 
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "POST",
            "GET",
            "PUT",
            "DELETE",
            "PATCH"});
            this.methodComboBox.Location = new System.Drawing.Point(12, 23);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(121, 21);
            this.methodComboBox.TabIndex = 0;
            this.methodComboBox.Text = "POST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Method";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(140, 23);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(441, 20);
            this.urlTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Url";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(689, 23);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // contentTypeTextBox
            // 
            this.contentTypeTextBox.Location = new System.Drawing.Point(12, 69);
            this.contentTypeTextBox.Name = "contentTypeTextBox";
            this.contentTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.contentTypeTextBox.TabIndex = 5;
            this.contentTypeTextBox.Text = "text/plain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Content Type";
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(118, 69);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(572, 96);
            this.bodyBox.TabIndex = 7;
            this.bodyBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Body";
            // 
            // responseText
            // 
            this.responseText.Location = new System.Drawing.Point(-2, 243);
            this.responseText.Name = "responseText";
            this.responseText.ReadOnly = true;
            this.responseText.Size = new System.Drawing.Size(802, 209);
            this.responseText.TabIndex = 9;
            this.responseText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Response";
            // 
            // qtdNumber
            // 
            this.qtdNumber.Location = new System.Drawing.Point(605, 23);
            this.qtdNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.qtdNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtdNumber.Name = "qtdNumber";
            this.qtdNumber.Size = new System.Drawing.Size(56, 20);
            this.qtdNumber.TabIndex = 11;
            this.qtdNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qtdNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.responseText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contentTypeTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.methodComboBox);
            this.Name = "Form1";
            this.Text = "Request";
            ((System.ComponentModel.ISupportInitialize)(this.qtdNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox contentTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox bodyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox responseText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown qtdNumber;
    }
}

