using Entities.DTOs;

namespace UI
{
    public class DefaultObject
    {

        public static bool isDefault(EntityDtos entity)
        {
            return entity.Id == 0;
        }
        public static bool isDefault(List<EntityDtos> entities)
        {
            return entities.Count == 0;
        }
    }
}
