package walking.game;

import walking.game.util.*;

public class WalkingBoard{
    private int[][] tiles;
    private int x;
    private int y;
    public static final int BASE_TILE_SCORE=3;

    public int[][] getTiles(){
        return tiles;
    }

    public WalkingBoard(int size){

    }

    public WalkingBoard(int[][] tiles){

    }

    public int[] getPosition(){
        int[] arr={1,2,3};
        return arr;
    }

    public boolean isValidPosition(int x, int y){
        return false;
    }

    public int getTile(int x, int y){
        return 0;
    }

    public static int getXStep(Direction direction){
        return 0;
    }

    public static int getYStep(Direction direction){
        return 0;
    }

    public int moveAndSet(Direction direction, int steps){
        return 0;
    }
}