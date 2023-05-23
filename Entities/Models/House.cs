using System.Text.Json;

namespace Entities.Models
{
    public class House : Entity
    {

        public static string FORSALE_FOR_STATUS = "Satılık";
        public static string FORRENT_FOR_STATUS = "Kiralık";

        public static string HIDEAWAY_FOR_TYPE = "Kır Evi";
        public static string FARM_HOUSE_FOR_TYPE = "Çiftlik Evi";
        public static string PREFABRICATED_HOUSE_FOR_TYPE = "Prefabrik Ev";
        public static string CONTAINER_HOUSE_FOR_TYPE = "Konteyner Ev";
        public static string FERTOCONCRETE_HOUSE_FOR_TYPE = "Betonarme Ev";
        public static string STONE_HOUSE_FOR_TYPE = "Taş Ev";
        public static string TERRAIN_HOUSE_FOR_TYPE = "Arazi Ev";
        public static string MOBILE_HOUSE_FOR_TYPE = "Mobil Ev";

        public string Status { get; set; }

        public Address Address { get; set; }
        
        public string Type { get; set; }
        public decimal Price { get; set; }
        public decimal SquareMeter { get; set; }
        public int CountOfRooms { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


        public List<Image> Images { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
