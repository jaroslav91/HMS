using System;

namespace CompanyName.HousingManagementSystem.Application.Exceptions
{
    public class BadRequestException: ApplicationException
    {
        public BadRequestException(string message): base(message)
        {

        }
    }
}
