using Study.UnitTest.Domain.Entities.Enums;

namespace Study.UnitTest.Domain.Entities
{
    public class Department : AbstractEntity
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Department(string name, Category category)
        {
            Name = name;
            Category = category;
        }
    }
}
