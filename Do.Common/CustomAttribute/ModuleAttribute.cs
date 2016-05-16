using System;

namespace Do.Common
{
    public class ModuleAttribute:Attribute
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Sort { get; set; }
    }
}
