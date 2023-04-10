using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return knightIsAwake.Equals(false);
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake.Equals(true) || archerIsAwake.Equals(true) || prisonerIsAwake.Equals(true);
        
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return prisonerIsAwake.Equals(true) && archerIsAwake.Equals(false);
        
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
       bool prisonIsFree = petDogIsPresent.Equals(true) && archerIsAwake.Equals(false);
       bool prisonIsFreeSleep = prisonerIsAwake.Equals(true) && archerIsAwake.Equals(false) && knightIsAwake.Equals(false);
       return  prisonIsFree || prisonIsFreeSleep ;      

    }
}
