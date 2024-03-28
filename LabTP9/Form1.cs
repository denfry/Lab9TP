using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTP9
{
    public partial class MainForm : Form
    {
        public delegate void DrawDelegate(Graphics graphics);
        private DrawDelegate drawDelegate;
        public MainForm()
        {
            InitializeComponent();
            drawDelegate = g =>
            {
                // Рисование неба и солнца
                g.FillRectangle(Brushes.LightBlue, panel1.ClientRectangle); // Рисуем небо
                g.FillEllipse(Brushes.Yellow, new Rectangle(250, 30, 50, 50)); // Рисуем солнце
            };
        }

        
        // Статический метод
        private static void DrawWallsStatic(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Gray, new Rectangle(50, 50, 865, 626));
        }
        // Нестатический метод
        private void DrawWindowsNonStatic(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.White, new Rectangle(300, 200, 100, 100));
            graphics.FillRectangle(Brushes.White, new Rectangle(600, 200, 100, 100));
        }
    
        // Статический метод пользовательского класса
        private static void DrawRoofStatic(Graphics graphics)
        {
            DrawRoofAndDoor.DrawRoofStatic(graphics);
        }
        // Нестатический метод пользовательского класса
        private void DrawDoorNonStatic(Graphics graphics)
        {
            var drawDoor = new DrawRoofAndDoor();
            drawDoor.DrawDoorNonStatic(graphics);
        }
        // Нестатический метод, определяемый лямбда-выражением
        private static DrawDelegate DrawPipe = g =>
        {
            g.FillRectangle(Brushes.Gray, new Rectangle(600, 100, 100, 150));
        };
        private void buttonPaint_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            drawDelegate.Invoke(g);
        }
        class DrawRoofAndDoor
        {
            public static void DrawRoofStatic(Graphics graphics)
            {
                Point[] roofPoints =
                {
                    new Point(222, 30),
                    new Point(666, 230),
                    new Point(1110, 30)
                };
                graphics.FillPolygon(Brushes.Red, roofPoints);
            }
            public void DrawDoorNonStatic(Graphics graphics)
            {
                graphics.FillRectangle(Brushes.Brown, new Rectangle(450, 400, 200, 300));
            }
        }

        private void checkBoxWalls_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWalls.Checked)
            {
                drawDelegate += DrawWallsStatic;
            }
            else
            {
                drawDelegate -= DrawWallsStatic;
            }
            UpdateProgressBarValue();
        }

        private void checkBoxWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWindows.Checked)
            {
                drawDelegate += DrawWindowsNonStatic;
            }
            else
            {
                drawDelegate -= DrawWindowsNonStatic;
            }
            UpdateProgressBarValue();
        }

        private void checkBoxRoof_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRoof.Checked)
            {
                drawDelegate += DrawRoofStatic;
            }
            else
            {
                drawDelegate -= DrawRoofStatic;
            }
            UpdateProgressBarValue();
        }

        private void checkBoxDoor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDoor.Checked)
            {
                drawDelegate += DrawDoorNonStatic;
            }
            else
            {
                drawDelegate -= DrawDoorNonStatic;
            }
            UpdateProgressBarValue();
        }

        private void checkBoxPipe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPipe.Checked)
            {
                drawDelegate += DrawPipe;
            }
            else
            {
                drawDelegate -= DrawPipe;
            }
            UpdateProgressBarValue();
        }
        private void UpdateProgressBarValue()
        {
            int checkedCount = 0;
            if (checkBoxWalls.Checked) checkedCount++;
            if (checkBoxWindows.Checked) checkedCount++;
            if (checkBoxRoof.Checked) checkedCount++;
            if (checkBoxDoor.Checked) checkedCount++;
            if (checkBoxPipe.Checked) checkedCount++;

            progressBar1.Value = (int)(((double)checkedCount / 5) * 100); // 5 - количество чекбоксов
        }
    }
}
