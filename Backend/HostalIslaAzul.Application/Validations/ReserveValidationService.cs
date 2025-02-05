using System.ComponentModel.DataAnnotations;
using HostalIslaAzul.Domain.Entities;

namespace HostalIslaAzul.Application.Validations;

public class ReserveValidationService
{
    public void ValidateReserve(Reserve reserve)
    {
        if (reserve.CheckInDate < DateTime.Now.Date)
        {
            throw new ValidationException("Check In Date can't be in past");
        }
        if(reserve.CheckOutDate < reserve.CheckInDate)
        {
            throw new ValidationException("Check Out Date can't be before Check In Date");
        }

        if (reserve.CheckInDate >= reserve.CheckOutDate)
        {
            throw new ValidationException("Check In Date can't be equal or greater than Check Out Date");
        }
    }
}