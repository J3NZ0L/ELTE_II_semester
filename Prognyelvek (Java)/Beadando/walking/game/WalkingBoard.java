package walking.game;

import walking.game.util.*;

public class WalkingBoard{
    private int[][] tiles;
    private int x;  //ezeken a koordinatakon all a babu
    private int y;
    public static final int BASE_TILE_SCORE=3;

    public int[][] getTiles(){
        return tiles;
    }

    public WalkingBoard(int size){
        this.tiles= new int[size][size];
        for ( int i=0; i<size;i++){
            for (int j : tiles[i]){
                tiles[i][j]=BASE_TILE_SCORE;
            }
        }
    }

    public WalkingBoard(int[][] tiles){
        this.tiles=tiles;
        for ( int i=0; i<size;i++){ //TODO: nem biztos h <size> a sorok hossza
            for (int j : tiles[i]){
                if (BASE_TILE_SCORE>tiles[i][j]){
                tiles[i][j]=BASE_TILE_SCORE;
                }
            }
        }
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