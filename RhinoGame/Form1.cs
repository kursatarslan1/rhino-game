using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhinoGame
{
    public partial class Form1 : Form
    {

        Rhino tank;
        Mermi mermi;
        private readonly int boyut = 10;
        int[,] map = new int[40, 60];
        private readonly Label rhino1 = new Label();
        public int x = 305, y = 350;
        public int sekilBakıyor;
        public Form1()
        {
            
            InitializeComponent();
            tank = new Rhino(29, 35);
            Tank();
        }

        public void SekilMermi()
        {
            for (int i = mermi.y; i < mermi.y + mermi.sizeMatrix; i++)
            {
                for (int j = mermi.x; j < mermi.x + mermi.sizeMatrix; j++)
                {
                    if (mermi.matrix[i - mermi.y, j - mermi.x] != 0)
                    {
                        map[i, j] = mermi.matrix[i - mermi.y, j - mermi.x];
                    }
                }
            }
        }

        public void MermiyiSifirla()
        {
            for (int i = mermi.y; i < mermi.y + mermi.sizeMatrix; i++)
            {
                for (int j = mermi.x; j < mermi.x + mermi.sizeMatrix; j++)
                {
                    if (mermi.matrix[i - mermi.y, j - mermi.x] != 0)
                    {
                        map[i, j] = 0;
                    }
                }
            }
        }


        public void Tank()
        {
            for (int i = tank.y; i < tank.y + tank.sizeMatrix; i++)
            {
                for (int j = tank.x; j < tank.x + tank.sizeMatrix; j++) 
                {
                    if(tank.matrix[i - tank.y, j - tank.x] != 0)
                    {
                        map[i, j] = tank.matrix[i - tank.y, j - tank.x];
                    }
                }
            }
            rhino1.Text = "Rhino 1";
            rhino1.ForeColor = Color.White;
            rhino1.BackColor = Color.Transparent;
            rhino1.Location = new Point(x, y);
            this.Controls.Add(rhino1);
        }

        public void TankiSifirla()
        {
            for (int i = tank.y; i < tank.y + tank.sizeMatrix; i++)
            {
                for (int j = tank.x; j < tank.x + tank.sizeMatrix; j++)
                {
                    if (tank.matrix[i - tank.y, j - tank.x] != 0)
                    {
                        map[i, j] = 0;
                    }
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData) 
        {
            if (keyData == Keys.A)
            {
                if(x > 15)
                {
                    x -= 10;
                    TankiSifirla();
                    tank.moveLeft();
                    rhino1.Location = new Point(x, y);
                    tank.matrix = tank.rhinoShape4;
                    Tank();
                    Invalidate();
                }
            }
            if (keyData == Keys.D)
            {
                if(x < 585)
                {
                    x += 10;
                    TankiSifirla();
                    tank.moveRight();
                    tank.matrix = tank.rhinoShape2;
                    Tank();
                    Invalidate();
                }
                
            }
            if (keyData == Keys.W)
            {
                if (y > 0)
                {
                    y -= 10;
                    TankiSifirla();
                    tank.moveUp();
                    tank.matrix = tank.rhinoShape1;
                    Tank();
                    Invalidate();
                }
                
            }
            if (keyData == Keys.S)
            {
                if (y < 370)
                {
                    y += 10;
                    TankiSifirla();
                    tank.moveDown();
                    tank.matrix = tank.rhinoShape3;
                    Tank();
                    Invalidate();
                }
                
            }
            if (keyData == Keys.Space && (y<370 && y>0 && x<585 && x>15))
            {
                if (tank.matrix == tank.rhinoShape1)
                {
                    mermi = new Mermi(tank.x + 1, tank.y - 2);
                    sekilBakıyor = 1;
                }
                else if (tank.matrix == tank.rhinoShape2)
                {
                    mermi = new Mermi(tank.x + 3, tank.y + 1);
                    sekilBakıyor = 2;
                }
                else if (tank.matrix == tank.rhinoShape3)
                {
                    mermi = new Mermi(tank.x + 1, tank.y + 3);
                    sekilBakıyor = 3;
                }
                else if (tank.matrix == tank.rhinoShape4)
                {
                    mermi = new Mermi(tank.x - 2, tank.y + 1);
                    sekilBakıyor = 4;
                }

                SekilMermi();
                Ates.Start();
                Invalidate();
            }         
            return base.ProcessDialogKey(keyData);
    }

        public void HaritayiCiz(Graphics g)
        {
            for (int i = 0; i <= 40; i++)
            {
                if(i == 0 || i == 40)
                {
                    g.DrawLine(Pens.Black, new Point(20, 20 + i * boyut), new Point(20 + 60 * boyut, 20 + i * boyut));
                }
                
            }
            for (int j = 0; j <= 60; j++)
            {
                if (j == 0 || j == 60)
                {
                    g.DrawLine(Pens.Black, new Point(20 + j * boyut, 20), new Point(20 + j * boyut, 20 + 40 * boyut));
                }
                
            }
        }

        public void HaritayaSekilleriCiz(Graphics e) // Harita üzerinde şekillerimizi çiziyoruz. Burada aslında kare (dikdörtgen ama kare) dolduruyoruz.
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if(map[i,j]==0)
                    {
                        e.FillRectangle(Brushes.Black, new Rectangle(20 + j * (boyut) , 20 + i * (boyut), boyut, boyut));
                    }

                    if (map[i, j] == 1)
                    {
                        e.FillRectangle(Brushes.Bisque, new Rectangle(20 + j * (boyut) + 1, 20 + i * (boyut) + 1, boyut - 1, boyut - 1)); // + 1 ve - 1 ler aradaki kareler arasındaki düz çizgiler // tetromino şekil 1
                    }
                    if(map[i,j] == 2)
                    {
                        e.FillRectangle(Brushes.Red, new Rectangle(20 + j * (boyut), 20 + i * (boyut), boyut, boyut));
                    }
                }
            }

            
        }


        private void OnPaint(object sender, PaintEventArgs e)
        {
            HaritayiCiz(e.Graphics);
            HaritayaSekilleriCiz(e.Graphics);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //tank = new Rhino(3, 0);
        }

        private void Ates_Tick(object sender, EventArgs e)
        {
            if (sekilBakıyor == 1)
            {
                MermiyiSifirla();
                mermi.y--;
                Invalidate();
                if(mermi.y == -1)
                {
                    Ates.Stop();
                    mermi = null; 
                }

            }
            else if (sekilBakıyor == 2)
            {
                MermiyiSifirla();
                mermi.x++;
                Invalidate();
                if(mermi.x == 60)
                {
                    Ates.Stop();
                    mermi = null;
                }
            }
            else if (sekilBakıyor == 3)
            {
                MermiyiSifirla();
                mermi.y++;
                Invalidate();
                if(mermi.y == 40)
                {
                    Ates.Stop();
                    mermi = null;
                }
            }
            else if (sekilBakıyor == 4)
            {
                MermiyiSifirla();
                mermi.x--;
                Invalidate();
                if(mermi.x == -1)
                {
                    Ates.Stop();
                    mermi = null;
                }
            }
            if (mermi != null)
            {
                MermiyiSifirla();
                SekilMermi();
                Invalidate();
            }
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            TankiSifirla();
            Tank();
            SekilMermi();
            Invalidate();
        }
    }
}
