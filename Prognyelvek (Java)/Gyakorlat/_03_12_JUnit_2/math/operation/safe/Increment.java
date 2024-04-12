//DB7ZTC
package _03_12_JUnit_2.math.operation.safe;

public class Increment{

    public static int increment( int n){
        if (n==Integer.MAX_VALUE){
            return n;
        } else {
            return n+1;
        }
    };
}