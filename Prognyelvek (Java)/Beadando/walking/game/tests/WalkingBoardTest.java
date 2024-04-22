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
        1, 
        7,
        20,
    """)
    public void testSimpleInit(int size){
        walking.game.WalkingBoard wb=new walking.game.WalkingBoard(size);
        int yl=wb.getTiles().length; 
        int xl=wb.getTiles()[yl-1].length;
        assertEquals(size,yl,xl);
    }

    @ParameterizedTest
    @CsvSource (textBlock = """
        3, 4, walking.game.WalkingBoard.BASE_TILE_SCORE;
    """)
    public void testCustomInit(int x, int y, int expected){        
        walking.game.WalkingBoard wb=new walking.game.WalkingBoard(expected);
        
        assertEquals(wb.getTile(x,y), expected);
    }
}