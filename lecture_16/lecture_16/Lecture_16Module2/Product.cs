using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_16Module2
{
    class Product
    {
        public const string ProductType = "Phone";
        private Guid _id;
        public Guid Id { get { return _id; } }

        public string Name { get; set; }

        public Product()
        {
            _id = Guid.NewGuid();
        }
    }
}
