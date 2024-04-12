package _03_05_JUnit_unit_testing.famous.sequence;
//eloszor le kell forditani a classt
//javac -cp ".;junit5all.jar;checkthat.jar" .\_03_05_JUnit_unit_testing\famous\sequence\FibonacciStructureTest.java
//java -jar junit5all.jar -cp ".;checkthat.jar" -c _03_05_JUnit_unit_testing.famous.sequence.FibonacciStructureTest
import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import org.junit.jupiter.api.*;
import check.CheckThat;

public class FibonacciStructureTest {
    @BeforeAll
    public static void init() {
        CheckThat.theClass("_03_05_JUnit_unit_testing.famous.sequence.Fibonacci")
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL);
    }

    @Test
    public void constructor() {
        it.has(DEFAULT_CONSTRUCTOR);
    }

    @Test
    public void methodFib() {
        it.hasMethod("fib", withParams("n: int"))
            .thatIs(FULLY_IMPLEMENTED, USABLE_WITHOUT_INSTANCE, VISIBLE_TO_ALL)
            .thatReturns("int");
    }
}

