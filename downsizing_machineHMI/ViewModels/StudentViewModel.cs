using downsizing_machineHMI.Commands;
using downsizing_machineHMI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;

namespace downsizing_machineHMI.ViewModels
{
    public class StudentViewModel:NotifyPropertyBase
    {
        public ICommand SubmitCommand { get; set; }

        public StudentViewModel()
        {
            SubmitCommand = new CommandBase(ExeSubmitCommand);
        }

        private void ExeSubmitCommand(object obj)
        {
            string gender = "";
            if (StudentGender == GenderEnum.Female)
            {
                gender = "男";
            }
            else
            {
                gender = "女";
            }
            MessageBox.Show($"学员编号：{StudentId}, 学员姓名：{studentName}, 学员年龄：{StudentAge}, 学员性别：{gender}");
        }

        #region 绑定的属性

        private int studentId;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; NotifyPropertyChanged(); }
        }

        private string studentName;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; NotifyPropertyChanged(); }
        }

        private int studentAge;

        public int StudentAge
        {
            get { return studentAge; }
            set { studentAge = value; NotifyPropertyChanged(); }
        }

        private GenderEnum studentGender;

        public GenderEnum StudentGender
        {
            get { return studentGender; }
            set { studentGender = value; NotifyPropertyChanged(); }
        }

        public ObservableCollection<GenderEnum> Genders
        {
            get
            {
                return new ObservableCollection<GenderEnum>() { GenderEnum.Male, GenderEnum.Female };
            }
        }

        #endregion

    }
}
