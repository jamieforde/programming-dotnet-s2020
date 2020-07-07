/*
 * Copyright 2016-2020 Mohawk College of Applied Arts and Technology
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: Jamie Forde
 * Date: 2020-06-01
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Week2_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Writing to a file");
            try
            {
                // Provides a stream for a file
                // Investigate the FileMode and FileAccess enums
                // Note exceptions that can be thrown
                FileStream file = new FileStream("test3.txt", FileMode.Open, FileAccess.Read);
                
                // Used for writing characters to a stream
                StreamWriter data = new StreamWriter(file);


                for (var i = 1; i < 10; i++)
                {
                    Console.WriteLine($"\tInserting Line {i}");
                    data.WriteLine($"This is line {i}");
                }

                // Always close your streams
                data.Close();
                file.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine($"An exception has been thrown {e.Message}");
            }

            Console.WriteLine("Reading from a file");
            try
            {
                FileStream file = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                
                // Used for reading characters from a stream
                StreamReader data = new StreamReader(file);

                string line;

                // ReadLine method will return null when no more data is available
                while ((line = data.ReadLine()) != null)
                {
                    // Here are we just writing to the console 
                    // But this is were you would process the data you read in
                    Console.WriteLine($"\t{line}");
                }

                data.Close();
                file.Close();
            
            } catch (Exception e)
            {
                Console.WriteLine($"An exception has been thrown while reading from file {e.Message}");
            }


            Console.WriteLine("File Info Section");
            // Use the file info object to access a file's properties 
            try
            {
                FileInfo fileInfo = new FileInfo("test.txt");
                Console.WriteLine($"\tFile Full Name: {fileInfo.FullName}");
                Console.WriteLine($"\tFile Name: {fileInfo.Name}");
                Console.WriteLine($"\tFile CreationTime: {fileInfo.CreationTime}");
                Console.WriteLine($"\tFile Last Accessed: {fileInfo.LastAccessTime}");
                Console.WriteLine($"\tFile Size: {fileInfo.Length}");
            } catch (Exception e)
            {
                Console.WriteLine($"An exception has been thrown while accessing file {e.Message}");

            }


            // Directory class for moving, creating and looping through directories (folders) 
            // and subdirectories
            Console.WriteLine("List of Drives");
            string[] drives = Directory.GetLogicalDrives();

            foreach (var drive in drives)
            {
                Console.WriteLine($"\t{drive}");
            }

            Console.WriteLine("List of Files");

            // Files           
            string[] files = Directory.GetFiles("c:\\windows");

            foreach (var file in files)
            {
                Console.WriteLine($"\t{file}");
            }

            Console.WriteLine("List of Directories");

            // Subdirectories
            string[] directories = Directory.GetDirectories("c:\\windows");

            foreach (var directory in directories)
            {
                Console.WriteLine($"\t{directory}");
            }

            Console.ReadKey();
        }
    }
}
