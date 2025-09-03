namespace Acme.Hello.Plataform.Generic.Interfaces.REST.Recources;
/// <summary>
/// Request to a greet Developer
/// </summary>
/// <remarks>\
/// This record is used in the Great Developer enPoint
/// </remarks>
/// <param name="FirstName"></param>
/// <param name="LastName"></param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);