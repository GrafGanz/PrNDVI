using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сегментация_аэро_снимков
{
    public partial class Shablon : Form
    {
        public Shablon()
        {
            InitializeComponent();
        }
        UGIVar UGIVar = new UGIVar();
        SaveFileDialog dlgSavel;
            int i, j, k, l, il, jl, i2, j2, i3, j3, i4, j5, i5;

        private void BtnLoadFromFL_Click(object sender, EventArgs e)
        {
            string[] str = new string[40];

            str[1]= "Таблица соответствия интервалов NDVI,покровов и цветов ";
            str[2]= "Количество уровней:";
            str[3]= "8";
            str[4]= "+-------+---------+---------+-------+------------------------";
            str[5]= " Номер  | Нижняя  | Верхняя | Номер | Покров";
            str[6]= " уровня | граница | граница | цвета |";
            str[7]= "+-------+---------+---------+-------+------------------------";
            str[8]= "   1       -1         -0.5      1     Ничего нетy";
            str[9]= "   2       -0.5       -0.25     8     Искусственные материалы";
            str[10]= "   3       -0.25      -0.05     13    Вода";
            str[11]= "   4       -0.05       0        15    Снег и лед";
            str[12]= "   5        0          0.25     16    Облака";
            str[13]= "   6        0.25       0.5      9     Открытая почва";
            str[14]= "   7        0.5        0.7      7     Разреженная растительность";
            str[15]= "   8        0.7        1        3     Густая растительность";

            richTextBox1.Clear();
            for(int i = 1; i < 15; i++)
            {
                richTextBox1.Lines = str;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        int[]dx = new int[10];
            int[] ik = new int[10];
            int[] i0 = new int[10];
            int[]jk = new int[300];
            int[] j0 = new int[300];
            int KoLStb, NomStb, KoLStr, NomStr, dy;
            string txt;



        private void BtnVisTabStdClr_Click(object sender, EventArgs e)
        {
            KoLStb = 4;
            dx[1] = 40;
            dx[2] = 40;
            dx[3] = 65;
            dx[4] = 90;

            KoLStr = 17;
            dy= 16;

            i0[1] = 5;
            for (k = 2; k < KoLStb; k++) //Здесь к-номер столбца
                i0[k] = i0[k - 1] + dx[k - 1];
            for(k=1; k < KoLStb; k++)
                ik[k]= i0[k] + dx[k];

            j0[1]= 2;
            for(k = 1; k < KoLStr; k++) //Здесь к-номер строки
                j0[k]= j0[k - 1] + dy;
            for(k = 1; k < KoLStr; k++)
                jk[k]= j0[k] + dy;

            ImgCveta.Width = ik[KoLStb] - i0[1] + 10;
            ImgCveta.Height = jk[KoLStr] - j0[1] + 10;

            Bitmap bitmapImg = new Bitmap(ImgCveta.Width, ImgCveta.Height);
            Graphics graphics = Graphics.FromImage(bitmapImg);
            Pen myPen = new Pen(Color.Black);
            // Create font and brush.
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            NomStb = 1;
            for(NomStr = 1; NomStr < KoLStr; NomStr++)
            {
                i = i0[NomStb] + 5;
                j = j0[NomStr] + 2;

                if (NomStr == 1)
                    txt = "Номер";
                else
                    txt = " " + Convert.ToString(NomStr - 1);
                graphics.DrawString(txt, drawFont, drawBrush, i, j);
            }

            NomStb = 2;
            for(NomStr = 1; NomStr < KoLStr; NomStr++)
            {
                if (NomStr == 1)
                {
                    i = i0[NomStb] + 5;
                    j = j0[NomStr] + 2;
                    txt = "Цвет";
                    graphics.DrawString(txt, drawFont, drawBrush, i, j);
                }
                else
                    for (i = i0[NomStb]; i < ik[NomStb]; i++)
                        for (j = j0[NomStr]; j < KoLStr * dy; j++)
                            bitmapImg.GetPixel(i, j) = UGIVar.MasStdClr[NomStr - 1].Zn;
            }

            NomStb = 3;
            for(NomStr=1;NomStb<KoLStr; NomStb++)
            {
                i = i0[NomStb] + 5;
                j = j0[NomStr] + 2;

                if (NomStr == 1)
                    txt = "Англ. назв.";
                else
                    txt = UGIVar.MasStdClr[NomStr - 1].NmEng;
                graphics.DrawString(txt, drawFont, drawBrush, i, j);
            }

            NomStb = 4;
            for (NomStr = 1; NomStr < KoLStr; NomStr++)
            {
                i = i0[NomStb] + 5;
                j = j0[NomStr] + 2;
                if (NomStr == 1)
                    txt = "Русск. назв.";
                else
                    txt = UGIVar.MasStdClr[NomStr - 1].NmRus;
                graphics.DrawString(txt, drawFont, drawBrush, i, j);
            }

            for (k = 1; k < KoLStr; k++)
            {
                j = j0[k];
                graphics.DrawLine(myPen, new Point(i0[1], j), new Point(ik[KoLStb], j));
            }
            j = jk[KoLStr];
            graphics.DrawLine(myPen, new Point(i0[1], j), new Point(ik[KoLStb], j));

            for (k = 1; k < KoLStb; k++)
            {
                i = i0[k];
                graphics.DrawLine(myPen, new Point(i, j0[1]), new Point(i, jk[KoLStr]));
            }
            i = ik[KoLStb];
            graphics.DrawLine(myPen, new Point(i, j0[1]), new Point(i, jk[KoLStr]));
        }

        private void BtnSaveToFL_Click(object sender, EventArgs e) //Сохранить в файл - не закончена
        {
            string FLNm;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FLNm = saveFileDialog1.FileName;
            
            MessageBox.Show("Файл сохранен");
            
        }

    }
}
