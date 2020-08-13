using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesLibrary.Strategies
{
    public class Role : Strategy
    {
        string role = "";
        public Role(string role)
        {
            this.role = role ;
        }
      
        public override string ApplyStrategy(string file)
        {
            if (role.Equals("Admin"))
            {
                return file ;
            }
            else
            {
                return null;
            }
             
        }
    }
}
