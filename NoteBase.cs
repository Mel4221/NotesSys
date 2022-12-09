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

                public override string ToString() =>  $" Name: {Name} \n Text: {Text} \n Path: {Path} \n URI: {UriPath} \n ID: {Id} \n Number: {Number} \n Created_Date: {CreatedDate} ";
                   
                
                public Note()
                {
                     Name = null; 
                     Text = null;
                     Id = 1000; 
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
        
       
}
