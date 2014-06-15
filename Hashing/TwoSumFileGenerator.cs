using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Hashing
{
    public class TwoSumFileGenerator
    {
        /*
        a = [0] * 1000000; t = 0; modulus = 2 ** 24; 
        for i in xrange(1000000) : 
            t = (615949*t + 797807) % modulus
            a[i] = t - modulus / 2

        for i in (20,100,1000,10000,100000,1000000) :
            fname = "sum2tc_%d.txt" % i
            f = open(fname,"w")
            for j in xrange(i) : f.write("%d\n" % a[j])
            f.close()
         */

        public string Generate(int numberCount)
        {
            const int size = 1000000;
            var modulus = Convert.ToInt64(Math.Pow(2, 24));

            var a = new long[size];
            var t = 0L; 

            foreach (var i in Enumerable.Range(0, size))
            {
                t = (615949L*t + 797807L)%modulus;
                a[i] = t - modulus/2;
            }

            var data = new StringBuilder(numberCount * 10);

            foreach (var j in Enumerable.Range(0, numberCount))
            {
                data.AppendLine(a[j].ToString(CultureInfo.InvariantCulture));
            }

            var fileName = String.Format("sum2tc_{0}.txt", numberCount);
            File.WriteAllText(fileName, data.ToString());

            return fileName;
        }
    }
}