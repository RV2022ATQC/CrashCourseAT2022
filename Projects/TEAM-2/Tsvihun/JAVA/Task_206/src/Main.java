/*
206. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.
*/
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner readData = new Scanner(System.in);

        System.out.println("Enter integer :");

        try {
            var number = readData.nextInt();

            if (number % 2 == 0){
                System.out.println(number + " is EVEN");
            }
            else {
                System.out.println(number + " is ODD");
            }
        }
        catch (Exception ex){
            System.out.println("Invalid number");
        }
        }
}
