using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

namespace RoadProgram.Management
{
    public class FileManagement
    {
      public string path { get; set; }
      public List<FileInfo> Files {get; set;}
      public FileManagement()
      {
        path = "data";
        Files = GetFilesInPath(path);
      }
      
      public string GetFilePath()
      {
        while(true)
        {
          Console.WriteLine("Enter Path of Folder you want to read from");
          string path = Console.ReadLine().ToLower();
          if(Directory.Exists(path))
          {
            return path;
          }
          else
          {
            Console.WriteLine("Please supply a real directory");
          }
        }
      }  
      public List<FileInfo> GetFilesInPath(string filePath)
      {
        List<FileInfo> files = new List<FileInfo>();
        foreach (var file in new DirectoryInfo(filePath).GetFiles("*.txt"))
        {
            files.Add(file);
        }
        return files;
      }
      public FileInfo GetFile(List<FileInfo> files, string fileName)
      {
        foreach (var item in files)
        {
          if(item.Name == fileName)
          {
            return item;
          }
        }
        return null;
      }
      public string[] GetContentsOfFile(FileInfo file)
      {
        return System.IO.File.ReadAllLines($"{file}");
      } 
    }
}