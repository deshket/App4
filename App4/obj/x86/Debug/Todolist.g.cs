﻿#pragma checksum "C:\Users\deshk\OneDrive\Documents\Visual Studio 2017\Projects\App4\App4\Todolist.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "389014A7365F77EB4A6B5D713EE8759B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App4
{
    partial class Todolist : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.btnSubmit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\Todolist.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSubmit).Click += this.Submit_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.txtBoxItem = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.BtnRefresh = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Todolist.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnRefresh).Click += this.BtnRefresh_Click_1;
                    #line default
                }
                break;
            case 4:
                {
                    this.ListItems = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5:
                {
                    this.hplMainPage = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 29 "..\..\..\Todolist.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.hplMainPage).Click += this.HplMainPage_Click;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element6 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 30 "..\..\..\Todolist.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element6).Click += this.HyperlinkButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element7 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 24 "..\..\..\Todolist.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element7).Checked += this.CheckBoxComplete_Checked;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

