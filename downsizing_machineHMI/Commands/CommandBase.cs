using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace downsizing_machineHMI.Commands
{
    public class CommandBase : ICommand
    {
        //定义一个委托
        public Action<object?> ExecuteAction { get; set; }

        public event EventHandler? CanExecuteChanged;

        public CommandBase(Action<object> action)
        {
            ExecuteAction = action;

        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //利用委托执行需要调用的方法
            ExecuteAction.Invoke(parameter);
        }
    }
}
