using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>();
            buttons.AddRange(new Button[5] { button1, button2, button3, button4, button5 });
            button1.Click += button1_Click;
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
        }

        void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            Button btn = buttons[rnd.Next(buttons.Count)];
            btn.Visible = !btn.Visible;
        }
    }
}