class dominoes
{
    //Se realizan las variables
    public int d1;
    public int d2;
    public dominoes (int d1, int d2)
    {
        this.d1 = d1;
        this.d2 = d2;
    }
    //sobrecarga de operador
    public static int operator +(dominoes a, dominoes b)
    {
        int suma = a.d1 + b.d1 + a.d2 + b.d2;
        return suma;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        dominoes d1 = new dominoes (0,1);
        dominoes d2 = new dominoes (2,3);
        //Proceso de suma
        int total = d1 + d2;
        Console.Write (total);
    }
}