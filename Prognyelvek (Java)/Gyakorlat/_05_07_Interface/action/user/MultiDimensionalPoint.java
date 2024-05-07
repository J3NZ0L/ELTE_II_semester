package _05_07_Interface.action.user;

import java.util.Objects;

import _05_07_Interface.action.Scalable;
import _05_07_Interface.action.Undoable;

public class MultiDimensionalPoint implements Scalable, Undoable, Comparable<MultiDimensionalPoint>{ //Comperable interface megvalositasa kell a natural orderinghez

    private int[] coordinates;
    private int[] lastCoordinates;

    @Override   //Equality check
    public boolean equals(Object other){ //igy onmagaban az other nem enged hozzaferni a belso allapotahoz az objektumnak
        if(other == this) return true;
        if(other instanceof MultiDimensionalPoint mdp){ //belso allapothoz valo hozzaferes erdekeben type castolast is vegzunk, ez lesz az mdp, illetve igy tudunk ra hivatkozni is
            //TODO this.coordinates <-> mdp.coordinates
            int i=0;
            while(i<coordinates.length && this.coordinates[i]==mdp.coordinates[i]){
                i++;
            }
            return i<coordinates.length;
        }
        return false;
    }   

    @Override   //Equality check, hashcode
    public int hashCode(){
        return Objects.hash(coordinates);
    }

    @Override //alapbol a comperator +1, 0, -1 ertekekkel terhet vissza, (en nagyobb vagyok, egyenlo, kisebb vagyok)
    public int compareTo(MultiDimensionalPoint mdp){
        if (this.coordinates.length != mdp.coordinates.length){
            return Math.signum(this.coordinates.length-mdp.coordinates.length);
        }
        
    }

    public MultiDimensionalPoint(int... arg){
        coordinates=arg;
    }
    
    public int get(int coord){
        return coordinates[coord];
    }

    public void set(int coord, int value){
        coordinates[coord]=value;
    }

    @Override
    public void scale(int factor){
        for(int coord : coordinates){
            coord=coord*factor;
        }
    }

    private void saveToLast(){

    }

    @Override
    public void undoLast(){

    }


    


}