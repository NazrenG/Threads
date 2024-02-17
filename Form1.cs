using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ThreadsTask
{
    public partial class Form1 : Form
    {
        public string srcPath, destPath;
        public Thread thread;
        public bool checkCopy = false;
        public bool checkSuspend = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void from_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "AllFiles|*.*|TextFile|*.txt";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName.ToString();
                srcPath = textBox1.Text.ToString();
            }
        }

        private void to_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "AllFiles|*.*|TextFile|*.txt";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName.ToString();
                destPath = textBox2.Text.ToString();
            }
        }

        private void resume_btn_Click(object sender, EventArgs e)
        {
            if (!checkCopy)
            {
                MessageBox.Show("If you want a resume, you need to copy to a file first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkSuspend)
            {
                thread.Resume();
            }
            else
            {
                MessageBox.Show("There are no suspended threads to resume!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!checkCopy)
            {
                MessageBox.Show("If you want a pause, you need to copy to a file first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            thread.Suspend();
            checkSuspend = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkCopy)
            {
                MessageBox.Show("If you want abort thread, you need to copy to a file first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            thread.Abort();
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {

            if (srcPath==null)
            {
                MessageBox.Show("The file to transfer does not exist!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (destPath==null)
            {
                MessageBox.Show("No file to file transfer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            thread = new Thread(() =>
           {
               if (!File.Exists(srcPath))
               {
                   MessageBox.Show("File not exist!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   return;
               } 
               progressBar1.Minimum = 1;
               progressBar1.Value = 1;

               using (FileStream fsRead = new FileStream(srcPath, FileMode.Open, FileAccess.Read))
               {
                   checkCopy = true;
                   progressBar1.Maximum = Convert.ToInt32(fsRead.Length);

                   using (FileStream fsWrite = new FileStream(destPath, FileMode.Create, FileAccess.Write))
                   {
                       var len = 10;
                       var fileSize = fsRead.Length;
                       byte[] buffer = new byte[len];

                       do
                       {
                           len = fsRead.Read(buffer, 0, buffer.Length);
                           progressBar1.Step = len;
                           fsWrite.Write(buffer, 0, len);

                           progressBar1.PerformStep();
                           fileSize -= len;

                           Thread.Sleep(250);

                       } while (len != 0);

                   }
               }

           });

            thread.Start();

            int final = progressBar1.Value;
            if (final == progressBar1.Maximum)
            {
                progressBar1.Value = 1;
                textBox1.Text = null;
                textBox2.Text = "";
            }
        }
    }
}
