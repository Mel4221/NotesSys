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
using QuickTools.Colors;

namespace NotesSys
{
      public partial class SettingsManager
      {



            public SettingsManager()
            {

            }

            public bool Switch(string input)
            {
                
                        bool Is = false;

                        Is = input == "True" ? true : false;


                  return Is;
            }



          
       

              



            private string SettingsFile = "DefalutSettings.xml";

            public void DefaultSettings()
            {
                  //  try {
                  QSettings settings = new QSettings();
                  settings.FileName = SettingsFile; 

                        settings.Create(); 
                        bool IsDefault, LoadPath, IsLocked, FirstTime;

                        IsLocked = true;
                        LoadPath = true;
                        IsDefault = true;
                        FirstTime = false;

                  settings.Add("IsDefault", IsDefault);
                  settings.Add("IsLocked", IsLocked);
                  settings.Add("LoadPath", LoadPath);
                  settings.Add("FirstTime", FirstTime);
             /*   }catch(Exception ex)
                  {
                        Log.Event("DefaultSettings",ex);
                        Get.Wrong("There was an error while Setting up the default Settings"); 
                  }*/
            }

            internal void LoadSettings()
            {
                  QSettings settings = new QSettings();
                  settings.FileName = SettingsFile;
                  settings.Create(); 
                  settings.Load(); 
                  if(settings.GetSetting("FirstTime") == "True" || settings.GetSetting("FirstTime") == null)
                  {
                              DefaultSettings();
                  }
            }
      }
}