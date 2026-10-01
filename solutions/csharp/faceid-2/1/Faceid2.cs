public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public bool Equals(FacialFeatures facialFeatures)
    {
        if(facialFeatures == null) return false;
        return this.EyeColor == facialFeatures.EyeColor && this.PhiltrumWidth == facialFeatures.PhiltrumWidth;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as FacialFeatures);
    }


    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }

}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public bool Equals(Identity identity)
    {
        if(identity == null) return false;
        return this.Email == identity.Email && this.FacialFeatures.Equals(identity.FacialFeatures);
            
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Identity);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }
}

public class Authenticator
{
    static FacialFeatures adminFacialFeatures = new FacialFeatures("green", 0.9m);
    static Identity adminIdentity = new Identity("admin@exerc.ism", adminFacialFeatures);
    
    private HashSet<Identity> registeredIdentities = new();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return identity.Equals(adminIdentity);
    }

    public bool Register(Identity identity)
    {
        return registeredIdentities.Add(identity);
    }

    public bool IsRegistered(Identity identity)
    {
        return registeredIdentities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA == identityB;
    }
}
