using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas
{
   public class Employee
    {
        private string _name;
        private string _team;
        private string _taskName;
        private bool _isCordinator;
        private bool _isPersonInCharge;
        private DateTime _StartDate;
        private DateTime _DateFinish;
        private string _description;

        public Employee(string Name, string Team, string TaskName, bool IsCordinator, bool IsPersonInCharge, DateTime Start, DateTime Finish, string Description)
        {
            _name = Name;
            _team = Team;
            _taskName = TaskName;
            _isCordinator = IsCordinator;
            _isPersonInCharge = IsPersonInCharge;
            _StartDate = Start;
            _DateFinish = Finish;
            _description = Description;
        }


    }
}
