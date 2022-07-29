using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Configuration.Extensions
{
    public static class ValidatorExtension//Validasyonun başarılı ya da başarısız olduğunu kontrol ettiğim sınıf ve metodu. Static sınıfı, o sınıftan nesne oluşturmadan kullanabiliriz. 
    {
        public static void ThrowIfException(this FluentValidation.Results.ValidationResult validationResult)
        {
            if (validationResult.IsValid) return; 
            
                var message = string.Join(',', validationResult.Errors.Select(x => x.ErrorMessage));
                throw new ValidationException(message);
            
        }
    }
}
