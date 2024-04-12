package _03_12_JUnit_2.music.recording;

public class Fan{
    private final String name;
    private final Artist favourite;
    private int moneySpent;


    public String getName(){
        return this.name;
    }

    public Artist getFavourite(){
        return this.favourite;
    }

    public int getMoneySpent(){
        return this.moneySpent;
    }

    public Fan(String _name, Artist _favourite){
        this.name=_name;
        this.favourite=_favourite;
        this.moneySpent=0;
    }

    public int buyMerchandise(int _price, Fan... friends){
        int calculatedPrice;

        if (friends.length<=1){
            calculatedPrice=_price*(10-(int)friends.length)/10;
        } else {
            calculatedPrice=(int)(_price*0.8);
        }
        favourite.getLabel().gotIncome((int)calculatedPrice/2);
        for (Fan friend : friends){
            friend.buyMerchandise(_price);
        }
        this.moneySpent+=calculatedPrice;
        return calculatedPrice;
    }

    public boolean favesAtSameLabel(Fan _fan){
        return _fan.getFavourite()==this.favourite;
    }

    public String toString1(){
        return this.name+" has "+this.favourite.getName()+" as favourite artist, and has spent "+this.moneySpent+" dollars worth of money.";
    }

    public String toString2(){
        return "%s has %s as favourite artist, and has spent %d dollars worth of money spent.".formatted(this.name,this.favourite.getName(),this.moneySpent);
    }

    public String toString3(){
        return String.format("%s has %s as favourite artist, and has spent %d dollars worth of money spent.",this.name,this.favourite.getName(),this.moneySpent);
    }

    public String toString4(){
        StringBuilder sb = new StringBuilder(100);
        sb.append(this.name);
        sb.append(" has ");
        sb.append(this.favourite.getName());
        sb.append(" as a favourite artist, and has spent ");
        sb.append(this.moneySpent);
        sb.append(" dollars worth of money.");

        return sb.toString();
    }
}