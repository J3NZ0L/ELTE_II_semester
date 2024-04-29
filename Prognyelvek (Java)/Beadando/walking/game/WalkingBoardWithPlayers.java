package walking.game;

import walking.game.player.*;

public class WalkingBoardWithPlayers extends WalkingBoard{
    private Player[] players;
    private int round;
    public static final int SCORE_EACH_STEP = 13;


    public WalkingBoardWithPlayers(int[][] board, int playerCount) {
        super(board);
        players=new Player[playerCount];
    }

    public WalkingBoardWithPlayers(int size, int playerCount) {
        super(size);
        players=new Player[playerCount];
    }

    private void initPlayers(int playerCount) {
        if (playerCount < 2) {
            throw new IllegalArgumentException("Player count must be at least 2");
        }
        players[0]=new MadlyRotatingBuccaneer();
        for (int i = 1; i < playerCount; i++) {
            players[i] = new Player();
        }
    }

    public int[] walk(int... stepCounts) {
        int overall_steps=0;
        int[] scores = new int[players.length];
        for (int i=0; i<players.length; i++) {
            players[i].turn();
            overall_steps+=stepCounts[i];
            for(int j=0; j<stepCounts[i]; j++) {
                moveAndSet(players[i].getDirection(),Math.min(overall_steps,SCORE_EACH_STEP));
            }
            players[i].addToScore(getTile(x,y));
            scores[i]=players[i].getScore();
        }
        return scores;
    }
}