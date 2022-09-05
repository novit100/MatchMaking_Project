using DP;
using MatchMaking_Project.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MatchMaking_Project
{
    public class BoyOrGirlCMD:ICommand
    {
        insertSeekerVM vm;
        public BoyOrGirlCMD(insertSeekerVM vm)
        {
            this.vm = vm;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           String s = (String)parameter;
            if (s == "girl")
            {
                vm.person = new SeekerGirl();
                vm.Girl = true;
                vm.Boy = false;
            }
            else
            {
                vm.person = new SeekerBoy();
                vm.Boy = true;
                vm.Girl = false;
            }
        }
    }
}
