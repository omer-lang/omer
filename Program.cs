using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSH_OS
{
    class Program
    {
        class File
        {
           
            static string[] fileTypes = { "txt", "mp3", "pdf", "jpg", "mpg" };
            private string name;
            private int filetype;
            private int size;
            private string content;
            private int stam = 0;

            public File(string Name, int FileType, string Content)
            {
                name = Name;
                filetype = FileType;
                content = Content;
            }

            public File(File ExistingFile)
            {
               File NewFile;
               NewFile = ExistingFile;
             }



            public void SetName(string Name)
            {
                name = Name;
            }

            public int GetFileType()
            {
                return filetype;
            }

            public int GetSize()
            {
                return size;
            }

            public string GetFullName()
            {
                return name;
            }

            public override string ToString()
            {
                return name + size;
            }

            static bool NonUnique(File[] Files, File NewFile)
            {
                for (int i=0; i<Files.Length;i++)
                {
                    if (Files[i]!= null) {
                        return (Files[i].GetFullName().Equals(NewFile.GetFullName()) && Files[i].GetType().Equals(NewFile.GetType()));
                    }
                    
                }
                return false;
            }



            public static int GetFileTypesCount()
            {

                return fileTypes.Length;
            }


            public static string GetFileTypeByIndex(int index)
            {
                return fileTypes[index];
            }




        }//END CLASS










        static void Main(string[] args)
        {

        }
    }
}
