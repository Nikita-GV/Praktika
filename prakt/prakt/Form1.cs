using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                label4.Text = "Введите колличество элементов в массиве"; //Проверка на заполнение
            }
            else { 

            string st = "Исходный массив (не должен превышать 20 элементов)\n\nСортировка пузырьком\n\n";
            string st2 = "Отсортированный массив \n\nСортировка пузырьком\n\n";
            label2.Text = st;
            label3.Text = st2;
            int N;
                if (int.TryParse(textBox1.Text, out int number))      //проверка на число
                {



                    N = Int32.Parse(textBox1.Text);
                    if (N > 20)
                    {
                        label4.Text = "Количество элементов массива не должно превышать 20";
                        
                    }
                    else
                    {


                        if (N == 1)
                        {
                            label4.Text = "Нельзя сортировать массив из одного элемента";
                            
                        }
                        else
                        {
                            if (N == 0)
                            {
                                label4.Text = "Количество элементов массива не может быть равно 0";
                                
                            }
                            else
                            {
                                if (N < 0)
                                {
                                    label4.Text = "Введите положительное количество элементов массива";
                                                                                          //Проверка на положительное число элементов
                                }
                                else 
                                {
                                    int[] mas = new int[N];
                                    Random rand = new Random();
                                    for (int i = 0; i < mas.Length; i++)
                                    {
                                        mas[i] = rand.Next(1, 21);              //заполнение массива
                                    }

                                    Console.WriteLine("До сортировки:");
                                    for (int i = 0; i < mas.Length; i++)
                                    {

                                        label2.Text += (mas[i]).ToString();             //вывод массива до сортировки
                                        label2.Text += " ";
                                    }


                                    int temp;
                                    for (int i = 0; i < mas.Length; i++)
                                    {
                                        for (int j = i + 1; j < mas.Length; j++)
                                        {
                                            if (mas[i] > mas[j])
                                            {
                                                temp = mas[i];
                                                mas[i] = mas[j];                          //сортировка
                                                mas[j] = temp;
                                            }
                                        }
                                    }

                                    Console.WriteLine("После сортировки:");
                                    for (int i = 0; i < mas.Length; i++)
                                    {
                                        label3.Text += (mas[i]).ToString();             //вывод массива после
                                        label3.Text += " ";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    label4.Text = "Введите число";
                    
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {
                label4.Text = "Введите количество элементов в массиве"; //Проверка на заполнение
            }
            else
            {


                string st = "Сортировка вставками\n\n";
                string st2 = "Сортировка вставками \n\n";
                label6.Text = st;
                label7.Text = st2;
                int N;
                if (int.TryParse(textBox1.Text, out int number))        //проверка на число
                {



                    N = Int32.Parse(textBox1.Text);
                    if (N > 20)
                    {
                        label4.Text = "Количество элементов массива не должно превышать 20";
                        
                    }
                    else
                    {
                        if (N == 1)
                        {
                            label4.Text = "Нельзя сортировать массив из одного элемента";
                            
                        }
                        else
                        {
                            if (N == 0)
                            {
                                label4.Text = "Количество элементов массива не может быть равно 0";
                                
                            }
                            else
                            {
                                if (N < 0)
                                {
                                    label4.Text = "Введите положительное количество элементов массива";
                                                                                           //Проверка на положительное число элементов
                                }
                                else
                                {
                                    int[] mas = new int[N];
                                    Random rand = new Random();
                                    for (int i = 0; i < mas.Length; i++)
                                    {
                                        mas[i] = rand.Next(1, 21);              //заполнение массива
                                    }

                                    Console.WriteLine("До сортировки:");
                                    for (int i = 0; i < mas.Length; i++)
                                    {

                                        label6.Text += (mas[i]).ToString();             //вывод массива до сортировки
                                        label6.Text += " ";
                                    }

                                    int index;                             //номер элемента в массиве
                                    int currentNumber;                     //значение текущего элемента в массиве
                                    for (int i = 0; i < mas.Length; i++)
                                    {
                                        index = i;
                                        currentNumber = mas[i];
                                        while (index > 0 && currentNumber < mas[index - 1])
                                        {
                                            mas[index] = mas[index - 1];
                                            index--;
                                        }
                                        mas[index] = currentNumber;
                                    }

                                    for (int i = 0; i < mas.Length; i++)
                                    {
                                        label7.Text += (mas[i]).ToString();             //вывод массива после
                                        label7.Text += " ";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    label4.Text = "Введите число";
                    
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
