﻿#pragma checksum "F:\HocWeb\Universal app\BT_universal_app\formJson\formJson\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C610796BAE0BA6586B4425F05F346F050852AC5E6C157B3F1AA7B9852AE6B38"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace formJson
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.lbFirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // MainPage.xaml line 14
                {
                    this.lbLastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // MainPage.xaml line 15
                {
                    this.lbPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5: // MainPage.xaml line 16
                {
                    this.lbAddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 17
                {
                    this.lbEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // MainPage.xaml line 18
                {
                    this.lbPhone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // MainPage.xaml line 19
                {
                    this.lbAvatar = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // MainPage.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.CalendarDatePicker element9 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)element9).DateChanged += this.CalendarDatePicker_DateChanged;
                }
                break;
            case 10: // MainPage.xaml line 26
                {
                    this.btnRegister = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRegister).Click += this.btnRegister_Click;
                }
                break;
            case 11: // MainPage.xaml line 27
                {
                    this.lbIntroduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // MainPage.xaml line 28
                {
                    this.lbValidFirstName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // MainPage.xaml line 29
                {
                    this.lbValidLastName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // MainPage.xaml line 30
                {
                    this.lbValidPhone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // MainPage.xaml line 31
                {
                    this.lbValidAvatar = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // MainPage.xaml line 32
                {
                    this.lbValidPassword = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // MainPage.xaml line 33
                {
                    this.lbValidAddress = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // MainPage.xaml line 34
                {
                    this.lbValidEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // MainPage.xaml line 35
                {
                    this.lbValidIntroduct = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // MainPage.xaml line 36
                {
                    this.lbValidGender = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // MainPage.xaml line 37
                {
                    this.lbValidBirthday = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22: // MainPage.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element22 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element22).Checked += this.RadioButton_Checked;
                }
                break;
            case 23: // MainPage.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element23 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element23).Checked += this.RadioButton_Checked;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

