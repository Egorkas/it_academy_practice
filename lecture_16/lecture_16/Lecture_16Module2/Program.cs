using System;
using System.Linq;
using System.Reflection;

namespace Lecture_16Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Product);
            ConstructorInfo ctor = myType.GetTypeInfo()
                .DeclaredConstructors.Single();

            //Our constructor have no parameters, so...
            Object[] parameters = new Object[0];
            object obj = ctor.Invoke(parameters);

            Console.WriteLine($"Created type is {obj.GetType()}");
            

            FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_id");
            Console.WriteLine($"Field Name is {fieldInfo.Name}");
            Console.WriteLine($"Is Private - {fieldInfo.IsPrivate}");
            Console.WriteLine(obj.ToString());
            //change our _id
            fieldInfo.SetValue(obj, Guid.NewGuid());
            Console.WriteLine(obj.ToString());

            PropertyInfo propertyInfo = obj.GetType().GetTypeInfo().GetDeclaredProperty("Name");
            propertyInfo.SetValue(obj, "Iphone 12 Pro");
            Console.WriteLine(obj.ToString());

            FieldInfo fieldInfo1 = obj.GetType().GetTypeInfo().GetDeclaredField("ProductType");

            Console.WriteLine($"Field Name is {fieldInfo1.Name}");
            Console.WriteLine($"Is Private - {fieldInfo1.IsPrivate}");
        }
    }
}
