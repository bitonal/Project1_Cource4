namespace Joe_s_Pizza.Models
{
    public class OrderInfo:Pizza

    {
        //public OrderInfo(int pizzaId, string type, int price, int orderid, int qty, int total )
        //{
        //   OrderId = orderid;
        //    Quantity = qty;
        //    TotalPrice = total;
        //    PizzaId = pizzaId;
        //    Type = type;
        //    Price = price;
        //}
        public int OrderId { get; set; }



        public int TotalPrice { get; set; }
    }
}
