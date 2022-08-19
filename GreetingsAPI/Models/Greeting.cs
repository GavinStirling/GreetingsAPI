namespace GreetingsAPI.Models
{
    public class Greeting
    {
        /*
        private int id;
        private string createdBy;
        private string greeting;
        private string originaCountry;
        private string nationality;

        public Greeting(int id, string createdBy, string greeting, string originaCountry, string nationality)
        {
            this.id = id;
            this.createdBy = createdBy;
            this.greeting = greeting;
            this.originaCountry = originaCountry;
            this.nationality = nationality;
        }
        */

        public int id { get; set; }
        public string? createdBy { get; set; }
        public string? greeting { get; set; }
        public string? originaCountry { get; set; }
        public string? nationality { get; set; }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id=id;
        }

        public string getCreatedBy()
        {
            return createdBy;
        }

        public void setCreatedby(string createdBy)
        {
            this.createdBy = createdBy;
        }

        public string getGreeting ()
        {
            return greeting;
        }

        public void setGreeting (string greeting)
        {
            this.greeting=greeting;
        }

        public string getOriginCountry()
        {
            return originaCountry;
        }

        public void setOriginCountry(string originaCountry)
        {
            this.originaCountry = originaCountry;
        }

        public string getNationality()
        {
            return nationality;
        }

        public void setnationality(string nationality)
        {
            this.nationality = nationality;
        }

    }
}
