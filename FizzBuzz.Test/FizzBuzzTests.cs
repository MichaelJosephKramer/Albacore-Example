using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentAssertions;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz subject;

        [SetUp]
        public void before_each()
        {
            subject = new FizzBuzz();
        }

        [Test]
        public void when_entering_a_multiple_of_3()
        {
            var result = subject.Process(9);
            result.Should().Be("Fizz");
        }

        [Test]
        public void when_entering_a_multiple_of_5()
        {
            var result = subject.Process(20);
            result.Should().Be("Buzz");
        }

        [Test]
        public void when_entering_a_multiple_of_3_and_5()
        {
            var result = subject.Process(15);
            result.Should().Be("FizzBuzz");
        }
    }
}
