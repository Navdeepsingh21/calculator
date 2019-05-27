namespace firstform_example
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
            this.lbl_firstnumber = new System.Windows.Forms.Label();
            this.lbl_secondnumber = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn3_mult = new System.Windows.Forms.Button();
            this.btn4_div = new System.Windows.Forms.Button();
            this.txt_firstnumber = new System.Windows.Forms.TextBox();
            this.txt_secondnumber = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstnumber
            // 
            this.lbl_firstnumber.AutoSize = true;
            this.lbl_firstnumber.Location = new System.Drawing.Point(311, 65);
            this.lbl_firstnumber.Name = "lbl_firstnumber";
            this.lbl_firstnumber.Size = new System.Drawing.Size(64, 13);
            this.lbl_firstnumber.TabIndex = 0;
            this.lbl_firstnumber.Text = "First number";
            // 
            // lbl_secondnumber
            // 
            this.lbl_secondnumber.AutoSize = true;
            this.lbl_secondnumber.Location = new System.Drawing.Point(311, 93);
            this.lbl_secondnumber.Name = "lbl_secondnumber";
            this.lbl_secondnumber.Size = new System.Drawing.Size(82, 13);
            this.lbl_secondnumber.TabIndex = 1;
            this.lbl_secondnumber.Text = "Second number";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(312, 126);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(37, 13);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "Result";
            this.lbl_result.Click += new System.EventHandler(this.Lbl_result_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(482, 119);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add.Location = new System.Drawing.Point(285, 172);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sub.Location = new System.Drawing.Point(377, 172);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 5;
            this.btn_sub.Text = "SUB";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.Btn_sub_Click);
            // 
            // btn3_mult
            // 
            this.btn3_mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn3_mult.Location = new System.Drawing.Point(468, 172);
            this.btn3_mult.Name = "btn3_mult";
            this.btn3_mult.Size = new System.Drawing.Size(75, 23);
            this.btn3_mult.TabIndex = 6;
            this.btn3_mult.Text = "MULT";
            this.btn3_mult.UseVisualStyleBackColor = false;
            this.btn3_mult.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn4_div
            // 
            this.btn4_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn4_div.Location = new System.Drawing.Point(559, 172);
            this.btn4_div.Name = "btn4_div";
            this.btn4_div.Size = new System.Drawing.Size(75, 23);
            this.btn4_div.TabIndex = 7;
            this.btn4_div.Text = "DIV";
            this.btn4_div.UseVisualStyleBackColor = false;
            this.btn4_div.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // txt_firstnumber
            // 
            this.txt_firstnumber.Location = new System.Drawing.Point(482, 58);
            this.txt_firstnumber.Name = "txt_firstnumber";
            this.txt_firstnumber.Size = new System.Drawing.Size(100, 20);
            this.txt_firstnumber.TabIndex = 8;
            // 
            // txt_secondnumber
            // 
            this.txt_secondnumber.Location = new System.Drawing.Point(482, 86);
            this.txt_secondnumber.Name = "txt_secondnumber";
            this.txt_secondnumber.Size = new System.Drawing.Size(100, 20);
            this.txt_secondnumber.TabIndex = 9;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.Location = new System.Drawing.Point(609, 117);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.txt_secondnumber);
            this.Controls.Add(this.txt_firstnumber);
            this.Controls.Add(this.btn4_div);
            this.Controls.Add(this.btn3_mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_secondnumber);
            this.Controls.Add(this.lbl_firstnumber);
            this.Name = "Form1";
            this.Text = "CALCULATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstnumber;
        private System.Windows.Forms.Label lbl_secondnumber;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn3_mult;
        private System.Windows.Forms.Button btn4_div;
        private System.Windows.Forms.TextBox txt_firstnumber;
        private System.Windows.Forms.TextBox txt_secondnumber;
        private System.Windows.Forms.Button clear;
    }
}

