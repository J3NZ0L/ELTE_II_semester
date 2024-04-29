package walking.game.player;

import walking.game.player.Player;
import walking.game.util.Direction;

public class MadlyRotatingBuccaneer extends Player{
    private int turnCount;

    public MadlyRotatingBuccaneer() {
        this.turnCount=0;
        super();
    }

    public void turn() {
        turnCount++;
        for (int i=0; i<turnCount; i++) {
            super.turn();
        }
    }

}