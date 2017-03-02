using System;
using System.Collections.Generic;
using System.Linq;

public class Files
{
    public static void Main()
    {
        int filesCount = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, long>> files = new Dictionary<string, Dictionary<string, long>>();

        for (int i = 0; i < filesCount; i++)
        {
            string[] input = Console.ReadLine()
                                        .Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            string root = input[0].Trim();
            string[] filesInfo = input[input.Length - 1]
                                        .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string fileName = filesInfo[0].Trim();
            long fileSize = long.Parse(filesInfo[1].Trim());

            if (!files.ContainsKey(root))
            {
                files.Add(root, new Dictionary<string, long>());
            }
            if (!files[root].ContainsKey(fileName))
            {
                files[root].Add(fileName, 0);
            }

            files[root][fileName] = fileSize;
        }

        string[] extensionAndRootInfo = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string extension = extensionAndRootInfo[0];
        string demandRoot = extensionAndRootInfo[2];

        var selectedByRoot = files.Where(r => r.Key == demandRoot).ToDictionary(x => x.Key, x => x.Value);
        Dictionary<string, long> selectedByExtension = new Dictionary<string, long>();

        foreach (var file in selectedByRoot)
        {
            var filesInRoot = files[file.Key].Keys.ToArray();

            for (int i = 0; i < filesInRoot.Length; i++)
            {
                if (filesInRoot[i].EndsWith(extension))
                {
                    selectedByExtension.Add(filesInRoot[i], files[file.Key][filesInRoot[i]]);
                }
            }
        }

        bool isFound = false;

        foreach (var file in selectedByExtension.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
        {
            Console.WriteLine($"{file.Key} - {file.Value} KB ");
            isFound = true;
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}
