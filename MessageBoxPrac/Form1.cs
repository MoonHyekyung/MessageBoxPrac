﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            MessageBox.Show("내용","제목");
            MessageBox.Show("내용", "제목",
               MessageBoxButtons.AbortRetryIgnore); // 중단, 다시, 무시
            
            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                // 중단, 다시, 무시버튼 / 느낌표 아이콘
            } while (result == DialogResult.Retry);
        }
    }
}
