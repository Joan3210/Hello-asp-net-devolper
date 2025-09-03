using Acme.Hello.Plataform.Generic.Domain.Model.Entities;
using Acme.Hello.Plataform.Generic.Interfaces.REST.Recources;

namespace Acme.Hello.Plataform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// assembler for developer entity and related request/response objects
/// </summary>
/// <remarks>This class provides methods to converts from rest request to Developer objects</remarks>
public static class DeveloperAssembler
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.FirstName) || string.IsNullOrWhiteSpace(request.LastName))
        {
            return null;
        }
        return new Developer(request.FirstName, request.LastName);
    }
}