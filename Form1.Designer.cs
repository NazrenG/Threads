namespace ThreadsTask
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.copy_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.resume_btn = new System.Windows.Forms.Button();
            this.to_button = new System.Windows.Forms.Button();
            this.from_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 20);
            this.textBox2.TabIndex = 0;
            // 
            // copy_btn
            // 
            this.copy_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.copy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_btn.Location = new System.Drawing.Point(375, 140);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(70, 31);
            this.copy_btn.TabIndex = 1;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = false;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Teal;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progressBar1.Location = new System.Drawing.Point(39, 148);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(211, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Abort";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(39, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "Suspend";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // resume_btn
            // 
            this.resume_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.resume_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume_btn.Location = new System.Drawing.Point(123, 186);
            this.resume_btn.Name = "resume_btn";
            this.resume_btn.Size = new System.Drawing.Size(69, 39);
            this.resume_btn.TabIndex = 1;
            this.resume_btn.Text = "Resume";
            this.resume_btn.UseVisualStyleBackColor = false;
            this.resume_btn.Click += new System.EventHandler(this.resume_btn_Click);
            // 
            // to_button
            // 
            this.to_button.BackColor = System.Drawing.Color.LightBlue;
            this.to_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_button.Location = new System.Drawing.Point(375, 106);
            this.to_button.Name = "to_button";
            this.to_button.Size = new System.Drawing.Size(70, 23);
            this.to_button.TabIndex = 1;
            this.to_button.Text = "File to....";
            this.to_button.UseVisualStyleBackColor = false;
            this.to_button.Click += new System.EventHandler(this.to_button_Click);
            // 
            // from_btn
            // 
            this.from_btn.BackColor = System.Drawing.Color.LightBlue;
            this.from_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_btn.Location = new System.Drawing.Point(375, 69);
            this.from_btn.Name = "from_btn";
            this.from_btn.Size = new System.Drawing.Size(70, 23);
            this.from_btn.TabIndex = 1;
            this.from_btn.Text = "File to ...";
            this.from_btn.UseVisualStyleBackColor = false;
            this.from_btn.Click += new System.EventHandler(this.from_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 247);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.resume_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.from_btn);
            this.Controls.Add(this.to_button);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button resume_btn;
        private System.Windows.Forms.Button to_button;
        private System.Windows.Forms.Button from_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

