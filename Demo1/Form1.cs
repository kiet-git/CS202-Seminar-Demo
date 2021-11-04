using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form1 : Form
    {
        Dictionary<string, IColor> lColor = new Dictionary<string, IColor>() {
                { "Red", new RedColor() },
                { "Blue", new BlueColor() },
                { "Dark Orange", new DarkOrangeColor() },
                { "Black", new BlackColor() }
            };

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Select();
        }

        Shape chooseShape(string lb1choice, string lb2choice, int length1, int length2)
        {
            Shape shape = null;
            switch (lb1choice)
            {
                case "Square":
                    shape = new Square(lColor[lb2choice], length1);
                    break;
                case "Circle":
                    shape = new Circle(lColor[lb2choice], length1);
                    break;
                case "Rectangle":
                    shape = new Rectangle1(lColor[lb2choice], length1, length2);
                    break;
                case "Ellipse":
                    shape = new Ellipse(lColor[lb2choice], length1, length2);
                    break;
                default:
                    break;
            }
            return shape;
        }

        void updateShape()
        {
            if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1) return;

            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty) return;

            pictureBox1.Refresh();

            string lb1choice = listBox1.SelectedItem.ToString();
            string lb2choice = listBox2.SelectedItem.ToString();

            int length1 = 0;
            int.TryParse(textBox1.Text, out length1);
            int length2 = 0;
            int.TryParse(textBox2.Text, out length2);

            Shape shape = chooseShape(lb1choice, lb2choice, length1, length2);
            Graphics graphics = pictureBox1.CreateGraphics();

            if (shape is not null)
                shape.manufacture(graphics);

            graphics.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateShape();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateShape();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            pictureBox1.Select();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            updateShape();
        }
    }
}
