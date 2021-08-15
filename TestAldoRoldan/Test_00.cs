using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAldoRoldan
{
    public class Test_00
    {       
        static void Main(string[] args)
        {
                  

        }

        public static String GetPath()
        {
            var url = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            //correction in path to point it in Root directory
            var mainpath = url.Replace("\\bin\\Debug", "");
            var pthurl = mainpath.Replace("file:\\", "");
      
            return pthurl;


        }

    }
}
