using System.Linq;
using FluentAssertions;
using NHSE.Core;
using Xunit;

namespace NHSE.Tests
{
    public static class TerrainTileTests
    {
        [Fact]
        public static void FlattenRoad_WhenTileIsNotRoad_DoesNotFlattenRoad()
        {
            TerrainUnitModel terrainUnitModel = TerrainUnitModel.Fall207;
            ushort landMakingAngleRoad = 1;
            ushort variationRoad = 2;
            var tile = new TerrainTile
            {
                UnitModelRoad = terrainUnitModel,
                LandMakingAngleRoad = landMakingAngleRoad,
                VariationRoad = variationRoad
            };

            tile.FlattenRoad();

            tile.UnitModelRoad.Should().Be(terrainUnitModel);
            tile.LandMakingAngleRoad.Should().Be(landMakingAngleRoad);
            tile.VariationRoad.Should().Be(variationRoad);
        }

        [Fact]
        public static void FlattenRoad_WhenTileIsRoad_DoesFlattenRoadCorrectly()
        {
            var tile = new TerrainTile
            {
                UnitModelRoad = TerrainUnitModel.RoadSoil3A,
                LandMakingAngleRoad = 2,
                VariationRoad = 3
            };

            tile.FlattenRoad();

            tile.UnitModelRoad.Should().Be(TerrainUnitModel.RoadSoil8A);
            tile.LandMakingAngleRoad.Should().Be(0);
            tile.VariationRoad.Should().Be(0);
        }
    }
}