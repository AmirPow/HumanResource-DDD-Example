﻿using HR.Framework.Domain;

namespace HR.EmployeeContext.Domain.Employees.Exceptions
{
   public class NationalCodeMustBeDigitException: DomainException
   {
       public override string Message => Resource.Resource.NationalCodeMustBeDigitException;
   }
}
