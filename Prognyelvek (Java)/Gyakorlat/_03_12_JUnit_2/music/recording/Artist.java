package _03_12_JUnit_2.music.recording;

public class Artist{
    private final String name;
    private final RecordLabel label;


    public String getName(){
        return this.name;
    }

    public RecordLabel getLabel(){
        return this.label;
    }

    public Artist(String _name, RecordLabel _label){
        this.name=_name;
        this.label=_label;
    }
}