﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4Birthdays
{
    public partial class FormMain : Form
    {
        private Birthdays birthdays;
        /// <summary>
        /// Задача 4
        /// *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать
        /// собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка,
        /// Английские слова и другие).
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование “по-взрослому.\n" +
                               "Задача 4. Собственная утилита хранения Дней рождения.";
            birthdays = new Birthdays();


        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (birthdays.Count == 0)
            {
                MessageBox.Show("Без файла дней рождений работа программы невозможна!");
                this.Close();
            }
        }
    }
}