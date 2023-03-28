using System;
using System.Collections.Generic;

namespace Demo_Project__ASP.NET_Core_Web_API_.Models;

public partial class UserDetail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;
}
