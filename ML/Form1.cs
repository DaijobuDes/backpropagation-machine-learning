using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Backprop;
using LumenWorks.Framework.IO.Csv;

namespace ML
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 110 hidden output because why not
            nn = new NeuralNet(11, 110, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"T:\input.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                // Inputs, basically 11 inputs, starting at 0
                nn.setInputs(0, Convert.ToDouble(csvTable.Rows[i][0].ToString()));
                nn.setInputs(1, Convert.ToDouble(csvTable.Rows[i][1].ToString()));
                nn.setInputs(2, Convert.ToDouble(csvTable.Rows[i][2].ToString()));
                nn.setInputs(3, Convert.ToDouble(csvTable.Rows[i][3].ToString()));
                nn.setInputs(4, Convert.ToDouble(csvTable.Rows[i][4].ToString()));
                nn.setInputs(5, Convert.ToDouble(csvTable.Rows[i][5].ToString()));
                nn.setInputs(6, Convert.ToDouble(csvTable.Rows[i][6].ToString()));
                nn.setInputs(7, Convert.ToDouble(csvTable.Rows[i][7].ToString()));
                nn.setInputs(8, Convert.ToDouble(csvTable.Rows[i][8].ToString()));
                nn.setInputs(9, Convert.ToDouble(csvTable.Rows[i][9].ToString()));
                nn.setInputs(10, Convert.ToDouble(csvTable.Rows[i][10].ToString()));

                // Quality (The output)
                
                switch (csvTable.Rows[i][11].ToString())
                {
                    /*
                    case "0":
                        nn.setDesiredOutput(0, 0.0);
                        break;
                    case "1":
                        nn.setDesiredOutput(0, 0.1);
                        break;
                    case "2":
                        nn.setDesiredOutput(0, 0.2);
                        break;
                    case "3":
                        nn.setDesiredOutput(0, 0.0);
                        break;
                    */
                    case "4":
                        nn.setDesiredOutput(0, 0.5);
                        break;
                    case "5":
                        nn.setDesiredOutput(0, 0.6);
                        break;
                    case "6":
                        nn.setDesiredOutput(0, 0.7);
                        break;
                    case "7":
                        nn.setDesiredOutput(0, 0.8);
                        break;
                    case "8":
                        nn.setDesiredOutput(0, 0.9);
                        break;
                    /*
                    case "9":
                        nn.setDesiredOutput(0, 0.9);
                        break;
                    case "10":
                        nn.setDesiredOutput(0, 1.0);
                        break;
                    */
                    default:
                        // nn.setDesiredOutput(0, 0.0);
                        break;
                }

                // nn.setDesiredOutput(0, Convert.ToDouble(csvTable.Rows[i][11].ToString()) * 0.1);
                nn.learn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            //nn.setInputs(1, Convert.ToDouble(textBox1.Text));
            //nn.run();
            //textBox3.Text = "" + nn.getOuputData(0);
            nn.setInputs(0, Convert.ToDouble(fixedacidity_textBox.Text));
            nn.setInputs(1, Convert.ToDouble(volatileacidity_textBox.Text));
            nn.setInputs(2, Convert.ToDouble(citricacid_textBox.Text));
            nn.setInputs(3, Convert.ToDouble(residualsugar_textBox.Text));
            nn.setInputs(4, Convert.ToDouble(chlorides_textBox.Text));
            nn.setInputs(5, Convert.ToDouble(freesulfur_textBox.Text));
            nn.setInputs(6, Convert.ToDouble(totalsulfur_textBox.Text));
            nn.setInputs(7, Convert.ToDouble(density_textBox.Text));
            nn.setInputs(8, Convert.ToDouble(phvalue_textBox.Text));
            nn.setInputs(9, Convert.ToDouble(sulphates_textBox.Text));
            nn.setInputs(10, Convert.ToDouble(alcohol_textBox.Text));

            // Run training
            nn.run();

            quality_textBox.Text = "" + nn.getOuputData(0);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            fixedacidity_textBox.Text = "";
            volatileacidity_textBox.Text = "";
            citricacid_textBox.Text = "";
            residualsugar_textBox.Text = "";
            chlorides_textBox.Text = "";
            freesulfur_textBox.Text = "";
            totalsulfur_textBox.Text = "";
            density_textBox.Text = "";
            phvalue_textBox.Text = "";
            sulphates_textBox.Text = "";
            alcohol_textBox.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
