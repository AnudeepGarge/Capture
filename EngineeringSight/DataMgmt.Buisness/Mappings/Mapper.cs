using DataMgmt.Data;


namespace DataMgmt.Buisness.Mappings
{
    public static class Mapper
    {
        public static void CreateMaps()
        {
            AutoMapper.Mapper.CreateMap(typeof(University), typeof(DataMgmt.Buisness.Model.University));
        }

    }
}
