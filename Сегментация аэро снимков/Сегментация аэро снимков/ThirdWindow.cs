using System;
using System.Drawing;
using System.Windows.Forms;

namespace Сегментация_аэро_снимков
{
    public partial class ThirdWindow : Form
    {
        SecondWindowForm secondWindowForm = new SecondWindowForm();
        GlavOkno GlavOkno = new GlavOkno();
        UGIVar UGIVar = new UGIVar();
        Graphics graphics;
        Point[,] point = new Point[,] {};

        public byte maxR, maxG, maxB, NDVI;
        public int Nx, Ny, NxRED, NyRED, NxNIR, NyNIR, KolPokr, NomPokr;

        public float x, y, z, zmax, zmin, mass, massl, delz;
        public float[,] Zmas = new float[1024, 1024];
        public double DelUrR;
        public int[,] PloshUrCveta = new int[UGIVar.MaxKolSnim, UGIVar.MaxKolUr];
        

        public ThirdWindow()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
        }

        //-------------------------------------------------------------------------------------------------------------

        private void ClearImg(PictureBox img)
        {
            int nx = img.Width;
            int ny = img.Height;

            Graphics graphics;
            graphics = Graphics.FromImage(new Bitmap(img.Width, img.Height));
            for (int j = 0; j < ny-1; j++)
            {
                //graphics.DrawLines(new Pen[0,j]);
            }
        }

        private void GetRGB(int i, byte r, byte g, byte b)
        {
            int i1 = i / 256;
            r = Convert.ToByte(i - 256 * i1);
            int i2 = i1 / 256;
            g = Convert.ToByte(i1 - i2 * 256);
            b = Convert.ToByte(i2);
        }
        //----------------------------------------------------------
        private void CvetImg(PictureBox img, int nomSv) //ВЫЯСНЕНИЕ КАКОГО ЦВЕТА ИЗОБРАЖЕНИЕ
        {
            bool PrR, PrG, PrB, PrSer, PrRGB;
            int Cvet, KolR, KolG, KolB, KolObsh;
            int KolSer = 0;
            byte r = 0, g = 0, b = 0;

            graphics = Graphics.FromImage(new Bitmap(img.Image));

            PrR = false; PrG = false; PrB = false;
            PrSer = false; PrRGB = false;

            maxR = 0; maxG = 0; maxB = 0;
            KolR = 0; KolG = 0; KolB = 0;
            KolObsh = Nx * Ny;
            for (int j = 0; j < Ny - 1; j++)
                for (int i = 0; i < Nx - 1; i++)
                {
                    Cvet = Convert.ToInt32(point[i, j]);
                    GetRGB(Cvet, r, g, b);
                    if (r > maxR) maxR = r;
                    if (g > maxG) maxG = g;
                    if (b > maxB) maxB = b;

                    if (r > 0 & g == 0 & b == 0)
                        KolR = KolR + 1;
                    if (r == 0 & g > 0 & b == 0)
                        KolG = KolG + 1;
                    if (r == 0 & g == 0 & b > 0)
                        KolB = KolB + 1;
                    if (r == g && g == b)
                        KolSer = KolSer + 1;
                }
            if (KolSer == KolObsh)
                PrSer = true; //Серый, т.е. черно-белый красный цвет
            if (KolR > 0 & KolG == 0 & KolB == 0)
                PrR = true; //Красный цвет
            if (KolR == 0 & KolG > 0 & KolB == 0)
                PrG = true; //Зеленый цвет
            if (KolR == 0 & KolG == 0 & KolB > 0)
                PrB = true; //Синий цвет
            if (!PrSer | !PrR | !PrG | !PrB)
                PrRGB = true; //Цветной немонохронный

            nomSv = 5;
            if (PrSer)
                nomSv = 0; //Черно-белый
            if (PrR)
                nomSv = 1; //Красный цвет
            if (PrG)
                nomSv = 2; //Зеленый цвет
            if (PrB)
                nomSv = 3; //Синий цвет
            if (PrRGB)
                nomSv = 4; //Цветной немонохронный
        }
        //--------------------------------------------
        private void ImgScr()
        {
            for (int j = 1; j < Ny; j++)
            {
                for (int i = 1; i < Nx; i++)
                {
                    // graphics = Graphics.FromImage(image);
                }
            }
        }


        private void BtnRaschetNDVI_Click(object sender, EventArgs e)
        {
            int per;
            int cvet = 0;
            byte R, G, B, R1 = 0, G1 = 0, B1 = 0, R2 = 0, G2 = 0, B2 = 0;
            //secondWindowForm.pictRed = new Bitmap(secondWindowForm.OpenFile.);
            Bitmap redBitmap = new Bitmap(secondWindowForm.pictRed.Image);//------Ошибка
            Bitmap nirBitmap = new Bitmap(secondWindowForm.pictNir.Image);//------Ошибка
            Bitmap rassBitmap = new Bitmap(image4.Image);

            Bitmap redOutput = new Bitmap(redBitmap.Width, redBitmap.Height);
            Bitmap nirOutput = new Bitmap(nirBitmap.Width, nirBitmap.Height);

            if (NxRED == NxNIR & NyRED == NyNIR)
            {
                Nx = secondWindowForm.pictRed.Width;
                Ny = secondWindowForm.pictRed.Height;
            }

            else
            {
                MessageBox.Show("Размеры RED и NIR не совпадают");
                BtnRaschetNDVI.Visible = false;
            }
            ScrBxInpImg.Visible = false;
            ClearImg(secondWindowForm.pictNir);

            int KR = 1; int KG = 256; int KB = 256 * 256; int KCHB = KR + KG + KB;

            image4.Width = Nx;
            image4.Height = Ny;

            for (int j = 1; j < Ny; j++)
            {
                for (int i = 1; i < Nx; i++)
                {
                    cvet = Convert.ToInt32(redOutput.GetPixel(i - 1, j - 1));
                    GetRGB(cvet, R1, G1, B1);
                    cvet = Convert.ToInt32(nirOutput.GetPixel(i - 1, j - 1));
                    GetRGB(cvet, R2, G2, B2);
                    R = R1; G = R2; B = 0;
                    if (secondWindowForm.NDVIForm1.Checked)
                        y = R1 - R2;
                    else
                        y = R2 - R1;
                    x = R1 + R2;
                    if (x == 0)
                    {
                        z = 1;  //или z=1
                        z = -1; //или z=1
                        z = 0;  //или z=0
                        z = 0;  //Выберем последнее
                    }
                    else
                        z = y / x;
                    Zmas[i - 1, j - 1] = z;
                }
            }
            //Отображение в виде чернобелого изображения
            //Поиск Zmin и Zmax
            zmin = 1;
            zmax = -1;
            for (int j = 1; j < Ny; j++)
            {
                for (int i = 1; i < Nx; i++)
                {
                    z = Zmas[i - 1, j - 1];
                    if (z < zmin) zmin = z;
                    if (z > zmax) zmax = z;
                }
            }
            //Выбор Zmin и Zmax
            if (RGrMaxMinNVDI1.Checked)
            {
                zmin = -1;
                zmax = 1;
            }

            //Вычислим масштаб mass-для отображения NDVI
            //и масштаб mass1-для отображения раскраски

            if (zmax - zmin > 1.0E-20)   // zmax <> zmin
                mass = 255 / (zmax - zmin);
            else
            {
                if (zmax > 0.5)
                    mass = 1;
                else
                    mass = 0;
            }
            massl = 255 / 2;//--

            // * * * * * * * Запись в виде Img * * * * * * * *
            for (int j = 1; j < Ny; j++)
            {
                for (int i = 1; i < Nx; i++)
                {
                    z = Zmas[i - 1, j - 1];     /* z-истинное значение NDVI
                    вычислим яркость для отображения z масштабе mass
                    обозначив ее через NDVI
                    и ее записываем в image4 */
                    NDVI = Convert.ToByte(Math.Round(mass * (z - zmin)));
                    per = Convert.ToInt32(rassBitmap.GetPixel(i - 1, j - 1));
                    per = KCHB * NDVI;
                }
            }

            if (image5.Image != null)
            {
                image4.Image = new Bitmap(image5.Image);
            }
        }


        private void BtnRaskraska_Click(object sender, EventArgs e)
        {
            int[] top = new int[32];
            int cvet, KolPix, KonSumPix, PLpixel;
            byte nur;
            double PL;
            string[] st2 = new string[32];

            image5.Width = Nx;
            image5.Height = Ny;
            Bitmap image4Bit = new Bitmap(image4.Width, image4.Height);
            Bitmap image5Bit = new Bitmap(image5.Image);

            int KR = 1, KG = 256, KB = 256 * 256, KCHB = KR + KG + KB;

            for (nur = 1; nur<UGIVar.KolUr+1; nur++)
            {
                top[nur] = 272 - (Convert.ToInt32(Math.Round((nur - 1) * DelUrR)));
            }
            //Выполнение сегментации
            LbKolPix.Text = Convert.ToString(UGIVar.KolUr);
            for (nur =1; nur<UGIVar.KolUr; nur++)
            {
                PloshUrCveta[nur, UGIVar.NomGod] = 0;
            }

            for(int j = 0; j < Ny-1; j++)
            {
                for (int i = 0; i < Nx-1; i++)
                {
                    cvet = Convert.ToInt32(image4Bit.GetPixel(i, j));
                    NDVI = Convert.ToByte(cvet / KCHB);
                    z = zmin + (NDVI / mass);

                    nur = 1;
                    while (UGIVar.VgrUr[nur] < z)
                    {
                        nur = Convert.ToByte(nur + 1);
                        nur++;
                    }

                    if (nur > UGIVar.KolUr)
                        nur = Convert.ToByte(UGIVar.KolUr);

                    image5Bit.GetPixel(i, j) = UGIVar.MasStdClr[UGIVar.NomColorUr[nur]].Zn;
                    UGIVar.PloshUrCveta[nur, UGIVar.NomGod] = UGIVar.PloshUrCveta[nur, UGIVar.NomGod] + 1;
                }
            }
            image5.Width = image5.Image.Width;
            image5.Height = image5.Image.Height;

            PL = 0; //initialited
            for (nur=1; nur<UGIVar.KolUr; nur++)
            {
                PLpixel = UGIVar.PloshUrCveta[nur, UGIVar.NomGod];
                if (UGIVar.NomEdIzmPL <= 0) //Пискел
                    PL = PLpixel;
                if (UGIVar.NomEdIzmPL == 1) //кв. м.
                {
                    if (UGIVar.NomEdIzmRaz == 0) //кв. м.
                        PL = PLpixel * UGIVar.Razr * UGIVar.Razr;
                    if (UGIVar.NomEdIzmRaz == 1)    //кв. км.
                        PL = PLpixel * UGIVar.Razr * UGIVar.Razr * 1000000;
                }
                if(UGIVar.NomEdIzmPL==2)
                {
                    if (UGIVar.NomEdIzmRaz == 0)   //кв. м.
                        PL = PLpixel * UGIVar.Razr * UGIVar.Razr / 1000000.0;
                    if (UGIVar.NomEdIzmRaz == 1)   //кв. км.
                        PL = PLpixel * UGIVar.Razr * UGIVar.Razr;
                }
                UGIVar.PloshUrCvetaReal[nur, UGIVar.NomGod] = PL;
                st2[nur] = Convert.ToString(PL);
            }

            //  Показ или скрывание меток La...

            scrlbx1.Visible = true;
            //----Контрольная сумма пикселей----
            KolPix = Nx * Ny;
            KonSumPix = 0;
            for (nur = 1; nur < UGIVar.KolUr; nur++)
                KonSumPix = KonSumPix + UGIVar.PloshUrCveta[nur, UGIVar.NomGod];
            LbKolPix.Text = "Общ. кол. = " + Convert.ToString(KolPix);
            LbKonSum.Text = "По контр. сумме = " + Convert.ToString(KonSumPix);
            LbKolPix.Visible = true;
            LbKonSum.Visible = true;
            RadioGroup1.Visible = true;
            lbl3.Visible = true;
            scrlbx1.Visible = true;
            rg2.Visible = true;

            lblRASKR.Visible = true;
            lblRASKR.Text = "Результат раскраски:";
            btnSaveRaskraska.Visible = true;
            grpSlktClrPkr.Visible = true;
            btnShowRaskr.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
            secondWindowForm.Close();
            GlavOkno.Close();
        }


    }
}
