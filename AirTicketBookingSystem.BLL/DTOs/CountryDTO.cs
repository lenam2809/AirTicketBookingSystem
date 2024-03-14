namespace AirTicketBookingSystem.BLL.DTOs
{
    public class CountryDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public CountryDTO()
        {

        }
        public CountryDTO(int idCountry, string namecoutry)
        {
            this.id = id;
            this.name = namecoutry;
        }
    }
}
