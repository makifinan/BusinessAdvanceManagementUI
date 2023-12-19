using BusinessAdvanceManagement.Core.APIService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class EmailExistsAttribute: ActionFilterAttribute
    {
        GeneralApiService generalApi;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var email = context.ActionArguments["email"] as string;

            // E-posta veritabanında var mı kontrolü burada yapılmalı

            if (EmailExistsInDatabase(email))
            {
                
                var result = new ContentResult
                {
                    Content = "Bu e-posta adresi zaten kullanılmaktadır. Lütfen başka bir e-posta adresi deneyin.",
                    StatusCode = 400 
                };

                context.Result = result;
            }

            base.OnActionExecuting(context);
        }

        private bool EmailExistsInDatabase(string email)
        {
            // Veritabanında e-posta kontrolü gerçekleştirilmeli
            // Burada uygun bir veritabanı sorgusu yazılmalı
            // Örnek: return _dbContext.Users.Any(u => u.Email == email);

            // Örnek olarak her zaman e-posta varmış gibi dönüyoruz
            return true;
        }
    }
}
