using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1_TablolarArasiIliskiler.Entity
{
    // User için tek bir tablo oluşturmak yerine 2 tabloya ayıracağız. Buna Entity Splitting denir. Tablolardan birinde kullanıcı hakkında bağlantı bilgilerini tutarken, diğerinde hesap bilgilerini tutacağız. 1-1 ilişkili tablolar oluşuyor.
    public class AppUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string Adress { get; set; }

        // [NotMapped]
        public string Email { get; set; }
    }
}
