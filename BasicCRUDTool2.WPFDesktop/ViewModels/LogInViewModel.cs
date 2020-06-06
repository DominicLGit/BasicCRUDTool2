using BasicCRUDTool2.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUDTool2.WPFDesktop.ViewModels
{
    public class LogInViewModel : ViewModel
    {
        #region Private Properties
        private string userID;
        private string database;
        private string host;
        private SecureString securePassword { get; set; }
        #endregion

        #region Public Properties
        [Required]
        public string UserID
        {
            get { return userID; }
            set
            {
                userID = value;
                OnPropertyChanged();
            }
        }

        [Required]
        public string Database
        {
            get { return database; }
            set
            {
                database = value;
                OnPropertyChanged();
            }
        }

        [Required]
        public string Host
        {
            get { return host; }
            set
            {
                host = value;
                OnPropertyChanged();
            }
        }

        [Required]
        public SecureString SecurePassword
        {
            set
            {
                securePassword = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
