using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDupsLinkedList.Tests
{
    public class RemoveDupsLinkedListTests
    {
        [Test]
        public void Test1()
        {
            // arrange
            var ll = new LinkedList<int>();
            var head = ll.AddFirst(5);
            var node2 = ll.AddAfter(head, 32);
            var node3 = ll.AddAfter(node2, 23);
            var node4 = ll.AddAfter(node3, 32);
            var node5 = ll.AddAfter(node4, 6);
            var node6 = ll.AddAfter(node5, 7);
            ll.AddAfter(node6, 7);

            // act
            ll = RemoveDupsLinkedList.RemoveDups(ll);

            // assert
            var actual = ll.ToList();
            var expected = new List<int> { 5, 32, 23, 6, 7 };
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
