using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsMemeryTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Imposter_CheckedChanged(object sender, EventArgs e)
        {
            Globals.clientImposter = Convert.ToByte(ClientImposter.Checked);
            Globals.updateClientImposter = true;   
        }
        private void Dead_CheckedChanged(object sender, EventArgs e)
        {
            Globals.clientDead = Convert.ToByte(ClientDead.Checked);
            Globals.updateClientDead = true;
        }
        private void SpeedBar_ValueChanged(object sender, System.EventArgs e)
        {
            Globals.speed = (float) SpeedBar.Value;
            Globals.updateSpeed = true;
        }
        private void KillTimer_ValueChanged(object sender, System.EventArgs e)
        {
            Globals.killTimer = (float) KillTimerBar.Value;
            Globals.updateKillTimer = true;
        }
    }
}
