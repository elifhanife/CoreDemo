using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Blog ve category için aynı fonksiyonları yazmak yerine generic bir interface oluşturup onun için yazdık
    //ve blog ve category interfaceleri generic interfaceden inherit aldılar. `Interfaces can inherit interfaces.`
    public interface ICategoryDal : IGenericDal<Category>
    {
        
    }
}
