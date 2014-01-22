using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Windows.Foundation.Metadata;
using CrmClient.Models;
using CrmClient.Repositories;

namespace CrmClient.ViewModels
{
    public class SettingsViewModel :BaseViewModel, INotifyDataErrorInfo
    {
        
        private string _host;
        private string _userName;
        private string _organization;
        private bool _useHttps;
        private string _password;
        
        public string Host
        {
            get { return _host; }
            set
            {
                
                _host = value;
                if (_host != null && string.IsNullOrEmpty(_host) ) 
                {
                    AddError("Host", "That text can only be 4 or less characters long.");
                }
                else
                {
                    ClearError("Host");
                }
                OnPropertyChanged();
            }

        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                
                _userName = value;
                if (_userName != null && string.IsNullOrEmpty(_userName))
                {
                    AddError("UserName", "That text can only be 4 or less characters long.");
                }
                else
                {
                    ClearError("UserName");
                }
               
            }
        }

        public string Organization
        {
            get { return _organization; }
            set
            {
                _organization = value;
                if (_organization != null && string.IsNullOrEmpty(_organization))
                {
                    AddError("Organization", "That text can only be 4 or less characters long.");
                }
                else
                {
                    ClearError("Organization");
                }
                
            }
        }

        public bool UseHttps
        {
            get { return _useHttps; }
            set
            {
                if (value.Equals(_useHttps)) return;
                _useHttps = value;
               OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
               
                _password = value;
                if (_password != null && string.IsNullOrEmpty(_password) )
                {
                    AddError("Password", "That text can only be 4 or less characters long.");
                }
                else
                {
                    ClearError("Password");
                }
                OnPropertyChanged();
            }
        }

        private void AddError(string propertyName, string errorMessage)
        {
            _errors[propertyName] = new List<string> { errorMessage };
            OnErrorsChanged(propertyName);
        }

        private void ClearError(string propertyName)
        {
            if (_errors.ContainsKey(propertyName))
            {
                _errors.Remove(propertyName);
            }

            OnErrorsChanged(propertyName);
        }


        private void OnErrorsChanged(string propertyName)
        {
            var handlers = ErrorsChanged;
            if (handlers != null)
            {
                handlers(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }

        private readonly Dictionary<string, IList<string>> _errors = new Dictionary<string, IList<string>>();

        public IEnumerable GetErrors(string propertyName)
        {
            IList<string> errors;
            _errors.TryGetValue(propertyName, out errors);
            return errors;
        }

        public bool HasErrors
        {
            get { return _errors.Count > 0; }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public void Validate()
        {
            if (_host == null)
            {
                AddError("Host", "That text can only be 4 or less characters long.");
            }
            else
            {
                ClearError("Host");
            }
        }

        public void GetSettings()
        {
            var repository = new SettingsRepository();
            var settings = repository.GetSettings();
            Host = settings.Host;
            UseHttps = settings.UseHttps;
            Organization = settings.Organization;
            UserName = settings.UserName;
            Password = settings.Password;
        }

        public void SaveSettings()
        {
            var settings = new Settings
            {
                Host = Host,
                Organization = Organization,
                UserName = UserName,
                Password = Password,
                UseHttps = UseHttps
            };
            var save = new SettingsRepository();
            save.SaveSettings(settings);
        }
    }
}
