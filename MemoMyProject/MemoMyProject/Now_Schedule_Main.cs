﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoMyProject
{
    public partial class Now_Schedule_Main : Form
    {
      
        public Now_Schedule_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Schedule_Write schedule_Write = new Schedule_Write();
            schedule_Write.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main_Form Main = new Main_Form();
            Main.ShowDialog();
        }

       
    }
}
