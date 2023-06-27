using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace downsizing_machineHMI.Commands
{
    public class NotifyPropertyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 实现消息通知
        /// </summary>
        /// <param name="prop">通知的属性</param>
        public void NotifyPropertyChanged([CallerMemberName] string prop = "") 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
