using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2Alternative
{
    class DOCHandler : AbstractHandler
    {
        public override string Chenge() => "Chenge doc file";

        public override string Create() => "Create doc file";

        public override string Open() => "Open doc file";

        public override string Save() => "Spen doc file";
    }
}
