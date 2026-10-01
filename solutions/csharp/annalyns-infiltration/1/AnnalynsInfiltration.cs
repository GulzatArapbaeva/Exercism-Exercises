static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake || archerIsAwake || prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent)
        {
            if((knightIsAwake || prisonerIsAwake) && !archerIsAwake)
            {
                return true;
            }
            if(!knightIsAwake && !prisonerIsAwake && !archerIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if(prisonerIsAwake)
            {
                if(!knightIsAwake && !archerIsAwake)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
