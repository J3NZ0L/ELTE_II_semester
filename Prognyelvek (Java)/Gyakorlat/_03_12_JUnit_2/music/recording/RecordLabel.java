package _03_12_JUnit_2.music.recording;

public class RecordLabel{
    private final String name;
    private int cash;

    public String getName(){
        return name;
    }
    public int getCash(){
        return cash;
    }

    public RecordLabel(String _name,int _cash){
        this.name=_name;
        this.cash=_cash;
    }

    public void gotIncome(int sum){
        cash+=sum;
    }
}