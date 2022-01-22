using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    public class SingleTonMy
    {

        private SingleTonMy()
        {
           
        }
        private  static  SingleTonMy obj = null;
        private static  Object lockObj = new object();
        
        public static  SingleTonMy GiveMeInstance()
        {
            if (obj == null)
            {
                lock (lockObj)
                {
                    if (obj == null)
                    {

                        obj= new SingleTonMy();
                    }
                }
            }
            
            
              return obj;
            
        }
    }
}
