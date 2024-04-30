package _04_30_Oroklodes.cafe;

public class Bartender{
    private int legalAge;

    public Bartender(int legalAge){
        this.legalAge = legalAge;
    }

    public boolean order(Guest guest){
        /*
        if(guest.getAge() >= legalAge){
            return true;
        }
        */
        return (guest instanceof Adult) || (guest instanceof Minor && guest.getAge() >= legalAge);
        //guest instanceof Minor m - egybol peldanyositja es igy attol fuggetlenul h a guest csak Guest tipusu, meghibhatjuk a Minor egy metodusat pl
    }
}