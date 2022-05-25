using Microsoft.AspNetCore.Mvc.Filters;

namespace AdminDashboard.DotNetCore.Infrastructure.ErrorHandling
{
    public abstract class ModelStateTransfer : ActionFilterAttribute
    {
        protected const string Key = nameof(ModelStateTransfer);
    }
}