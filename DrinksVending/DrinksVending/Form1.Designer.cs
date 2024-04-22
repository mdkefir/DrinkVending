namespace DrinksVending
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lbAlko = new Label();
            lbJuise = new Label();
            lbGaz = new Label();
            btnLoad = new Button();
            btnGetDrink = new Button();
            txtInfo = new RichTextBox();
            txtQueue = new RichTextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 17);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Сок";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 8);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Газировка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 8);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Алгоколь";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbAlko);
            panel1.Controls.Add(lbJuise);
            panel1.Controls.Add(lbGaz);
            panel1.Location = new Point(72, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 49);
            panel1.TabIndex = 3;
            // 
            // lbAlko
            // 
            lbAlko.AutoSize = true;
            lbAlko.Location = new Point(217, 26);
            lbAlko.Name = "lbAlko";
            lbAlko.Size = new Size(13, 15);
            lbAlko.TabIndex = 6;
            lbAlko.Text = "0";
            // 
            // lbJuise
            // 
            lbJuise.AutoSize = true;
            lbJuise.Location = new Point(15, 26);
            lbJuise.Name = "lbJuise";
            lbJuise.Size = new Size(13, 15);
            lbJuise.TabIndex = 4;
            lbJuise.Text = "0";
            // 
            // lbGaz
            // 
            lbGaz.AutoSize = true;
            lbGaz.Location = new Point(105, 26);
            lbGaz.Name = "lbGaz";
            lbGaz.Size = new Size(13, 15);
            lbGaz.TabIndex = 5;
            lbGaz.Text = "0";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(10, 62);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnGetDrink
            // 
            btnGetDrink.Location = new Point(311, 62);
            btnGetDrink.Margin = new Padding(3, 2, 3, 2);
            btnGetDrink.Name = "btnGetDrink";
            btnGetDrink.Size = new Size(82, 22);
            btnGetDrink.TabIndex = 5;
            btnGetDrink.Text = "Получить";
            btnGetDrink.UseVisualStyleBackColor = true;
            btnGetDrink.Click += btnGetDrink_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(10, 88);
            txtInfo.Margin = new Padding(3, 2, 3, 2);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(383, 27);
            txtInfo.TabIndex = 6;
            txtInfo.Text = "";
            // 
            // txtQueue
            // 
            txtQueue.Location = new Point(10, 119);
            txtQueue.Margin = new Padding(3, 2, 3, 2);
            txtQueue.Name = "txtQueue";
            txtQueue.Size = new Size(383, 91);
            txtQueue.TabIndex = 7;
            txtQueue.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(272, 75);
            label4.TabIndex = 8;
            label4.Text = "Придумать иерархию классов\r\nДля раздачи напитков (общее свойство: объем)\r\n•Сок (используемый фрукт, наличие мякоти)\r\n•Газировка (вид, количество пузыриков)\r\n•Алкоголь (крепость, тип)\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 296);
            Controls.Add(label4);
            Controls.Add(txtQueue);
            Controls.Add(txtInfo);
            Controls.Add(btnGetDrink);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Напитки";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label lbAlko;
        private Label lbJuise;
        private Label lbGaz;
        private Button btnLoad;
        private Button btnGetDrink;
        private RichTextBox txtInfo;
        private RichTextBox txtQueue;
        private Label label4;
    }
}