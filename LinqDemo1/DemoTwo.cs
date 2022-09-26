
class DemoTwo
{
    public static void LinqDemo2()
    {
        string sentence = "wellcome";
        string[] catName = {"W","E","L","L","C","O","M","E"};
        int[] numbers = { 3, 1, 2, 6, 3, 8, 9, 4, 7, 5};

        var getTheNumbers = from number in numbers
                            where number < 5
                            select number;

        List<int> newNumbers = new List<int>();

        foreach (var number in numbers)
        {
            if (number < 5)
            {
                newNumbers.Add(number);
            }
        }

        System.Console.WriteLine(string.Join(", ", getTheNumbers));
        System.Console.WriteLine(string.Join(", ", newNumbers));
    }

}