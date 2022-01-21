using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2Alternative
{
    class TXTHandler : AbstractHandler
    {
        public override string Chenge() => "Chenge txt file";

        public override string Create() => "Create txt file";

        public override string Open() => "Open txt file";

        public override string Save() => "Spen txt file";
    }
}
