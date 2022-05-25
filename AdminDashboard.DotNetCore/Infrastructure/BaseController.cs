﻿using Microsoft.AspNetCore.Mvc;

namespace AdminDashboard.DotNetCore.Infrastructure
{
    [Route("[controller]/[action]", Name = "[controller]_[action]")]
    public abstract class BaseController : Controller
    {
    }
}