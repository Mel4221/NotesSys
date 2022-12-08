using System;

namespace NotesSys
{
        public class Note 
        {
            
                public string Name { get; set; } 
                public string Text { get; set; }
                public string Path { get; set; } 
                public Uri UriPath { get; set; }
                public int    Id   { get; set; }
                public int Number  { get; set; } 
                public DateTime CreatedDate { get; set; }

                
               

               // public override string ToString() =>  $" Name: {Name} \n Text: {Text} \n Path: {Path} \n URI: {UriPath} \n ID: {Id} \n Number: {Number} \n Created Date: {CreatedDate} ";
                   
                
                public Note()
                {
                     Name = null; 
                     Text = null; 
                     Id   = XRandom.Int(1111,9999);
                     UriPath = new Uri(Environment.CurrentDirectory); 
                     Path = UriPath.LocalPath; 
                     CreatedDate = DateTime.Now; 
                }
                public Note(string name , string text)
                {
                     Name = name; 
                     Text = text;
                }
                public Note(string name , string text , int id )
                {
                     Name = name; 
                     Text = text; 
                     Id   = id;
 
                }
                public Note(string name , string text , int id , DateTime date)
                {
                     Name = name; 
                     Text = text; 
                     Id   = id;
                     CreatedDate = date;   
                }
                public Note(string name , string text , int id , Uri uriPath , DateTime date)
                {
                    
                     Name = name; 
                     Text = text; 
                     Id   = id;
                     UriPath = uriPath; 
                     Path = UriPath.LocalPath; 
                     CreatedDate = date; 
                }
        }
        
        class XRandom
        {
                  public static int Int(int from , int until)
            {
                  if (from  > until || from == int.MinValue || until == int.MaxValue)
                  {
                        Console.Write($"The Values MUST BE ON THE FALLOWING FROM < UNTIL AND RESPECTING THE MAXIMUM VALUE OF INTENGER VALUE");
                        Console.Write("Imposible Operation "); 
                        return 1111; 
                  }
                 // string password = "".Replace(" ", "");
                  Random number = new Random();

              
                        int rand = number.Next(from,until);


                  return rand; 
            }
        }
}
