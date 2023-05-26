using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_rekurzija_i_permutacije
{
    class Permutacije
    {
        public void ZamjeniDvaBroja(ref int a, ref int b)
        {
            int temp = a;
            a = b; 
            b = temp;
        }
        public void IspisPermutacije(int[] lista, int k, int n)
        {
            
            if(k == n)
            {
                for(int i = 0; i <= n; i++)
                {
                    Console.Write("{0}", lista[i]);
                }
                Console.Write(" ");
            }
            else
            {
                for(int i = k; i <= n; i++)
                {
                        ZamjeniDvaBroja(ref lista[k], ref lista[i]);
                        IspisPermutacije(lista,k + 1, n);
                        ZamjeniDvaBroja(ref lista[k], ref lista[i]);
                }
            }
        }
    }
}
