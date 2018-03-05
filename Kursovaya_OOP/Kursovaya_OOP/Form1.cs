using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_OOP
{

    public partial class Form1 : Form
    {
        Circuitry F;
        bool _IsClicked = false;
        int
            _i = 0,
            _j = 0;
        double
            _deltaX = 0,
            _deltaY = 0;

        public Form1()
        {
            InitializeComponent();
            F = new Circuitry();
            
        }

        private void Resistor_Click(object sender, EventArgs e)
        {
            F.Resistor(pictureBox1);
        }

        private void Capacitor_Click(object sender, EventArgs e)
        {
            F.Capacitor(pictureBox1);
        }

        private void Diod_Click(object sender, EventArgs e)
        {
            F.Diod(pictureBox1);
        }

        private void Battary_Click(object sender, EventArgs e)
        {
            F.Battary(pictureBox1);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            F.Paint(e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.ContextMenuStrip != null)
                pictureBox1.ContextMenuStrip = null;
            for (int i = 0; i < F._figure.Length; i++)
            {
                if (F._figure[i] == null) continue;
                for( int j = 0; j < F._figure[i].Count; j++ )
                {
                    if ((e.X < F._figure[i][j].Uper_Left_Corner.X + F._figure[i][j].Width) && (e.X > F._figure[i][j].Uper_Left_Corner.X))
                        if ((e.Y < F._figure[i][j].Uper_Left_Corner.Y + F._figure[i][j].Height) && (e.Y > F._figure[i][j].Uper_Left_Corner.Y))
                            if (e.Button == MouseButtons.Left)
                            {
                                _IsClicked = true;
                                _deltaX = e.X - F._figure[i][j].Uper_Left_Corner.X;
                                _deltaY = e.Y - F._figure[i][j].Uper_Left_Corner.Y;
                                _i = i;
                                _j = j;
                                Output_Of_Indicators(F._figure[i][j]);
                                return;
                            }
                            else if (e.Button == MouseButtons.Right)
                            {
                                _i = i;
                                _j = j;
                                //F.ContextMenuStripCircuitry = ContextMenuStripPictureBox;
                                //Context_Menu(pictureBox1, ContextMenuStripPictureBox);

                                //textBoxTesting.Text = pictureBox1.ContextMenuStrip.ToString();

                                //ContextMenuStripPictureBox
                                pictureBox1.ContextMenuStrip = ContextMenuStripPictureBox;
                                //pictureBox1.Invalidate();
                                //pictureBox1.ContextMenuStrip = null;
                            }
                            else return;
                }
            }
        }


        private void Gnd_Click(object sender, EventArgs e)
        {
            F.Gnd(pictureBox1);
        }

        private void Connection_Click(object sender, EventArgs e)
        {
            F.Connection(pictureBox1);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _IsClicked = false;
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            textAmperage.Clear();
            textCapacitance.Clear();
            textResist.Clear();
            textVoltage.Clear();

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_IsClicked)
            {
                F._figure[_i][_j].Uper_Left_Corner.X = e.X - _deltaX;
                F._figure[_i][_j].Uper_Left_Corner.Y = e.Y - _deltaY;
                pictureBox1.Invalidate();
            }
        }

        private void Output_Of_Indicators(Cell tmp)
        {
            textCapacitance.Text = tmp.Capacitance.ToString();
            textAmperage.Text = tmp.Amperage.ToString();
            textResist.Text = tmp.Resist.ToString();
            textVoltage.Text = tmp.Voltage.ToString();

        }
        private void Turn_Figure_Click(object sender, EventArgs e)
        {
            //if(F._figure)
            F._figure[_i][_j].Fi += 90;
            pictureBox1.Invalidate();
            //pictureBox1.p = null;

        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            if (F._figure[_i] == null || F._figure[_i][_j] == null) return;

        }

        private void Del_Figure(object sender, EventArgs e)
        {
            F._figure[_i].Remove(F._figure[_i][_j]);
            pictureBox1.Invalidate();
            pictureBox1.ContextMenuStrip = null;
        }
        private void Context_Menu(PictureBox pb, ContextMenuStrip cms)
        {
            pb.ContextMenuStrip = cms;
            //pb.ContextMenuStrip.
        }

    }
}

