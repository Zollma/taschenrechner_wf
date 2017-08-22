using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner_WF
{
    public partial class TaschenrechnerForm : Form
    {
        private string anzeigeString;
        private RechnerModel rechner;

        public TaschenrechnerForm()
        {
            InitializeComponent();
            rechner = new RechnerModel();
        }

        private void OperationAusfuehren(string operation)
        {
            if (anzeigeString != "")
            {
                double zahl = Convert.ToDouble(anzeigeString);
                rechner.SetzeZahl(zahl);
                anzeigeString = "";
                rechner.Operation = operation;
                //Wenn genügend Zahlen für eine Berechnung vorliegen und ein Zwischenergebnis geliefert werden kann
                if (rechner.RechnungAuswerten())
                {
                    this.AnzeigeRechnung.Text = Convert.ToString(rechner.Resultat);
                }   
            }
            if (operation == "=")
            {
                anzeigeString = Convert.ToString(rechner.Resultat);
            }

            if (operation == "C")
            {
                this.AnzeigeRechnung.Text = "";
            }
        }
        private void AnzeigeRechnung_Click(object sender, EventArgs e)
        {

        }

        private void TaschenrechnerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString +"1";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "2";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "3";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "4";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "5";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "6";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "7";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "8";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "9";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            anzeigeString = anzeigeString + "0";
            this.AnzeigeRechnung.Text = anzeigeString;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            OperationAusfuehren("C");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

            OperationAusfuehren("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            OperationAusfuehren("-");
        }

        private void buttonMal_Click(object sender, EventArgs e)
        {
            OperationAusfuehren("*");
        }

        private void buttonGeteilt_Click(object sender, EventArgs e)
        {
            OperationAusfuehren("/");
            
         }

        private void buttonErgebnis_Click(object sender, EventArgs e)
        {
            OperationAusfuehren("=");
        }
    }
}
