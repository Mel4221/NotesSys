//
// ${Melquiceded Balbi Villanueva}
//
// Author:
//       ${Melquiceded} <${melquiceded.balbi@gmail.com}>
//
// Copyright (c) ${2089} MIT
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Collections.Generic;
using QuickTools; 

namespace NotesSys
{
      class MainClass
      {
            public static void Main(string[] args)
            {
                  /*
                        NotesManager notesManager = new NotesManager();
                        var setup = new SettingsManager();
                  */

                  NotesManager notes = new NotesManager();

                  notes.Add(new Note() {
                        Name = "TodoList",
                        Text = "go to the school",
                        Number = notes.Number(),

                        
                  });

                  notes.Add(new Note()
                  {
                        Name = "TodoList",
                        Text = "go to the store",
                        Number = notes.Number()
                        
                  });


                  foreach(var note in notes.Notes)
                  {
                        Get.Blue(note.ToString());
                        //Get.Wait(note.ToString());
                        //string file = $"{note.Number}{note.Name}.txt";
                        Writer.Write(note.Number+"note.txt", note.ToString()); 
                  }


                  Get.Blue(notes.Get(0).ToString());
                  Get.Wait("Waiting for input");
                /**********************************************************/
                  if (args.Length > 0 )
                  {
                        Get.Yellow("This is still not implemented"); 
                        return;
                  }
                  else
                  {
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Start(); 
                  }
            }
      }
}


/*

                  int x = 0; 
                  while(x < 500)
                  {

                        x++;
                       // Get.Green(setup.Get(x.ToString()));
                        //setup.Remove(x.ToString()); 
                        //string data = $"Date: {DateTime.Now } Random Data: {IRandom.RandomText(10000)}";
                       // Get.Green($" {Math.Round(Convert.ToDouble((x/500)*1000),2)}%"); 
                       // setup.Add(x,data);
                        //Get.WaitTime(1000); 

                  }
               

*/