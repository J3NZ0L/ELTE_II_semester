package walking.game.player;

import walking.game.util.Direction;

public class Player{
    private int score;
    protected Direction direction = Direction.UP;

    public int getScore() {
        // TODO
        return this.score;
    }

    public Direction getDirection() {
        // TODO
        return this.direction;
    }

    public Player() {
        // TODO
    }

    public void addToScore(int score) {
        // TODO
    }

    public void turn() {
        switch (direction) {
            case UP:
                direction = Direction.RIGHT;
                break;
            case RIGHT:
                direction = Direction.DOWN;
                break;
            case DOWN:
                direction = Direction.LEFT;
                break;
            case LEFT:
                direction = Direction.UP;
                break;
        }
    }
}