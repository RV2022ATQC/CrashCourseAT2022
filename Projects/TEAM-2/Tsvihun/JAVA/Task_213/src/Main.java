/*
213.
Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися число навпаки - 54321.
*/
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner inputData = new Scanner(System.in);

        System.out.println("Enter number");
        var number = inputData.next();

        // Show array in reverse order. It works for all the symbols, not only numbers
        for (int i = number.length()-1; i >= 0; i--){
            System.out.print(number.charAt(i));
        }

    }
}
