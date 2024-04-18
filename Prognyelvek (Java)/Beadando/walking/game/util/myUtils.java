package walking.game.util;

public class myUtils{
    public static int[][] copyMatrix(int[][] _matrix){
        int[][] returnMatrix = new int[_matrix.length][];
        for(int row=0; row<_matrix.length; row++){
            int[] currentMatrixRow=new int[_matrix[row].length];
            for(int col=0; col<_matrix[row].length; col++){
                currentMatrixRow[col]=_matrix[row][col];
            }
            returnMatrix[row]=currentMatrixRow;
        }
        return returnMatrix;
    }
}