namespace Acme.Hello.Plataform.Generic.Interfaces.REST.Recources;
/// <summary>
/// Response returned when greeting a develpoer
/// </summary>
/// <remarks>This records encapsulates the response details when a develper is greated</remarks>
/// <param name="Id"></param>
/// <param name="FullName"></param>
/// <param name="Message"></param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    /// Initialites a new instance of a greet 
    /// </summary>
    /// <param name="Message"></param>
    public GreetDeveloperResponse(string Message): this(Id:null,FullName:null,Message){}
}