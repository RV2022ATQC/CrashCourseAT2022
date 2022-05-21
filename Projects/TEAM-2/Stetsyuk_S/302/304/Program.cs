using System.Text;
using _304;

public class Program
{
    public static void Main(string[] args)
    {
        //Create row of 80 symbols
        StringRow row1 = new StringRow();
        Console.WriteLine("Length of first row: " + row1.row.Length);

        //Create row of certain number of symbols
        StringRow row2 = new StringRow(-60);
        Console.WriteLine("Length of second row: " + row2.row.Length);

        //Create row of user's row
        Console.Write("\n\nEnter row: ");
        string str = Console.ReadLine();
        StringRow row3 = new StringRow(str);
        Console.WriteLine("\nUser's row: " + row3);
        Console.WriteLine("\n\n");


        //Read from console
        StringRow row4 = new StringRow();
        row4.ReadRow();

        //Write
        row4.Show();


    }
}