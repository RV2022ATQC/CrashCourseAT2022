/*
204.
Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.
*/
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter number");

        var number = scanner.nextInt();

        System.out.println("Square number = " + (number * number));
    }
}