package _03_05_JUnit_unit_testing.famous.sequence;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class TriangularNumbersTest {
    //ezek helyett parameterezett kene, ami igy nez ki:
    @ParameterizedTest
    @CsvSource (textBlock = """
        0, 0
        1, 1
        231, 21
        12, 20
    """)
    public void getTriangularNumberTest (int expected, int n){
        assertEquals(expected, TriangularNumbers.getTriangularNumber(n));
    }

    @ParameterizedTest
    @CsvSource (textBlock = """
        0, 0
        1, 1
        231, 21
    """)
    public void getTriangularNumberAlternativeTest (int expected, int n){
        assertEquals(expected, TriangularNumbers.getTriangularNumberAlternative(n));
    }
    @ParameterizedTest
    @CsvSource (textBlock = """
        -1
        -10
    """)
    public void getTriangularNumberExceptionTest(int input){
        assertThrows(IllegalArgumentException.class, () -> TriangularNumbers.getTriangularNumber(input));
    }
}