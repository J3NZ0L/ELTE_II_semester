package _03_12_JUnit_2.math;

//import _03_12_JUnit_2.math.*;
import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class IncrementTest{
    @ParameterizedTest
    @CsvSource (textBlock = """
        1, 0
        2147483647, 2147483647
        -2147483647, -2147483648
        -214747, -214748
        214749, 214748
        0, -1
    """)
    public void incrementTest(int expected, int n){
        assertEquals(expected,  _03_12_JUnit_2.math.operation.safe.Increment.increment(n));
    }
}
