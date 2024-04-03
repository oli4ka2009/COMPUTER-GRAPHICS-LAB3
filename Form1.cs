using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing.Imaging;
using System.Globalization;

namespace LAB3
{
    public partial class Form1 : Form
    {
        private Bitmap fractalImage;
        public double gRoughness;
        public double gBigSize;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void plasmaButton_Click(object sender, EventArgs e)
        {
            InitializePlasmaFractal();
        }

        private void InitializePlasmaFractal()
        {
            int width = pictureBox.Width;
            int height = pictureBox.Height;

            Color[] colors = new Color[4];

            ColorDialog colorDialog = new ColorDialog();
            for (int i = 0; i < 4; ++i)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colors[i] = colorDialog.Color;
                }
            }

            double[] reds = new double[4];
            double[] greens = new double[4];
            double[] blues = new double[4];

            for (int i = 0; i < 4; ++i)
            {
                reds[i] = colors[i].R;
                greens[i] = colors[i].G;
                blues[i] = colors[i].B;
            }

            if (double.TryParse(roughnessBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double roughness))
            {
                if (roughness <= 1 && roughness >= 0)
                {
                    double[,] pointsR = Generate(width, height, roughness, reds);
                    double[,] pointsG = Generate(width, height, roughness, greens);
                    double[,] pointsB = Generate(width, height, roughness, blues);
                    DrawFractal(pointsR, pointsG, pointsB);
                }
                else {
                    MessageBox.Show("Roughness must be between 0 and 1");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Roughness must be numerical value");
                return;
            }
        }

        public double[,] Generate(int iWidth, int iHeight, double iRoughness, double[] numbers)
        {
            double c1, c2, c3, c4;
            double[,] points = new double[iWidth + 1, iHeight + 1];

            c1 = numbers[0] / 255;
            c2 = numbers[1] / 255;
            c3 = numbers[2] / 255;
            c4 = numbers[3] / 255;
            gRoughness = iRoughness;
            gBigSize = iWidth + iHeight;
            DivideGrid(ref points, 0, 0, iWidth, iHeight, c1, c2, c3, c4);
            return points;
        }

        public void DivideGrid(ref double[,] points, double x, double y, double width, double height, double c1, double c2, double c3, double c4)
        {
            double Edge1, Edge2, Edge3, Edge4, Middle;

            double newWidth = Math.Floor(width / 2);
            double newHeight = Math.Floor(height / 2);

            if (width > 1 || height > 1)
            {
                Middle = ((c1 + c2 + c3 + c4) / 4) + Displace(newWidth + newHeight); 
                Edge1 = ((c1 + c2) / 2);
                Edge2 = ((c2 + c3) / 2);
                Edge3 = ((c3 + c4) / 2);
                Edge4 = ((c4 + c1) / 2);
                                       
                Middle = Rectify(Middle);
                Edge1 = Rectify(Edge1);
                Edge2 = Rectify(Edge2);
                Edge3 = Rectify(Edge3);
                Edge4 = Rectify(Edge4);
            
                DivideGrid(ref points, x, y, newWidth, newHeight, c1, Edge1, Middle, Edge4);
                DivideGrid(ref points, x + newWidth, y, width - newWidth, newHeight, Edge1, c2, Edge2, Middle);
                DivideGrid(ref points, x + newWidth, y + newHeight, width - newWidth, height - newHeight, Middle, Edge2, c3, Edge3);
                DivideGrid(ref points, x, y + newHeight, newWidth, height - newHeight, Edge4, Middle, Edge3, c4);
            }
            else     
            {
                double c = (c1 + c2 + c3 + c4) / 4;

                points[(int)(x), (int)(y)] = c;
                if (width == 2)
                {
                    points[(int)(x + 1), (int)(y)] = c;
                }
                if (height == 2)
                {
                    points[(int)(x), (int)(y + 1)] = c;
                }
                if ((width == 2) && (height == 2))
                {
                    points[(int)(x + 1), (int)(y + 1)] = c;
                }
            }
        }

        private double Rectify(double iNum)
        {
            if (iNum < 0)
            {
                iNum = 0;
            }
            else if (iNum > 1.0)
            {
                iNum = 1.0;
            }
            return iNum;
        }

        private double Displace(double SmallSize)
        {

            double Max = SmallSize / gBigSize * gRoughness;
            return (rnd.NextDouble() - 0.5) * Max;
        }

        private void DrawFractal(double[,] pointsR, double[,] pointsG, double[,] pointsB)
        {
            int width = pointsR.GetLength(0);
            int height = pointsR.GetLength(1);

            fractalImage = new Bitmap(width, height);

            double minR = double.MaxValue;
            double maxR = double.MinValue;
            double minG = double.MaxValue;
            double maxG = double.MinValue;
            double minB = double.MaxValue;
            double maxB = double.MinValue;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (pointsR[x, y] < minR)
                        minR = pointsR[x, y];
                    if (pointsR[x, y] > maxR)
                        maxR = pointsR[x, y];
                    if (pointsB[x, y] < minB)
                        minB = pointsB[x, y];
                    if (pointsB[x, y] > maxB)
                        maxB = pointsB[x, y];
                    if (pointsG[x, y] < minG)
                        minG = pointsG[x, y];
                    if (pointsG[x, y] > maxG)
                        maxG = pointsG[x, y];
                }
            }

            // Draw fractal
            using (Graphics g = Graphics.FromImage(fractalImage))
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int colorValueR = (int)((pointsR[x, y] - minR) / (maxR - minR) * 255);
                        int colorValueG = (int)((pointsG[x, y] - minG) / (maxG - minG) * 255);
                        int colorValueB = (int)((pointsB[x, y] - minB) / (maxB - minB) * 255);
                        Color color = Color.FromArgb(colorValueR, colorValueG, colorValueB);
                        SolidBrush brush = new SolidBrush(color);
                        g.FillRectangle(brush, x, y, 1, 1);
                    }
                }
            }

            pictureBox.Image = fractalImage;
        }

        public static Func<Complex, Complex, Complex> Fractal() => (c, z) => z * Complex.Sin(z) + c;

        private void DrawAlgebraicFractal(double Scale, int Iterations, double xOffset, double yOffset)
        {
            for (int x = 0; x < pictureBox.Width; x++)
            {
                for (int y = 0; y < pictureBox.Height; y++)
                {
                    double a = (x - pictureBox.Width / 2.0) / Scale + xOffset;
                    double b = (y - pictureBox.Height / 2.0) / Scale + yOffset;
                    Complex c = new Complex(a, b);
                    Complex z = Complex.Zero;
                    int iterations = 0;

                    while (iterations < Iterations)
                    {
                        z = Fractal()(c, z);
                        iterations++;

                        if (z.Magnitude >= 2)
                            break;
                    }

                    int colorValue = (int)((double)iterations / Iterations * 255);
                    Color color = Color.FromArgb(34, colorValue, colorValue);
                    fractalImage.SetPixel(x, y, color);
                }
            }
        }

        private void algebraicButton_Click(object sender, EventArgs e)
        {
            fractalImage = new Bitmap(pictureBox.Width, pictureBox.Height);

            if (!double.TryParse(scaleTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double scale))
            {
                MessageBox.Show("Incorrect scale!");
                return;
            }
            if (!int.TryParse(iterationsTextBox.Text, out int iterations))
            {
                MessageBox.Show("Incorrect iterations number!");
                return;
            }
            if (!double.TryParse(xOffsetTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double xOffset))
            {
                MessageBox.Show("Incorrect x offset!");
                return;
            }
            if (!double.TryParse(yOffsetTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double yOffset))
            {
                MessageBox.Show("Incorrect y offset!");
                return;
            }

            DrawAlgebraicFractal(scale, iterations, xOffset, yOffset);
            pictureBox.Image = fractalImage;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Зображення (*.png)|*.png|Всі файли (*.*)|*.*";
            saveFileDialog1.Title = "Зберегти зображення";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                fractalImage.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
        }
    }
}
