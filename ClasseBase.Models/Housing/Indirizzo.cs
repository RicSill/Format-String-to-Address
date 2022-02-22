namespace ClasseBase.Model.Housing

{
    public class Indirizzo
    {
        #region PROPRIETIES
        /// <summary>
        /// Denomination Address ex. Via Einstein
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Number location address
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        public string CAP { get; set; }
        #endregion

        #region COSTRUCTORS
        public Indirizzo(string address, int number, string city, string cap)
        {
            Address = address;
            Number = number;
            City = city;
            CAP = cap;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{Address} N°{Number}, {City} {CAP}";
        }

        /// <summary>
        /// Splits the string by commas 
        /// </summary>
        /// <param name="FullAddress"></param>
        /// <returns></returns>
        public static Indirizzo Parse(string FullAddress)
        {
            FullAddress = FullAddress.Trim();
            string[] addressParts = FullAddress.Split(',');
            var a = addressParts[0];
            var b = addressParts[1];
            var addressNumber = SecondParse(a);
            var CityCap = SecondParse(b);

            //
            var address = addressNumber[0];
            var number = int.Parse(addressNumber[1]);
            var city = CityCap[0];
            var CAP = CityCap[1];
            Indirizzo addr = new Indirizzo(address, number, city, CAP);
            return addr;
        }
        /// <summary>
        /// divides string by space and assigns the last array to matrice[1], the rest to matrice[0]
        /// </summary>
        /// <param name="abc"></param>
        /// <returns></returns>
        public static string[] SecondParse(string addressParts)
        {
            var array = new string[] {string.Empty,string.Empty};
            addressParts.Trim();
            string[] fragment = addressParts.Split(' ');
            for (int i = 0; i < fragment.Length-1; i++)
            {
                array[0]  = array[0] + fragment[i] + " ";
            }

            array[1] = fragment[fragment.Length-1];
            
            return array;
        }
        #endregion
    }
}
