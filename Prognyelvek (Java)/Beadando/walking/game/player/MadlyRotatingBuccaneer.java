package walking.game.player;

import walking.game.player.Player;
import walking.game.util.Direction;

public class MadlyRotatingBuccaneer extends Player{
    private int turnCount;

    public MadlyRotatingBuccaneer() {
        super();
        this.turnCount=0;
        
    }

    public void turn() {        
        for (int i=0; i<turnCount; i++) {
            super.turn();
        }
        turnCount++;
    }

}