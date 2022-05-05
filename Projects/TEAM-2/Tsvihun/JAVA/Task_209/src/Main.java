/* 209.
Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів,
який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.
 */
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        int length = 0;

        System.out.println("Enter symbol:");
        char symbol = reader.next().charAt(0);

        System.out.println("Enter length:");

        //Check if length is a number
        while (!reader.hasNextInt()) {
            System.out.println("Length must be a number ! Try again:");
            reader.next();
        }
        length = reader.nextInt();

        System.out.println("Choose direction:\n1 - horizontal\n2 - vertical");
        String direction = reader.next();

        if (direction.equals("1")) {
            for (int i = 0; i < length; i++) {
                System.out.print(symbol);
            }
        }
        else if (direction.equals("2")) {
            for (int i = 0; i < length; i++) {
                System.out.println(symbol);
            }
        }
        else {
            System.out.println("Choose only 1 or 2");
        }
    }
}
