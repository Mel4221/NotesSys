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
using System.Configuration;
using System.Collections.Generic; 
using System.Collections.Specialized;
using QuickTools.Colors;

namespace NotesSys
{
      internal class SettingsManager
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


            private Configuration config;

            public void Update(object setting , object newValue)
            {

                  string key, value;
                  key = setting.ToString();
                  value = newValue.ToString();

                  config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


                  config.AppSettings.Settings.Remove(key);
                  ConfigurationManager.RefreshSection("appSettings");
                  config.Save(ConfigurationSaveMode.Minimal);


                  config.AppSettings.Settings.Add(key, value);
                  ConfigurationManager.RefreshSection("appSettings");
                  config.Save(ConfigurationSaveMode.Minimal);
            }



            public void Add(object setting , object value)
            {
                  
                  if(Load(setting) != null)
                  {     
                                    
                   throw new Exception($"Not Possible to Add Setting {setting} due to already exist");

                  }
                  config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


                  config.AppSettings.Settings.Add(setting.ToString(), value.ToString());

                  ConfigurationManager.RefreshSection("appSettings");
                  config.Save(ConfigurationSaveMode.Minimal);
            }

            public string Load(object setting)
            {
#pragma warning disable CS0618 // Type or member is obsolete
                  return ConfigurationSettings.AppSettings.Get(setting.ToString());
#pragma warning restore CS0618 // Type or member is obsolete
            }




            public List<string> SettingRef = new List<string>(); 
            public List<string> SettingVal = new List<string>(); 


            internal void ManageSettings()
            {

                  Options.Label = "Update Settings |  just hit the right or left arrow keys to change the values";
                  Options options = new Options(LoadAll());
                  // function to change from true to false a value 
                  if (options.Count < 0)
                  {
                        ManageSettings();
                  }

                  while(true)
                  {
                        int answer = options.Pick(true);
                        if (Options.Triguered) Go.Back(); 

                        Get.Wait(Load(SettingRef[answer-1])); 
                  }

                  /*
                  switch (options.Pick(true))
                  {
                        case int.MaxValue:

                              string option = SettingRef[Options.CurrentSelection]; 

                              Update(option, Switch(Load(option)));
                              Color.Green("Changes Process Sucessfully"); 
                              Get.WaitTime(1000);
                              options = null;
                              //options.ClearOptions();
                              //Print.List(LoadAll()); 
                              //Get.Wait(); 
                              Go.Back(); 
                              break;
                        case int.MinValue:
                              //Go.Back(); 
                              break;

                  }
                  */
                  //Print.List(LoadAll(),true); 



            }
    //        public SettingsList<string, string> SettingsWithValues = new SettingsList<string, string>();  
            public string[] LoadAll()
            {

                

#pragma warning disable CS0618 // Type or member is obsolete
                  string[] settings = new string[ConfigurationSettings.AppSettings.Count];
#pragma warning restore CS0618 // Type or member is obsolete
                  int indexer = 0; 
                                                                       #pragma warning disable CS0618 // Type or member is obsolete
                  foreach (var setting in ConfigurationSettings.AppSettings)
                                                                       #pragma warning restore CS0618 // Type or member is obsolete
                  {

                        settings[indexer] = setting + " = " + Load(setting);
                        SettingRef.Add(setting.ToString());
                        SettingVal.Add(Load(setting)); 
                        //  SettingsWithValues.Add(setting.ToString(), Load(setting)); 
                        indexer++; 
                  }


              

                  return settings; 
            }


            
            public void DefaultSettings()
            {
                //  try {
                        bool IsDefault, LoadPath, IsLocked, FirstTime;

                        IsLocked = true;
                        LoadPath = true;
                        IsDefault = true;
                        FirstTime = false;

                        Add("IsDefault", IsDefault);
                        Add("IsLocked", IsLocked);
                        Add("LoadPath", LoadPath);
                        Add("FirstTime", FirstTime);
             /*   }catch(Exception ex)
                  {
                        Log.Event("DefaultSettings",ex);
                        Get.Wrong("There was an error while Setting up the default Settings"); 
                  }*/
            }

            internal void LoadSettings()
            {
                  if (Load("IsDefault") == "true" && Load("FirstTime") == "true" || Load("IsDefault") == null) 
                  {
                      
                        DefaultSettings();
                        return; 
                  }
                

            }
      }
}