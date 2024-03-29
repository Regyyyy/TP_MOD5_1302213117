﻿using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric<string> gen = new HaloGeneric<string>();
        gen.SapaUser("Regy");
        DataGeneric<string> siswa = new DataGeneric<string>("1302213117");
        siswa.PrintData();
    }
}

public class HaloGeneric<T>
{
    public void SapaUser(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: "+data);
    }
}