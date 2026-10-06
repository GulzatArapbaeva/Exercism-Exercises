using System;
abstract class Character
{
    string characterType;
    protected Character(string characterType)
    {
        this.characterType = $"Character is a {characterType}";
    }
    
    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return characterType;
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if(target.Vulnerable())
            return 10;
        else
            return 6;
    }
}

class Wizard : Character
{
    private bool spellPrepared;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target) => spellPrepared ? 12 : 3;
    

    public void PrepareSpell()
    {
        spellPrepared = false;
        spellPrepared = true;
    }

    public override bool Vulnerable() => spellPrepared ? false : true;
    
}
