
class program
{
    public static void main()
    {
        int[] age = { 12, 23, 21, 22, 45, 33, 20, 26, 55, 66 };
        var a = from i in age where i > 20 orderby i descending select i;

        foreach (int item in a)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}
