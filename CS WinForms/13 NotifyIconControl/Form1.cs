﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_NotifyIconControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // NotifyIcon에 메뉴 추가
            ContextMenu ctx = new ContextMenu();
            ctx.MenuItems.Add(new MenuItem("열기"));
            ctx.MenuItems.Add(new MenuItem("실행"));
            ctx.MenuItems.Add("-");
            ctx.MenuItems.Add(new MenuItem("종료", new EventHandler((s, ex) => this.Close())));
            notifyIcon1.ContextMenu = ctx;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 아이콘을 더블클릭하면 폼 화면을 보여줌
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
    }
}
