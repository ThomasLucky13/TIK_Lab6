using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {

        private String text;
        private List<int> a, b, erb;
        private int k, r, s;
        private NumClass mc, pc;

        public Form1()
        {
            InitializeComponent();
        }

        private void BOutput_Click(object sender, EventArgs e)
        {

        }

        private List<int> BinNum(int n)
        {
            List<int> res = new List<int>();
            while (n > 0)
            {
                res.Add(n % 2);
                n = n / 2;
            }
            res.Reverse();
            return res;
        }

        private void set_mc(int s, int h)
        {
            table2 table = new table2();
            mc = new NumClass( table.Get(0, h) );
            for (int i = 1; i<s; ++i)
            {
                System.Console.WriteLine(mc.ToString());
                System.Console.WriteLine(new NumClass(table.Get(i, h)).ToString());
                if (new NumClass(table.Get(i, h)).NumInt()!=0)
                {
                    mc = new NumClass(mc.Mult(new NumClass(table.Get(i, h)).Num()));
                }
                System.Console.WriteLine(mc.ToString());
            }
        }

        private bool isTextAllowable()
        {
            for (int i = 0; i < text.Length; ++i)
            {
                if (text[i]=='1')
                {
                    a.Add(1);
                } else if (text[i]=='0')
                {
                    a.Add(0);
                } else
                {
                    return false;
                }
            }
            k = text.Length;
            return true;
        }

        bool set_r()
        {
            table1 table = new table1();
            if (table.GetR(k) != -1)
            {
                r = table.GetR(k);
                return true;
            }
            return false;
        }

        bool set_s()
        {
            table1 table = new table1();
            if (table.GetS(k) != -1)
            {
                s = table.GetS(k);
                return true;
            }
            return false;
        }

        private String ListString(List <int> a)
        {
            String res = "";
            foreach (int i in a)
            {
                res += i.ToString();
            }
            return res;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            errorLable.Visible = false;
            krn_Output.Text = "";
            H_Matrix.Text = "";
            BOutput.Text = "";
            ErBOutput.Text = "";
            ResOutput.Text = "";
            text = textInput.Text;
            a = new List<int>();
            if (!isTextAllowable())
            {
                errorLable.Visible = true;
                return;
            }

            if (!set_r())
            {
                errorLable.Visible = true;
                return;
            }

            if (!set_s())
            {
                errorLable.Visible = true;
                return;
            }

            int n = r + k;

            int ii = 2 * s - 1;
            int h = (int)Math.Log(n+1, 2);
            krn_Output.Text = $"k = {k}    r = {r}      s = {s}     n = {n}     \ni = {ii}     h = {h}";

            set_mc(s, h);
            pc = new NumClass(new NumClass(a).Mult(mc.Num().Count-1));
            NumClass ost = new NumClass(pc.Mod(mc.Num()));
            b = pc.Add(ost.Num());
            H_Matrix.Text = $"Образующий многочлен: {mc.ToString()}\nОстаток от деления:{ost.ToString()}";

            BOutput.Text = $"B = {ListString(b)}";


            Random rand = new Random();
            int erCount = rand.Next(s);
            erb = new List<int>(b);

            for (int i= 0; i < erCount; ++i)
            {
                int erInd = rand.Next(b.Count);
                System.Console.WriteLine(erInd);
            
                if (erb[erInd]==1)
                {
                    erb[erInd] = 0;
                } else
                {
                    erb[erInd] = 1;
                }
            }
            
            ErBOutput.Text = $"!B = {ListString(erb)}";

            int nn = 0;
            NumClass erNum = new NumClass(erb);
            System.Console.WriteLine($"B = {ListString(b)}\nerNum{erNum.ToString()}\nОбразующий многочлен: {mc.ToString()}");
            if (new NumClass(erNum.Mod(mc.Num())).NumInt() !=0)
            {
                while (new NumClass(erNum.Mod(mc.Num())).countsOne() > s)
                {
                    nn++;
                    erNum.Left();
                }
                erNum = new NumClass( erNum.Sum(erNum.Mod(mc.Num())));
                for (int i = 0; i<nn; ++i)
                {
                    erNum.Right();
                }
                erb = erNum.Num();
                ResOutput.Text = $"Исправленный код: {ListString(erb)}";

            }
            

        }
    }
}
