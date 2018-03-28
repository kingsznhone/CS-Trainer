using hacker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hacker
{
    public partial class CShack : Form
    {
        public CShack()
        {
            InitializeComponent();
        }
        bool LockAmmo = false;
        uint BaseAddr = 0x11069BC;
        int Offset_Stage1 = 0x7C;
        int Offset_Stage2 = 0x5D8;
        int Offset_Stage3 = 0xCC;
        int bytesOut;
        uint ptr_s1;
        uint ptr_s2;
        uint ptr_s3;
        ProcessMemoryReader mReader = new ProcessMemoryReader();
        uint Ammo;
        private void CShack_Load(object sender, EventArgs e)
        {
            Process p = Process.GetProcessesByName("cstrike").ToList().FirstOrDefault();

            mReader.ReadProcess = p;
            mReader.OpenProcess();

            ptr_s1 = BitConverter.ToUInt32(mReader.ReadMemory((IntPtr)((uint)p.Modules[0].BaseAddress + (uint)BaseAddr), 4, out bytesOut), 0);
            ptr_s2 = BitConverter.ToUInt32(mReader.ReadMemory((IntPtr)((uint)ptr_s1 + (uint)Offset_Stage1), 4, out bytesOut), 0);
            ptr_s3 = BitConverter.ToUInt32(mReader.ReadMemory((IntPtr)((uint)ptr_s2 + (uint)Offset_Stage2), 4, out bytesOut), 0);
            mReader.ReadMemory((IntPtr)((uint)ptr_s3 + (uint)Offset_Stage3), 4, out bytesOut);
            LockTimer.Enabled = true;

            

        }

        private void LockTimer_Tick(object sender, EventArgs e)
        {
            Ammo = BitConverter.ToUInt32(mReader.ReadMemory((IntPtr)((uint)ptr_s3 + (uint)Offset_Stage3), 4, out bytesOut), 0);
            AmmoLB.Text = Convert.ToString(Ammo);
            if (LockAmmo)
            {
                byte[] Mag = new byte[4];
                Mag[0] = 0b00011110;
                mReader.WriteMemory((IntPtr)((uint)ptr_s3 + (uint)Offset_Stage3), Mag , out bytesOut);
            }
        }

        private void AmmoHack_Click(object sender, EventArgs e)
        {
            if (AmmoHack.Text == "Lock")
            {
                LockAmmo = true;
                AmmoHack.Text = "Unlock";
            }
            else
            {
                LockAmmo = false;
                AmmoHack.Text = "Lock";
            }
        }
    }
}
