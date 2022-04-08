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
        private double hmotnostNakladu = 0;

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
        public double GeHmotnostNakladu(double HmotnostNakladu)
        {
            return HmotnostNakladu;
        }


        public double GetNosnost(double nosnost)
        {
            return nosnost;
        }

       /* public double NalozNaklad(double hmotnostNakladky)
        {
            double nebyloNalozeno = 0;
           if((hmotnostNakladu + hmotnostNakladky) <= nosnost)
            {
                hmotnostNakladu += hmotnostNakladky;
            }
            else
            {
                nebyloNalozeno = hmotnostNakladu + hmotnostNakladky - nosnost;
                 hmotnostNakladu = nosnost;
                //HmotnostNakladu += hmotnostNakladky - nebyloNalozeno;
               
            }
            return nebyloNalozeno;
                    
        }*/
       public void NalozNaklad(double nalozit)
        {
            double nebyloNalozeno = 0;
            if ((hmotnostNakladu + nalozit) <= nosnost)
            {
                hmotnostNakladu += nalozit;
            }
            else
            {
                nebyloNalozeno = hmotnostNakladu + nalozit - nosnost;
                hmotnostNakladu = nosnost;
                //HmotnostNakladu += hmotnostNakladky - nebyloNalozeno;
                System.Windows.Forms.MessageBox.Show("Nebylo naloženo: " + nebyloNalozeno + " t");
                

            }
            
            return;
        }
        public void VylozNaklad(double vyloz)
        {
            double chybiMaterialu = 0;
            if(vyloz > hmotnostNakladu)
            {
                chybiMaterialu = vyloz - hmotnostNakladu; ;
                hmotnostNakladu = 0;
                System.Windows.Forms.MessageBox.Show("Chybi materialu: " + chybiMaterialu + " t");
            }
            else 
            {
                hmotnostNakladu -= vyloz;
            }

            return;

        }
        public override string ToString()
        {

            string s = "\nNákladní auto: " + spz
                + "\nMá nosnost: " + nosnost + " t"
                + "\nMá naloženo: " + hmotnostNakladu + " t";



            return base.ToString() + s;
        }





    }
}
