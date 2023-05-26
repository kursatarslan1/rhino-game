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
        Rhino tank2;
        Mermi mermi;
        Mermi mermi2;
        bool checkMermi = false;
        private readonly int boyut = 10;
        int[,] map = new int[40, 60];
        private readonly Label rhino1 = new Label();
        private readonly Label rhino2 = new Label();
        public int x = 305, y = 350, z= 305, d=40;
        public int sekilBakıyor;
        public Form1()
        {
            InitializeComponent();
            tank = new Rhino(29, 35);
            tank2 = new Rhino(29, 5);
            tank2.matrix = tank2.rhinoShape3;
            Tank(tank);
            Tank(tank2);
        }

        public void SekilMermi(Mermi mermi)
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

        public void MermiyiSifirla(Mermi mermi)
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


        public void Tank(Rhino tank)
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
            //rhino1.Text = "Rhino 1";
            rhino1.ForeColor = Color.White;
            rhino1.BackColor = Color.Transparent;
            rhino1.Location = new Point(x, y);
            this.Controls.Add(rhino1);

            //rhino2.Text = "Rhino 2";
            rhino2.ForeColor = Color.White;
            rhino2.BackColor = Color.Transparent;
            rhino2.Location = new Point(z, d);
            this.Controls.Add(rhino2);
        }

        public void TankiSifirla(Rhino tank)
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
                    TankiSifirla(tank);
                    tank.moveLeft();
                    rhino1.Location = new Point(x, y);
                    tank.matrix = tank.rhinoShape4;
                    Tank(tank);
                    Invalidate();
                }
            }
            if (keyData == Keys.Left)
            {
                if (z > 15)
                {
                    z -= 10;
                    TankiSifirla(tank2);
                    tank2.moveLeft();
                    rhino2.Location = new Point(z, d);
                    tank2.matrix = tank2.rhinoShape4;
                    Tank(tank2);
                    Invalidate();
                }
            }
            if (keyData == Keys.D)
            {
                if(x < 585)
                {
                    x += 10;
                    TankiSifirla(tank);
                    tank.moveRight();
                    tank.matrix = tank.rhinoShape2;
                    Tank(tank);
                    Invalidate();
                }
                
            }
            if (keyData == Keys.Right)
            {
                if (z < 585)
                {
                    z += 10;
                    TankiSifirla(tank2);
                    tank2.moveRight();
                    tank2.matrix = tank2.rhinoShape2;
                    Tank(tank2);
                    Invalidate();
                }

            }
            if (keyData == Keys.W)
            {
                if (y > 0)
                {
                    y -= 10;
                    TankiSifirla(tank);
                    tank.moveUp();
                    tank.matrix = tank.rhinoShape1;
                    Tank(tank);
                    Invalidate();
                }
                
            }
            if (keyData == Keys.Up)
            {
                if (d >= 0)
                {
                    d -= 10;
                    TankiSifirla(tank2);
                    tank2.moveUp();
                    tank2.matrix = tank2.rhinoShape1;
                    Tank(tank2);
                    Invalidate();
                }

            }
            if (keyData == Keys.S)
            {
                if (y < 370)
                {
                    y += 10;
                    TankiSifirla(tank);
                    tank.moveDown();
                    tank.matrix = tank.rhinoShape3;
                    Tank(tank);
                    Invalidate();
                }
                
            }
            if (keyData == Keys.Down)
            {
                if (d < 360)
                {
                    d += 10;
                    TankiSifirla(tank2);
                    tank2.moveDown();
                    tank2.matrix = tank2.rhinoShape3;
                    Tank(tank2);
                    Invalidate();
                }

            }
            if (keyData == Keys.Space && (y < 370 && y > 0 && x < 585 && x > 15) && (mermi == null && mermi2 == null)) 
            {
                checkMermi = true;
                mermi = test(tank,mermi);
            }
            if(keyData == Keys.NumPad0 && (y < 370 && y > 0 && x < 585 && x > 15) && (mermi2 == null && mermi == null))
            {
                checkMermi = false;
                mermi2 = test(tank2, mermi2);
            }
            
            return base.ProcessDialogKey(keyData);
        }

        public Mermi test(Rhino tank, Mermi mermi)
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

            SekilMermi(mermi);
            Ates.Start();
            Invalidate();
            return mermi;
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
                        e.FillRectangle(Brushes.White, new Rectangle(20 + j * (boyut) + 1, 20 + i * (boyut) + 1, boyut - 1, boyut - 1)); 
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if(txtBoxRhino1.Text != "")
                rhino1.Text = txtBoxRhino1.Text;
            else
                rhino1.Text = "Rhino 1";
            if (txtBoxRhino2.Text != "")
                rhino2.Text = txtBoxRhino2.Text;
            else
                rhino2.Text = "Rhino 2";
            this.ActiveControl = null;  //this = form

        }

        private void Ates_Tick(object sender, EventArgs e)
        {
            if (checkMermi)
                mermi = test2(mermi);
            else
                mermi2 = test2(mermi2);
        }

        public Mermi test2(Mermi mermi)
        {
            if (sekilBakıyor == 1)
            {
                MermiyiSifirla(mermi);
                mermi.y--;
                Invalidate();
                if (mermi.y == -1)
                {
                    Ates.Stop();
                    mermi = null;
                }

            }
            else if (sekilBakıyor == 2)
            {
                MermiyiSifirla(mermi);
                mermi.x++;
                Invalidate();
                if (mermi.x == 60)
                {
                    Ates.Stop();
                    mermi = null;
                }
            }
            else if (sekilBakıyor == 3)
            {
                MermiyiSifirla(mermi);
                mermi.y++;
                Invalidate();
                if (mermi.y == 40)
                {
                    Ates.Stop();
                    mermi = null;
                }
            }
            else if (sekilBakıyor == 4)
            {
                MermiyiSifirla(mermi);
                mermi.x--;
                Invalidate();
                if (mermi.x == -1)
                {
                    Ates.Stop();
                    mermi = null;
                }
            }
            if (mermi != null)
            {
                MermiyiSifirla(mermi);
                SekilMermi(mermi);
                Invalidate();
            }
            return mermi;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            TankiSifirla(tank);
            TankiSifirla(tank2);
            Tank(tank);
            Tank(tank2);
            SekilMermi(mermi);
            Invalidate();
        }
    }
}
