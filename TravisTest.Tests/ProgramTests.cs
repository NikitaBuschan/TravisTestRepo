using System;
using Xunit;

namespace TravisTest.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Create_God_Goooooood()
        {
            var nikita = new A();
            int a = 3.4;

            Assert.True(nikita.name.Length > 0);
            Assert.True(nikita.surname.Length > 0);
        }
    }
}
