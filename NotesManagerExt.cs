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
using System.Xml; 
using QuickTools; 
using System.Collections.Generic; 

namespace NotesSys
{
        public partial class NotesManager
      { 
            public class NotesInfo
            {

                  
                  public void Get(string file)
                  {




                        string fileName, atribute;
                        fileName = file;
                        atribute = "PATH";


                        using (XmlReader reader = XmlReader.Create(fileName))
                        {


                              while (reader.Read())
                              {

                                    // Get.Green(reader.Name + " " + reader.GetAttribute(atribute));


                                    if ((reader.NodeType == XmlNodeType.Element) && reader.Name != "")//(reader.Name.IndexOf("DATE") == 0))
                                    {
                                          if (reader.HasAttributes)
                                          {
                                                //  Get.Blue(reader.GetAttribute(atribute));

                                          }

                                    }


                              }
                        }
                  }
                        public void Write()
                        {

                        }
                  }
                  public void Set()
                  {

                  }

            }
      }

}
