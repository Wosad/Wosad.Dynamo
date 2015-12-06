using System.Windows;

namespace Wosad.Dynamo.Common.Infra
{
    public class EnumDataElement
    {

        public Style Icon { get; set; }
        public string Description { get; set; }
        public string EnumString { get; set; }

        public override string ToString()
        {
            return this.EnumString;
        }
    }
}
