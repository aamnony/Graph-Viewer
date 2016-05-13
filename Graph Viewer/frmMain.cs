using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph_Viewer
{
    public partial class frmMain : Form
    {
        Series s;
        bool first;
        //int vOld, vNew;

        public frmMain()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            chart1.Visible = true;
            scrlbar.Visible = true;
            miView.Enabled = true;
            Start();            
        }

        private void LoadChart(int start, int end)
        {
            s.Points.Clear();
            //s.ChartType = SeriesChartType.Line;
            //s.YValueType = ChartValueType.Int32;
            List<int> data = new List<int>();

            int[] a= Data.GetWords(start, end);
            int i;
            for (i = 0; i < a.Length; i++)
            {
                s.Points.AddY(a[i]);
            }
            //chart1.Series.Clear();
            if (first)
            {
                chart1.Series.Add(s);
                chart1.ChartAreas[0].AxisY.Minimum = short.MinValue;
                chart1.ChartAreas[0].AxisY.Maximum = short.MaxValue;
                first = false;
            }
            //chart1.Series[0] = s;
            //Application.DoEvents();
            
        }

        //private void scrlbar_Scroll(object sender, ScrollEventArgs e)
        //{
        //    vOld = e.OldValue;
        //    vNew = e.NewValue;
        //}

        private void scrlbar_ValueChanged(object sender, EventArgs e)
        {
            int end = scrlbar.Value + Int32.Parse(txtByteShown.Text);
            LoadChart(scrlbar.Value, end);
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void txtByteShown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            // Check for a naughty character in the KeyDown event.
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
                return;
            }
            short temp;
            bool check = Int16.TryParse(txtByteShown.Text + e.KeyChar.ToString(), out temp);
            if (!check)
            {
                e.Handled = true; 
                return;
            }
        }

        private void txtByteShown_TextChanged(object sender, EventArgs e)
        {
            int end;
            bool check = Int32.TryParse(txtByteShown.Text,out end);
            if (check)
            {
                scrlbar.SmallChange = end;
                scrlbar.LargeChange = end * 2;
                LoadChart(scrlbar.Value,scrlbar.Value + end);
            }
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuality.SelectedIndex == 0)
            { 
                //Low
                chart1.AntiAliasing = AntiAliasingStyles.None;
            }
            if (cmbQuality.SelectedIndex == 1)
            {
                //Medium
                chart1.AntiAliasing = AntiAliasingStyles.Text;
                chart1.TextAntiAliasingQuality = TextAntiAliasingQuality.Normal;
            }
            if (cmbQuality.SelectedIndex == 2)
            {
                //High
                chart1.AntiAliasing = AntiAliasingStyles.All;
                chart1.TextAntiAliasingQuality = TextAntiAliasingQuality.High;
            }
        }

        private void cmbDecode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDecode.SelectedIndex == 0)
            {
                //Big Endian
                Data.SetDecoder(Data.Decoder.BIG_ENDIAN);
                if (chart1.Visible)
                {
                    //refresh chart
                    Start();
                }
            }
            if (cmbDecode.SelectedIndex == 1)
            {
                //Little Endian
                Data.SetDecoder(Data.Decoder.LITTLE_ENDIAN);
                if (chart1.Visible)
                {
                    //refresh chart
                    Start();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbDecode.SelectedIndex = 1;
        }

        public void Start()
        {
            chart1.Series.Clear();
            Data.LoadFile(openFileDialog1.FileName);
            scrlbar.Maximum = Data.Decode().Length;
            first = true;
            //scrlBar.Maximum = Data.GetWords().Length;
            s = new Series(openFileDialog1.SafeFileName);
            s.ChartType = SeriesChartType.Line;
            s.YValueType = ChartValueType.Int32;
            cmbQuality.SelectedIndex = 2;

            int end;
            bool check = Int32.TryParse(txtByteShown.Text, out end);
            if (check)
            {
                scrlbar.SmallChange = end;
                scrlbar.LargeChange = end * 2;
                scrlbar.Value = 0;
                LoadChart(0, end);
            }
        }

    }
}
