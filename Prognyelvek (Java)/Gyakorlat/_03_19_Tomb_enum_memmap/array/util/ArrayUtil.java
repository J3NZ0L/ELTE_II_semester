 //DB7ZTC
package _03_19_Tomb_enum_memmap.array.util;

public class ArrayUtil{

    public static int max(int[] array){
        if (array.length==0){
            return 0;
        } else {
            int max = Integer.MIN_VALUE;
            for (int i = 0; i < array.length; i++){
                if (array[i] > max){
                    max = array[i];
                }
            }
            return max;
        }
    }

public static int min(int[] array){
        if (array.length==0){
            return 0;
        } else {
            int min = Integer.MAX_VALUE;
            for (int i = 0; i < array.length; i++){
                if (array[i] < min){
                    min = array[i];
                }
            }
            return min;
        }
    }

    public static int max2(int[] array){
        if (array.length==0){
            return 0;
        } else {
            int max = Integer.MIN_VALUE;
            for (int i = 0; i < array.length; i++){
                max=(array[i]>max) ? array[i] : max;
            }
            return max;
        }
    }

    public static int max3(int[] array){
        if (array.length==0){
            return 0;
        } else {
            int max = Integer.MIN_VALUE;
            for (int i = 0; i < array.length; i++){
                max=Math.max(array[i], max);
            }
            return max;
        }
    }

    public static int max4(int[] array){
        if (array.length==0){
            return 0;
        } else {
            int max = Integer.MIN_VALUE;
            for (int e : array){
                max=Math.max(e, max);
            }
            return max;
        }
    }

    public static int[] minMax(int[] array){
        int[] minmaxarray ={Integer.MAX_VALUE,Integer.MIN_VALUE};
        if (array.length==0){
            minmaxarray[0]=0;
            minmaxarray[1]=0;
            return minmaxarray;
        } else {
            for (int e : array){
                minmaxarray[0]=Math.min(e, minmaxarray[0]);
                minmaxarray[1]=Math.max(e, minmaxarray[1]);
            } 
            return minmaxarray;
        }
       
    }

}