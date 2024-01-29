using System;

namespace Prop
{
    public class TestProp
    {
        private decimal NB1 = 0;
        private decimal NB2 = 0;
        public decimal nb1
        {
            get{
                return NB1;
            } 
            set{
                if(value ==0)
                NB1 = 1;
                else
                NB1 = value;
            }
        }
        public decimal nb2
        {
            get{
                return NB2;
            } 
            set{
                if(value ==0)
                NB2 = 1;
                else
                NB2 = value;
            }
        }
        public decimal Somme()
        {
            return NB1+NB2;
        }
        public decimal Quotient()
        {
            if (nb2==0)return 0;
            else return NB1/NB2;
        }

    }
}