namespace PassengersTest
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
            passengersGrid = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)passengersGrid).BeginInit();
            SuspendLayout();
            // 
            // passengersGrid
            // 
            passengersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            passengersGrid.Location = new Point(147, 12);
            passengersGrid.Name = "passengersGrid";
            passengersGrid.RowTemplate.Height = 25;
            passengersGrid.Size = new Size(462, 415);
            passengersGrid.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(2, 369);
            button2.Name = "button2";
            button2.Size = new Size(139, 58);
            button2.TabIndex = 2;
            button2.Text = "Сохранить Изменения";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(passengersGrid);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)passengersGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private DataGridView passengersGrid;
    }
}