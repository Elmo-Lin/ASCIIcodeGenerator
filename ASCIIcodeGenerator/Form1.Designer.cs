
namespace ASCIIcodeGenerator
{
    partial class ASCIIcode
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
            this.Input = new System.Windows.Forms.Label();
            this.InputTb = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(57, 68);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(142, 25);
            this.Input.TabIndex = 0;
            this.Input.Text = "Inuput a string : ";
            // 
            // InputTb
            // 
            this.InputTb.Location = new System.Drawing.Point(205, 65);
            this.InputTb.Name = "InputTb";
            this.InputTb.Size = new System.Drawing.Size(150, 31);
            this.InputTb.TabIndex = 1;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(126, 126);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(229, 36);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Change to ASCII code";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(111, 192);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(88, 25);
            this.Output.TabIndex = 3;
            this.Output.Text = " Output : ";
            // 
            // ASCIIcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 306);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.InputTb);
            this.Controls.Add(this.Input);
            this.Name = "ASCIIcode";
            this.Text = "ASCII code generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.TextBox InputTb;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label Output;
    }
}

