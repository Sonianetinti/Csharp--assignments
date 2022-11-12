using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace assignment7 
{ class directory 
    { 
        static void Main(string[] args) 
       { 
         string path; 
         string root = @"C:\newtext"; 
         string subdir = @"C:\newtext\Sonia"; 
            Directory.CreateDirectory(root); 
            Directory.CreateDirectory(subdir); 
            path = "C:\\newtext\\Sonia"; 
            Console.WriteLine(path);
            Console.ReadKey();
        } 
    } 
}