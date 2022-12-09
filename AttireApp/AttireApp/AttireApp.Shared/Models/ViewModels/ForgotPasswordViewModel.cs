using AttireApp.Database.DBUser;

namespace AttireApp.Models.ViewModels
{
    class ForgotPasswordViewModel : BindableBase
    {
        //error handling for when the current password is incorrect
        private string _UpdatePassErrorMsg = string.Empty;
        public string UpdatePassErrorMsg
        {
            get => _UpdatePassErrorMsg;
            set => SetMyProperty(ref _UpdatePassErrorMsg, value);
        }
        private bool _IsPasswordInvalid = false;
        public bool IsPasswordInvalid
        {
            get => _IsPasswordInvalid;
            set => SetMyProperty(ref _IsPasswordInvalid, value);
        }

        private string _curpassword = string.Empty;
        public string CurPassword
        {
            get => _curpassword;
            set => SetMyProperty(ref _curpassword, value);
        }

        private string _newpass = string.Empty;
        public string NewPass
        {
            get => _newpass;
            set => SetMyProperty(ref _newpass, value);
        }

        private string _confirmpass = string.Empty;
        public string ConfirmPass
        {
            get => _confirmpass;
            set => SetMyProperty(ref _confirmpass, value);
        }

        public bool ChangePass()
        {
            if(User.CurrentUser.UpdatePassword(CurPassword, NewPass, ConfirmPass) == 0)
            {
                IsPasswordInvalid = true;
                UpdatePassErrorMsg = "Your original password does not match our records. Please try again";
                return false;
            }
            else if(User.CurrentUser.UpdatePassword(CurPassword, NewPass, ConfirmPass) == -1)
            {
                IsPasswordInvalid = true;
                UpdatePassErrorMsg = "The new password and confirm password fields do not match. Please try again";
                return false;
            }else if(User.CurrentUser.UpdatePassword(CurPassword, NewPass, ConfirmPass) == -2)
            {
                IsPasswordInvalid = true;
                UpdatePassErrorMsg = "Your new password cannot be empty. Please try again";
                return false;
            }
            return true;
        }
    }
}
