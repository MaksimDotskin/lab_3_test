namespace Lab_Dotskin
{
    partial class MyForm: Form
    {

        PictureBox pictureBox1;
        Label label_info;
        Label label_view;
        Label label_form;

        public MyForm()
        {
            pictureBox1= new PictureBox();
            pictureBox1.Width= 200;
            pictureBox1.Height= 200;

            label_info= new Label();
            label_info.Width= 20;
            label_info.Height= 20;
            label_info.Text = "!";
            label_info.Location = new Point(150, 50);
        }
    }
}