using System;
//See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//var date = new DateTime();
//var date1 = new DateOnly();
//Console.WriteLine("Date1 is:"+date1);
//Console.WriteLine("Date is:"+ date);


//var time = new TimeOnly();
//Console.WriteLine("Time is:"+time.AddHours(2));

//var date3 =new DateOnly();
//var currentDate = DateOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(currentDate);
//Console.WriteLine(currentDate.DayOfWeek);
//Console.WriteLine(currentDate.DayOfYear);
//Console.WriteLine(currentDate.Day)


//    public class TestReference
//    {
//         public int MyProperty { get; set; }
//    }

Console.WriteLine("Hello, World!");



// calling WithoutDelegate
PrepareAndDeliverFood(new OrderItem { WhatIwantToEat = "Pizza", Location = "gach" });
PrepareAndDeliverFood(new OrderItem { WhatIwantToEat = "Pizza", Location = "madha" });
PrepareAndDeliverFood(new OrderItem { WhatIwantToEat = "Pizza", Location = "Nalla" });




// calling WitDelegate
PrepareAndDeliverFoodWithDeleate(new OrderItem { WhatIwantToEat = "Pizza", Location = "gach" }, functionSendByFoot);
PrepareAndDeliverFoodWithDeleate(new OrderItem { WhatIwantToEat = "Pizza", Location = "madha" }, functionSendBybike);
PrepareAndDeliverFoodWithDeleate(new OrderItem { WhatIwantToEat = "Pizza", Location = "Nalla" }, functionSendByBus);






//With delegate
string PrepareAndDeliverFoodWithDeleate(OrderItem order, Func<OrderItem, string> sendByfuc)
{
//Prpareorder
    order.Isprepared = true;
    return sendByfuc(order);
}




//Without delegate
string PrepareAndDeliverFood(OrderItem order)
{
//Prpareorder
        order.Isprepared = true;
        if (order.Location == "gach")
        return functionSendByCar(order);
        else if (order.Location == "Madha")
        return functionSendByBus(order);
        else if (order.Location == "Nalla")
        return functionSendBybike(order);
        else
        return functionSendByFoot(order);
}



string functionSendByFoot(OrderItem order)
{
       return "Delevered on foot";
}



string functionSendBybike(OrderItem order)
{
    return "Delevered on Bike";
}



string functionSendByBus(OrderItem order)
{
     return "Delevered on Bus";
}



string functionSendByCar(OrderItem order)
{
    return "Delevered on car";
}



public  class OrderItem
{
    public string WhatIwantToEat { get; set; }
    public bool Isprepared { get; set; }
    public string Location { get; set; }
}











