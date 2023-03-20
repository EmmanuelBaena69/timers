namespace timers
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
            components = new System.ComponentModel.Container();
            tmr1 = new System.Windows.Forms.Timer(components);
            tmr2 = new System.Windows.Forms.Timer(components);
            tmr3 = new System.Windows.Forms.Timer(components);
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            btn1 = new Button();
            btn2 = new Button();
            SuspendLayout();
            // 
            // tmr1
            // 
            tmr1.Tick += tmr1_Tick;
            // 
            // tmr2
            // 
            tmr2.Tick += tmr2_Tick;
            // 
            // tmr3
            // 
            tmr3.Tick += tmr3_Tick;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(55, 132);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "label1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(376, 132);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(50, 20);
            lbl2.TabIndex = 1;
            lbl2.Text = "label2";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(672, 132);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(50, 20);
            lbl3.TabIndex = 2;
            lbl3.Text = "label3";
            // 
            // btn1
            // 
            btn1.Location = new Point(243, 341);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 3;
            btn1.Text = "Start";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(468, 341);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 4;
            btn2.Text = "Stop";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Timer tmr3;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Button btn1;
        private Button btn2;
    }
}