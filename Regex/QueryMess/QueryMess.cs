using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class QueryMess
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string firstPattern = @"(.+)=(.+)";
        

        while (!input.Equals("END"))
        {
            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
            string[] inputInfo = input.Split(new char[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in inputInfo)
            {
                Regex regex = new Regex(firstPattern);
                bool isMatch = regex.IsMatch(item);

                if (isMatch)
                {
                    Match match = regex.Match(item);
                    string keyName = match.Groups[1].ToString();
                    string valueName = match.Groups[2].ToString();
                    string secondPattern = @"\+|%20";
                    string[] keyAndValue = new string[2];
                    keyAndValue[0] = keyName;
                    keyAndValue[1] = valueName;

                    for (int i = 0; i < 2; i++)
                    {
                        Regex rgx = new Regex(secondPattern);
                        isMatch = rgx.IsMatch(keyAndValue[i]);
                        string firstReplacement = " ";

                        if (isMatch && i == 0)
                        {
                            keyName = rgx.Replace(keyName, firstReplacement);
                            string thirdPattern = @"\s+";
                            string secondReplacement = " ";
                            Regex reg = new Regex(thirdPattern);
                            keyName = reg.Replace(keyName, secondReplacement);
                        }
                        else if (isMatch && i == 1)
                        {
                            valueName = rgx.Replace(valueName, firstReplacement);
                            string thirdPattern = @"\s+";
                            string secondReplacement = " ";
                            Regex reg = new Regex(thirdPattern);
                            valueName = reg.Replace(valueName, secondReplacement);
                        }
                    }

                    keyName = keyName.Trim();
                    valueName = valueName.Trim();

                    if (!results.ContainsKey(keyName))
                    {
                        results.Add(keyName, new List<string>());
                    }

                    results[keyName].Add(valueName);
                }
                else
                {
                    continue;
                }
            }

            bool isPrint = false;

            foreach (var key in results)
            {

                Console.Write($"{key.Key}=[{string.Join(", ", key.Value)}]");
                isPrint = true;
            }

            if (isPrint)
            {
                Console.WriteLine();
            }
            
            input = Console.ReadLine();
        }       
    }
}
