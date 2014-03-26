using System.Collections.Generic;
using System.Linq;
using OrganizingData.EncapsulateCollection;
using OrganizingData.EncapsulateCollection.EncapsulateArrays;
using Xunit;

namespace OrganizingDataFacts
{
    public class EncapsulateCollectionFact
    {
        [Fact]
        public void should_init_courses_for_person()
        {
            var kent = new Person();
            var courses = new List<Course>();
            courses.Add(new Course("SmalTalk Programming", false));
            courses.Add(new Course("Appreciating Single Malts", true));
            kent.Courses = courses;
            kent.Courses.Add(new Course("Refactoring", true));

            var advantagedCount = kent.Courses.Count(c => c.IsAdvantaged);

            Assert.Equal(2, advantagedCount);
        }

        [Fact]
        public void should_init_skills()
        {
            var skillManager = new SkillManager();
            skillManager.Skills = new string[2];
            skillManager.Skills[0] = "Refactoring";
            skillManager.Skills[1] = "TDD";

            Assert.Equal("Refactoring", skillManager.Skills[0]);
            Assert.Equal("TDD", skillManager.Skills[1]);
        }
    }
}