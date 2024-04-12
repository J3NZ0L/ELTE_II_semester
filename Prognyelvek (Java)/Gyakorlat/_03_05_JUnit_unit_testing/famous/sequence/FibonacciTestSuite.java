package _03_05_JUnit_unit_testing.famous.sequence;
//javac -cp ".;junit5all.jar;checkthat.jar" .\_03_05_JUnit_unit_testing\famous\sequence\FibonacciTestSuite.java
//java -jar junit5all.jar -cp ".;checkthat.jar" -c _03_05_JUnit_unit_testing.famous.sequence.FibonacciTestSuite
import org.junit.platform.suite.api.SelectClasses;
import org.junit.platform.suite.api.Suite;

@Suite
@SelectClasses({
    FibonacciStructureTest.class,
    FibonacciTest.class
})
public class FibonacciTestSuite {}
