public class ComplexMain{
    public static void main( String[] Args){
        Complex alpha= new Complex();
        Complex beta= new Complex();
        alpha.real = 3;
        alpha.imaginary = 2;
        beta.real = 1;
        beta.imaginary = 2;
        alpha.add(beta);
        alpha.print();
        beta.print();
        alpha.substract(beta);
        alpha.print();
        beta.print();
        alpha.mul(beta);
        alpha.print();
        beta.print();
    }
}