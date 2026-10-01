public static class DialingCodes
{
    
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        Dictionary<int, string> emptyDictionary = new Dictionary<int, string>();
        return emptyDictionary;
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        Dictionary<int, string> countryDictionary = new Dictionary<int, string>()
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };
        return countryDictionary;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        Dictionary<int, string> emptyDictionary = new Dictionary<int, string>();
        emptyDictionary.Add(countryCode, countryName);
        return emptyDictionary;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.TryGetValue(countryCode, out var value) ? value : "";
   

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.ContainsKey(countryCode);
    

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if(existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
            
        }
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if(existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary.Remove(countryCode);
        }
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestCountryName = "";
        foreach(var value in existingDictionary.Values)
        {
            if(value.Length > longestCountryName.Length)
                longestCountryName = value;
        }
        return longestCountryName;
    }
}