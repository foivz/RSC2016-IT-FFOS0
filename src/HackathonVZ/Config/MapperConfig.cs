using AutoMapper;

namespace HackathonVZ.Config
{
    public class MapperConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(new[] {
                    "Repository",
                });
            });
        }
    }
}