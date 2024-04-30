package _04_30_Oroklodes.cafe;

public abstract class Guest{
    protected String name;
    protected int age;

    public Guest(String name, int age){
        this.name = name;
        this.age = age;
    }

    public String getName(){
        return name;
    }

    public int getAge(){
        return age;
    }
}