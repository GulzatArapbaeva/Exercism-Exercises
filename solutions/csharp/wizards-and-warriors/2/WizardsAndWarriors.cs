using System;
abstract class Character
{
    string characterType;
    protected Character(string characterType)
    {
        this.characterType = $"Character is a {characterType}";
    }
    
    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;
    

    public override string ToString() => characterType;
    
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
    
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
