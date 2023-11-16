using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dotskin_lab_3
{
    public partial class Form2 : Form
    {
        Panel[,] cells;
        PictureBox picture_box;

        public Form2()
        {
            InitializeComponent();

            Width = 1000;
            Height = 1040;

            picture_box = new PictureBox();
            picture_box.Width = 1000;
            picture_box.Height = 1035;
            picture_box.Location = new Point(50, 50);
            this.Controls.Add(picture_box);

            InitializeCheckerboard();
            picture_box.Paint += new PaintEventHandler(_Paint);
        }

        private void InitializeCheckerboard()
        {
            cells = new Panel[10, 10];

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Panel cell = new Panel();
                    cell.Width = 100;
                    cell.Height = 100;
                    cell.Location = new Point(x * 100, y * 100);

                    // Alternate colors for a checkerboard pattern
                    if ((x + y) % 2 == 0)
                        cell.BackColor = Color.Beige;
                    else
                        cell.BackColor = Color.Brown;

                    cells[x, y] = cell;
                    picture_box.Controls.Add(cell);
                }
            }
        }

        private void _Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if ((x + y) % 2 == 1)
                    {
                        if (y < 4)
                        {
                            Rectangle circleRect = new Rectangle(x * 100 + 10, y * 100 + 10, 80, 80);
                            graphics.FillEllipse(Brushes.White, circleRect);
                        }

                        if (y > 5)
                        {
                            Rectangle circleRect = new Rectangle(x * 100 + 10, y * 100 + 10, 80, 80);
                            graphics.FillEllipse(Brushes.Brown, circleRect);
                        }
                    }

                }
            }
        }
    }
}
