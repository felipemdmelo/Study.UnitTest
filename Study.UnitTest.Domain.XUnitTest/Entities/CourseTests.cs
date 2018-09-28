using Study.UnitTest.Domain.Entities;
using Study.UnitTest.Domain.Entities.Enums;
using Study.UnitTest.Domain.Exceptions;
using System;
using Xunit;

namespace Study.UnitTest.Domain.XUnitTest.Entities
{
    public class CourseTests
    {
        [Fact(DisplayName = "Course Set Department With Same Category")]
        public void Course_SetDepartmentWithSameCategory()
        {
            var course = CreateCourse();

            try
            {
                var department = CreateDepartment();
                course.Department = department;

                Assert.NotNull(course.Department);
            }
            catch
            {
                Assert.Null(course.Department);
            }
        }

        [Fact(DisplayName = "Course Set Department With Diff Category")]
        public void Course_SetDepartmentWithDiffCategory()
        {
            var course = CreateCourse(Category.HUMANAS);

            try
            {
                var department = CreateDepartment(Category.SAUDE);
                course.Department = department;

                Assert.NotNull(course.Department);
            }
            catch(Exception e)
            {
                Assert.True(e is CategoryException);
                Assert.Null(course.Department);
            }
        }

        #region PRIVATE METHODS
        private Course CreateCourse(Category category = Category.EXATAS)
        {
            return new Course("Course", category);
        }

        private Department CreateDepartment(Category category = Category.EXATAS)
        {
            return new Department("Department", category);
        }

        #endregion
    }
}
