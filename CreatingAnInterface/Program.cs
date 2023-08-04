using System;
using System.Runtime.CompilerServices;

namespace CreatingAnInterface
{
    class program
    {
        static void Main(string[] args)
        {
            VWAmarok a = new VWAmarok();
            VWPolo polo = new VWPolo();
            VWGTI gti = new VWGTI();

            a.paint();
            polo.Badge();
            gti.polish();
           
        }
        public class VWPolo:IControls
        {
            public void Badge()
            {

            }

            public void infortainment()
            {
                throw new NotImplementedException();
            }

            public void inspection()
            {
                throw new NotImplementedException();
            }

            public void paint()
            {
                throw new NotImplementedException();
            }

            public void polish()
            {
                throw new NotImplementedException();
            }

            public void wheels()
            {
                throw new NotImplementedException();
            }
        }
        public class VWAmarok:IControls
        {
            public void Badge()
            {
                throw new NotImplementedException();
            }

            public void infortainment()
            {
                throw new NotImplementedException();
            }

            public void inspection()
            {
                throw new NotImplementedException();
            }

            public void paint()
            {
                throw new NotImplementedException();
            }

            public void polish()
            {
                throw new NotImplementedException();
            }

            public void wheels()
            {

            }
           
        }
        public class VWGTI:IControls
        {
            public void Badge()
            {
                throw new NotImplementedException();
            }

            public void infortainment()
            {
                throw new NotImplementedException();
            }

            public void inspection()
            {
                throw new NotImplementedException();
            }

            public void paint()
            {
                throw new NotImplementedException();
            }

            public void polish()
            {

            }

            public void wheels()
            {
                throw new NotImplementedException();
            }
        }
        interface IControls
        {
            void Badge();
            void infortainment();
            void wheels();
            void inspection();
            void paint();
            void polish();
        }
    }
}