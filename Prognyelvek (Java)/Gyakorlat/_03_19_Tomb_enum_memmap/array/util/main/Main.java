package _03_19_Tomb_enum_memmap.array.util.main;

import java.util.Scanner;
import java.util.Arrays;

public class Main{
    public static void main(String[] args){
            Scanner scanner = new Scanner(System.in);
            System.out.println("Enter the length of the array: ");
            int arrayLen = scanner.nextInt();
            scanner.nextLine(); // Consume the newline character
            int[] array = new int[arrayLen];
            for (int i = 0; i < arrayLen; i++) {
                System.out.print("Enter the " + (i + 1) + ". element: ");
                array[i] = scanner.nextInt();
                scanner.nextLine(); // Consume the newline character
            }

            System.out.println("The array is: ");
            System.out.println(Arrays.toString(array));
            System.out.println();
            System.out.println("The maximum of the array is: "+_03_19_Tomb_enum_memmap.array.util.ArrayUtil.max(array));
            System.out.println("The minimum of the array is: "+_03_19_Tomb_enum_memmap.array.util.ArrayUtil.min(array));
            System.out.println("The min/max by the function minmax: "+Arrays.toString(_03_19_Tomb_enum_memmap.array.util.ArrayUtil.minMax(array)));
    }
}