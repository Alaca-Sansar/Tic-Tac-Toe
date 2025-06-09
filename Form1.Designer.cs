namespace Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            groupBox2 = new GroupBox();
            XKazanma = new Label();
            groupBox3 = new GroupBox();
            OKazanma = new Label();
            label1 = new Label();
            LabelPlayer = new Label();
            Sifirla = new Button();
            button10 = new Button();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button1.Location = new Point(12, 14);
            button1.Name = "button1";
            button1.Size = new Size(157, 157);
            button1.TabIndex = 1;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button2.Location = new Point(175, 14);
            button2.Name = "button2";
            button2.Size = new Size(157, 157);
            button2.TabIndex = 2;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button3.Location = new Point(338, 14);
            button3.Name = "button3";
            button3.Size = new Size(157, 157);
            button3.TabIndex = 3;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button4.Location = new Point(12, 177);
            button4.Name = "button4";
            button4.Size = new Size(157, 157);
            button4.TabIndex = 4;
            button4.Text = " ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button5.Location = new Point(175, 177);
            button5.Name = "button5";
            button5.Size = new Size(157, 157);
            button5.TabIndex = 5;
            button5.Text = " ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button6.Location = new Point(338, 177);
            button6.Name = "button6";
            button6.Size = new Size(157, 157);
            button6.TabIndex = 6;
            button6.Text = " ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button7.Location = new Point(12, 340);
            button7.Name = "button7";
            button7.Size = new Size(157, 157);
            button7.TabIndex = 7;
            button7.Text = " ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button8.Location = new Point(175, 340);
            button8.Name = "button8";
            button8.Size = new Size(157, 157);
            button8.TabIndex = 8;
            button8.Text = " ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Tahoma", 72F, FontStyle.Bold);
            button9.Location = new Point(338, 340);
            button9.Name = "button9";
            button9.Size = new Size(157, 157);
            button9.TabIndex = 9;
            button9.Text = " ";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(XKazanma);
            groupBox2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(0, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 75);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "X";
            // 
            // XKazanma
            // 
            XKazanma.Location = new Point(6, 29);
            XKazanma.Name = "XKazanma";
            XKazanma.Size = new Size(249, 25);
            XKazanma.TabIndex = 0;
            XKazanma.Text = "Kazanma : 0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(OKazanma);
            groupBox3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(0, 117);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(255, 75);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "O";
            // 
            // OKazanma
            // 
            OKazanma.Location = new Point(6, 29);
            OKazanma.Name = "OKazanma";
            OKazanma.Size = new Size(249, 25);
            OKazanma.TabIndex = 0;
            OKazanma.Text = "Kazanma : 0";
            // 
            // label1
            // 
            label1.Location = new Point(6, 201);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 2;
            label1.Text = "Oynama sırası :";
            // 
            // LabelPlayer
            // 
            LabelPlayer.AutoSize = true;
            LabelPlayer.BackColor = SystemColors.Control;
            LabelPlayer.Font = new Font("Microsoft YaHei UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LabelPlayer.ForeColor = SystemColors.ActiveCaptionText;
            LabelPlayer.Location = new Point(6, 241);
            LabelPlayer.Name = "LabelPlayer";
            LabelPlayer.Size = new Size(142, 156);
            LabelPlayer.TabIndex = 3;
            LabelPlayer.Text = "X";
            // 
            // Sifirla
            // 
            Sifirla.ForeColor = SystemColors.ActiveCaptionText;
            Sifirla.Location = new Point(6, 413);
            Sifirla.Name = "Sifirla";
            Sifirla.Size = new Size(117, 58);
            Sifirla.TabIndex = 4;
            Sifirla.Text = "Sıfırla";
            Sifirla.UseVisualStyleBackColor = true;
            Sifirla.Click += Sifirla_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(133, 413);
            button10.Name = "button10";
            button10.Size = new Size(122, 58);
            button10.TabIndex = 5;
            button10.Text = "Meraklısı için veriler";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Purple;
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(Sifirla);
            groupBox1.Controls.Add(LabelPlayer);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(527, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 486);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "İstatikler";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private GroupBox groupBox2;
        private Label XKazanma;
        private GroupBox groupBox3;
        private Label OKazanma;
        private Label label1;
        private Label LabelPlayer;
        private Button Sifirla;
        private Button button10;
        private GroupBox groupBox1;
    }
}
