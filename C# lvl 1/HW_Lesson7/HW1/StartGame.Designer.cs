namespace HW1
{
    partial class StartGame
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
            this.bthFirstGame = new System.Windows.Forms.Button();
            this.btnSecondGame = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bthFirstGame
            // 
            this.bthFirstGame.Location = new System.Drawing.Point(69, 85);
            this.bthFirstGame.Name = "bthFirstGame";
            this.bthFirstGame.Size = new System.Drawing.Size(100, 25);
            this.bthFirstGame.TabIndex = 0;
            this.bthFirstGame.Text = "Удвоитель";
            this.bthFirstGame.UseVisualStyleBackColor = true;
            this.bthFirstGame.Click += new System.EventHandler(this.bthFirstGame_Click);
            // 
            // btnSecondGame
            // 
            this.btnSecondGame.Location = new System.Drawing.Point(69, 116);
            this.btnSecondGame.Name = "btnSecondGame";
            this.btnSecondGame.Size = new System.Drawing.Size(100, 25);
            this.btnSecondGame.TabIndex = 1;
            this.btnSecondGame.Text = "Угадай число";
            this.btnSecondGame.UseVisualStyleBackColor = true;
            this.btnSecondGame.Click += new System.EventHandler(this.btnSecondGame_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 49);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(103, 20);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Выбери игру";
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 202);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnSecondGame);
            this.Controls.Add(this.bthFirstGame);
            this.Name = "StartGame";
            this.Text = "StartGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthFirstGame;
        private System.Windows.Forms.Button btnSecondGame;
        private System.Windows.Forms.Label lblQuestion;
    }
}