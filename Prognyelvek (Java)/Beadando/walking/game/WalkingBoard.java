package walking.game;

import walking.game.util.*;

public class WalkingBoard{
    private int[][] tiles;
    private int x;  //ezeken a koordinatakon all a babu
    private int y;
    public static final int BASE_TILE_SCORE=3;

    public int[][] getTiles(){
        return myUtils.copyMatrix(tiles);
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
        this.tiles=myUtils.copyMatrix(tiles);
        for ( int i=0; i<this.tiles.length;i++){
            for (int j=0; j<this.tiles[i].length;j++){
                if (BASE_TILE_SCORE>this.tiles[i][j]){
                this.tiles[i][j]=BASE_TILE_SCORE;
                }
            }
        }
    }

    public int[] getPosition(){
        int[] arr={x,y};
        return arr;
    }

    public boolean isValidPosition(int x, int y) throws IllegalArgumentException{
        if (this.x+x<0 || this.x+x>=tiles.length || this.y+y<0 || this.y+y>=tiles[this.x].length){
            return false;
        }
        return true;
    }

    public int getTile(int x, int y){
        if (!isValidPosition(x,y)){
            throw new IllegalArgumentException();
        }
        return tiles[x][y];
    }

    public static int getXStep(Direction direction){
        switch(direction){
            case direction.UP:
                return 0; 
            case direction.DOWN:
                return 0; 
            case direction.RIGHT:
                return 1; 
            case direction.LEFT:
                return -1;
            default:return -2;
        }
    }

    public static int getYStep(Direction direction){
        switch(direction){
            case direction.UP:
                return -1; 
            case direction.DOWN:
                return 1; 
            case direction.RIGHT:
                return 0; 
            case direction.LEFT:
                return 0;
            default: return -2;
        }
    }

    public int moveAndSet(Direction direction, int value){
        if(!isValidPosition(getXStep(direction),getYStep(direction))){
            return 0;
        }
        this.x+=getXStep(direction);
        this.y+=getYStep(direction);
        int toReturn=getTile(x,y);
        this.tiles[x][y]=value;
        return toReturn;
    }
}