using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_WF
{
    class RechnerModel
    {

       //Konstanten
        private const string PLUS = "+";
        private const string MINUS = "-";
        private const string MAL = "*";
        private const string GETEILT = "/";
        private const string ISTGLEICH = "=";

        //Variablen
        private double zahl1;
        private double zahl2;
        private double zahl3;
        private string operation1;
        private string operation2;
        private string operation3;

        public double Resultat { get; private set; }
        public string ErrorAnzeige { get; private set; }

        private string operation;
        public string Operation
        {
            get { return operation; }
            set
            {
                if (value == "C")
                {
                    Initialisiere();
                }
                else if(operation1 == "")
                {
                    operation1 = value;
                }
                else if(operation2 == "")
                {
                    operation2 = value;
                }
                else
                {
                    operation3 = value;
                }
                operation = value;
            }
        }

        //Konstruktor
        public RechnerModel()
        {
            Operation = "C";
            Initialisiere();
        }

        private void Initialisiere()
        {
            zahl1 = Double.NaN;
            zahl2 = Double.NaN;
            zahl3 = Double.NaN;
            Resultat = 0;
            ErrorAnzeige = "";
            operation1 = "";
            operation2 = "";
            operation3 = "";
        }

        public void SetzeZahl(double zahl)
        {
            if(Double.IsNaN(zahl1))
            {
                zahl1 = zahl;
            }
            else if (Double.IsNaN(zahl2))
            {
                zahl2 = zahl;
            }
            else if (Double.IsNaN(zahl3))
            {
                zahl3 = zahl;
            }     
        }

        public bool RechnungAuswerten()
        {
            bool bl_brechnung = false;

            if((operation1 != "") && (operation2 != "")&& (operation3 == ""))
            {
                if(PunktVorStrich(operation1,operation2))
                {
                    //zahl1 und operation1 für spätere Berechnung merken

                }
                else
                {
                    if(Double.IsNaN(zahl2))
                    {
                        Berechne(Resultat, zahl1, operation1);
                    }
                    else
                    {
                        Berechne(zahl1, zahl2, operation1);
                    }
                    zahl1 = Double.NaN;
                    zahl2 = Double.NaN;
                    operation1 = operation2;
                    operation2 = "";
                    bl_brechnung = true;
                }
            }

            if (operation3 != "")
            {
                if(PunktVorStrich(operation1, operation2))
                {
                    Berechne(zahl2, zahl3, operation2);
                    zahl2 = Resultat;
                    zahl3 = Double.NaN;
                  
                    if (WechselVonPunktAufStrich(operation2, operation3))
                    {
                        //Wenn ein Wechsel von Punkt auf Strich stattfindet, kann die zahl1 zu dem Zwischenresultat verechnet werden
                        Berechne(zahl1, Resultat, operation1);
                        bl_brechnung = true; // Resultat kann angezeigt werden
                        zahl1 = Resultat;
                        zahl2 = Double.NaN;
                        operation1 = operation3;
                        operation2 = "";
                        operation3 = "";
                        
                    }
                    else
                    {
                        operation2 = operation3;
                        operation3 = "";
                    }
                    
                }
            }

                return bl_brechnung;
        }

        private void Berechne (double zahl1, double zahl2, string operation)
        {
            switch (operation)
            {
                case "+":
                    //Ausführung der Addition
                    Resultat = Addiere(zahl1, zahl2);
                    break;
                case "-":
                    //Ausführung der Subraktion
                    Resultat = Subtrahiere(zahl1, zahl2);       
                    break;
                case "/":
                    //Ausführung der Division
                    Resultat = Dividiere(zahl1, zahl2);        
                    break;
                case "*":
                    //Ausführung der Multiplikation
                    Resultat = Multipliziere(zahl1, zahl2);
                    break;
                default:
                    break;
            }
        }

        private bool PunktVorStrich(string operation1, string operation2)
        {
            bool bl_punktVorstrich = false;
            if ((operation1 == PLUS || operation1 == MINUS) && (operation2 == MAL || operation2 == GETEILT))
            {
                bl_punktVorstrich = true;
            }
            return bl_punktVorstrich;
        }

        private bool WechselVonPunktAufStrich (string operation1, string operation2)
        {
            bool bl_wechsel = false;

            if ((operation1 == MAL || operation1 == GETEILT)&& (operation2 == PLUS || operation2 == MINUS))
            {
                bl_wechsel = true;
            }
            return bl_wechsel;
        }

        #region Rechnenoperationen
        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }

        private double Subtrahiere(double minuend, double subrahend)
        {
            double differenz = minuend - subrahend;
            return differenz;
        }

        private double Multipliziere(double factor1, double factor2)
        {
            double produkt = factor1 * factor2;
            return produkt;
        }

        private double Dividiere(double dividend, double divisor)
        {
            double quotient = dividend / divisor;
            if(divisor==0)
            {
                ErrorAnzeige = "Error Division durch 0";
            }
            
            return quotient;
        }
        #endregion
    }

}
