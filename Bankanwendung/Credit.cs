using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankanwendung
{
    public class Credit
    {
        private double betrag = 0.0;
        public double GetBetrag()
        {
            return betrag;
        }
        public void SetBetrag(double value)
        {
            betrag = value;
        }

        private bool genehmigt = false;
        public bool GetGenehmigt()
        {
            return genehmigt;
        }
        public void SetGenehmigt(bool value)
        {
            genehmigt = value;
        }

        private double zins = 0.0;
        public double GetZins()
        {
            return zins;
        }
        public void SetZins(double value)
        {
            zins = value;
        }

        // Laufzeit in Tagen
        private int laufzeit = 0;
        public int GetLaufzeit()
        {
            return laufzeit;
        }
        public void SetLaufzeit(int value)
        {
            laufzeit = value;
        }
    }
}
