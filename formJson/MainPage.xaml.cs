using formJson.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace formJson
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string checkedGender;
        private string checkedCalendarDatePicker;
        private bool validateCheck = false;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            checkedGender = rb.Content.ToString();
        }

        private void CalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            CalendarDatePicker cdp = sender as CalendarDatePicker;
            checkedCalendarDatePicker = cdp.Date.Value.ToString("dd-MM-yyyy");
        }

        private void checkValidate(string FirstName, string LastName, string Phone, string Avatar, string Password, string Address, string Introduction, string checkedGender, string checkedCalendarDatePicker, string Email)
        {
            if (FirstName == "" || FirstName == null)
            {
                lbValidFirstName.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidFirstName.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (LastName == "" || LastName == null)
            {
                lbValidLastName.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidLastName.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (Phone == "" || Phone == null)
            {
                lbValidPhone.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidPhone.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (Avatar == "" || Avatar == null)
            {
                lbValidAvatar.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidAvatar.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (Password == "" || Password == null)
            {
                lbValidPassword.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidPassword.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (Address == "" || Address == null)
            {
                lbValidAddress.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidAddress.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (Introduction == "" || Introduction == null)
            {
                lbValidIntroduct.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidIntroduct.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (checkedGender == "" || checkedGender == null)
            {
                lbValidGender.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidGender.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (checkedCalendarDatePicker == "" || checkedCalendarDatePicker == null)
            {
                lbValidBirthday.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidBirthday.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
            if (Email == "" || Email == null)
            {
                lbValidEmail.Visibility = Visibility.Visible;
                validateCheck = true;
            }
            else
            {
                lbValidEmail.Visibility = Visibility.Collapsed;
                validateCheck = false;
            }
        }

        private async void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            checkValidate(lbFirstName.Text, lbLastName.Text, lbPhone.Text, lbAvatar.Text, lbPassword.Password.ToString(), lbAddress.Text, lbIntroduction.Text, checkedGender, checkedCalendarDatePicker, lbEmail.Text);
            //if (checkedGender == "" || checkedGender == null)
            //{
            //    ContentDialog contentDialog = new ContentDialog();
            //    contentDialog.Title = "Chưa nhập đủ";
            //    contentDialog.Content = "Chưa chưa nhập";
            //    contentDialog.CloseButtonText = "OK";
            //    await contentDialog.ShowAsync();
            //    return;
            //}
            //else
            //{
            //    ContentDialog contentDialog = new ContentDialog();
            //    contentDialog.Title = "Đã chọn";
            //    contentDialog.Content = checkedGender;
            //    contentDialog.CloseButtonText = "OK";
            //    await contentDialog.ShowAsync();
            //    return;
            //}
            if (validateCheck == true)
            {
                return;
            }
            else
            {
                var register = new Register() {
                    firstName = lbFirstName.Text,
                    lastName = lbLastName.Text,
                    Password = lbPassword.Password.ToString(),
                    Address = lbAddress.Text,
                    Phone = lbPhone.Text,
                    Avatar = lbAvatar.Text,
                    Gender = checkedGender,
                    Email = lbEmail.Text,
                    Birthday = checkedCalendarDatePicker,
                    Introduction = lbIntroduction.Text,
                };
                var jsonString = JsonConvert.SerializeObject(register);
                Debug.WriteLine(register);
                ContentDialog contentDialog = new ContentDialog();
                contentDialog.Title = "Thông tin đăng ký dạng Json";
                contentDialog.Content = jsonString;
                contentDialog.CloseButtonText = "OK";
                await contentDialog.ShowAsync();
                return;
            }
        }
    }
}
