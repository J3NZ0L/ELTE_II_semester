package walking.game.tests;

//sajat importok:
import walking.game.util.*;

//kapott importok:
import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class WalkingBoardTest{
    @ParameterizedTest
    @CsvSource (textBlock = """
        0, 0, 0
        1, 1, 1
        7, 7, 1
        20, 20, 1
    """)
    public void testSimpleInit(int expected, int size){
        WalkingBoard wb=new WalkingBoard(size);
        assertEquals(expected,wb.getTiles().length, wb.getTiles()[length].length);
    }
}