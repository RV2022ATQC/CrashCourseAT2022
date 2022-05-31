//Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну.
//Примітка: Наприклад, користувач ввів число 11123445555. На екрані має з'явитися повідомлення про те, що в числі 5 цифр.
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int counter = 1;
        boolean unique;

        System.out.println("enter number:");
        String number = input.next();

        // Go through array, check if char (number) is unique and count if yes
        for (int i = 1; i < number.length(); i++) {
            unique = true;
            for (int j = i - 1; j >= 0; j--) {
                if (number.charAt(j) == number.charAt(i)) {
                    unique = false;
                }
            }
            if (unique) {
                counter++;
            }
        }

        System.out.println("The number of unique characters = " + counter);
    }
}
