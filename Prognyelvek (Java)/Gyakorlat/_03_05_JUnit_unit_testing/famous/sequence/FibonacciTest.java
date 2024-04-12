package _03_05_JUnit_unit_testing.famous.sequence;
//Classt forditani elobb
//javac -cp ".;junit5all.jar;checkthat.jar" .\_03_05_JUnit_unit_testing\famous\sequence\FibonacciTest.java     
//java -jar junit5all.jar -cp ".;checkthat.jar" -c _03_05_JUnit_unit_testing.famous.sequence.FibonacciTest     
import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class FibonacciTest{

    @Test
    public void fib0(    ){
        assertEquals(0,Fibonacci.fib(0));
    }

    @Test
    public void fib1(    ){
        assertEquals(1,Fibonacci.fib(1));
    }

    @Test
    public void fib2(    ){
        assertEquals(1,Fibonacci.fib(2));
    }

    @Test
    public void fib3(    ){
        assertEquals(2,Fibonacci.fib(3));
    }

    //ezek helyett parameterezett kene, ami igy nez ki:
    @ParameterizedTest
    @CsvSource (textBlock = """
        0, 0
        1, 1
        34, 9
    """)
    public void fibs (int expected, int n){
        assertEquals(expected, Fibonacci.fib(n));
    }
}