using System.Collections.Generic;

namespace GenericClassExample
{
    public class Repository<T>
    {
        public List<T> getir()
        {            
            return null;
        }

        public string ekle(T data)
        {            
            return "Data başarılı bir şekilde eklenmiştir.";
        }

    }
}
