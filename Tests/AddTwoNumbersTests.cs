using Solutions;
using NUnit.Framework;

namespace Tests
{
    public class AddTwoNumbersTests
    {
        [Test]
        public void should_return_two_sum_results()
        {
            // Arrange
            var expected = new ListNode(7);

            expected.next = new ListNode(0);
            expected.next.next = new ListNode(8);

            var l1 = new ListNode(2);

            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            var l2 = new ListNode(5);

            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            // Act
            var actual = Solution.AddTwoNumbers(l1, l2);

            // Assert
            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.next.val, actual.next.val);
            Assert.AreEqual(expected.next.next.val, actual.next.next.val);
        }
    }
}
