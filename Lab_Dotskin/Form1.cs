using System.Security.Cryptography.X509Certificates;

namespace Lab_Dotskin
{
    public partial class Form1 : Form
    {
   
       
        PictureBox pictureBox1;
        Label label_info, label_view, label_form;

        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);

        bool rentangle_clicked = false;
        bool circle_clicked=false;
        bool square_clicked = false;  

        int rentangle_x=0, rentangle_y=0;
        int circle_x=0, circle_y=0;
        int square_x=0, square_y=0;

        int X,Y,dX,dY;
        int LastClicked;

       


        public Form1()
        {
            this.Width= 1000;
            this.Height=700;

            pictureBox1 = new PictureBox();
            pictureBox1.Width = 1000;
            pictureBox1.Height = 700;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Paint += new PaintEventHandler(_Paint);
            this.Controls.Add(pictureBox1);

            label_info = new Label();
            label_info.Width = 200;
            label_info.Height = 150;
            label_info.Location = new Point(750, 450);
            label_info.Text = "Info";
            label_info.BackColor= Color.DarkGray;
            pictureBox1.Controls.Add(label_info);

            label_form = new Label();
            label_form.Width= 200;
            label_form.Height = 150;
            label_form.Location = new Point(400, 450);
            label_form.Text = "Form";
            label_form.BackColor = Color.DarkGray;
            pictureBox1.Controls.Add(label_form);

            label_view = new Label();
            label_view.Width = 200;
            label_view.Height = 150;
            label_view.Location = new Point(50, 450);
            label_view.Text = "View";
            label_view.BackColor = Color.DarkGray;
            pictureBox1.Controls.Add(label_view);

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;

            void _Paint(object sender, PaintEventArgs e)
            {


                Graphics graphics = e.Graphics;
                graphics.FillEllipse(Brushes.Red, Circle);
                graphics.FillRectangle(Brushes.Blue, Square);
                graphics.FillRectangle(Brushes.Yellow, Rectangle);
            }
            void PictureBox1_MouseDown(object sender, MouseEventArgs e)
            {
                if (Rectangle.Contains(e.X, e.Y))
                {
                    rentangle_clicked = true;
                    rentangle_x = e.X - Rectangle.X;
                    rentangle_y = e.Y - Rectangle.Y;
                    
                }
                else if (Circle.Contains(e.X, e.Y))
                {
                    circle_clicked = true;
                    circle_x = e.X - Circle.X;
                    circle_y = e.Y - Circle.Y;
                   
                }
                else if (Square.Contains(e.X, e.Y))
                {
                    square_clicked = true;
                    square_x = e.X - Square.X;
                    square_y = e.Y - Square.Y;
           
                }
            }

            void PictureBox1_MouseMove(object sender, MouseEventArgs e)
            {
                if (rentangle_clicked)
                {
                    Rectangle.X = e.X - rentangle_x;
                    Rectangle.Y = e.Y - rentangle_y;
                }
                else if (circle_clicked)
                {
                    Circle.X = e.X - circle_x;
                    Circle.Y = e.Y - circle_y;
                }
                else if (square_clicked)
                {
                    Square.X = e.X - square_x;
                    Square.Y = e.Y - square_y;
                }

                if ((label_view.Location.X < Square.X + Square.Width) && (label_view.Location.X > Square.X))
                {
                    if ((label_view.Location.Y < Square.Y + Square.Height) && (label_view.Location.Y > Square.Y))
                    {
                        label_info.Text = "Blue scuare";
                    }
                }
                if ((label_view.Location.X < Circle.X + Circle.Width) && (label_view.Location.X > Circle.X))
                {
                    if ((label_view.Location.Y < Circle.Y + Circle.Height) && (label_view.Location.Y > Circle.Y))
                    {
                        label_info.Text = "Red circle";
                    }
                }
                if ((label_view.Location.X < Rectangle.X + Rectangle.Width) && (label_view.Location.X > Rectangle.X))
                {
                    if ((label_view.Location.Y < Rectangle.Y + Rectangle.Height) && (label_view.Location.Y > Rectangle.Y))
                    {
                        label_info.Text = "Yellow Rectangle";
                    }
                }

                pictureBox1.Invalidate();
            }


            void PictureBox1_MouseUp(object sender, MouseEventArgs e)
            {
                rentangle_clicked = false;
                circle_clicked = false;
                square_clicked = false;

                if (LastClicked == 2)
                {
                    if ((label_form.Location.X < Circle.X + Circle.Width) && (label_form.Location.X > Circle.X)) {
                        if ((label_form.Location.Y < Circle.Y + Circle.Height) && (label_form.Location.Y > Circle.Y))
                        {
                            X= Circle.X;
                            Y= Circle.Y;
                            dX= Circle.X;
                            dY= Circle.Y;
                        }
                    
                    }
                }
            }






        }
    }
}