using System.Diagnostics;
using HostalIslaAzul.Infrastructure.Data;
using Microsoft.Extensions.Logging;

namespace HostalIslaAzul.API.Middleware;

public class AuditoriaService
{
    private readonly ILogger<AuditoriaService> _logger;
    private ApplicationDbContext _context;
    
    public async Task SaveAudit(string user, string action,string details)
    {
        var audit = new Audit
        {
            User = user,
            Action = action,
            Details = details,
            Date = DateTime.UtcNow
        };
        _context.Audits.Add(audit);
        await _context.SaveChangesAsync();
        _logger.LogInformation($"Action: {action} done by {user} with details: {details}");
    }
}