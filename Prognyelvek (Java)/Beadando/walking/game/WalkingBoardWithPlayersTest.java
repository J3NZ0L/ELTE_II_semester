package walking.game;

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

public class WalkingBoardWithPlayersTest{
    //KITOROLNI!!!
    @Test
    public void printWalk() {
        
        int n = 5;
        WalkingBoardWithPlayers w = new WalkingBoardWithPlayers(n, 3);
        int[] scores =w.walk(1, 2, 3, 3, 2, 1, 4, 5, 1);
        for(int i=0; i<2; i++) {   
            System.out.printf("%d ", scores[i]);
        }
        
        System.out.printf("\n");
        for(int i = 0; i<n;i++) {
            for(int j = 0; j<n;j++) {
                System.out.printf(" %d ", w.getTiles()[i][j]);
            }
            System.out.printf("\n");
        }
        
    }
    //KITOROLNI!!!

        @Test
    public void walk1()
    {
        WalkingBoardWithPlayers w = new WalkingBoardWithPlayers(4, 2);
        assertArrayEquals(new int[]{6, 15}, w.walk(2, 3, 3, 1, 2, 1));
        assertArrayEquals(new int[][]{{3,2,3,4},{11,10,9,8},{3,3,3,3},{3,3,3,3,3}},w.getTiles());
    }
    
    @Test
    public void walk2()
    {
        WalkingBoardWithPlayers w = new WalkingBoardWithPlayers(5, 3);
        assertArrayEquals(new int[]{12, 12, 0}, w.walk(1, 2, 3, 3, 2, 1, 4, 5, 1));
        assertArrayEquals(new int[][]{{3,3,4,5,3},{3,3,3,13,},{3,3,3,13},{13,13,13,13}},w.getTiles());
    }
    
}