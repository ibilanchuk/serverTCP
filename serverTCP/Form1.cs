﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serverTCP
{
    public partial class Form1 : Form
    {
        public void Add_Event(string MSG)
        {
            listBox1.Items.Add(MSG);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void Conncet_Click(object sender, EventArgs e)
        {
            string STMSG = SocketCoderBinaryServer.Start_Video_Server(int.Parse(text_Port.Text));
            Add_Event(STMSG);
            Conncet.Enabled = false;
            DisConncet.Enabled = true;
            text_Port.Enabled = false;
        }

        private void DisConncet_Click(object sender, EventArgs e)
        {
            try
            {
                string STMSG = SocketCoderBinaryServer.ShutDown();
                Add_Event(STMSG);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DisConncet.Enabled = false;
            Conncet.Enabled = true;
            text_Port.Enabled = true;
        }
    }
}
