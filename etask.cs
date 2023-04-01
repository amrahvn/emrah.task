

Class Program;
{
    public static void Main();
    {




        Console.WriteLine();
        int bal = 23;
        if (bal < 0 || bal > 100)
        {
            Console.WriteLine("bal duzgun deil");
        }
        else if (bal > 90 && bal <= 100)
        {
            Console.WriteLine("Neticeniz:" + "A");
        }
        else if (bal > 80 && bal <= 90)
        {
            Console.WriteLine("Neticeniz:" + "B");
        }
        else if (bal > 70 && bal <= 80)
        {
            Console.WriteLine("Neticeniz:" + "C");
        }
        else if (bal > 60 && bal <= 70)
        {
            Console.WriteLine("Neticeniz:" + "D");
        }
        else if (bal > 50 && bal <= 60)
        {
            Console.WriteLine("Neticeniz:" + "E");
        }
        else if (bal <= 50)
        {
            Console.WriteLine("kesildiniz");
        }









        //2-ci taks  arraydaki menfi ve musbet ededlern sayi
        int[] num = { 2, 3, -6, 23, -34, -24, 36 };
        int countmusbet = 0;
        int countmenfi = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > 0)
            {
                countmusbet++;
            }
            else if (num[i] < 0)
            {
                countmenfi++;
            }
        }
        Console.WriteLine("musbet:" + countmusbet);
        Console.WriteLine("menfi:" + countmenfi);




        // 3-cu task (en boyuk reqem)
        int[] num = { 3, 5, 6, 54, 6, 6, 65, 7, 68, 87, 878 };
        int enb = num[0];
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > enb)

                enb = num[i];
        }
        Console.WriteLine(enb);
    } 
};








