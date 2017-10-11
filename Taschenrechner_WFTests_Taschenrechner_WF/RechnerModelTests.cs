using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taschenrechner_WF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_WF.Tests
{
    [TestClass()]
    public class RechnerModelTests
    {
        [TestMethod()]
        public void TestFall1()
        {
            //Rechnung Fall 1. Gleiche Rechenoperation, kein Wechsel
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(3);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(4);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 7, 0);
        }

        [TestMethod()]
        public void TestFall2()
        {
            //Rechnung Fall 2. Wechsel im Strichbereich bzw. Punktbereich bzw. Istgleich-Zeichen
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(1);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(2);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "-";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(4);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 2, 0);
        }

        [TestMethod()]
        public void TestFall3()
        {
            //Rechnung Fall3: Wechsel von Strich auf Punkt
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(47);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(5);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 62, 0);
        }

        [TestMethod()]
        public void TestFall4()
        {
            //Rechnung Fall4: Wechsel von Punkt auf Strich
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(5);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(2);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 50, 0);
        }

        [TestMethod()]
        public void TestFall5()
        {
            //Rechnung: Wechsel von Strich auf Punkt und wieder auf Strich
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(2);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(5);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(2);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 49, 0);

        }

        [TestMethod()]
        public void TestFall6()
        {
            //Rechnung Wechsel von Punkt auf Strich und wieder auf Punkt
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(5);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(2);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(5);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 62, 0);
        }

        [TestMethod()]
        public void TestFall7()
        {
            //Rechnung Wechsel von Strich auf Punkt auf Strich und wieder auf Punkt
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(2);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(5);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(5);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(2);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 83, 0);
        }

        [TestMethod()]
        public void TestFall8()
        {
            //Rechnung Wechsel von Strich auf Punkt auf Strich und wieder auf Punkt
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(2);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "+";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(2);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 13, 0);
        }

        [TestMethod()]
        public void TestFall9()
        {
            //Rechnung Wechsel im Punktzeichen
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(5);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(2);
            rechner.Operation = "/";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 10, 0);

        }

        [TestMethod()]
        public void TestFall10()
        {
            //Rechnung und dann Drücken der Taste C
            RechnerModel rechner = new RechnerModel();
            rechner.SetzeZahl(5);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "*";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(2);
            rechner.Operation = "/";
            rechner.RechnungAuswerten();
            rechner.SetzeZahl(3);
            rechner.Operation = "=";
            rechner.RechnungAuswerten();
            rechner.Operation = "C";
            rechner.RechnungAuswerten();
            Assert.AreEqual(rechner.Resultat, 0, 0);
        }
    }
}