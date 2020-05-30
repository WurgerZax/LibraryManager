namespace LibraryManager
{
    partial class FormFilterByPrice
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.yearTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.equalRadioButton = new System.Windows.Forms.RadioButton();
            this.moreRadioButton = new System.Windows.Forms.RadioButton();
            this.lessRadioButton = new System.Windows.Forms.RadioButton();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rangeTabPage = new System.Windows.Forms.TabPage();
            this.toNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.yearTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.rangeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.yearTabPage);
            this.tabControl1.Controls.Add(this.rangeTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 195);
            this.tabControl1.TabIndex = 4;
            // 
            // yearTabPage
            // 
            this.yearTabPage.Controls.Add(this.label3);
            this.yearTabPage.Controls.Add(this.groupBox1);
            this.yearTabPage.Controls.Add(this.priceNumericUpDown);
            this.yearTabPage.Location = new System.Drawing.Point(4, 35);
            this.yearTabPage.Name = "yearTabPage";
            this.yearTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.yearTabPage.Size = new System.Drawing.Size(368, 156);
            this.yearTabPage.TabIndex = 0;
            this.yearTabPage.Text = "Точный";
            this.yearTabPage.UseVisualStyleBackColor = true;
            this.yearTabPage.Click += new System.EventHandler(this.yearTabPage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equalRadioButton);
            this.groupBox1.Controls.Add(this.moreRadioButton);
            this.groupBox1.Controls.Add(this.lessRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // equalRadioButton
            // 
            this.equalRadioButton.AutoSize = true;
            this.equalRadioButton.Checked = true;
            this.equalRadioButton.Location = new System.Drawing.Point(6, 104);
            this.equalRadioButton.Name = "equalRadioButton";
            this.equalRadioButton.Size = new System.Drawing.Size(100, 30);
            this.equalRadioButton.TabIndex = 2;
            this.equalRadioButton.TabStop = true;
            this.equalRadioButton.Text = "Равно";
            this.equalRadioButton.UseVisualStyleBackColor = true;
            this.equalRadioButton.CheckedChanged += new System.EventHandler(this.equalRadioButton_CheckedChanged);
            // 
            // moreRadioButton
            // 
            this.moreRadioButton.AutoSize = true;
            this.moreRadioButton.Location = new System.Drawing.Point(5, 68);
            this.moreRadioButton.Name = "moreRadioButton";
            this.moreRadioButton.Size = new System.Drawing.Size(118, 30);
            this.moreRadioButton.TabIndex = 1;
            this.moreRadioButton.Text = "Больше";
            this.moreRadioButton.UseVisualStyleBackColor = true;
            this.moreRadioButton.CheckedChanged += new System.EventHandler(this.moreRadioButton_CheckedChanged);
            // 
            // lessRadioButton
            // 
            this.lessRadioButton.AutoSize = true;
            this.lessRadioButton.Location = new System.Drawing.Point(6, 32);
            this.lessRadioButton.Name = "lessRadioButton";
            this.lessRadioButton.Size = new System.Drawing.Size(121, 30);
            this.lessRadioButton.TabIndex = 0;
            this.lessRadioButton.Text = "Меньше";
            this.lessRadioButton.UseVisualStyleBackColor = true;
            this.lessRadioButton.CheckedChanged += new System.EventHandler(this.lessRadioButton_CheckedChanged);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(225, 76);
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.priceNumericUpDown.TabIndex = 0;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceNumericUpDown.ValueChanged += new System.EventHandler(this.priceNumericUpDown_ValueChanged);
            // 
            // rangeTabPage
            // 
            this.rangeTabPage.Controls.Add(this.toNumericUpDown);
            this.rangeTabPage.Controls.Add(this.fromNumericUpDown);
            this.rangeTabPage.Controls.Add(this.label2);
            this.rangeTabPage.Controls.Add(this.label1);
            this.rangeTabPage.Location = new System.Drawing.Point(4, 35);
            this.rangeTabPage.Name = "rangeTabPage";
            this.rangeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rangeTabPage.Size = new System.Drawing.Size(368, 156);
            this.rangeTabPage.TabIndex = 1;
            this.rangeTabPage.Text = "Диапазон";
            this.rangeTabPage.UseVisualStyleBackColor = true;
            this.rangeTabPage.Click += new System.EventHandler(this.rangeTabPage_Click);
            // 
            // toNumericUpDown
            // 
            this.toNumericUpDown.DecimalPlaces = 2;
            this.toNumericUpDown.Location = new System.Drawing.Point(151, 86);
            this.toNumericUpDown.Name = "toNumericUpDown";
            this.toNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.toNumericUpDown.TabIndex = 3;
            this.toNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toNumericUpDown.ValueChanged += new System.EventHandler(this.toNumericUpDown_ValueChanged);
            // 
            // fromNumericUpDown
            // 
            this.fromNumericUpDown.DecimalPlaces = 2;
            this.fromNumericUpDown.Location = new System.Drawing.Point(151, 36);
            this.fromNumericUpDown.Name = "fromNumericUpDown";
            this.fromNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.fromNumericUpDown.TabIndex = 2;
            this.fromNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromNumericUpDown.ValueChanged += new System.EventHandler(this.fromNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "До:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "От:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(92, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Применить фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFilterByPrice
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 270);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "FormFilterByPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Фильтр по цене";
            this.Load += new System.EventHandler(this.FormFilterByPrice_Load);
            this.tabControl1.ResumeLayout(false);
            this.yearTabPage.ResumeLayout(false);
            this.yearTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.rangeTabPage.ResumeLayout(false);
            this.rangeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage yearTabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton equalRadioButton;
        private System.Windows.Forms.RadioButton moreRadioButton;
        private System.Windows.Forms.RadioButton lessRadioButton;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.TabPage rangeTabPage;
        private System.Windows.Forms.NumericUpDown toNumericUpDown;
        private System.Windows.Forms.NumericUpDown fromNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}