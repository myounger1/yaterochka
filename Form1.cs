﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Ya_Terochka : Form
    {
        int sc = 0;
        public Ya_Terochka()
        {
            InitializeComponent();
        }

        private void Магазин_Click(object sender, EventArgs e)
        {
            MagazinForm mf = new MagazinForm();
            mf.ShowDialog();
        }

        private void Тёрочка_Click(object sender, EventArgs e)
        {
            Terochka mv= new Terochka();
            mv.ShowDialog();
        }

        private void Мой_кабинет_Click(object sender, EventArgs e)
        {
            My_Kabinet ms = new My_Kabinet();
            ms.ShowDialog();
        }

        private void Скины_Click(object sender, EventArgs e)
        {
            Skins mk = new Skins();
            mk.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc = sc + 1;

            label1.Text = ":" + sc.ToString();

            //if(button1.Click)
        }
    }
}
