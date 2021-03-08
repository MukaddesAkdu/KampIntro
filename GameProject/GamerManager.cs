using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            //if(_userValidationService.Validate(gamer)==true)  default'u true, iki şekilde de yazılır.
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Başarıyla Yapıldı.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt Yapılamadı.");
            }
            //Console.WriteLine("Kayıt oldu.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }

        /*public void Add(Gamer gamer, IUserValidationService userValidationService)
        {
            if (userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt Yapılamadı.");
            }
        }*/
    }
}
