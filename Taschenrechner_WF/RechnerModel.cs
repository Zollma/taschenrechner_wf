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
        //Zahlen die vom GUI kommen
        private double zahlenspeicher1;
        private double zahlenspeicher2;
        //Zahlen für die Berechnung
        private double zahl1;
        private double zahl2;
        private double zwischenErgebnis;
        private string operation1;
        private string operation2;
        private string operationBerechnungAusfuehren;
        //Operation und Zahl für spätere Strichberechnung
        private string operationStrich;
        private double zahlStrich;
        bool berechneStrich;

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
                
                operation = value;
            }
        }

        //Konstruktor
        public RechnerModel()
        {
            Operation = "C";
            Initialisiere();
        }

        private void ZahlenspeicherInitialisieren()
        {
            zahlenspeicher1 = Double.NaN;
            zahlenspeicher2 = Double.NaN;
        }

        private void Initialisiere()
        {
            ZahlenspeicherInitialisieren();
            zahl1 = Double.NaN;
            zahl2 = Double.NaN;
            zwischenErgebnis = Double.NaN;
            Resultat = 0;
            ErrorAnzeige = "";
            operation1 = "";
            operation2 = "";
            operationBerechnungAusfuehren = "";
            InitialisiereZahlStrichUndOperationStrich();
        }

        public void SetzeZahl(double zahl)
        {
            if(Double.IsNaN(zahlenspeicher1))
            {
                zahlenspeicher1 = zahl;
            }
            else if (Double.IsNaN(zahlenspeicher2))
            {
                zahlenspeicher2 = zahl;
            }
        }

        private bool IstZahlenSpeicherFuerBerechnungBereit()
        {
            bool bereit = false;
            if ((!(Double.IsNaN(zahlenspeicher1))) && (!(Double.IsNaN(zahlenspeicher2))))
            {
                bereit = true;
            }
            return bereit;
        }

        private bool IstZahlStrichUndOperationStrichBereit()
        {
            bool bereit = false;
            if(!(Double.IsNaN(zahlStrich))&& (operationStrich != ""))
            {
                bereit = true;
            }
            return bereit; 
        }

        private void InitialisiereZahlStrichUndOperationStrich()
        {
            operationStrich = "";
            zahlStrich = Double.NaN;
            berechneStrich = false;
        }

        public bool RechnungAuswerten()
        {
            bool bl_brechnung = false;

            if (IstZahlenSpeicherFuerBerechnungBereit())
            {
                PruefeZeichenWechsel();
                if (IstZahlenSpeicherFuerBerechnungBereit())
                {
                    bl_brechnung = true;
                    zahl1 = zahlenspeicher1;
                    zahl2 = zahlenspeicher2;
                    ZahlenspeicherInitialisieren();
                    Berechne(zahl1, zahl2, operationBerechnungAusfuehren);

                    if (berechneStrich)
                    {
                        Berechne(Resultat, zahlStrich, operationStrich);
                        InitialisiereZahlStrichUndOperationStrich();
                    }

                    zwischenErgebnis = Resultat;
                    zahlenspeicher1 = zwischenErgebnis;
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

        private void PruefeZeichenWechsel()
        {
            //Fall1: Kein Wechsel
            if (operation1 == operation2)
            {
                operationBerechnungAusfuehren = operation1;
                operation1 = operation2;
                operation2 = "";
            }
            else
            {
                if(WechselVonStrichAufPunkt())
                {
                    //Fall3: Wechsel von Strich auf Punkt
                    zahlStrich = zahlenspeicher1;
                    zahlenspeicher1 = zahlenspeicher2;
                    zahlenspeicher2 = Double.NaN;
                    operationStrich = operation1;
                    operation1 = operation2;
                    operation2 = "";
                }
                else
                {
                    //Fall2: Wechsel im Strichbereich bzw. Punktbereich bzw. Istgleich-Zeichen
                    //Fall4: Wechsel von Punkt auf Strich
                    if ((WechselVonPunktAufStrich()|| operation2 == ISTGLEICH) && IstZahlStrichUndOperationStrichBereit())
                    {
                        berechneStrich = true;
                    }
                    operationBerechnungAusfuehren = operation1;
                    operation1 = operation2;
                    operation2 = "";
                    
                       
                }
            }
        }

        private bool WechselVonStrichAufPunkt()
        {
            bool bl_punktVorstrich = false;
            if ((operation1 == PLUS || operation1 == MINUS) && (operation2 == MAL || operation2 == GETEILT))
            {
                bl_punktVorstrich = true;
            }
            return bl_punktVorstrich;
        }

        private bool WechselVonPunktAufStrich ()
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
