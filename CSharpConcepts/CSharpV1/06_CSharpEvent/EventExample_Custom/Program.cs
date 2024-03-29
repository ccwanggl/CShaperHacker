﻿using System;
using System.Threading;


namespace EventExample_Custom_Full
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); ;
            Waiter waiter = new Waiter();

            customer.Order += waiter.Action;

            customer.Action();
            customer.PayTheBill();
        }
    }

    //note(guoliang): event
    //note(guoliang): declaration delegate
    public class OrderEventArgs:EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    //note(guoliang): 
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs s);

    //note(guoliang): Event owner
    public class Customer
    {
        private OrderEventHandler orderEventHandler;

        public event OrderEventHandler Order {
            add {
                this.orderEventHandler += value;
            }

            remove {
                this.orderEventHandler -= value;
            }
        }
        public double Bill { get; set; }

        public void PayTheBill()
        {
            Console.WriteLine("I will pay ${0}.", this.Bill);
        }

        public void WalkIn()
        {
            Console.WriteLine("Walk into the restaurant.");
        }

        public void SitDown()
        {
            Console.WriteLine("Sit down.");
        }

        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think ...");
                Thread.Sleep(1000);
            }

            //note(guoliang): "null" means no one subscribe the order event
            OnOrder("Kongpao Chicken", "large");
        }

        protected void OnOrder(string dishName, string size)
        {
            if(this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = dishName;
                e.Size = size;
                this.orderEventHandler.Invoke(this, e);
            }
        }
        public void Action()
        {
            Console.ReadLine();
            this.WalkIn();
            this.SitDown();
            this.Think();
        }
    }

    //note(guoliang): event respone
    class Waiter
    {
        //note(guoliang): event deal function
        public void Action(Customer customer, OrderEventArgs s)
        {
            Console.WriteLine("I will serve you the dish - {0}.", s.DishName);
            double price = 10;
            switch (s.Size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price *= 1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }
}
