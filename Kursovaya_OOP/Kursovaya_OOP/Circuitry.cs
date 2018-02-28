//#define C 50 
//int C = 50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Kursovaya_OOP
{
    using Data = List<Cell>;

    class Cell
    {
        public Coord XY0;//цент фигуры
        public Coord Uper_Left_Corner;//левый верхний угол
        public int Fi = 0;//угол поворота
        public double Width = 0;
        public double Height = 0;
        public Cell()
        {
            XY0 = new Coord();
            Uper_Left_Corner = new Coord();
        }
    }
    class Coord
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Coord(double valX = 0, double valY = 0)
        {
            X = valX;
            Y = valY;
        }
        public static bool operator ==(Coord val1, Coord val2)
        {
            return (val1.X == val2.X && val1.Y == val2.Y) ? true : false;

        }
        public static bool operator !=(Coord val1, Coord val2)
        {
            return (val1.X != val2.X || val1.Y != val2.Y) ? true : false;
        }

    }
    class Circuitry
    {
        public const int
            RESISTOR = 0,
            CAPACITOR = 1,//Capacitor
            DIOD = 2,
            BATTARY = 3,
            GND = 4,
            CONNECTION = 5;//Connection

        int _begin_X = 20;
        int _begin_Y = 20;
        int _width;
        double[][] _point_X;
        double[][] _point_Y;
        public Data [] _figure;
        Color _color;
        public Pen _pen;

        public Circuitry()
        {
            int nFigure = 6;
            _point_X = new double[nFigure][];
            _point_Y = new double[nFigure][];
            //resistor
            _point_X[0] = new double[] { 0, 10, 10, 35, 35, 45, 35, 35, 10, 10 };
            _point_Y[0] = new double[] { 5, 5, 0, 0, 5, 5, 5, 10, 10, 5 };
            //Capacitor 4+4
            _point_X[1] = new double[] { 0, 10, 10, 10, 25, 15, 15, 15 };
            _point_Y[1] = new double[] { 10, 10, 0, 20, 10, 10, 0, 20 };
            //Diod 6 левых и 4 правых
            _point_X[2] = new double[] { 20, 10, 10, 0, 10, 10, 30, 20, 20, 20 };
            _point_Y[2] = new double[] { 10, 0, 10, 10, 10, 20, 10, 10, 0, 20 };
            //Battary 4+4
            _point_X[3] = new double[] { 0, 10, 10, 10, 25, 15, 15, 15 };
            _point_Y[3] = new double[] { 20, 20, 10, 30, 20, 20, 0, 40 };
            //gnd
            _point_X[GND] = new double[] { 10,10,0,20};
            _point_Y[GND] = new double[] { 0,10,10,10};
            //
            _point_X[CONNECTION] = new double[] { 0, 20, 0, 0};
            _point_Y[CONNECTION] = new double[] { 10, 10, 0,20};


            _figure = new Data[nFigure];
            _width = 2;
            _color = Color.Black;
            _pen = new Pen(_color, _width);
        }
        //создаёт новый элемент name в указаной точке с углом наклона fi
        public void NewElement(int name, double x0, double y0, int fi)
        {
            var tmp = new Cell();
            var pointX = new double[_point_X[name].Length];
            var pointY = new double[_point_Y[name].Length];
            Turn(_point_X[name], _point_Y[name],
                pointX, pointY, fi);
            tmp.XY0.X = x0;
            tmp.XY0.Y = y0;
            tmp.Fi = fi;
            tmp.Height = pointY.Max() - pointY.Min();
            tmp.Width = pointX.Max() - pointX.Min();
            tmp.Uper_Left_Corner.X = x0 - tmp.Width / 2;
            tmp.Uper_Left_Corner.Y = y0 - tmp.Height / 2;
            if (_figure[name] == null) _figure[name] = new Data();
            _figure[name].Add(tmp);
        }
        //считает точки отрисовки name по данным tmp
        public void FigureDrawing(int name, PaintEventArgs pa, Cell tmp)
        {
            var pointX = new double[_point_X[name].Length];
            var pointY = new double[_point_Y[name].Length];
            Turn(_point_X[name], _point_Y[name], pointX, pointY, tmp.Fi);
            for (int i=0; i < pointX.Length; i++)
            {
                pointX[i] += tmp.Uper_Left_Corner.X;
                pointY[i] += tmp.Uper_Left_Corner.Y;
            }
            switch(name)
            {
                case RESISTOR:
                    {
                        Resistor(pa, pointX, pointY);
                        break;
                    }
                case CAPACITOR:
                    {
                        Capacitor(pa, pointX, pointY);
                        break;
                    }
                case DIOD:
                    {
                        Diod(pa, pointX, pointY);
                        break;
                    }
                case BATTARY:
                    {
                        Battary(pa, pointX, pointY);
                        break;
                    }
                case GND:
                    {
                        Gnd(pa, pointX, pointY);
                        break;
                    }
                case CONNECTION:
                    {
                        Connection(pa, pointX, pointY);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        //отрисовка фигур по введённым точкам
        private void Resistor(PaintEventArgs pa, double []pX, double []pY)
        {
            PointF[] arr = new PointF[pX.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].X = (float)pX[i];
                arr[i].Y = (float)pY[i];
            }
            pa.Graphics.DrawPolygon(_pen, arr);
        }
        private void Capacitor(PaintEventArgs pa, double[]pX, double[] pY)
        {
            var arr = new PointF[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].X = (float)pX[i];
                arr[i].Y = (float)pY[i];
            }
            pa.Graphics.DrawLines(_pen, arr);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].X = (float)pX[i + arr.Length];
                arr[i].Y = (float)pY[i + arr.Length];
            }
            pa.Graphics.DrawLines(_pen, arr);
        }
        private void Diod(PaintEventArgs pa, double[] pX, double[] pY)
        {
            var arrP = new PointF[6];
            for (int i = 0; i < arrP.Length; i++)
            {
                arrP[i].X = (float)pX[i];
                arrP[i].Y = (float)pY[i];
            }
            pa.Graphics.DrawPolygon(_pen, arrP);
            //*********
            PointF[] arrL = new PointF[4];
            for (int i = 0; i < arrL.Length; i++)
            {
                arrL[i].X = (float)pX[i + arrP.Length];
                arrL[i].Y = (float)pY[i + arrP.Length];
            }
            pa.Graphics.DrawLines(_pen, arrL);
        }
        private void Battary(PaintEventArgs pa, double []pX, double []pY)
        {
            var arrL = new PointF[4];
            for (int i = 0; i < arrL.Length; i++)
            {
                arrL[i].X = (float)pX[i];
                arrL[i].Y = (float)pY[i];
            }
            pa.Graphics.DrawLines(_pen, arrL);
            var arrR = new PointF[4];
            for (int i = 0; i < arrR.Length; i++)
            {
                arrR[i].X = (float)pX[i + arrL.Length];
                arrR[i].Y = (float)pY[i + arrL.Length];
            }
            pa.Graphics.DrawLines(_pen, arrR);
        }
        private void Gnd(PaintEventArgs pa, double[] pX, double[] pY)
        {
            var arrP = new PointF[pX.Length];
            for (int i = 0; i < arrP.Length; i++)
            {
                arrP[i].X = (float)pX[i];
                arrP[i].Y = (float)pY[i];
            }
            pa.Graphics.DrawLines(_pen, arrP);
        }
        private void Connection(PaintEventArgs pa, double[] pX, double[] pY)
        {
            var arrP = new PointF[2];
            for(int i = 0; i < arrP.Length; i++)
            {
                arrP[i].X = (float)pX[i];
                arrP[i].Y = (float)pY[i];
            }
            pa.Graphics.DrawLines(_pen, arrP);
        }

        //
        public void Resistor(PictureBox pb)
        {
            NewElement(RESISTOR, _begin_X, _begin_Y, 0);
            pb.Invalidate();
        }
        public void Capacitor(PictureBox pb)
        {
            NewElement(CAPACITOR, _begin_X, _begin_Y, 0);
            pb.Invalidate();
        }
        public void Diod(PictureBox pb)
        {
            NewElement(DIOD, _begin_X, _begin_Y, 0);
            pb.Invalidate();
        }
        public void Battary(PictureBox pb)
        {
            NewElement(BATTARY, _begin_X, _begin_Y, 0);
            pb.Invalidate();
        }
        public void Gnd(PictureBox pb)
        {
            NewElement(GND, _begin_X, _begin_Y, 0);
            pb.Invalidate();
        }
        public void Connection(PictureBox pb)
        {
            NewElement(CONNECTION, _begin_X, _begin_Y, 0);
            pb.Invalidate();
        }

        //поворот координат точек массивов1 в массивы2 вокруг точки х0 у0 на угол фи
        public void Turn(double[] arrX1, double[] arrY1,
            double []arrX2, double []arrY2, int Fi, double x0, double y0)
        {
            var fi = Math.PI * Fi / 180.0;//перевод в радианы
            if (arrX1.Length != arrX2.Length && arrY1.Length != arrY2.Length//проверка корректности массивов
                && arrY2.Length != arrX2.Length) return;
            ///
            for(int i = 0; i < arrX1.Length; i++)
            {
                arrX2[i] = x0 + (arrX1[i] - x0) * Math.Cos(fi) - 
                    (arrY1[i] - y0) * Math.Sin(fi);
                arrY2[i] =y0 + (arrX1[i] - x0) * Math.Sin(fi) + 
                    (arrY1[i] - y0) * Math.Cos(fi);
            }
        }
        public void Turn(double[] arrX1, double[] arrY1, 
            double[] arrX2, double[] arrY2, int Fi)
        {
            Turn(arrX1, arrY1, arrX2, arrY2, Fi,
                Centr(arrX1), Centr(arrY1));            
        }
        private double Centr(double[] arr)//центр вращения
        {
            return arr.Max() / 2 - arr.Min() / 2;
        }
        public void Paint(PaintEventArgs pa)
        {
            for(int i = 0; i < _figure.Length; i++)
            {
                if (_figure[i] != null)
                    foreach (var tmp in _figure[i])
                    {
                        if (tmp == null) break;
                        FigureDrawing(i, pa, tmp);
                    }
            }
        }
    }
}