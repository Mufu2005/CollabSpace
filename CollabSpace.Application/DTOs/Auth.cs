using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabSpace.Application.DTOs
{
    public class RegisterDto
    {
        string UserName { get; set; }
        string Email { get; set; }
        string Password { get; set; }

    }

    public class LoginDto
    {
        string Email { get; set; }
        string Password { get; set; }
    }
}
