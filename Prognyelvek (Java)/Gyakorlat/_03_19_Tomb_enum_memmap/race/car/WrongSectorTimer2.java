package _03_19_Tomb_enum_memmap.race.car;

public class WrongSectorTimer2{
    private int[] sectorTimes;
    public int[] getSectorTimes(){
        return sectorTimes;
    }
    public void setSectorTimes(int[] _sectorTimes){
        this.sectorTimes=_sectorTimes;
    }
    public WrongSectorTimer2(int[] _sectorTimes){
        this.sectorTimes=_sectorTimes;
    }

    public int getLapTime(int par){
        return 0;
    }
    
    public int getSectorTime(int par){
        return 0;
    }
}