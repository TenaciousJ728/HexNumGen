using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexNumberGen {

    public partial class Form1 : Form {
        public int[] rawGenOutput;
        private bool somethingsWrong;

        public Form1() {
            InitializeComponent();
            StartGen();
        }

        void chckBoxRandom_CheckedChanged(object sender, EventArgs e) {
            if (chckBoxRandom.Checked) 
                txtBoxStartAt.Enabled = false;
            else 
                txtBoxStartAt.Enabled = true;
        }

        private void StartGen() {
            somethingsWrong = false;
            upDwnQuantity.Value = Convert.ToInt32(upDwnQuantity.Value);
            upDwnSize.Value = Convert.ToInt32(upDwnSize.Value);
            upDwnStep.Value = Convert.ToInt32(upDwnStep.Value);
            rawGenOutput = Generate();
            if (somethingsWrong)
                return;
            txtBoxOutput.Text = Output();
        }

        private int[] Generate() {
            int muhStart;
            try {
                muhStart = Convert.ToInt32(txtBoxStartAt.Text, 16);
            } catch {
                somethingsWrong = true;
                txtBoxOutput.Text = "Please re-enter starting hex value.";
                return null;
            }
            int[] muhHex = new int[(int)upDwnQuantity.Value];
            if (!chckBoxRandom.Checked) {
                for (int i = 0; i < muhHex.Count(); i++)
                    muhHex[i] = muhStart + ((int)upDwnStep.Value * i);
            }
            return muhHex;
        }

        private string Output() {
            string muhOutputString = "";
            for (int i = 0; i < rawGenOutput.Count(); i++) {
                if (i > 0)
                    muhOutputString = muhOutputString + "\r\n";
                muhOutputString = muhOutputString + rawGenOutput[i].ToString("X" + upDwnSize.Value.ToString());
            }
            return muhOutputString;
        }

        private void upDwnSize_ValueChanged(object sender, EventArgs e)
        {
            StartGen();
        }

        private void upDwnQuantity_ValueChanged(object sender, EventArgs e)
        {
            StartGen();
        }

        private void txtBoxStartAt_TextChanged(object sender, EventArgs e)
        {
            StartGen();
        }

        private void upDwnStep_ValueChanged(object sender, EventArgs e)
        {
            StartGen();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxOutput.Text);
        }
    }
}
