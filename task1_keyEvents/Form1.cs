using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1_keyEvents
{
    public partial class Form1 : Form
    {
        private HashSet<Keys> pressedKeys;
        public Form1()
        {
            InitializeComponent();

            pressedKeys = new HashSet<Keys>();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           pressedKeys.Remove(e.KeyCode);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pressedKeys.Contains(Keys.W))
            {
                leftPaddle.Top -= 8;
            }

            if(pressedKeys.Contains(Keys.S))
            {
                leftPaddle.Top += 8;
            }

            if(pressedKeys.Contains(Keys.Up))
            {
                rightPaddle.Top -= 8;   
            }

            if(pressedKeys.Contains(Keys.Down))
            {
                rightPaddle.Top += 8;
            }
        }
    }
}
