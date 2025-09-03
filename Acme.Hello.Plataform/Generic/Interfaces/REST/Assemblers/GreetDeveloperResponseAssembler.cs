using Acme.Hello.Plataform.Generic.Domain.Model.Entities;
using Acme.Hello.Plataform.Generic.Interfaces.REST.Recources;

namespace Acme.Hello.Plataform.Generic.Interfaces.REST.Assemblers;
/// <summary>
/// Assembler for converting 
/// </summary>
public static class GreetDeveloperResponseAssembler
{
    public static GreetDeveloperResponseAssembler ToResponseFromEntity(Developer? entity)
    {
        if (entity == null || entity.IsAnyNameEmpty())
            return new GreetDeveloperResponse(Message: "Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(entity.Id,entity.getFullName(),
            Message:$"Congrats, {entity.getFullName()}! You are an asp.net CORE Developer.");
    }
}