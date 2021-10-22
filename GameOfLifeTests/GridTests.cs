using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTests
{
    public class GridTests
    {
        private const string Dead = ".";
        private const string Live = "*";

        private Grid ClassUnderTest;

        [Test]
        public void When_getting_neighbors_for_center_cell()
        {
            ClassUnderTest = new Grid
            {
                CurrentGrid = new[,]
                {
                    {Dead, Dead, Live},
                    {Dead, Live, Live},
                    {Dead, Dead, Live}
                }
            };
            var neighbors = new[] {Dead, Dead, Live, Dead, Live, Dead, Dead, Live};
            var result = ClassUnderTest.GetNeighborsAtLocation(1, 1);

            Assert.That(result, Is.EquivalentTo(neighbors));
        }

        [Test]
        public void When_getting_neighbors_for_side_cell()
        {
            ClassUnderTest = new Grid
            {
                CurrentGrid = new[,]
                {
                    {Dead, Dead, Live},
                    {Dead, Live, Live},
                    {Dead, Dead, Live}
                }
            };

            var neighbors = new[] {Dead, Live, Dead, Live, Live};
            var result = ClassUnderTest.GetNeighborsAtLocation(0, 1);

            Assert.That(result, Is.EquivalentTo(neighbors));
        }

        [Test]
        public void When_getting_neighbors_for_corner_cell()
        {
            ClassUnderTest = new Grid
            {
                CurrentGrid = new[,]
                {
                    {Dead, Dead, Live},
                    {Dead, Live, Live},
                    {Dead, Dead, Live}
                }
            };
            var neighbors = new[] {Live, Live, Dead};
            var result = ClassUnderTest.GetNeighborsAtLocation(2, 2);

            Assert.That(result, Is.EquivalentTo(neighbors));
        }
    }
}