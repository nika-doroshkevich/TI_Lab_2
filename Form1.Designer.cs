
namespace Lab_2_WinForms
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
            this.Start_Value_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Polynom_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Generated_Key_Box = new System.Windows.Forms.TextBox();
            this.File_Content_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Result_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Run_Button = new System.Windows.Forms.Button();
            this.Select_File_Button = new System.Windows.Forms.Button();
            this.Dialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Start_Value_Box
            // 
            this.Start_Value_Box.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_Value_Box.Location = new System.Drawing.Point(73, 42);
            this.Start_Value_Box.Name = "Start_Value_Box";
            this.Start_Value_Box.Size = new System.Drawing.Size(551, 37);
            this.Start_Value_Box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting value:";
            // 
            // Polynom_Box
            // 
            this.Polynom_Box.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Polynom_Box.Location = new System.Drawing.Point(73, 127);
            this.Polynom_Box.Name = "Polynom_Box";
            this.Polynom_Box.Size = new System.Drawing.Size(551, 37);
            this.Polynom_Box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Polynom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Generated key:";
            // 
            // Generated_Key_Box
            // 
            this.Generated_Key_Box.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Generated_Key_Box.Location = new System.Drawing.Point(73, 212);
            this.Generated_Key_Box.Name = "Generated_Key_Box";
            this.Generated_Key_Box.Size = new System.Drawing.Size(1164, 37);
            this.Generated_Key_Box.TabIndex = 5;
            // 
            // File_Content_Box
            // 
            this.File_Content_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.File_Content_Box.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.File_Content_Box.Location = new System.Drawing.Point(73, 298);
            this.File_Content_Box.Name = "File_Content_Box";
            this.File_Content_Box.Size = new System.Drawing.Size(1164, 37);
            this.File_Content_Box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(73, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "File content:";
            // 
            // Result_Box
            // 
            this.Result_Box.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result_Box.Location = new System.Drawing.Point(73, 382);
            this.Result_Box.Name = "Result_Box";
            this.Result_Box.Size = new System.Drawing.Size(1164, 37);
            this.Result_Box.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(73, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Result:";
            // 
            // Run_Button
            // 
            this.Run_Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Run_Button.Location = new System.Drawing.Point(737, 85);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(132, 48);
            this.Run_Button.TabIndex = 10;
            this.Run_Button.Text = "Run";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // Select_File_Button
            // 
            this.Select_File_Button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Select_File_Button.Location = new System.Drawing.Point(921, 85);
            this.Select_File_Button.Name = "Select_File_Button";
            this.Select_File_Button.Size = new System.Drawing.Size(169, 48);
            this.Select_File_Button.TabIndex = 11;
            this.Select_File_Button.Text = "Select file";
            this.Select_File_Button.UseVisualStyleBackColor = true;
            this.Select_File_Button.Click += new System.EventHandler(this.Select_File_Button_Click);
            // 
            // Dialog
            // 
            this.Dialog.FileName = "Dialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 484);
            this.Controls.Add(this.Select_File_Button);
            this.Controls.Add(this.Run_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Result_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.File_Content_Box);
            this.Controls.Add(this.Generated_Key_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Polynom_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_Value_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Start_Value_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Polynom_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Generated_Key_Box;
        private System.Windows.Forms.TextBox File_Content_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Result_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.Button Select_File_Button;
        private System.Windows.Forms.OpenFileDialog Dialog;
    }
}

