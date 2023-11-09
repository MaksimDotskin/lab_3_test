using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Dotskin
{
    public partial class Form2 : Form
    {
        Label label_white;
        Label label_black;
        PictureBox picture_box;
        Rectangle Circle = new Rectangle(200, 200, 150, 150);
        public Form2()
        {

            Width = 1000;
            Height = 1040;
            int last_created_label = 1;//0-white,1-black

            picture_box = new PictureBox();
            picture_box.Width = 1000;
            picture_box.Height = 1035;
            

            //picture_box.Location = new Point(50,50);
            Controls.Add(picture_box);

            
            for (int x = 0; x < 10; x++)
            {

                for (int y = 0; y < 10; y++)
                {
                    if (last_created_label == 1)
                    {
                        label_white = new Label();
                        label_white.Width = 100;
                        label_white.Height = 100;
                        label_white.Location = new Point(x * 100, y * 100);
                        label_white.BackColor = Color.Beige;
                        label_white.SendToBack();
                        picture_box.Controls.Add(label_white);
                        last_created_label = 0;
                     
                    }
                    else if (last_created_label == 0)
                    {
                        label_black = new Label();
                        label_black.Width = 100;
                        label_black.Height = 100;
                        label_black.Location = new Point(x * 100, y * 100);
                        label_black.BackColor = Color.Brown;
                        label_black.SendToBack();
                        picture_box.Controls.Add(label_black);
                        last_created_label = 1;
                        



                    }


                }
                if (last_created_label == 0) { last_created_label = 1; }
                else { last_created_label = 0; }

            }
            
            picture_box.Paint += new PaintEventHandler(_Paint);
            void _Paint(object sender, PaintEventArgs e)
            {
                Graphics graphics = e.Graphics;
    
                
                    

                 
               graphics.FillEllipse(Brushes.White, Circle);





            }
           
        }
    }
}
