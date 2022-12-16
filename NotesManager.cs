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
using QuickTools; 
using System.Collections.Generic; 

namespace NotesSys
{
        public partial class NotesManager
      {

            /// <summary>
            /// Noteses the indexer.
            /// </summary>
            /// <returns>The indexer.</returns>
            public int Number() => Count() + 1000; 

            /// <summary>
            /// Contains the List of Notes 
            /// </summary>
            public List<Note> Notes = new List<Note>();

            /// <summary>
            /// Returns the Notes Count
            /// </summary>
            /// <returns>The count.</returns>
            public int Count() => Notes.Count;

            /// <summary>
            /// Get the specified Note by the Index provided.
            /// </summary>
            /// <returns>The get.</returns>
            /// <param name="index">Index.</param>
            public Note Get(int index) => Notes[index];

            /// <summary>
            /// Add the spesifyed note to the list 
            /// </summary>
            /// <param name="note">Note.</param>
            public void Add(Note note) => Notes.Add(note);

            /// <summary>
            /// Remove the note from the list 
            /// </summary>
            /// <param name="name">Note.</param>
            public void Remove(string name ) => Notes.Remove(this.Find(name));



            public Note Find(string name)
            {
                  foreach(var note in Notes)
                  {
                        if(note.Name == name)
                        {
                              return note; 
                        }
                  }
                  return default(Note); 
            }

       


            /// <summary>
            /// Initializes a new instance of the <see cref="T:NotesSys.NotesManager"/> class.
            /// </summary>
            public NotesManager()
            {
                  SettingsManager settingsManager = new SettingsManager();

                  settingsManager.LoadSettings();
             
                  masterdb = "masterdb.xml";
                  notesdb =  "notesdb.xml";

            }
      }
}
