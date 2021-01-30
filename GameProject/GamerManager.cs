using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;


        public GamerManager(UserValidationManager userValidationManager)
        {
            userValidationService = userValidationService; 
        }

        public void Add(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gamer gamer. IUserValidationService userValidationService)
        {
            if (userValidationService.Validate(gamer)==true)
            {
               Console.WriteLine("Kayıt Silindi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");

            }


        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");

        }

        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
