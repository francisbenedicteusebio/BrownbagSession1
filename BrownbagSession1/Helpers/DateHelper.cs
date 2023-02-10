using BrownbagSession1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrownbagSession1.Helpers
{
    public static class DateHelper
    {
        public static int ComputeAge(DateTime? dateOfBirth)
        {
            if (dateOfBirth != null)
            {
                var age = Math.Floor((DateTime.Today - dateOfBirth.Value).TotalDays / 365);
                return (int)age;
            }

            return 0;
        }

       
    }
}
