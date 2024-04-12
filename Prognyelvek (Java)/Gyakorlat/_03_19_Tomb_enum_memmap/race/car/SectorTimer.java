package _03_19_Tomb_enum_memmap.race.car;

public class SectorTimer{

    private int[] sectorTimes;

    public int[] getSectorTimes(){
        return sectorTimes;
    }

    public SectorTimer(int[] _sectorTimes){
        this.sectorTimes=_sectorTimes;
    }
    
    public SectorTimer(boolean B, int[] _sectorTimes){

    }

    public int getSectorTime(int p){
        return p;
    }

    public int[] getSectorTimesV2(){
        return sectorTimes;
    }

    private void initSectorTimes(int[] initalSectorTimes){
        
    }

    public  void setLapTimes(int[] lapTimes){

    }

    public void setSectorTimesV2(int[] lapTimes){

    }
}