using System;
					
public class Program
{
	public static void Main()
	{
		int k = 8;

            switch (k)
            {
                case 3:
                    Console.WriteLine("HowKteam");
                    break;
                case 9:
                    Console.WriteLine("Kteam");
                    break;
                case 10:
                    Console.WriteLine("Free Education");
                    break;
                default: // Nếu không thỏa các trường hợp trên sẽ thực hiện lệnh sau đây
                    Console.WriteLine("Connecting to HowKteam. . .");
                    break;
            }
	}
}