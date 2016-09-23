using SQLite;

namespace XamarinForms.SQLite
{
    public class TodoItem
    {

		/*Database entries for pizza base */
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string PizzaName { get; set; }

        public string Topping1 { get; set; }

        public string Topping2 { get; set; }

        public string Topping3 { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", Type, PizzaName, Topping1, Topping2, Topping3);
        }
    }
}