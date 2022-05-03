/*
 Дано натуральне число а (a <100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр
 */
public class Main {

    public static void main(String[] args) {
	var number = 47;
    var digits = 0;
    var sum = 0;
    System.out.println("Number is " + number);

    while (number > 0) {
        sum = sum + (number % 10);
        number /= 10;
        digits++;
    }
    System.out.println("It has " + digits + " digits.");
    System.out.println("Sum of digits = " + sum);

    }
}
