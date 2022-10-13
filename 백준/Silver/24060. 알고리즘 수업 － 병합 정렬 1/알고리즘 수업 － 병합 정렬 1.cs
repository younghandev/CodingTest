using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    public static int[] temp = new int[500001];
    
    static void Main() {
        int[] nk = ReadLine().Split().Select(int.Parse).ToArray();
        int[] a = ReadLine().Split().Select(int.Parse).ToArray();
        
        int count = 0;
        
        MergeSort(a, 0, a.Length-1, ref count, nk[1]);
        
        if (count < nk[1]) WriteLine(-1);
    }
    
    public static void MergeSort(int[] a, int p, int r, ref int _count, int check) {
        if (p < r) {
            int q = (p + r) / 2;
            
            MergeSort(a, p, q, ref _count, check);
            MergeSort(a, q+1, r, ref _count, check);
            
            Merge(a, p, q, r, ref _count, check);
        }
    }
    
    public static void Merge(int[] a, int p, int q, int r, ref int _count, int check) {
        int i = p;
        int j = q + 1;
        int t = 1;
        
        while (i <= q && j <= r) {
            if (a[i] <= a[j]) {
                temp[t++] = a[i++];
            }
            else {
                temp[t++] = a[j++];
            }
        }
        
        while (i <= q) {
            temp[t++] = a[i++];
        }
        
        while (j <= r) {
            temp[t++] = a[j++];
        }
        
        i = p;
        t = 1;
        
        while(i <= r) {
            if (++_count == check) WriteLine(temp[t]);
            
            a[i++] = temp[t++];
        }
    }
}