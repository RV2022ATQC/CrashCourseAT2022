/*
201.
Напишіть програму, яка обчислює середнє арифметичне двох чисел.
*/

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.println("Enter first number: ");
        var firstNumber = input.nextFloat();

        System.out.println("Enter second number: ");
        var secondNumber = input.nextFloat();

        System.out.println((firstNumber + secondNumber) / 2);
    }
}
