using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ITransaction
    {
        bool Completed { get; set; }
        void Execute();
        void Undo();
    }
}
