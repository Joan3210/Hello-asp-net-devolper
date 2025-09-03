namespace Acme.Hello.Plataform.Generic.Domain.Model.Entities;
/// <summary>
/// Developer entity in the generic Bounded Context
/// </summary>
/// <param name="firstName"></param>
/// <param name="lastName"></param>

    public class Developer(string? firstName, string? lastName)
    {
        public Guid Id {get:} = Guid.NewGuid();
        
        public string FirstName {get;} = string.IsNullOrEmpty(firstName) ? "" : firstName.Trim();
        
        public string LastName {get;} = string.IsNullOrEmpty(lastName) ? "" : lastName.Trim();
        /// <summary>
        /// Gets the full name of the developer by concatenating the first an the last name.
        /// </summary>
        /// <returns>An string with the format "First Name and Last Name"</returns>
        public string getFullName() => $"{FirstName} {LastName}", Trim();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns </returns>
        public bool IsAnyNameEmpty( )=> string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);
    }
