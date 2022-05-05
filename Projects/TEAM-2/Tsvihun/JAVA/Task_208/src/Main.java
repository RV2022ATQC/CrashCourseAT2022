/*
 208. Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню.
  */
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner inputData = new Scanner(System.in);
        final double INCH = 2.54;
        String choice = "noChoice";

        System.out.println("Enter number:");

        // Check if double type entered
        while (!inputData.hasNextDouble()){
            System.out.println("Incorrect number ! Try again");
            inputData.next();
        }

        double number = inputData.nextDouble();

        //Enable only "1" or "2" to select
        while ( !choice.equals("1") & !choice.equals("2")) {
            System.out.println("Choose converter:\n1 - Inches >> Cm\n2 - Cm >> Inches");
            choice = inputData.next();
        }

        // Converter
        switch (choice) {
            case "1": {
                System.out.println(number + " inches = " + (number * INCH) + " cm.");
                break;
            }
            case "2": {
                System.out.println(number + " cm = " + (number / INCH) + " inches");
                break;
            }
        }
    }
}