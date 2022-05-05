/* 215
* Написати програму, яка виводить на екран - наступну фігуру:
"*********************
*                           *
*                           *
*                           *
*                           *
*********************
ширина і висота фігури встановлюються користувачем з клавіатури.
*/
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner readData = new Scanner(System.in);

        System.out.println("Enter length:");
        var length = readData.nextInt();

        System.out.println("Enter height:");
        var height = readData.nextInt();

        // Print * for every 1-st and last column; also for all 1-st and last line. Otherwise, print space.
        for (int i = 0; i < height; i++) {
             for (int j = 0; j < length; j++) {
                 if ((j == 0) || (j == length-1) || (i == 0) || (i == height-1)){
                     System.out.print("*");
                 }
                 else {
                     System.out.print(" ");
                 }
             }
             System.out.println();
         }
    }
}
