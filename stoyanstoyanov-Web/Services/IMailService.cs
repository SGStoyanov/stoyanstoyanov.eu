// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMailService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IMailService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace stoyanstoyanov_Web.Services
{
    public interface IMailService
    {
        bool SendMail(string to, string from, string subject, string body);

    }
}