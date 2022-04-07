using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop01
{
    
    internal class NakladniAuto
    {
        private string spz;
        private double nosnost;
        private double HmotnostNakladu = 0;

        public NakladniAuto(string spz, double nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }
        public double GetHmotnostNakladu(double HmotnostNakladu)
        {
            return HmotnostNakladu;
        }


        public string GetSpz(string spz)
        {
            return spz;
        }
        

        public double GetNosnost(double nosnost)
        {
            return nosnost;
        }

        public double NalozNaklad(double hmotnostNakladky)
        {
            double nebyloNalozeno = 0;
           if((HmotnostNakladu + hmotnostNakladky) <= nosnost)
            {
                HmotnostNakladu += hmotnostNakladky;
            }
            else
            {
                nebyloNalozeno = HmotnostNakladu + hmotnostNakladky - nosnost;
                 HmotnostNakladu = nosnost;
                //HmotnostNakladu += hmotnostNakladky - nebyloNalozeno;
               
            }
            return nebyloNalozeno;
         

            
        }
        public double VylozNaklad(double hmotnostVykladky)
        {
            double chybiMaterialu = 0;
            if(hmotnostVykladky > HmotnostNakladu)
            {
                chybiMaterialu = hmotnostVykladky - HmotnostNakladu; ;
                HmotnostNakladu = 0;
            }
            else 
            {
                HmotnostNakladu -= hmotnostVykladky;
            }

            return chybiMaterialu;

        }
        public override string ToString()
        {

            string s = "\nNákladní auto: " + spz
                + "\nMá nosnost: " + nosnost + " t"
                + "\nMá naloženo: " + HmotnostNakladu + " t";



            return base.ToString() + s;
        }





    }
}
