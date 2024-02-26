
namespace cifyonlubagliliste
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
            this.AddToStartButton = new System.Windows.Forms.Button();
            this.AddToEndButton = new System.Windows.Forms.Button();
            this.RemoveFromStartButton = new System.Windows.Forms.Button();
            this.RemoveFromEndButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // AddToStartButton
            // 
            this.AddToStartButton.Location = new System.Drawing.Point(117, 101);
            this.AddToStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToStartButton.Name = "AddToStartButton";
            this.AddToStartButton.Size = new System.Drawing.Size(159, 28);
            this.AddToStartButton.TabIndex = 0;
            this.AddToStartButton.Text = "BaşlangıcaEkle";
            this.AddToStartButton.UseVisualStyleBackColor = true;
            this.AddToStartButton.Click += new System.EventHandler(this.AddToStartButton_Click);
            // 
            // AddToEndButton
            // 
            this.AddToEndButton.Location = new System.Drawing.Point(312, 101);
            this.AddToEndButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToEndButton.Name = "AddToEndButton";
            this.AddToEndButton.Size = new System.Drawing.Size(167, 28);
            this.AddToEndButton.TabIndex = 1;
            this.AddToEndButton.Text = "SonaEkle";
            this.AddToEndButton.UseVisualStyleBackColor = true;
            this.AddToEndButton.Click += new System.EventHandler(this.AddToEndButton_Click);
            // 
            // RemoveFromStartButton
            // 
            this.RemoveFromStartButton.Location = new System.Drawing.Point(117, 160);
            this.RemoveFromStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveFromStartButton.Name = "RemoveFromStartButton";
            this.RemoveFromStartButton.Size = new System.Drawing.Size(159, 30);
            this.RemoveFromStartButton.TabIndex = 2;
            this.RemoveFromStartButton.Text = "BaşlangıçtanSil";
            this.RemoveFromStartButton.UseVisualStyleBackColor = true;
            this.RemoveFromStartButton.Click += new System.EventHandler(this.RemoveFromStartButton_Click);
            // 
            // RemoveFromEndButton
            // 
            this.RemoveFromEndButton.Location = new System.Drawing.Point(312, 161);
            this.RemoveFromEndButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveFromEndButton.Name = "RemoveFromEndButton";
            this.RemoveFromEndButton.Size = new System.Drawing.Size(167, 28);
            this.RemoveFromEndButton.TabIndex = 3;
            this.RemoveFromEndButton.Text = "SondanSil";
            this.RemoveFromEndButton.UseVisualStyleBackColor = true;
            this.RemoveFromEndButton.Click += new System.EventHandler(this.RemoveFromEndButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(228, 36);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(132, 22);
            this.InputTextBox.TabIndex = 4;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // OutputListView
            // 
            this.OutputListView.HideSelection = false;
            this.OutputListView.Location = new System.Drawing.Point(49, 215);
            this.OutputListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputListView.Name = "OutputListView";
            this.OutputListView.Size = new System.Drawing.Size(485, 190);
            this.OutputListView.TabIndex = 5;
            this.OutputListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.OutputListView);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.RemoveFromEndButton);
            this.Controls.Add(this.RemoveFromStartButton);
            this.Controls.Add(this.AddToEndButton);
            this.Controls.Add(this.AddToStartButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddToStartButton;
        private System.Windows.Forms.Button AddToEndButton;
        private System.Windows.Forms.Button RemoveFromStartButton;
        private System.Windows.Forms.Button RemoveFromEndButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.ListView OutputListView;
    }
}

