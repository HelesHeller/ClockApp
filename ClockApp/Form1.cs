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
            // ���������� ������� ��� ������ ���� �������.
            UpdateTime();
        }
        private void UpdateTime()
        {
            // �������� ������� �����.
            DateTime currentTime = DateTime.Now;

            // ���������� ������� ����� � 12-������� ��� 24-������� ������� � ����������� �� ������ ������������.
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
            // ������������ �� 24-������� ������ �������.
            UpdateTime();
        }
        private void radioButton12Hours_CheckedChanged(object sender, EventArgs e)
        {
            // ������������ �� 12-������� ������ �������.
            UpdateTime();
        }

    }
}