class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeFoodHasBeenInTheOven) => ExpectedMinutesInOven() - timeFoodHasBeenInTheOven;
    

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layerCount) =>  layerCount * 2;
   

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layerCount, int minutesLasagnaWasInOven) =>  PreparationTimeInMinutes(layerCount) + minutesLasagnaWasInOven;
    
}
