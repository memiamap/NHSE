using System.Linq;
using FluentAssertions;
using NHSE.Core;
using Xunit;

namespace NHSE.Tests
{
    public static class TerrainUnitModelTests
    {
        [Theory]
        [InlineData(TerrainUnitModel.Base, false, null)]
        [InlineData(TerrainUnitModel.Cliff1A, false, null)]
        [InlineData(TerrainUnitModel.Fall101, false, null)]
        [InlineData(TerrainUnitModel.River2B, false, null)]
        [InlineData(TerrainUnitModel.RoadBrick0A, true, TerrainUnitModel.RoadBrick8A)]
        [InlineData(TerrainUnitModel.RoadBrick5B, true, TerrainUnitModel.RoadBrick8A)]
        [InlineData(TerrainUnitModel.RoadBrick8A, true, TerrainUnitModel.RoadBrick8A)]
        [InlineData(TerrainUnitModel.RoadDarkSoil1C, true, TerrainUnitModel.RoadDarkSoil8A)]
        [InlineData(TerrainUnitModel.RoadDarkSoil7A, true, TerrainUnitModel.RoadDarkSoil8A)]
        [InlineData(TerrainUnitModel.RoadFanPattern0B, true, TerrainUnitModel.RoadFanPattern8A)]
        [InlineData(TerrainUnitModel.RoadFanPattern6B, true, TerrainUnitModel.RoadFanPattern8A)]
        [InlineData(TerrainUnitModel.RoadSand1B, true, TerrainUnitModel.RoadSand8A)]
        [InlineData(TerrainUnitModel.RoadSand4A, true, TerrainUnitModel.RoadSand8A)]
        [InlineData(TerrainUnitModel.RoadSoil2A, true, TerrainUnitModel.RoadSoil8A)]
        [InlineData(TerrainUnitModel.RoadSoil6A, true, TerrainUnitModel.RoadSoil8A)]
        [InlineData(TerrainUnitModel.RoadStone1C, true, TerrainUnitModel.RoadStone8A)]
        [InlineData(TerrainUnitModel.RoadStone4C, true, TerrainUnitModel.RoadStone8A)]
        [InlineData(TerrainUnitModel.RoadTile1B, true, TerrainUnitModel.RoadTile8A)]
        [InlineData(TerrainUnitModel.RoadTile6A, true, TerrainUnitModel.RoadTile8A)]
        [InlineData(TerrainUnitModel.RoadWood1B, true, TerrainUnitModel.RoadWood8A)]
        [InlineData(TerrainUnitModel.RoadWood5B, true, TerrainUnitModel.RoadWood8A)]
        public static void TryGetFlatRoadEquivalent(TerrainUnitModel source, bool isValid, TerrainUnitModel? target)
        {
            bool result = source.TryGetFlatRoadEquivalent(out var outTarget);
            result.Should().Be(isValid);
            outTarget.Should().Be(target);
        }
    }
}
