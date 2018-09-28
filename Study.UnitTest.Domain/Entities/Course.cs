using Study.UnitTest.Domain.Entities.Enums;
using Study.UnitTest.Domain.Exceptions;

namespace Study.UnitTest.Domain.Entities
{
    public class Course : AbstractEntity
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public long DepartmentId { get; set; }
        private Department _department;
        public Department Department
        {
            get
            {
                return _department;
            }
            set
            {
                if (value.Category.Equals(Category))
                    _department = value;
                else
                    throw new CategoryException("A categoria do curso não é a mesma categoria do departamento.");
            }
        }

        public Course(string name, Category category)
        {
            Name = name;
        }

    }
}
