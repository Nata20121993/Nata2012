using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace лаба11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vector;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ushort size = ushort.Parse(textBox1.Text);
                vector = new int[size];
                form_vector(ref vector);//Формирование вектора
                output_vector(vector, lstBx1);
                btn2.Visible = true;
                btn2.Focus();//Вывод вектрона в лист-бокс с исходным вектором
            }
            catch (FormatException)
            {
                MessageBox.Show("Вводите только цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static void form_vector(ref int[] A)//Функци формирующая вектор
        {
            Random m = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                //do
                //{
                A[i] = m.Next(A.Length) - m.Next(A.Length);
                //}
                // while (A[i] == 0);
            }
        }
        static void output_vector(int[] A, ListBox lsbx)//Функция выводящая векторв  лист-бокс с исходным вектором
        {
            lsbx.Items.Clear();
            foreach (int el in A)
                lsbx.Items.Add(el);
        }


        private void lstBx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn2_Click(object sender, EventArgs e)
        {
            int proiz = 1;
            proiz = calc(vector, proiz);//Вычисление среднего арифметического
            //Del_elem_vector(ref vector);//Удаление элементов меньше среднего арифметического
            output_vector(vector, lstBx2);//Вывод элементов векторы в лист-бокс
            textBox2.Text = proiz.ToString();
        }
            //textBox2.Visible = true;
            //textBox2.Enabled = false;
            //btn2.Visible = false;
        static void RandArray(int[] Mas)
        {
            Random m = new Random();//инициализация датчика случайных чисел
            for (int i = 0; i < Mas.Length; i++)
                Mas[i] = m.Next(Mas.Length);//получение случайного числа в диапазоне от 0 до длины вектора
        }
            static int calc(int [] vector, int proiz)//Фунция вычисляющая среднее арифметическое
            {
                //Random m = new Random();//инициализация датчика случайных чисел
                //for (int i = 0; i < Mas.Length; i++)
                //    Mas[i] = m.Next(Mas.Length);//получение случайного числа в диапазоне от 0 до длины вектора

                      double sum = 0;
            foreach (int el in Mas)
                sum += el;
            return sum / Mas.Length; 
                  }
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    //        Console.Write("Input size vectora-->");
    //        int size = int.Parse(Console.ReadLine());
    //        int[] a = new int[size]; //создали вектор размера size;
    //        RandArray(a);
    //        Console.WriteLine("Initial vector:");
    //        PrintArray(a);
    //        Console.Write("Input new size vectora-->");
    //        int newsize = int.Parse(Console.ReadLine());
    //        Array.Resize(ref a, newsize);
    //        Console.WriteLine("Change kol-el vectora:");
    //        PrintArray(a);
    //        Array.Sort(a);
    //        Console.WriteLine("Sorting vector:");
    //        PrintArray(a);
    //        Console.WriteLine("Rank vectora=" + a.Rank.ToString());
    //        Console.WriteLine("Length vectora=" + a.Length.ToString());
    //        Console.WriteLine("Average el-tov vectora=" + AverageArray(a).ToString());

    //        }
    //           static void RandArray(int[] Mas)
    //    {
    //        Random m = new Random();//инициализация датчика случайных чисел
    //        for (int i = 0; i < Mas.Length; i++)
    //            Mas[i] = m.Next(Mas.Length);//получение случайного числа в диапазоне от 0 до длины вектора
    //    }
    //    static void PrintArray(int[] Mas)
    //    {
    //        foreach (int el in Mas)
    //            Console.Write(el.ToString()+"\t");
    //        Console.WriteLine();
    //    }
    //    static double AverageArray(int[] Mas)
    //    {
    //        double sum = 0;
    //        foreach (int el in Mas)
    //            sum += el;
    //        return sum / Mas.Length;
    //    }

    }
        }
    
