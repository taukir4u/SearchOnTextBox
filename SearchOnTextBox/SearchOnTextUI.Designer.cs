namespace SearchOnTextBox
{
    partial class SearchOnTextUI
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
            this.hfkj = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.inputTextTextBox = new System.Windows.Forms.RichTextBox();
            this.totalFindNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hfkj
            // 
            this.hfkj.AutoSize = true;
            this.hfkj.Location = new System.Drawing.Point(26, 70);
            this.hfkj.Name = "hfkj";
            this.hfkj.Size = new System.Drawing.Size(36, 13);
            this.hfkj.TabIndex = 0;
            this.hfkj.Text = "Article";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(345, 60);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 33);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // inputTextTextBox
            // 
            this.inputTextTextBox.Location = new System.Drawing.Point(77, 34);
            this.inputTextTextBox.Name = "inputTextTextBox";
            this.inputTextTextBox.Size = new System.Drawing.Size(262, 96);
            this.inputTextTextBox.TabIndex = 2;
            this.inputTextTextBox.Text = "";
            // 
            // totalFindNumberTextBox
            // 
            this.totalFindNumberTextBox.Location = new System.Drawing.Point(156, 68);
            this.totalFindNumberTextBox.Name = "totalFindNumberTextBox";
            this.totalFindNumberTextBox.Size = new System.Drawing.Size(74, 20);
            this.totalFindNumberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(77, 35);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(262, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(356, 32);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(66, 23);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.totalFindNumberTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Word";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputTextTextBox);
            this.groupBox2.Controls.Add(this.hfkj);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 160);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Article";
            // 
            // SearchOnTextUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchOnTextUI";
            this.Text = "Search On Text";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hfkj;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox inputTextTextBox;
        private System.Windows.Forms.TextBox totalFindNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

