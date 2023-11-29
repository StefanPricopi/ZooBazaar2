using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CustomException
    {
        public class CustomErrorHandler
        {
            public static string GetErrorMessage(Exception ex)
            {
                if (ex is AuthenticationException)
                {
                    return "Authentication failed. Please check your credentials.";
                }
 
                return "An error occurred. Please try again later.";
            }
        }
    }
}
