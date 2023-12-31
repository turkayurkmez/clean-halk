﻿namespace OpenClosed
{
    //public enum CardType
    //{
    //    Standart,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    public abstract class CardType
    {
        public abstract decimal GetDiscounted(decimal totalPrice);

    }

    public class StandardCard : CardType
    {
        public override decimal GetDiscounted(decimal totalPrice)
        {
            return totalPrice * .95m;
        }
    }
    public class SilverCard : CardType
    {
        public override decimal GetDiscounted(decimal totalPrice)
        {
            return totalPrice * .90m;
        }
    }

    public class GoldCard : CardType
    {
        public override decimal GetDiscounted(decimal totalPrice)
        {
            return totalPrice * .85m;
        }
    }

    public class Premium : CardType
    {
        public override decimal GetDiscounted(decimal totalPrice)
        {
            return totalPrice * .8m;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public CardType Card { get; set; }


    }


    public class OrderManagement
    {
        public Customer Customer { get; set; }

        public decimal GetDiscountedPrice(decimal totalPrice)
        {
            return Customer.Card.GetDiscounted(totalPrice);
            //switch (Customer.Card)
            //{
            //    case CardType.Standart:
            //        return totalPrice * .95m;
            //    case CardType.Silver:
            //        return totalPrice * .90m;

            //    case CardType.Gold:
            //        return totalPrice * .85m;
            //    case CardType.Premium:
            //        return totalPrice * .8m;

            //    default:
            //        return totalPrice;

            //}
        }
    }
}
