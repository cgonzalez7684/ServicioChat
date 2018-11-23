using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace PServicio.App_Code.Authentication
{
    class UserNamePassValidator :
           System.IdentityModel.Selectors.UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
            {
                throw new ArgumentNullException();
            }

            if (!(userName == "coopecaja1" && password == "coopecaja1"))
            {
                throw new FaultException("Incorrect Username or Password");
            }
        }
    }
}
