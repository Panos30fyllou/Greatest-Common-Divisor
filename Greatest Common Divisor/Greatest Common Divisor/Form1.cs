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

namespace Greatest_Common_Divisor
{
    public partial class Form1 : Form
    {
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = 1;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                //Show Algorithm Definition
                algorithmTitleLabel.Visible = true;
                algorithmLabel.Visible = true;
                i++;
            }
            else if (i == 2)
            {
                //Show Example
                exampleLabel.Visible = true;
                i++;
            }
            else if (i == 3)
            {
                showAlgorithm1();
                i++;
            }
            else if (i == 4)
            {
                showAlgorithm2();
                nextButton.Text = "ΕΠΑΝΑΛΗΨΗ";
                i++;
            }
            else if (i == 5)
            {
                clearAll();
                nextButton.Text = "ΕΠΟΜΕΝΟ";
                i = 1;
            }
        }

        private void execAlg2_Click(object sender, EventArgs e)
        {
            int value1, value2;
            try
            {
                value1 = Convert.ToInt32(alg2X.Text);
                value2 = Convert.ToInt32(alg2Y.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            //Euclidean Algorithm
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int x = value1;
            int y = value2;
            int z = y;
            while (z != 0)
            {
                z = x % y;
                x = y;
                y = z;
            }
            stopwatch.Stop();
            exec2TimeLabel.Text = "Χρόνος Εκτέλεσης: " + stopwatch.ElapsedTicks + " ms";
            mdk2Label.Text = "ΜΚΔ: " + x;
        }

        private void execAlg1_Click(object sender, EventArgs e)
        {
            int value1, value2, z;
            try
            {
                value1 = Convert.ToInt32(alg1X.Text);
                value2 = Convert.ToInt32(alg1Y.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            //GCD Algorithm
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int x = value1;
            int y = value2;
            if (x > y) z = y;
            else z = x;
            while (x % z != 0 || y % z != 0)
            {
                z--;
            }
            stopwatch.Stop();
            exec1TimeLabel.Text = "Χρόνος Εκτέλεσης: " + stopwatch.ElapsedTicks + " ms";
            mdk1Label.Text = "ΜΚΔ: " + z;
            Console.WriteLine(z);
        }

        private void showAlgorithm1()
        {
            execTitleLabel.Visible = true;
            algorithm1Label.Visible = true;
            algorithm1.Visible = true;
            alg1XLabel.Visible = true;
            alg1YLabel.Visible = true;
            alg1X.Visible = true;
            alg1Y.Visible = true;
            execAlg1Button.Visible = true;
            mdk1Label.Visible = true;
            exec1TimeLabel.Visible = true;
        }

        private void showAlgorithm2()
        {
            algorithm2Label.Visible = true;
            algorithm2.Visible = true;
            alg2XLabel.Visible = true;
            alg2YLabel.Visible = true;
            alg2X.Visible = true;
            alg2Y.Visible = true;
            execAlg2Button.Visible = true;
            mdk2Label.Visible = true;
            exec2TimeLabel.Visible = true;
            conclusionLabel.Visible = true;
        }

        private void clearAll()
        {
            execTitleLabel.Visible = false;
            algorithmLabel.Visible = false;
            algorithmTitleLabel.Visible = false;
            algorithm2.Visible = false;
            algorithm2Label.Visible = false;
            exampleLabel.Visible = false;
            alg2XLabel.Visible = false;
            alg2YLabel.Visible = false;
            alg2X.Visible = false;
            alg2Y.Visible = false;
            execAlg2Button.Visible = false;
            mdk2Label.Visible = false;
            exec2TimeLabel.Visible = false;
            algorithm1.Visible = false;
            algorithm1Label.Visible = false;
            alg1XLabel.Visible = false;
            alg1YLabel.Visible = false;
            alg1X.Visible = false;
            alg1Y.Visible = false;
            execAlg1Button.Visible = false;
            mdk1Label.Visible = false;
            exec1TimeLabel.Visible = false;
            conclusionLabel.Visible = false;
        }
    }
}
