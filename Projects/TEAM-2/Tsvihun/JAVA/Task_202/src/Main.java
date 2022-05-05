/*
202.
Напишіть програму, яка переводить гривні в $, Є.
*/
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        float usdRate = 29.4f;
        float eurRate = 32.06f;

        System.out.println("Enter amount :");
        var amount = input.nextFloat();

        System.out.println(amount + "grn = " + amount/usdRate + " dollars");
        System.out.println(amount + "grn = " + amount/eurRate + " euros");
    }
}