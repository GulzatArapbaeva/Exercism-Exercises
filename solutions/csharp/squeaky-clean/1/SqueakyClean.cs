using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        
        StringBuilder sb = new StringBuilder(identifier.Length);
        bool capitalizeNext = false;
        foreach(char c in identifier)
        {
            if(c == '-')
            {
                capitalizeNext = true;
                continue;
            }

            if(capitalizeNext)
            {
                sb.Append(char.ToUpper(c));
                capitalizeNext = false;
            }
            else if(char.IsControl(c))
                sb.Append("CTRL");
            else if(c == ' ')
                sb.Append('_');
            else if(c >= 'α' && c <= 'ω')
                continue;
            else
                if(char.IsLetter(c))
                    sb.Append(c);
        }
        
        return sb.ToString();
        
    }
}
