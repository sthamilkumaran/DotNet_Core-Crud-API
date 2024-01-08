using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList = new List<VillaDTO>
        {
            new VillaDTO { Id = 1,Name = "Tamil"},
            new VillaDTO { Id = 2,Name = "Kumaran"},
        };
    }
}
