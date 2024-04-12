package _03_05_JUnit_unit_testing.famous.sequence;

public class TriangularNumbers {
    public static int getTriangularNumber(int n) {
        if (n < 0) {
            throw new IllegalArgumentException("n must be non-negative");
        }
        int sum = 0;
        for (int i = 1; i <= n; i++) {
            sum += i;
        }
        return sum;
        
    }
    public static int getTriangularNumberAlternative(int n) {
        if (n < 0) {
            throw new IllegalArgumentException("n must be non-negative");
        }
        return n * (n + 1) / 2;
    }
}
