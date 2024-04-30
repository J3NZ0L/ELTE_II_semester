package walking.game.util;

public class myUtils{
    public static int[][] copyMatrix(int[][] _matrix){
        int[][] returnMatrix = new int[_matrix.length][]; //_matrix.length a sorok szama
        for(int row=0; row<_matrix.length; row++){
            int[] currentMatrixrow=new int[_matrix[row].length];
            for(int col=0; col<_matrix[row].length; col++){
                currentMatrixrow[col]=_matrix[row][col];
            }
            returnMatrix[row]=currentMatrixrow; //visszaadjuk a sorokat
        }
        return returnMatrix;
    }
}