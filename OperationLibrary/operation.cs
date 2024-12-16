using System;

namespace OperationLibrary
{
    public class operation : MarshalByRefObject
    {
        public int Add(int firstnum, int secnum, int thirdnum) => firstnum + secnum + thirdnum;

        public int Sub(int firstnum, int secnum, int thirdnum) => firstnum - secnum - thirdnum;


        public int Mul(int firstnum, int secnum, int thirdnum)=> firstnum * secnum * thirdnum;


        public double Div(int firstnum, int secnum, int thirdnum)=>secnum==0? 0e8 :((double)firstnum/(double)secnum)/(double) thirdnum;

        public int Rem(int firstnum, int secnum, int thirdnum) => (firstnum % secnum) % thirdnum;
    }
}
