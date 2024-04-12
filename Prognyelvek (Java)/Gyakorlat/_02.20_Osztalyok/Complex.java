public class Complex{
    public double real;
    public double imaginary;

    public Complex(){}

    public double abs(){
        return Math.sqrt(Math.pow(this.real,2)+Math.pow(this.imaginary,2));
    }
    
    public void add(Complex c){
        this.real+=c.real;
        this.imaginary+=c.imaginary;
    }

    public void substract(Complex c){
        this.real-=c.real;
        this.imaginary-=c.imaginary;
    }

    public void mul( Complex c){
        double tr=this.real;
        double ti=this.imaginary;
        this.real=this.real*c.real-(this.imaginary*c.imaginary);
        this.imaginary=tr*c.imaginary+ti*c.real;
    }

    public void print(){
        System.out.println(this.real+"+"+this.imaginary+"i");
    }

    public void conjugate(){
        this.imaginary*=-1;
    }
    public void reciprocate(){
        double d=Math.pow(this.real,2)+Math.pow(this.imaginary,2);
        this.real/=d;
        this.imaginary/=-d;
    }
    public void divide(Complex c){
        this.mul(c);
        c.mul(c);
        this.real/=c.real;
        this.imaginary/=c.real;
    }
}