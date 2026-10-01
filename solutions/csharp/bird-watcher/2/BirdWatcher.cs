class BirdCount
{
    private int[] birdsPerDay = {2,5,0,7,4,1};
    private bool hasDayWithoutBirds = false;
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0,2,5,3,7,8,4};
    }

    public int Today()
    {
        int todayBirdCount = birdsPerDay.Length - 1;
        return birdsPerDay[todayBirdCount];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(var birds in birdsPerDay)
        {
            if(birds == 0)
            {
                hasDayWithoutBirds = true;
                break;
            }
        }
        return hasDayWithoutBirds;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        int numberOfBusyDays = 0;    
        
        foreach(var birds in birdsPerDay)
        {
            if(birds >= 5)
            {
                numberOfBusyDays++;
            }
        }

        return numberOfBusyDays;
    }
}
