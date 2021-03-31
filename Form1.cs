using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownTimer_2Dia
{
    public partial class Home : Form
    {
        public TimeSpan resta;
        public DateTime diaEspe;
        bool atv = false;
        public Home()
        {
            InitializeComponent();
        }

        struct Hoje
        {
            public DateTime TempoHoje()
            {
                var diaHoje = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                var horar = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                diaHoje = diaHoje + horar;
                return diaHoje;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            diaEspe = Convert.ToDateTime(monthCalendar1.SelectionRange.End.ToLongDateString());
            var horar2 = new TimeSpan(Convert.ToInt32(upHora.Value),Convert.ToInt32(upMin.Value), 0);
            diaEspe = diaEspe + horar2;
            CountdownTimer_2Project.Properties.Settings.Default.TempoAnt = diaEspe;
            CountdownTimer_2Project.Properties.Settings.Default.Save();
            Calcular();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (atv == true)
            {
                var seg = new TimeSpan(0, 0, 1);
                resta = resta.Subtract(seg);

                string diasT = Convert.ToString(resta.Days);
                string horaT = Convert.ToString(resta.Hours);
                string minT = Convert.ToString(resta.Minutes);
                string segT = Convert.ToString(resta.Seconds);

                if (segT.Length == 1)
                {
                    segT = segT.PadLeft(2, '0');
                }
                if (minT.Length == 1)
                {
                    minT = minT.PadLeft(2, '0');
                }
                if (horaT.Length == 1)
                {
                    horaT = horaT.PadLeft(2, '0');
                }

                lblTempo.Text = diasT +" dias / "+horaT+":" + minT + ":" + segT;
                circularProgressBar1.Value = Convert.ToInt32(segT);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if ((CountdownTimer_2Project.Properties.Settings.Default.TempoAnt == null) == false){
                diaEspe = CountdownTimer_2Project.Properties.Settings.Default.TempoAnt;
                Calcular();
            }
        }

        public void Calcular()
        {
            Hoje h1;
            var diaHoje = h1.TempoHoje();
            var contagem = diaEspe.Subtract(diaHoje);
            if ((contagem.Days >= 0) && (contagem.Minutes >= 0))
            {
                atv = true;
                resta = contagem;
            }
            else
            {
                MessageBox.Show("Erro. Data inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            CountdownTimer_2Project.Properties.Settings.Default.Save();
        }
    }
}
