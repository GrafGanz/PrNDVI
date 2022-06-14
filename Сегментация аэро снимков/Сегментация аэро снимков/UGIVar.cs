using System;
using System.Drawing;

namespace Сегментация_аэро_снимков
{
    public class UGIVar
    {
        /*  Структуры для создания новых типов данных   */
        struct God
        {
            public int Znach;
            public string Name;

            public God (int Znach, string Name)
            {
                this.Znach = Znach;
                this.Name = Name;
            }
        }

        public struct Mes
        {
            public int ZnRzdMes, ZnRzdGod, Znach;
            public string Name;

            public Mes(int znRzdMes, int znRzDod, int znach, string name)
            {
                this.ZnRzdMes = znRzdMes;
                this.ZnRzdGod = znRzDod;
                this.Znach = znach;
                this.Name = name;
            }
        }

        public struct Clr
        {
            public Color Zn;
            public string NmRus, NmEng;

            public Clr(Color zn, string nmRus, string nmEng)
            {
                this.Zn = zn;
                this.NmRus = nmRus;
                this.NmEng = nmEng;
            }
        }

        struct Mas3x3
        {
            public double[,] mas3x3;
            public Mas3x3(double[,] mas3x3)
            {
                this.mas3x3 = mas3x3;
            }
        }
        //---------------------------------------------------------------

        /*  Константы  */
        public const int MaxKolUr = 20;     //макс. кол. уровней (т.е. объектов, покровов)
        public const int MaxKolSnim = 100;  //макс. кол. снимков (т.е. замеров, съемок)

        /*  Переменные  */
        public double[] Mas3 =new double[3];

        public string[] NmFLRedGdm, NmFILNirGdm = new string[Convert.ToInt32(MaxKolSnim)];
        public int KolGod, KolSnim;         //колич. снимков (т.е. замеров, съемок)
        public int NomGod, KolGodTrend, ShagTrenda, KolDop; //Порядковый номер снимков (т.е. хамеров съемок)
        public int KolUr, NomUr;

        God[] Gody = new God[MaxKolSnim]; //Структура
        Mes[] Mesyacy = new Mes[MaxKolSnim]; //Структура

        public int[] NumGodov = new int[MaxKolSnim];
        public string[] NameGodov = new string[MaxKolSnim];

        public double Razr;
        public int NomVidaVremeni, NomEdIzmRaz,/*-0*/ NomEdIzmPL,/*-0*/ ColorFon;
        public string NameVidaVremeni, FileNameObTab, StrEdIzmPl, Data, Vremya;
        public int[,] PloshUrCveta = new int[MaxKolUr,MaxKolSnim]; //В пикселях
        public double[,] PloshUrCvetaReal = new double[MaxKolUr,MaxKolSnim];
        public int[] KolNajUr, PrVyboraUr = new int[MaxKolUr];
        public double[] NgrUr, VgrUr = new double[MaxKolUr];
        public int[] NomColorUr = new int[MaxKolUr];
        public int[] ColorUr = new int[MaxKolUr], NomUrNomPokr = new int[MaxKolUr];
        public Clr[] MasStdClr = new Clr[MaxKolUr];
        public string[] NamePokrovUr = new string[MaxKolUr];
        public int[] argGod = new int[MaxKolSnim];

        //-------------------------------------------------

        /*  Методы  */
        public void MesStrToMesComp(string s)
        {
            string tochka = ".";
            string strMes="dgs", strGod="dfsd";/////
            Mes rez;
            int poz = tochka.IndexOf(s); //Находит индекс
            //strMes.CopyTo(1,Convert.ToChar(s),poz,1);
            //strGod.CopyTo
            rez.Name = s;
            rez.ZnRzdMes = Convert.ToInt32(strMes);
            rez.ZnRzdGod = Convert.ToInt32(strGod);
            rez.Znach = Convert.ToInt32(strMes) + 12 * Convert.ToInt32(strGod);
            MesStrToMesComp(Convert.ToString(rez));
        }

        public void GodStrToGodComp(string s)
        {
            God rez;
            rez.Znach = Convert.ToInt32(s);
            rez.Name = s;   //+'г.'
            GodStrToGodComp(Convert.ToString(s));
        }

        public void SUmMesToMes(Mes mes1, Mes mes2)
        {
            Mes rez;
            rez.ZnRzdGod = 0;
            int num = mes1.Znach + mes2.Znach;
            rez.ZnRzdMes = num / 12;
            rez.ZnRzdMes = num - 12 * rez.ZnRzdGod;/////////
            rez.Znach = num;
            rez.Name = Convert.ToString(rez.ZnRzdMes) + '.' + Convert.ToString(rez.ZnRzdGod);
            //SUmMesToMes(rez);
        }

        public void RazMesToMes(Mes mes1, Mes mes2)
        {
            Mes rez;
            rez.ZnRzdGod = 0;
            int num = mes1.Znach + mes2.Znach;
            rez.ZnRzdMes = num / 12;
            rez.ZnRzdMes = num - 12 * rez.ZnRzdGod;/////////
            rez.Znach = num;
            rez.Name = Convert.ToString(rez.ZnRzdMes) + '.' + Convert.ToString(rez.ZnRzdGod);
            //RazMesToMes(rez);
        }

        public void SumMesNumToMes(Mes mes, int num)
        {
            Mes rez;

            int rzdGod, rzdMes;
            int num1 = mes.Znach + num;
            rzdGod = num1 / 12;
            rzdMes = num1 - 12 * rzdGod;
            string strMes = Convert.ToString(rzdMes);
            string strGod = Convert.ToString(rzdGod);
            string name = strMes + strGod;

            rez.Znach = num1;
            rez.ZnRzdGod = rzdGod;
            rez.ZnRzdMes = rzdMes;
            rez.Name = name;
            SumMesNumToMes(rez,num);////////
        }

        public void RazMesNumToMes(Mes mes, int num)
        {
            Mes rez;

            int num1 = mes.Znach - num;
            int rzdGod = num1 / 12;
            int rzdMes = num1 - 12 * rzdGod;
            string strMes = Convert.ToString(rzdMes);
            string strGod = Convert.ToString(rzdGod);
            string name = strMes + '.' + strGod;

            rez.Znach = num;
            rez.ZnRzdGod = rzdGod;
            rez.ZnRzdMes = rzdMes;
            rez.Name = name;
            RazMesNumToMes(rez,num);
        }

        public void FunTrenda()
        {
            void det3(Mas3x3[,] a)
            {
                a.mas3x3[,] = a.mas3x3[1, 1] * a.mas3x3[2, 2];
            }
        }
    }
}
