using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Сегментация_аэро_снимков
{
    public partial class SecondWindowForm : Form
    {
        public static Bitmap input;

        public SecondWindowForm()
        {
            InitializeComponent();
        }
        //string path1 = @"E:\Aidar\Дипломка\PrNDVI 26.11.21\Снимки и таблицы\ObnovTab8.txt"; //Путь к файлу
        UGIVar uGIVar = new UGIVar();

        //-------------------------------------------------------------------------------------------------------------
        //ЗАГРУЗКА ИЗОБРАЖЕНИЙ
        private void RedBtn_Click(object sender, EventArgs e) // Выбор RED файла
        {


            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    pictRed.Image = new Bitmap(OpenFile.FileName);
                    input = new Bitmap(pictRed.Image);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Разрешение изображения
            int NxRed = pictRed.Width;
            int NyRed = pictRed.Height;
            LblNxRED.Text = "NxRed = " + Convert.ToString(NxRed);
            LblNyRED.Text = "NyRed = " + Convert.ToString(NyRed);
        }

        private void NirBtn_Click(object sender, EventArgs e) // Выбор NIR файла
        {

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictNir.Image = new Bitmap(OpenFile.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Разрешение изображения
            int NxNir = pictNir.Width;
            int NyNir = pictNir.Height;
            LblNxNIR.Text = "NxRed = " + Convert.ToString(NxNir);
            LblNyNIR.Text = "NyRed = " + Convert.ToString(NyNir);
        }

        //-------------------------------------------------------------------------------------------------------------
        //ПРОСМОТР В ПОЛНОМ РАЗМЕРЕ
        private void fullRedImg_Click(object sender, EventArgs e) //Просмотр в полном размере RED
        {
            ImgFull imgFull = new ImgFull();

            imgFull.Show();
            imgFull.pictImgFull.Image = pictRed.Image;
        }

        private void fullNirImg_Click(object sender, EventArgs e) // Просмотр в полном размере NIR
        {
            ImgFull imgFull = new ImgFull();

            imgFull.Show();
            imgFull.pictImgFull.Image = pictNir.Image;
        }

        //-------------------------------------------------------------------------------------------------------------
        //ВЫБОР ПАЛИТРЫ
        private void RGrRadio1_Click(object sender, EventArgs e)
        {
            //FileStream fileStream = new FileStream(path1, FileMode.Open); //Считывание файла
        }

        private void RGrRadio2_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = OpenFile.FileName;
            MessageBox.Show("Файл открыт");
        }

        private void RGrRadio3_Click(object sender, EventArgs e)
        {
            Shablon shablon = new Shablon();
            shablon.Show();
        }

        //-------------------------------------------------------------------------------------------------------------
        //СОЗДАНИЕ ТАБЛИЦЫ ЦВЕТОВ


        //-------------------------------------------------------------------------------------------------------------
        //ЧЕКБОКСЫ (РАЗРЕШИТЬ ДОСТУП)
        private void checkRedNir_Click(object sender, EventArgs e)
        {
            if (checkRedNir.Checked)
            {
                RedBtn.Enabled = true;
            }
        }

        private void checkPalitra_Click(object sender, EventArgs e)
        {
            if (checkPalitra.Checked == true)
            {
                RGrPalitra.Enabled = true;
            }
            RGrPalitra.Enabled = false;
        }

        private void checkForm_Click(object sender, EventArgs e)
        {
            if (checkForm.Enabled == true)
            {
                rgFormNDVI.Enabled = true;
            }
            rgFormNDVI.Enabled = false;
        }

        private void checkEdIzm_Click(object sender, EventArgs e)
        {
            if (checkEdIzm.Enabled == true)
            {
                checkEdIzm.Enabled = true;
            }
            checkEdIzm.Enabled = false;
        }


        //-------------------------------------------------------------------------------------------------------------
        //GroupBox Палитра
        private void RGrPalitra_Enter(object sender, EventArgs e)
        {
            rgFormNDVI.Enabled = true;

            rgEdIzmPL.Enabled = true;
            btnNDVI.Enabled = true;
        }

        //-------------------------------------------------------------------------------------------------------------
        //ВЫХОД ИЗ ОКНА (BUTTON)
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }



        //-------------------------------------------------------------------------------------------------------------
        //ТАБЛИЦА ЦВЕТОВ
        private void FormCreate( Color[] color)
        {
            //Создаем таблицу стандартный цветов и их номеров:

            uGIVar.MasStdClr[1].Zn = Color.Black;
            uGIVar.MasStdClr[2].Zn = Color.Maroon;
            uGIVar.MasStdClr[3].Zn = Color.Green;
            uGIVar.MasStdClr[4].Zn = Color.Olive;
            uGIVar.MasStdClr[5].Zn = Color.Navy;
            uGIVar.MasStdClr[6].Zn = Color.Purple;
            uGIVar.MasStdClr[7].Zn = Color.Teal;
            uGIVar.MasStdClr[8].Zn = Color.Gray;
            uGIVar.MasStdClr[9].Zn = Color.Silver;
            uGIVar.MasStdClr[10].Zn = Color.Red;
            uGIVar.MasStdClr[11].Zn = Color.Lime;
            uGIVar.MasStdClr[12].Zn = Color.Yellow;
            uGIVar.MasStdClr[13].Zn = Color.Blue;
            uGIVar.MasStdClr[14].Zn = Color.Fuchsia;
            uGIVar.MasStdClr[15].Zn = Color.Aqua;
            uGIVar.MasStdClr[16].Zn = Color.White;

            uGIVar.MasStdClr[1].NmEng = "Black";
            uGIVar.MasStdClr[2].NmEng = "Maroon";
            uGIVar.MasStdClr[3].NmEng = "Green";
            uGIVar.MasStdClr[4].NmEng = "Olive";
            uGIVar.MasStdClr[5].NmEng = "Navy";
            uGIVar.MasStdClr[6].NmEng = "Purple";
            uGIVar.MasStdClr[7].NmEng = "Teal";
            uGIVar.MasStdClr[8].NmEng = "Gray";
            uGIVar.MasStdClr[9].NmEng = "Silver";
            uGIVar.MasStdClr[10].NmEng = "Red";
            uGIVar.MasStdClr[11].NmEng = "Lime";
            uGIVar.MasStdClr[12].NmEng = "Yellow";
            uGIVar.MasStdClr[13].NmEng = "Blue";
            uGIVar.MasStdClr[14].NmEng = "Fuchsia";
            uGIVar.MasStdClr[15].NmEng = "Aqua";
            uGIVar.MasStdClr[16].NmEng = "White";

            uGIVar.MasStdClr[1].NmRus = "Чёрный";
            uGIVar.MasStdClr[2].NmRus = "Тёмно-красный";
            uGIVar.MasStdClr[3].NmRus = "Зелёный";
            uGIVar.MasStdClr[4].NmRus = "Оливковый";
            uGIVar.MasStdClr[5].NmRus = "Темно-синий";
            uGIVar.MasStdClr[6].NmRus = "Пурпурный";
            uGIVar.MasStdClr[7].NmRus = "Стальной";
            uGIVar.MasStdClr[8].NmRus = "Серый";
            uGIVar.MasStdClr[9].NmRus = "Серебрянный";
            uGIVar.MasStdClr[10].NmRus = "Красный";
            uGIVar.MasStdClr[11].NmRus = "Ярко-зелёный";
            uGIVar.MasStdClr[12].NmRus = "Жёлтый";
            uGIVar.MasStdClr[13].NmRus = "Синий";
            uGIVar.MasStdClr[14].NmRus = "Фиолетовый";
            uGIVar.MasStdClr[15].NmRus = "Бирюзовый";
            uGIVar.MasStdClr[16].NmRus = "Белый"; 
        }

        private async void btnNDVI_ClickAsync(object sender, EventArgs e)
        {
            string text;
            if (RGrRadio1.Checked)
            {
                uGIVar.KolUr = 8;
                uGIVar.NgrUr[1] = -1;      uGIVar.VgrUr[1] = -0.5;    uGIVar.NomColorUr[1] = 1;      uGIVar.NamePokrovUr[1] = "Ничего нету";
                uGIVar.NgrUr[2] = -0.5;    uGIVar.VgrUr[2] = -0.25;   uGIVar.NomColorUr[2] = 8;      uGIVar.NamePokrovUr[2] = "Искусств. материалы";
                uGIVar.NgrUr[3] = -0.25;   uGIVar.VgrUr[3] = -0.05;   uGIVar.NomColorUr[3] = 13;     uGIVar.NamePokrovUr[3] = "Вода";
                uGIVar.NgrUr[4] = -0.05;   uGIVar.VgrUr[4] = 0;       uGIVar.NomColorUr[4] = 15;     uGIVar.NamePokrovUr[4] = "Снег и лед";
                uGIVar.NgrUr[5] = 0;       uGIVar.VgrUr[5] = 0.25;    uGIVar.NomColorUr[5] = 16;     uGIVar.NamePokrovUr[5] = "Облака";
                uGIVar.NgrUr[6] = 0.25;    uGIVar.VgrUr[6] = 0.5;     uGIVar.NomColorUr[6] = 9;      uGIVar.NamePokrovUr[6] = "Открытая почва";
                uGIVar.NgrUr[7] = 0.5;     uGIVar.VgrUr[7] = 0.7;     uGIVar.NomColorUr[7] = 7;      uGIVar.NamePokrovUr[7] = "Разреженная почва";
                uGIVar.NgrUr[8] = 0.7;     uGIVar.VgrUr[8] = 1;       uGIVar.NomColorUr[8] = 3;      uGIVar.NamePokrovUr[8] = "Густая растительность";

            }
            Color[] colors = new Color[20];
            
            if (RGrRadio2.Checked)
            {
                using (StreamReader reader = new StreamReader(OpenFile.FileName))
                {
                    text = await reader.ReadToEndAsync();
                    Console.WriteLine(text);
                }
                text = Console.ReadLine();
                text = Console.ReadLine();
                text = Console.ReadLine();
                text = Console.ReadLine();
                text = Console.ReadLine();
                text = Console.ReadLine();
                text = Console.ReadLine();
                for (int i = 1; i < uGIVar.KolUr; i++)
                { 
                    uGIVar.NomUr = Convert.ToInt32(Console.ReadLine());
                    uGIVar.NgrUr[i] = Convert.ToDouble(Console.ReadLine());
                    uGIVar.VgrUr[i] = Convert.ToDouble(Console.ReadLine());
                    uGIVar.NomColorUr[i] = Convert.ToInt32(Console.ReadLine());
                    uGIVar.NamePokrovUr[i] = Convert.ToString(Console.ReadLine());
                    uGIVar.ColorUr[i] = Convert.ToInt32(uGIVar.MasStdClr[uGIVar.NomColorUr[i]].Zn);
                }
                //checkPalitra.Checked = false;
                //uGIVar.NomEdIzmPL=rgEdIzmPL.ite

            if( uGIVar.NomEdIzmPL==0)
            }

            ThirdWindow thirdWindow = new ThirdWindow();
            thirdWindow.Show();
        }
    }
}
