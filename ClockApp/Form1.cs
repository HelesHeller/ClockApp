using System;
//using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновление времени при каждом тике таймера.
            UpdateTime();
        }
        private void UpdateTime()
        {
            // Получите текущее время.
            DateTime currentTime = DateTime.Now;

            // Отобразите текущее время в 12-часовом или 24-часовом формате в зависимости от выбора пользователя.
            if (radioButton24h.Checked)
            {
                labelTime.Text = currentTime.ToString("HH:mm:ss");
            }
            else
            {
                labelTime.Text = currentTime.ToString("h:mm:ss tt");
            }
        }
        private void radioButton24h_CheckedChanged(object sender, EventArgs e)
        {
            // Переключение на 24-часовой формат времени.
            UpdateTime();
        }
        private void radioButton12Hours_CheckedChanged(object sender, EventArgs e)
        {
            // Переключение на 12-часовой формат времени.
            UpdateTime();
        }

    }
}