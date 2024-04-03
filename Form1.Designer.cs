namespace LAB3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.plasmaButton = new System.Windows.Forms.Button();
            this.algebraicButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roughnessBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xOffsetTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yOffsetTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(758, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fractals";
            // 
            // plasmaButton
            // 
            this.plasmaButton.BackColor = System.Drawing.Color.Tan;
            this.plasmaButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plasmaButton.Location = new System.Drawing.Point(665, 43);
            this.plasmaButton.Name = "plasmaButton";
            this.plasmaButton.Size = new System.Drawing.Size(157, 55);
            this.plasmaButton.TabIndex = 2;
            this.plasmaButton.Text = "Plasma";
            this.plasmaButton.UseVisualStyleBackColor = false;
            this.plasmaButton.Click += new System.EventHandler(this.plasmaButton_Click);
            // 
            // algebraicButton
            // 
            this.algebraicButton.BackColor = System.Drawing.Color.Tan;
            this.algebraicButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.algebraicButton.Location = new System.Drawing.Point(665, 204);
            this.algebraicButton.Name = "algebraicButton";
            this.algebraicButton.Size = new System.Drawing.Size(155, 55);
            this.algebraicButton.TabIndex = 3;
            this.algebraicButton.Text = "z*sin (z)+с";
            this.algebraicButton.UseVisualStyleBackColor = false;
            this.algebraicButton.Click += new System.EventHandler(this.algebraicButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(647, 623);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Roughness";
            // 
            // roughnessBox
            // 
            this.roughnessBox.Location = new System.Drawing.Point(669, 124);
            this.roughnessBox.Name = "roughnessBox";
            this.roughnessBox.Size = new System.Drawing.Size(87, 26);
            this.roughnessBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scale";
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Location = new System.Drawing.Point(669, 285);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(87, 26);
            this.scaleTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Iterations";
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(669, 337);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(87, 26);
            this.iterationsTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "X offset";
            // 
            // xOffsetTextBox
            // 
            this.xOffsetTextBox.Location = new System.Drawing.Point(669, 389);
            this.xOffsetTextBox.Name = "xOffsetTextBox";
            this.xOffsetTextBox.Size = new System.Drawing.Size(87, 26);
            this.xOffsetTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(798, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y offset";
            // 
            // yOffsetTextBox
            // 
            this.yOffsetTextBox.Location = new System.Drawing.Point(802, 389);
            this.yOffsetTextBox.Name = "yOffsetTextBox";
            this.yOffsetTextBox.Size = new System.Drawing.Size(87, 26);
            this.yOffsetTextBox.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Tan;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(665, 473);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(155, 55);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save image";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(929, 647);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.yOffsetTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xOffsetTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scaleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roughnessBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.algebraicButton);
            this.Controls.Add(this.plasmaButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plasmaButton;
        private System.Windows.Forms.Button algebraicButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roughnessBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iterationsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xOffsetTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yOffsetTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}

