using System;
using System.Collections;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dotskin_lab_3
{
    public partial class Form2 : Form
    {
        MenuStrip mainMenu;
        ToolStripMenuItem menuFile, menuOpen, menuSave, menuExit, menuInfo, menuTheme, menuToggleTheme;
        Label labelSec1, labelSec2, labelSearch;
        Panel panel;
        ComboBox comboBoxSec1, comboBoxSec2;
        public ListBox listBoxSection1, listBoxSection2, listBoxSearch;
        RichTextBox richTextbox;
        Button buttonMoveToSec2, buttonMoveToSec1, buttonMoveAllToSec2, buttonMoveAllToSec1,
               buttonSortSec1, buttonClearSec1, buttonAdd, buttonDelete, buttonSortSec2,
               buttonClearSec2, buttonSearch, buttonReset, buttonExit, buttonStart;
        GroupBox groupBoxSearch, groupBoxWordsSet;
        TextBox textBox;
        CheckBox checkBoxSec1, checkBoxSec2;
        RadioButton radioAll, radioNum, radioEmail;

        bool isDarkTheme = false;


        public Form2()
        {
            this.Height = 700;
            this.Width = 900;

            this.Text = "Редактор";

            mainMenu= new MenuStrip();

            menuFile = new ToolStripMenuItem("File");
            menuFile.Text = "Файл";


            menuOpen = new ToolStripMenuItem("File");
            menuOpen.Text = "Открыть файл";
            menuOpen.ShortcutKeys = Keys.Control | Keys.O;
            menuOpen.Click += new System.EventHandler(menuOpenClick);
            

            menuSave = new ToolStripMenuItem("File");
            menuSave.Text = "Сохранить 2 раздел";
            menuSave.ShortcutKeys = Keys.Control | Keys.S;

            menuSave.Click += new System.EventHandler(menuSaveClick);
            


            menuExit = new ToolStripMenuItem("File");
            menuExit.Text = "Выйти";
            menuExit.Click += new System.EventHandler(menuExitClick);
            menuExit.ShortcutKeys = Keys.Alt | Keys.X;


            menuInfo = new ToolStripMenuItem("File");
            menuInfo.Text = "?";
            menuInfo.Click += new System.EventHandler(menuInfoClick);

            menuTheme = new ToolStripMenuItem("File");
            menuTheme.Text = "Тема";




            labelSec1 = new Label();
            labelSec1.Text = "Раздел 1";
            labelSec1.Location = new Point(12, 35);
            labelSec1.Size = new Size(55, 20);
            labelSec1.Visible = true;

            labelSec2 = new Label();
            labelSec2.Text = "Раздел 2";
            labelSec2.Location = new Point(310, 35);
            labelSec2.Size = new Size(55, 20);
            labelSec2.Visible = true;

            labelSearch = new Label();
            labelSearch.Text = "Введи искомое слово";
            labelSearch.Location = new Point(30, 420);
            labelSearch.Size = new Size(150, 20);
            labelSearch.Visible = true;

            panel = new Panel();
            panel.Location = new Point(10, 30);
            panel.Name = "Panel1";
            panel.Size = new Size(500, 620);
            panel.BorderStyle = BorderStyle.Fixed3D;

            listBoxSection1 = new ListBox();
            listBoxSection1.SelectionMode = SelectionMode.MultiExtended;
            listBoxSection1.Location = new Point(20, 90);
            listBoxSection1.Size = new Size(170, 220);
            listBoxSection1.Visible = true;

            listBoxSection2 = new ListBox();
            listBoxSection2.SelectionMode = SelectionMode.MultiExtended;
            listBoxSection2.Location = new Point(310, 90);
            listBoxSection2.Size = new Size(170, 220);
            listBoxSection2.Visible = true;



            comboBoxSec1 = new ComboBox();
            comboBoxSec1.Location = new Point(20, 60);
            comboBoxSec1.Name = "comboBox1";
            comboBoxSec1.Size = new Size(170, 25);
            comboBoxSec1.Text = "Сортировка по...";
            comboBoxSec1.Items.Add("Алфавит (по возрастанию)");
            comboBoxSec1.Items.Add("Алфавит (по убыванию)");
            comboBoxSec1.Items.Add("Длине слова (по возрастанию)");
            comboBoxSec1.Items.Add("Длине слова (по убыванию)");


            comboBoxSec2 = new ComboBox();
            comboBoxSec2.Location = new Point(310, 60);
            comboBoxSec2.Name = "comboBox2";
            comboBoxSec2.Size = new Size(170, 25);
            comboBoxSec2.Text = "Сортировка по...";
            comboBoxSec2.Items.Add("Алфавит (по возрастанию)");
            comboBoxSec2.Items.Add("Алфавит (по убыванию)");
            comboBoxSec2.Items.Add("Длине слова (по возрастанию)");
            comboBoxSec2.Items.Add("Длине слова (по убыванию)");

            buttonSortSec1 = new Button();
            buttonSortSec1.Height = 30;
            buttonSortSec1.Width = 100;
            buttonSortSec1.Text = "Сортировать";
            buttonSortSec1.Location = new Point(50, 310);
            buttonSortSec1.Visible = true;
            buttonSortSec1.Click += new System.EventHandler(buttonSortSec1Click);


            listBoxSearch = new ListBox();
            listBoxSearch.SelectionMode = SelectionMode.MultiExtended;
            listBoxSearch.Location = new Point(30, 470);
            listBoxSearch.Size = new Size(170, 160);
            listBoxSearch.Visible = true;


            richTextbox = new RichTextBox();
            richTextbox.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextbox.Location = new Point(520, 30);
            richTextbox.Size = new Size(350, 470);
            richTextbox.Visible = true;


            groupBoxSearch = new GroupBox();
            groupBoxSearch.Text = "Поиск";
            groupBoxSearch.Location = new Point(20, 400);
            groupBoxSearch.Size = new Size(300, 230);
            groupBoxSearch.Visible = true;

            groupBoxWordsSet = new GroupBox();
            groupBoxWordsSet.Text = "Выбор слов";
            groupBoxWordsSet.Location = new Point(520, 510);
            groupBoxWordsSet.Size = new Size(350, 140);
            groupBoxWordsSet.Visible = true;

            textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.Fixed3D;
            textBox.Height = 50;
            textBox.Width = 170;
            textBox.Text = "";
            textBox.Location = new Point(30, 440);
            textBox.Visible = true;


            buttonMoveToSec2 = new Button();
            buttonMoveToSec2.Height = 30;
            buttonMoveToSec2.Width = 100;
            buttonMoveToSec2.Text = ">";
            buttonMoveToSec2.Location = new Point(200, 100);
            buttonMoveToSec2.Visible = true;
            buttonMoveToSec2.Click += new System.EventHandler(buttonMoveToSec2Click);


            buttonMoveToSec1 = new Button();
            buttonMoveToSec1.Height = 30;
            buttonMoveToSec1.Width = 100;
            buttonMoveToSec1.Text = "<";
            buttonMoveToSec1.Location = new Point(200, 140);
            buttonMoveToSec1.Visible = true;
            buttonMoveToSec1.Click += new System.EventHandler(buttonMoveToSec1Click);


            buttonMoveAllToSec2 = new Button();
            buttonMoveAllToSec2.Height = 30;
            buttonMoveAllToSec2.Width = 100;
            buttonMoveAllToSec2.Text = ">>";
            buttonMoveAllToSec2.Location = new Point(200, 180);
            buttonMoveAllToSec2.Visible = true;
            buttonMoveAllToSec2.Click += new System.EventHandler(buttonMoveAllToSec2Click);



            buttonMoveAllToSec1 = new Button();
            buttonMoveAllToSec1.Height = 30;
            buttonMoveAllToSec1.Width = 100;
            buttonMoveAllToSec1.Text = "<<";
            buttonMoveAllToSec1.Location = new Point(200, 220);
            buttonMoveAllToSec1.Visible = true;
            buttonMoveAllToSec1.Click += new System.EventHandler(buttonMoveAllToSec1Click);


            buttonClearSec1 = new Button();
            buttonClearSec1.Height = 30;
            buttonClearSec1.Width = 100;
            buttonClearSec1.Text = "Очистить";
            buttonClearSec1.Location = new Point(50, 350);
            buttonClearSec1.Visible = true;
            buttonClearSec1.Click+= new System.EventHandler(buttonClearSec1Click);


            buttonAdd = new Button();
            buttonAdd.Height = 30;
            buttonAdd.Width = 100;
            buttonAdd.Text = "Добавить";
            buttonAdd.Location = new Point(200, 310);
            buttonAdd.Visible = true;
            buttonAdd.Click += new System.EventHandler(buttonAddClick);


            buttonDelete = new Button();
            buttonDelete.Height = 30;
            buttonDelete.Width = 100;
            buttonDelete.Text = "Удалить";
            buttonDelete.Location = new Point(200, 350);
            buttonDelete.Visible = true;
            buttonDelete.Click += new System.EventHandler(buttonDeleteClick);


            buttonSortSec2 = new Button();
            buttonSortSec2.Height = 30;
            buttonSortSec2.Width = 100;
            buttonSortSec2.Text = "Сортировать";
            buttonSortSec2.Location = new Point(350, 310);
            buttonSortSec2.Visible = true;
            buttonSortSec2.Click += new System.EventHandler(buttonSortSec2Click);


            buttonClearSec2 = new Button();
            buttonClearSec2.Height = 30;
            buttonClearSec2.Width = 100;
            buttonClearSec2.Text = "Очистить";
            buttonClearSec2.Location = new Point(350, 350);
            buttonClearSec2.Visible = true;
            buttonClearSec2.Click += new System.EventHandler(buttonClearSec2Click);


            buttonSearch = new Button();
            buttonSearch.Height = 70;
            buttonSearch.Width = 100;
            buttonSearch.Text = "Поиск";
            buttonSearch.Location = new Point(210, 550);
            buttonSearch.Visible = true;
            buttonSearch.Click += new System.EventHandler(buttonSearchClick);


            buttonReset = new Button();
            buttonReset.Height = 70;
            buttonReset.Width = 170;
            buttonReset.Text = "Сброс";
            buttonReset.Location = new Point(330, 480);
            buttonReset.Visible = true;
            buttonReset.Click += new System.EventHandler(buttonResetClick);


            buttonExit = new Button();
            buttonExit.Height = 70;
            buttonExit.Width = 170;
            buttonExit.Text = "Выход";
            buttonExit.Location = new Point(330, 560);
            buttonExit.Visible = true;
            buttonExit.Click += new System.EventHandler(buttonExitClick);


            buttonStart = new Button();
            buttonStart.Height = 70;
            buttonStart.Width = 100;
            buttonStart.Text = "Начать";
            buttonStart.Location = new Point(760, 550);
            buttonStart.Visible = true;
            buttonStart.Click += new System.EventHandler(buttonStartClick);


            checkBoxSec1 = new CheckBox();
            checkBoxSec1.Text = "Раздел 1";
            checkBoxSec1.Location = new Point(210, 470);
            checkBoxSec1.Visible = true;

            checkBoxSec2 = new CheckBox();
            checkBoxSec2.Location = new Point(210, 490);
            checkBoxSec2.Text = "Раздел 2";
            checkBoxSec2.Visible = true;

            radioAll = new RadioButton();
            radioAll.Text = "Все";
            radioAll.Location = new Point(540, 540);
            radioAll.Size = new Size(50, 20);
            radioNum = new RadioButton();
            radioNum.Text = "Содержащие цифры";
            radioNum.Location = new Point(540, 570);
            radioNum.Size = new Size(150, 20);
            radioEmail = new RadioButton();
            radioEmail.Text = "Содержащие 'e-mail'";
            radioEmail.Location = new Point(540, 600);
            radioEmail.Size = new Size(150, 20);
            radioAll.Visible = true;
            radioNum.Visible = true;
            radioEmail.Visible = true;

            menuToggleTheme = new ToolStripMenuItem();
            menuToggleTheme.Height = 30;
            menuToggleTheme.Width = 100;
            menuToggleTheme.Text = "Переключить тему";
            menuToggleTheme.ShortcutKeys = Keys.Control | Keys.T;
            menuToggleTheme.Click += new System.EventHandler(buttonToggleTheme_Click);

            Controls.AddRange(new Control[] { mainMenu,richTextbox,labelSec1,labelSec2,comboBoxSec1,comboBoxSec2,
                listBoxSection1, listBoxSection2,buttonMoveAllToSec1,buttonMoveAllToSec2,buttonMoveToSec1,buttonMoveToSec2,
                buttonClearSec1,buttonClearSec2,buttonSortSec1,buttonSortSec2,  buttonAdd,buttonDelete,
                labelSearch, textBox,listBoxSearch,checkBoxSec1,checkBoxSec2,buttonSearch,groupBoxSearch,buttonReset,buttonExit,
                panel,radioAll,radioNum,radioEmail,buttonStart,groupBoxWordsSet
            });;
            mainMenu.Items.Add(menuFile);
            mainMenu.Items.Add(menuInfo);
            mainMenu.Items.Add(menuTheme);
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpen, menuSave, menuExit });

            menuTheme.DropDownItems.Add(menuToggleTheme);

            SetLightTheme();
        }
        private void SetLightTheme()
        {

            foreach (Control control in Controls)
            {
                control.ForeColor = Color.Black ;
            }
            foreach (ToolStripItem item in menuFile.DropDownItems)
            {
                item.BackColor = default;
                item.ForeColor = Color.Black;
            }
            menuToggleTheme.BackColor = default;
            menuToggleTheme.ForeColor = Color.Black;

            comboBoxSec1.BackColor = default;
            comboBoxSec2.BackColor = default;

            this.BackColor = SystemColors.Control;
            mainMenu.BackColor = SystemColors.Control;
            mainMenu.ForeColor = SystemColors.ControlText;

            labelSec1.BackColor = labelSec2.BackColor = labelSearch.BackColor = SystemColors.Control;
            panel.BackColor = SystemColors.ControlLight;
            listBoxSection1.BackColor = listBoxSection2.BackColor = listBoxSearch.BackColor = SystemColors.Window;
            groupBoxSearch.BackColor = groupBoxWordsSet.BackColor = SystemColors.Control;
            textBox.BackColor = SystemColors.Window;
            richTextbox.BackColor = SystemColors.Window;
            radioAll.BackColor = radioNum.BackColor = radioEmail.BackColor = SystemColors.Control;

        }

        private void SetDarkTheme()

        {
            foreach (Control control in Controls)
            {
                control.ForeColor = Color.White;
            }
            foreach (ToolStripItem item in menuFile.DropDownItems)
            {
                item.BackColor = Color.FromArgb(30, 30, 30);
                item.ForeColor = Color.White;
            }
            menuToggleTheme.BackColor = Color.FromArgb(30, 30, 30);
            menuToggleTheme.ForeColor = Color.White;


            comboBoxSec1.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxSec2.BackColor = Color.FromArgb(30, 30, 30);






            this.BackColor = Color.FromArgb(30, 30, 30);
            mainMenu.BackColor = Color.FromArgb(30, 30, 30);
            mainMenu.ForeColor = Color.White;


            labelSec1.BackColor = labelSec2.BackColor = labelSearch.BackColor = Color.FromArgb(30, 30, 30);
            panel.BackColor = Color.FromArgb(50, 50, 50);
            listBoxSection1.BackColor = listBoxSection2.BackColor = listBoxSearch.BackColor = Color.FromArgb(40, 40, 40);
            groupBoxSearch.BackColor = groupBoxWordsSet.BackColor = Color.FromArgb(50, 50, 50);
            textBox.BackColor = Color.FromArgb(60, 60, 60);
            richTextbox.BackColor = Color.FromArgb(40, 40, 40);
            radioAll.BackColor = radioNum.BackColor = radioEmail.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void buttonToggleTheme_Click(object sender, EventArgs e)
        {
            if (isDarkTheme)
            {
                SetLightTheme();
            }
            else
            {
                SetDarkTheme();
            }

            isDarkTheme = !isDarkTheme;
        }

        private void menuOpenClick(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextbox.Text = Reader.ReadToEnd();
                Reader.Close();
            }
        }
        private void menuSaveClick(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBoxSection2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBoxSection2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }
        private void menuExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonMoveToSec2Click(object sender, EventArgs e)
        {
            listBoxSection2.BeginUpdate();
            foreach (object Item in listBoxSection1.SelectedItems)
            {
                listBoxSection2.Items.Add(Item);
            }
            listBoxSection1.Items.RemoveAt(listBoxSection1.SelectedIndex);
            listBoxSection2.EndUpdate();
        }

        private void buttonMoveToSec1Click(object sender, EventArgs e)
        {
            listBoxSection1.BeginUpdate();
            foreach (object Item in listBoxSection2.SelectedItems)
            {
                listBoxSection1.Items.Add(Item);
            }
            listBoxSection2.Items.RemoveAt(listBoxSection2.SelectedIndex);
            listBoxSection1.EndUpdate();
        }
        private void buttonMoveAllToSec2Click(object sender, EventArgs e)
        {
            listBoxSection2.Items.AddRange(listBoxSection1.Items);
            listBoxSection1.Items.Clear();
        }
        private void buttonMoveAllToSec1Click(object sender, EventArgs e)
        {
            listBoxSection1.Items.AddRange(listBoxSection2.Items);
            listBoxSection2.Items.Clear();
        }

        private void buttonSortSec1Click(object sender, EventArgs e)
        {
            if (comboBoxSec1.Text == "Алфавит (по возрастанию)")
                listBoxSection1.Sorted = true;
            else if (comboBoxSec1.Text == "Алфавит (по убыванию)")
            {
                listBoxSection1.Sorted = false;
                ArrayList list = new ArrayList();
                foreach (var item in listBoxSection1.Items)
                {
                    list.Add(item);
                }
                list.Sort();
                list.Reverse();
                listBoxSection1.Items.Clear();
                foreach (var item in list)
                {
                    listBoxSection1.Items.Add(item);
                }
            }
            else if (comboBoxSec1.Text == "Длине слова (по возрастанию)")
            {
                listBoxSection1.Sorted = false;
                for (int i = 0; i < listBoxSection1.Items.Count; i++)
                {
                    for (int j = i; j < listBoxSection1.Items.Count; j++)
                    {
                        if (listBoxSection1.Items[i].ToString().Length > listBoxSection1.Items[j].ToString().Length)
                        {
                            string temp;
                            temp = listBoxSection1.Items[i].ToString();
                            listBoxSection1.Items[i] = listBoxSection1.Items[j];
                            listBoxSection1.Items[j] = temp;
                        }
                    }
                }
            }
            else if (comboBoxSec1.Text == "Длине слова (по убыванию)")
            {
                listBoxSection1.Sorted = false;
                for (int i = 0; i < listBoxSection1.Items.Count; i++)
                {
                    for (int j = i; j < listBoxSection1.Items.Count; j++)
                    {
                        if (listBoxSection1.Items[j].ToString().Length > listBoxSection1.Items[i].ToString().Length)
                        {
                            string temp;
                            temp = listBoxSection1.Items[j].ToString();
                            listBoxSection1.Items[j] = listBoxSection1.Items[i];
                            listBoxSection1.Items[i] = temp;
                        }
                    }
                }
            }
        }
        private void buttonClearSec1Click(object sender, EventArgs e)
        {
            listBoxSection1.Items.Clear();
        }
        private void buttonAddClick(object sender, EventArgs e)
        {
            Form3 AddRec = new Form3();

            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void buttonDeleteClick(object sender, EventArgs e)
        {
            if (listBoxSection2.Text == "")
                listBoxSection1.Items.RemoveAt(listBoxSection1.SelectedIndex);
            if (listBoxSection1.Text == "")
                listBoxSection2.Items.RemoveAt(listBoxSection2.SelectedIndex);
        }
        private void buttonSortSec2Click(object sender, EventArgs e)
        {
            if (comboBoxSec2.Text == "Алфавит (по возрастанию)")
                listBoxSection2.Sorted = true;
            else if (comboBoxSec2.Text == "Алфавит (по убыванию)")
            {
                listBoxSection2.Sorted = false;
                ArrayList list = new ArrayList();
                foreach (var item in listBoxSection2.Items)
                {
                    list.Add(item);
                }
                list.Sort();
                list.Reverse();
                listBoxSection2.Items.Clear();
                foreach (var item in list)
                {
                    listBoxSection2.Items.Add(item);
                }
            }
            else if (comboBoxSec2.Text == "Длине слова (по возрастанию)")
            {
                listBoxSection2.Sorted = false;
                for (int i = 0; i < listBoxSection2.Items.Count; i++)
                {
                    for (int j = i; j < listBoxSection2.Items.Count; j++)
                    {
                        if (listBoxSection2.Items[i].ToString().Length > listBoxSection2.Items[j].ToString().Length)
                        {
                            string temp;
                            temp = listBoxSection2.Items[i].ToString();
                            listBoxSection2.Items[i] = listBoxSection2.Items[j];
                            listBoxSection2.Items[j] = temp;
                        }
                    }
                }
            }
            else if (comboBoxSec2.Text == "Длине слова (по убыванию)")
            {
                listBoxSection2.Sorted = false;
                for (int i = 0; i < listBoxSection2.Items.Count; i++)
                {
                    for (int j = i; j < listBoxSection2.Items.Count; j++)
                    {
                        if (listBoxSection2.Items[j].ToString().Length > listBoxSection2.Items[i].ToString().Length)
                        {
                            string temp;
                            temp = listBoxSection2.Items[j].ToString();
                            listBoxSection2.Items[j] = listBoxSection2.Items[i];
                            listBoxSection2.Items[i] = temp;
                        }
                    }
                }
            }
        }
        private void buttonClearSec2Click(object sender, EventArgs e)
        {
            listBoxSection2.Items.Clear();
        }
        private void buttonSearchClick(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();

            string Find = textBox.Text;

            if (checkBoxSec1.Checked)
            {
                foreach (string String in listBoxSection1.Items)
                {
                    if (String.Contains(Find)) listBoxSearch.Items.Add(String);
                }
            }
            if (checkBoxSec2.Checked)
            {
                foreach (string String in listBoxSection2.Items)
                {
                    if (String.Contains(Find)) listBoxSearch.Items.Add(String);
                }
            }
            if (checkBoxSec1.Checked && checkBoxSec2.Checked)
            {
                foreach (string String in listBoxSection2.Items)
                {
                    if (String.Contains(Find)) listBoxSearch.Items.Add(String);
                }
                foreach (string String in listBoxSection1.Items)
                {
                    if (String.Contains(Find)) listBoxSearch.Items.Add(String);
                }
            }
        }
        private void buttonResetClick(object sender, EventArgs e)
        {
            listBoxSection1.Items.Clear();
            listBoxSection2.Items.Clear();
            listBoxSearch.Items.Clear();
            richTextbox.Text = string.Empty;
            textBox.Text = string.Empty;
            radioAll.Checked = false;
            radioNum.Checked = false;
            radioEmail.Checked = false;
            checkBoxSec1.Checked = false;
            checkBoxSec2.Checked = false;
        }

        private void buttonExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStartClick(object sender, EventArgs e)
        {
            listBoxSection1.Items.Clear();
            listBoxSearch.Items.Clear();

            listBoxSection1.BeginUpdate();

            string[] Strings = richTextbox.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();

                if (Str == String.Empty) continue;
                if (radioAll.Checked) listBoxSection1.Items.Add(Str);
                if (radioNum.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBoxSection1.Items.Add(Str);
                }
                if (radioEmail.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBoxSection1.Items.Add(Str);
                }
            }
            listBoxSection1.EndUpdate();
        }
        void menuInfoClick(object sender, EventArgs e)
        {
            MessageBox.Show("Информация о приложении и разработчике");
        }
    }
}
