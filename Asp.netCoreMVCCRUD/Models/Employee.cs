using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee : INotifyPropertyChanged
    {
        private string _fullName;
        private string _empCode;
        private string _position;
        private string _officeLocation;

        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "{0} field is required.")]
        [DisplayName("Full Name")]
        public string FullName
        {
            get => _fullName;
            set
            {
                if (value == _fullName) return;
                _fullName = value;
                OnPropertyChanged();
            }
        }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Code")]
        public string EmpCode
        {
            get => _empCode;
            set
            {
                if (value == _empCode) return;
                _empCode = value;
                OnPropertyChanged();
            }
        }

        [Column(TypeName = "varchar(100)")]
        public string Position
        {
            get => _position;
            set
            {
                if (value == _position) return;
                _position = value;
                OnPropertyChanged();
            }
        }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation
        {
            get => _officeLocation;
            set
            {
                if (value == _officeLocation) return;
                _officeLocation = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
