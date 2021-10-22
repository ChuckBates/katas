using GameOfLife;
using NUnit.Framework;

namespace GameOfLifeTests
{
    public class EvolutionTests
    {
        private const string Dead = ".";
        private const string Live = "*";
        
        private Evolution ClassUnderTest;
        
        [SetUp]
        public void Setup()
        {
            ClassUnderTest = new Evolution();
        }

        [TestCase(Dead, new []{Dead,Dead,Dead,Dead,Dead,Dead,Dead,Dead}, Dead)]
        [TestCase(Dead, new []{Dead,Live,Dead,Dead,Dead,Dead,Dead,Dead}, Dead)]
        [TestCase(Dead, new []{Dead,Live,Dead,Live,Live,Live,Live,Dead}, Dead)]
        [TestCase(Dead, new []{Dead,Live,Dead,Live,Dead,Live,Dead,Dead}, Live)]
        [TestCase(Dead, new []{Dead,Live,Dead}, Dead)]
        [TestCase(Live, new []{Dead,Live,Dead,Live,Dead,Dead,Dead,Dead}, Live)]
        [TestCase(Live, new []{Dead,Dead,Dead,Dead,Dead,Dead,Dead,Dead}, Dead)]
        [TestCase(Live, new []{Live,Live,Live,Live,Live,Live,Live,Live}, Dead)]
        [TestCase(Live, new []{Live,Live,Live,Dead,Dead,Dead,Dead,Dead}, Live)]
        [TestCase(Live, new []{Live,Live,Dead}, Live)]
        public void When_getting_cell_evolution(string cell, string[] neighbors, string evolvedCell)
        {
            var result = ClassUnderTest.EvolveCell(cell, neighbors);
            
            Assert.That(result, Is.EqualTo(evolvedCell));
        }

        [Test]
        public void When_getting_grid_evolution_for_three_by_three()
        {
            var grid = new Grid
            {
                CurrentGrid = new[,]
                {
                    {Dead, Dead, Live},
                    {Dead, Live, Live},
                    {Dead, Dead, Live}
                }
            };
            var evolvedGrid = new[,]
            {
                {Dead,Live,Live}, 
                {Dead,Live,Live}, 
                {Dead,Live,Live}
            };
        
            var result = ClassUnderTest.EvolveGrid(grid);
            
            Assert.That(result.CurrentGrid, Is.EquivalentTo(evolvedGrid));
        }

        [Test]
        public void When_getting_grid_evolution_for_four_by_eight()
        {
            var grid = new Grid
            {
                CurrentGrid = new[,]
                {
                    {Dead, Dead, Dead, Dead, Dead, Dead, Dead, Dead},
                    {Dead, Dead, Dead, Dead, Live, Dead, Dead, Dead},
                    {Dead, Dead, Dead, Live, Live, Dead, Dead, Dead},
                    {Dead, Dead, Dead, Dead, Dead, Dead, Dead, Dead}
                }
            };
            var evolvedGrid = new[,]
            {
                {Dead,Dead,Dead,Dead,Dead,Dead,Dead,Dead}, 
                {Dead,Dead,Dead,Live,Live,Dead,Dead,Dead}, 
                {Dead,Dead,Dead,Live,Live,Dead,Dead,Dead},
                {Dead,Dead,Dead,Dead,Dead,Dead,Dead,Dead}
            };
        
            var result = ClassUnderTest.EvolveGrid(grid);
            
            Assert.That(result.CurrentGrid, Is.EquivalentTo(evolvedGrid));
        }
    }
}