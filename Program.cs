using System;

class Program{

    static void Main(string[] args){
       //soru 1
       
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int[] dizi = new int[n];
        for (int i = 0; i < n; i++)
        {
        int a = Convert.ToInt32(Console.ReadLine().Trim());
        dizi.Append(a);    
        }

        //soru 2

        int n2 = Convert.ToInt32(Console.ReadLine().Trim());
        int n3 = Convert.ToInt32(Console.ReadLine().Trim());
        int[] dizi2 = new int[n];
        for (int i = 0; i < n3; i++)
        {
        int a = Convert.ToInt32(Console.ReadLine().Trim());
        dizi2.Append(a);    
        }

        //soru 3

        int n4 = Convert.ToInt32(Console.ReadLine().Trim());
        string[] strdizi = new string[n4];
        for (int i = 0; i < n4; i++)
        {
        string a = Convert.ToString(Console.ReadLine().Trim());
        strdizi.Append(a);
        Array.Reverse(strdizi);    
        }

        //soru 4

        string cümle = Console.ReadLine();
        string[] dizi4 = {};
        dizi4 = cümle.Split(" ");
        int sum = 0;
        foreach (var item in dizi4)
        {
            sum += item.Length;
        }
        Console.WriteLine(dizi4.Length);
        Console.WriteLine(sum);


    }
}

class Islemler{

    public static void Cift(int n,int[] dizi){
        foreach (var item in dizi)
        {
            if (item%2==0)
            {
                Console.WriteLine(item);
            }            
        }
    }

    public static void mod(int n,int m ,int[] dizi){
        foreach (var item in dizi)
        {
            if (item == m && item%m == 0)
            {
                Console.WriteLine(item);
            }
        }
    }
}
