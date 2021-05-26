using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory; //MEMORY.DLL

namespace DynamicHangarMod
{
    public partial class HangarMemory : Form
    {
        Mem WoTBHook = new Mem(); //Create WoTBHook
        public HangarMemory()
        {
            InitializeComponent();
        }

        private void HangarMemory_Load(object sender, EventArgs e)
        {
            //CHECK IF GAME IS OPEN (PID)
            int PID = WoTBHook.GetProcIdFromName("wotblitz");
            if (PID > 0)
            {
                WoTBHook.OpenProcess(PID); //ATTACH TO WOTB
            }
            else
            {
                MessageBox.Show("Please open the game before starting", "Dynamic Hangar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
                //Application.Exit();

                //Later
            }
        }

        private void ClosingButton_Click(object sender, EventArgs e)
        {
            //CLOSE APP
            this.Close();
            Application.Exit();
        }

        private void DeplaceButton_Click(object sender, EventArgs e)
        {
            //START MOD - WRITE CODE HERE
        }
    }
}
