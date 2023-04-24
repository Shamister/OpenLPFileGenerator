using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLPFileGenerator
{
    public class Parameters
    {
        public string OutputDirectory { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public int MaxLines { get; set; } = 2;

        public bool AutoTranslate { get; set; }

        public bool BracketBetweenTranslation { get; set; }

        public int LineBreaksBetweenTranslation { get; set; }
    }
}
