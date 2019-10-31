using Microsoft.AspNetCore.Mvc.Filters;

namespace Senner007.ScaffoldingOptions
{

    public class ScaffoldingOptions : System.Attribute
    {
        public string Prop { get; set; }

        public ScaffoldingOptions(string prop)
        {
            this.Prop = prop;
        }    
    }

}
