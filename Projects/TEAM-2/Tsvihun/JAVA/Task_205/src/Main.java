/*
205.
Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
 */
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);

    System.out.println("First number: ");
    var firstNumber = scanner.nextInt();

    System.out.println("Second number: ");
    var secondNumber = scanner.nextInt();

    System.out.println("Third number: ");
    var thirdNumber = scanner.nextInt();

    System.out.println("Sum = " + (firstNumber + secondNumber + thirdNumber));
    System.out.println("Product = " + (firstNumber * secondNumber * thirdNumber));

    }
}
