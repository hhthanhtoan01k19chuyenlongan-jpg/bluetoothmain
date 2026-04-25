using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace bluetoothmain
{
    public partial class ECT : Form
    {
        public ECT()
        {
            InitializeComponent();
        }
        float cellW, cellH;
        private void PMHT_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1600, 900);
            this.AutoScaleMode = AutoScaleMode.None;
            int rows = 1000;
            int cols = 1000;

            cellW = this.ClientSize.Width / (float)cols;
            cellH = this.ClientSize.Height / (float)rows;
            this.AutoSize = false;




        }

        int red , black ;
        string sensor="";
        string thangdo="";
        string fault="";
        string path;
        string cond;
        Point[] points = new Point[8];
        HashSet<(int , int)> snapCells;
        HashSet<(int row, int col)> selectedCells = new HashSet<(int, int)>();
        HashSet<Point> diemtren;
        HashSet<Point> diemduoi;


        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kimdo.BackgroundImage = Image.FromFile(@"PMHT/pics/kimdo.png");
            Point p = this.PointToClient(Cursor.Position);
            p.X -= 10;
            p.Y -= 10;
            kimdo.Location = p;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timerdo.Start();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int i = 0;
        
            Point p = this.PointToClient(Cursor.Position);
            Rectangle scanArea = new Rectangle(p.X - 25, p.Y - 25, 50, 50);
            foreach (var pt in points)
            {
                i++;
                Rectangle pointArea = new Rectangle(pt.X, pt.Y, 25, 25);

                if (scanArea.IntersectsWith(pointArea))
                {
                    kimdo.Left = pt.X-5 ;
                    kimdo.Top = pt.Y;
                    hang = "duoi";

                    if (diemtren.Contains(points[i-1]))
                    {
                        kimdo.BackgroundImage = Image.FromFile(@"PMHT/pics/kimdolat.png");
                        kimdo.Top =kimdo.Top- kimdo.Height;
                        chinhkimdo = true;
                        hang = "tren";
                    }
                    chinhvitrikim();

                    red = i;
                    timerdo.Stop();

                    readdmm();
                    return;
                }

                else { red = 0; }
                

            }
            timerdo.Stop();
            readdmm();
            label3.Text = red.ToString();
        }

        private void timerden_Tick(object sender, EventArgs e)
        {
            kimden.BackgroundImage = Image.FromFile(@"PMHT/pics/kimden.png");

            Point p = this.PointToClient(Cursor.Position);
            p.X -= 10;
            p.Y -= 10;
            kimden.Location = p;
        }

        private void kimden_MouseDown(object sender, MouseEventArgs e)
        {
            timerden.Start();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        string con = "";
        string faults = "";
        private void readdmm()
        {
            if (off) { giatridmm.Text = "";return; }
            if (!batt_conn_open && ohm) { giatridmm.Text = "0.L"; return; }
            if (batt_conn_open && volt) { giatridmm.Text = "0"; return; }

            if (!return_conn_open && !signal_conn_open && !mass_conn_open) { con = "con1"; }
            if (return_conn_open && !signal_conn_open && !mass_conn_open) { con = "con2"; }
            if (!return_conn_open && signal_conn_open && !mass_conn_open) { con = "con3"; }
            if (!return_conn_open && !signal_conn_open && mass_conn_open) { con = "con4"; }
            if (return_conn_open && !signal_conn_open && mass_conn_open) { con = "con5"; }
            if (!return_conn_open && signal_conn_open && mass_conn_open) { con = "con6"; }
            if (return_conn_open && signal_conn_open && !mass_conn_open) { con = "con7"; }
            if (return_conn_open && signal_conn_open && mass_conn_open) { con = "con8"; }

            if (ohm)
            {


                if (red != 0 && black != 0 )
                {
                    path = "PMHT/" + sensor + "/ohm/" + faults + ".xlsx";
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage(path))

                    {
                        var ws = package.Workbook.Worksheets[con];



                        giatridmm.Text = ws.Cells[red, black].Value.ToString();
                        return;
                    }
                }
                else { giatridmm.Text = "O.L"; return; }

            }
            else if (volt)
            {

                if (red != 0 && black != 0 && !batt_conn_open)
                {
                    if (con == "con7" || con == "con8") { giatridmm.Text = "0"; return; }
                    path = "PMHT/" + sensor + "/volt/" + faults + ".xlsx";
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage(path))

                    {
                        var ws = package.Workbook.Worksheets[con];

                        float a = float.Parse(ws.Cells[1, red].Value.ToString()) - float.Parse(ws.Cells[1, black].Value.ToString());
                        if (a == 6 || a == -6) { giatridmm.Text = "0"; return; }
                        else
                        {
                            giatridmm.Text = a.ToString();
                        }
                    }
                    return;
                }
                else { giatridmm.Text = "0"; return; }
            }
        }
        bool ohm = false, volt = false, off = true;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sensor = "ECT";
            faults = "normal";
            tabControl1.Hide();
            points[0] = new Point((int)(549 * cellW), (int)(442 * cellH));
            points[1] = new Point((int)(384 * cellW), (int)(443 * cellH));
            points[2] = new Point((int)(333 * cellW), (int)(442 * cellH));
            points[3] = new Point((int)(332 * cellW), (int)(512 * cellH));
            points[4] = new Point((int)(384 * cellW), (int)(513 * cellH));
            points[5] = new Point((int)(550 * cellW), (int)(509 * cellH));
            points[6] = new Point((int)(541 * cellW), (int)(701 * cellH));
            points[7] = new Point((int)(542 * cellW), (int)(795 * cellH));
            diemtren = new HashSet<Point>();
            diemtren.Add(points[0]);
            diemtren.Add(points[1]);
            diemtren.Add(points[2]);
            diemtren.Add(points[6]);
            diemduoi = new HashSet<Point>();
            diemduoi.Add(points[3]);
            diemduoi.Add(points[4]);
            diemduoi.Add(points[5]);
            diemduoi.Add(points[6]);






        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        int index = 0;
        private void PMHT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // string text = $"points[{index}] = new Point({e.X}, {e.Y});\n";
            // Clipboard.SetText(Clipboard.GetText() + text);

            // index++;
            int col = (int)(e.X / cellW);
            int row = (int)(e.Y / cellH);

            var cell = (row, col);

            // toggle chọn / bỏ chọn
            if (selectedCells.Contains(cell))
                selectedCells.Remove(cell);
            else
                selectedCells.Add(cell);
        }

        private void PMHT_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (off)
            {
                giatridmm.Text = "";
                volt = true;dmm.BackgroundImage = Image.FromFile(@"PMHT/pics/dmmVolt.png");
                off = false;

            }
            else if (volt)
            {
                ohm = true; dmm.BackgroundImage = Image.FromFile(@"PMHT/pics/dmmOhm.png");
                volt = false;
            }
            else if (ohm)
            {
                off = true; dmm.BackgroundImage = Image.FromFile(@"PMHT/pics/dmmOff.png");
                ohm = false;
            }
            readdmm();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = string.Join(Environment.NewLine,
       selectedCells.Select(c => $"({c.row},{c.col})"));

            Clipboard.SetText(text);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }
        bool signal_conn_open = false;
        private void signal_conn_Click(object sender, EventArgs e)
        {
            if (!signal_conn_open)
            {
                signal_conn.BackgroundImage = Image.FromFile(@"PMHT/pics/" + sensor + "/signal_conn_open.png");
                signal_conn_open = true;
            }
            else
            {
                signal_conn.BackgroundImage = Image.FromFile(@"PMHT/pics/" + sensor + "/signal_conn_close.png");
                signal_conn_open = false;
            }
            readdmm();

        }
        bool return_conn_open = false;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!return_conn_open)
            {
                return_conn.BackgroundImage = Image.FromFile(@"PMHT/pics/" + sensor + "/return_conn_open.png");
                return_conn_open = true;
            }
            else
            {
                return_conn.BackgroundImage = Image.FromFile(@"PMHT/pics/" + sensor + "/return_conn_close.png");
                return_conn_open = false;
            }
            readdmm();


        }
        bool mass_conn_open = false;
        private void mass_conn_Click(object sender, EventArgs e)
        {
            if (!mass_conn_open)
            {
                mass_conn.BackgroundImage = Image.FromFile(@"PMHT/pics/" + sensor + "/mass_conn_open.png");
                mass_conn_open = true;
            }
            else
            {
                mass_conn.BackgroundImage = Image.FromFile(@"PMHT/pics/" + sensor + "/mass_conn_close.png");
                mass_conn_open = false;
            }
            readdmm();

        }
        bool batt_conn_open = false; 
        private void batt_conn_Click(object sender, EventArgs e)
        {
            if (!batt_conn_open)
            {
                batt_conn.BackgroundImage = Image.FromFile(@"PMHT/pics/" + sensor + "/batt_conn_open.png");
                batt_conn_open = true;
            }
            else
            {
                batt_conn.BackgroundImage = Image.FromFile(@"PMHT/pics/" + sensor + "/batt_conn_close.png");
                batt_conn_open = false;
            }
            readdmm();
        }

        private void kimden_MouseUp(object sender, MouseEventArgs e)
        {
            int i = 0;
            Point p = this.PointToClient(Cursor.Position);
            Rectangle scanArea = new Rectangle(p.X - 25, p.Y - 25, 50, 50);
            foreach (var pt in points)
            {
                i++;
                Rectangle pointArea = new Rectangle(pt.X, pt.Y, 25, 25);

                if (scanArea.IntersectsWith(pointArea))
                {
                    kimden.Left = pt.X -5;
                    kimden.Top = pt.Y;
                    if (diemtren.Contains(points[i-1]))
                    {
                        kimden.BackgroundImage = Image.FromFile(@"PMHT/pics/kimdenlat.png");
                        kimden.Top -= kimden.Height;
                    }
                    chinhvitrikim();

                    black = i;

                    timerden.Stop();
                 
                    readdmm();
                    return;
                }
               

                else { black = 0; }
               
            }
            timerden.Stop();
       
            readdmm();

        }
        bool chinhkimdo = false;
        string hang;
        private void chinhvitrikim()
        {
             if (kimden.Top == kimdo.Top&&hang=="duoi")
                {
                    kimdo.BackgroundImage = Image.FromFile(@"PMHT/pics/kimdolat.png");
                    kimdo.Top -= kimdo.Height;
                }

            
            else if (kimden.Top == kimdo.Top && hang == "tren")
            {
                kimdo.BackgroundImage = Image.FromFile(@"PMHT/pics/kimdo.png");
                kimdo.Top += kimdo.Height;
            }

        }
    }
}








