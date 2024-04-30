package walking.game;

import walking.game.util.*;

public class WalkingBoard{
    private int[][] tiles; //elso index az y koordinata, masodik az x koordinata, azaz y a sorok szama, x az oszlopok szama
    private int x;  //babu horizontalis pozicioja, azaz az oszlop
    private int y;  //babu vertikalis pozicioja, azaz a sor
    public static final int BASE_TILE_SCORE=3;

    public int[][] getTiles(){
        return myUtils.copyMatrix(tiles);
    }

    public WalkingBoard(int size){
        this.tiles= new int[size][size];
        for ( int row=0; row<size;row++){
            for (int col=0; col<size;col++){
                tiles[row][col]=BASE_TILE_SCORE;
            }
        }
    }

    public WalkingBoard(int[][] tiles){
        this.tiles=myUtils.copyMatrix(tiles);
        for ( int row=0; row<this.tiles.length;row++){
            for (int col=0; col<this.tiles[col].length;col++){
                if (BASE_TILE_SCORE>this.tiles[row][col]){
                this.tiles[row][col]=BASE_TILE_SCORE;
                }
            }
        }
    }

    public int[] getPosition(){ 
        int[] arr={x,y};
        return arr;
    }

    public boolean isValidPosition(int x, int y) throws IllegalArgumentException{
        if (y<0 || y>=tiles.length || x<0 || x>=tiles[this.y].length){
            return false;
        }
        return true;
    }

    public int getTile(int x, int y){
        if (!isValidPosition(x,y)){
            throw new IllegalArgumentException();
        }
        return tiles[y][x]; //y a sor, x az oszlop
    }

    public static int getXStep(Direction direction){
        switch(direction){
            case direction.UP: //ha felfele megyunk, akkor az x koordinata nem valtozik
                return 0; 
            case direction.DOWN:
                return 0; 
            case direction.RIGHT: //ha jobbra megyunk, akkor az x koordinata no
                return 1; 
            case direction.LEFT:
                return -1;
            default:return -2;
        }
    }

    public static int getYStep(Direction direction){
        switch(direction){
            case direction.UP: //mivel a tomb indexelese miatt invertalni kell a lepes iranyat, ezert csokkenni fog az ertek ha felfele megyunk (ha fellepunk, akkor egyel kisebb tombindexu sorban leszunk)
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

    public int moveAndSet(Direction direction, int value){  //a direction iranyba lepunk 1-et, es az uj mezon levo erteket value-re valtoztatjuk
        if(!isValidPosition(getXStep(direction)+getPosition()[0],getYStep(direction)+getPosition()[1])){
            return 0;
        }
        this.x+=getXStep(direction);
        this.y+=getYStep(direction);
        int toReturn=getTile(x,y);
        this.tiles[y][x]=value;
        return toReturn;
    }
    
}