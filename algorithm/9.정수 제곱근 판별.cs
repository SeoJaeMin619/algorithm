using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution9
{
    public long solution9(long n)
    {
        long x = (long)Math.Sqrt(n);
        return (x * x == n) ? (x + 1) * (x + 1) : -1;
    }
}